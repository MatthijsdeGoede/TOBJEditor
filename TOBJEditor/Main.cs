using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace TOBJEditor
{
    public partial class Main : Form
    {
        private string singleTobj;
        private HashSet<String> multipleTobj;
        private HashSet<String> dds;
        private Regex ItemRegex = new Regex(@"(\/)([a-zA-Z0-9_.\/]+?)(\.dds)", RegexOptions.Compiled);
        private string tobjFilterString = "TOBJ Files (*.tobj)|*.tobj";
        private string ddsFilterString = "DDS Files (*.dds)|*.dds";
        private string openLocation;

        public Main()
        {
            singleTobj = "";
            multipleTobj = new HashSet<string>();
            dds = new HashSet<string>();
            InitializeComponent();
            this.cboSingleType.SelectedIndex = 0;
            this.cboMultType.SelectedIndex = 0;
            this.cboGenerateType.SelectedIndex = 0;
        }

        //Button click events

        private void btnOpenSingleTobj_Click(object sender, EventArgs e)
        {
            openSingleTobj.Filter = tobjFilterString;

            if (openSingleTobj.ShowDialog() == DialogResult.OK)
            {
                singleTobj = openSingleTobj.FileName;
                openLocation = singleTobj.Substring(0, singleTobj.LastIndexOf("\\"));
                lblOpenedFile.Text = $"Currently opened TOBJ file: {singleTobj}";
                readTobj(singleTobj, false);
            }
        }

        private void btnOpenMultTobj_Click(object sender, EventArgs e)
        {
            openMultTobj.Filter = tobjFilterString;

            if (openMultTobj.ShowDialog() == DialogResult.OK)
            {
                HashSet<string> arrAllFiles = openMultTobj.FileNames.ToHashSet();
                addMultipleTobj(arrAllFiles);
            }
        }

        private void btnSaveSingleTobj_Click(object sender, EventArgs e)
        {
            saveSingleTobj.Filter = tobjFilterString;
            saveSingleTobj.FileName = singleTobj.Substring(singleTobj.LastIndexOf("\\") + 1);
            saveSingleTobj.InitialDirectory = openLocation;

            if (saveSingleTobj.ShowDialog() == DialogResult.OK)
            {
                writeTobj(saveSingleTobj.FileName, txtOpenedSingleTobj.Text, cboSingleType);
                writeStatusMessage(lblSingleStatus, "File saved!", true);
            }
        }

        private void btnSaveMultTobj_Click(object sender, EventArgs e)
        {
            foreach(String filename in multipleTobj){
                writeTobj(filename, txtFolderPath.Text + retrieveFileName(filename, false, true), cboMultType);
            }
            writeStatusMessage(lblMultStatus, $"Succesfully updated texture folder for {multipleTobj.Count()} files!", true);
            resetMultTobj();
        }

        private void btnResetTobj_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All the currently opened TOBJ files will be closed.", "Are you sure you want to reset?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                resetMultTobj();
            }
        }

        private void btnOpenDds_Click(object sender, EventArgs e)
        {
            openDds.Filter = ddsFilterString;

            if (openDds.ShowDialog() == DialogResult.OK)
            {
                HashSet<string> arrAllFiles = openDds.FileNames.ToHashSet();
                addDds(arrAllFiles);
            }
        }
        private void btnResetDds_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All the currently opened DDS files will be closed.", "Are you sure you want to reset?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                txtModFolder.Text = "";
                resetDds();
            }
        }

        private void btnGenerateTobj_Click(object sender, EventArgs e)
        {
            if (txtModFolder.Text == "") 
            {
                writeStatusMessage(lblGenerateStatus, "Please select a valid mod folder!", false);
            }
            else 
            {
                try
                {
                    foreach (String filename in dds)
                    {
                        generateTobj(filename, cboGenerateType);
                    }
                    writeStatusMessage(lblGenerateStatus, $"Succesfully generated TOBJ files for {dds.Count()} textures!", true);
                    resetDds();
                }
                catch (Exception)
                {
                    writeStatusMessage(lblGenerateStatus, lblGenerateStatus.Text = "An error occured, please check the given mod folder!", false);
                }
            }            
        }

        //Business logic 

        private void addMultipleTobj(HashSet<String> files)
        {
            StringBuilder openedFilesBuilder = new StringBuilder(txtOpenedMultTobj.Text);
            lblMultStatus.Text = "";

            foreach (string fileName in files)
            {
                multipleTobj.Add(fileName);
                openedFilesBuilder.AppendLine(fileName);
            }
            readTobj(files.ElementAt(0), true);
            txtOpenedMultTobj.Text = openedFilesBuilder.ToString();
        }

        private void addDds(HashSet<String> files)
        {
            StringBuilder openedFilesBuilder = new StringBuilder(txtOpenedDds.Text);
            lblGenerateStatus.Text = "";

            foreach (string fileName in files)
            {
                dds.Add(fileName);
                openedFilesBuilder.AppendLine(fileName);
            }
            txtOpenedDds.Text = openedFilesBuilder.ToString();
        }

        private void writeTobj(string filename, string newText, ComboBox toCheck) {

            byte[] fileBytes;
            try
            {
                fileBytes = File.ReadAllBytes(filename);
            }
            catch(Exception e) {
                fileBytes = getDefaultBytes();
            }

            byte[] saveModeBytes = retrieveSaveModeBytes(toCheck);
            byte[] filePathBytes = Encoding.UTF8.GetBytes(newText);
           
            using (FileStream stream = File.OpenWrite(filename))
            {
                stream.SetLength(48 + filePathBytes.Length);
             
                for (int i = 0; i < 48; i++) {
                    stream.Position = i;
                    byte toBeWritten = fileBytes[i];

                    if (saveModeBytes.Length > 0) {
                        if (i == 22) { toBeWritten = saveModeBytes[0]; }
                        else if (i == 28) { toBeWritten = saveModeBytes[1]; }
                        else if (i == 30) { toBeWritten = saveModeBytes[2]; }
                        else if (i == 31) { toBeWritten = saveModeBytes[3]; }
                        else if (i == 33) { toBeWritten = saveModeBytes[4]; }
                    }                                 
                    if (i == 40) { toBeWritten = Decimal.ToByte(newText.Length); }                             

                    stream.WriteByte(toBeWritten);
                }                
                
                for (int i = 0; i < filePathBytes.Length; i++) {
                    stream.Position = i+48;
                    stream.WriteByte(filePathBytes[i]);
                }
            }
        }

        private void readTobj(string filename, bool readFolderOnly)
        {
            string text = File.ReadAllText(filename);

            foreach (Match ItemMatch in ItemRegex.Matches(text))
            {
                if (readFolderOnly) {
                    txtFolderPath.Text = ItemMatch.Value.Substring(0, ItemMatch.Value.LastIndexOf("/"));
                }
                else {
                    txtOpenedSingleTobj.Text = ItemMatch.Value;
                }
            }
        }

        private void generateTobj(string filename, ComboBox toCheck)
        {
            string tobjPath = retrieveFileName(filename, true, false);
            string texturePath = retrieveFileName($"\\{Path.GetRelativePath(txtModFolder.Text, filename)}", false, false);
            writeTobj(tobjPath, texturePath, cboGenerateType);
        }

        private void resetMultTobj() {
            multipleTobj.Clear();
            txtOpenedMultTobj.Text = "";
            txtFolderPath.Text = "";
        }

        private void resetDds()
        {
            dds.Clear();
            txtOpenedDds.Text = "";
        }
        private void writeStatusMessage(Label label, string message, bool success)
        {
            label.Text = message;
            label.ForeColor = success ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        private string retrieveFileName(string filename, bool returnTobjPath, bool relative) 
        {
            string path = relative ? filename.Substring(filename.LastIndexOf(@"\")) : filename;
            return returnTobjPath ? path.Replace(".dds", ".tobj") : 
                path.Replace(@"\", "/").Replace(".tobj", ".dds");
        }

        private byte[] retrieveSaveModeBytes(ComboBox toCheck) {
            byte[] result = new byte[0];

            if (toCheck.SelectedIndex == 1) {
                result = new byte[] {0x02, 0x03, 0x00, 0x00, 0x00};
            }
            else if (toCheck.SelectedIndex == 2) {
                result = new byte[] { 0x00, 0x03, 0x02, 0x02, 0x00 };
            }
            else if (toCheck.SelectedIndex == 3) {
                result = new byte[] { 0x00, 0x02, 0x02, 0x02, 0x01 };
            }
            return result;
        }
        private byte[] getDefaultBytes() {
            return new byte[] {
                    0x01, 0x0A, 0xB1, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x02, 0x00,
                    0x02, 0x00, 0x03, 0x03, 0x03, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,
                    0x00, 0x01, 0x00, 0x00, 0x35, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        }

        //Drag and drop mode

        private void txtSingleTobj_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[]) e.Data.GetData(DataFormats.FileDrop);

            if (Path.GetExtension(droppedFiles[0]).Equals(".tobj")) {
                singleTobj = droppedFiles[0];
                openLocation = singleTobj.Substring(0, singleTobj.LastIndexOf("\\"));
                lblOpenedFile.Text = $"Currently opened TOBJ file: {singleTobj}";              
                readTobj(singleTobj, false);
            }
        }

        private void txtMultTobj_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            HashSet<string> allowedFiles = new HashSet<string>();

            foreach (string file in droppedFiles)
            {
                if (Path.GetExtension(file).Equals(".tobj"))
                {
                    allowedFiles.Add(file);
                }
            }
            if (allowedFiles.Count > 0) {
                addMultipleTobj(allowedFiles);
            }
        }

        private void txtModFolder_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (Directory.Exists(droppedFiles[0])) 
            {
                txtModFolder.Text = droppedFiles[0];
            }
        }

        private void txtDds_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            HashSet<string> allowedFiles = new HashSet<string>();

            foreach (string file in droppedFiles)
            {
                if (Path.GetExtension(file).Equals(".dds"))
                {
                    allowedFiles.Add(file);
                }
            }
            if (allowedFiles.Count > 0)
            {
                addDds(allowedFiles);
            }
        }

        private void txtMultTobj_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true) {
                e.Effect = DragDropEffects.All;
            }
        }

        private void txtSingleTobj_DragEnter(object sender, DragEventArgs e)
        {
            txtMultTobj_DragEnter(sender, e);
        }

        private void txtDds_DragEnter(object sender, DragEventArgs e) 
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void txtModFolder_DragEnter(object sender, DragEventArgs e)
        {
            txtModFolder_DragDrop(sender, e);
        }
    }
}
