using System;

namespace TOBJEditor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOpenedSingleTobj = new System.Windows.Forms.TextBox();
            this.btnOpenSingleTobj = new System.Windows.Forms.Button();
            this.grpSingle = new System.Windows.Forms.GroupBox();
            this.lblSingleStatus = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cboSingleType = new System.Windows.Forms.ComboBox();
            this.lblOpenedFile = new System.Windows.Forms.Label();
            this.btnSaveSingleTobj = new System.Windows.Forms.Button();
            this.grpMult = new System.Windows.Forms.GroupBox();
            this.lblMultStatus = new System.Windows.Forms.Label();
            this.txtOpenedMultTobj = new System.Windows.Forms.TextBox();
            this.btnResetTobj = new System.Windows.Forms.Button();
            this.lblType2 = new System.Windows.Forms.Label();
            this.cboMultType = new System.Windows.Forms.ComboBox();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.lblOpenedTobj = new System.Windows.Forms.Label();
            this.btnOpenMultTobj = new System.Windows.Forms.Button();
            this.btnSaveMultTobj = new System.Windows.Forms.Button();
            this.openSingleTobj = new System.Windows.Forms.OpenFileDialog();
            this.saveSingleTobj = new System.Windows.Forms.SaveFileDialog();
            this.openMultTobj = new System.Windows.Forms.OpenFileDialog();
            this.grpDds = new System.Windows.Forms.GroupBox();
            this.lblModFolder = new System.Windows.Forms.Label();
            this.txtModFolder = new System.Windows.Forms.TextBox();
            this.lblGenerateStatus = new System.Windows.Forms.Label();
            this.txtOpenedDds = new System.Windows.Forms.TextBox();
            this.btnResetDds = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGenerateType = new System.Windows.Forms.ComboBox();
            this.lblOpenedDds = new System.Windows.Forms.Label();
            this.btnOpenDds = new System.Windows.Forms.Button();
            this.btnGenerateTobj = new System.Windows.Forms.Button();
            this.openDds = new System.Windows.Forms.OpenFileDialog();
            this.lblCredits = new System.Windows.Forms.Label();
            this.grpSingle.SuspendLayout();
            this.grpMult.SuspendLayout();
            this.grpDds.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOpenedSingleTobj
            // 
            this.txtOpenedSingleTobj.AllowDrop = true;
            this.txtOpenedSingleTobj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOpenedSingleTobj.Location = new System.Drawing.Point(23, 77);
            this.txtOpenedSingleTobj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpenedSingleTobj.Name = "txtOpenedSingleTobj";
            this.txtOpenedSingleTobj.Size = new System.Drawing.Size(727, 26);
            this.txtOpenedSingleTobj.TabIndex = 0;
            this.txtOpenedSingleTobj.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtSingleTobj_DragDrop);
            this.txtOpenedSingleTobj.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtSingleTobj_DragEnter);
            // 
            // btnOpenSingleTobj
            // 
            this.btnOpenSingleTobj.Location = new System.Drawing.Point(595, 124);
            this.btnOpenSingleTobj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenSingleTobj.Name = "btnOpenSingleTobj";
            this.btnOpenSingleTobj.Size = new System.Drawing.Size(75, 36);
            this.btnOpenSingleTobj.TabIndex = 2;
            this.btnOpenSingleTobj.Text = "Open";
            this.btnOpenSingleTobj.UseVisualStyleBackColor = true;
            this.btnOpenSingleTobj.Click += new System.EventHandler(this.btnOpenSingleTobj_Click);
            // 
            // grpSingle
            // 
            this.grpSingle.Controls.Add(this.lblSingleStatus);
            this.grpSingle.Controls.Add(this.lblType);
            this.grpSingle.Controls.Add(this.cboSingleType);
            this.grpSingle.Controls.Add(this.lblOpenedFile);
            this.grpSingle.Controls.Add(this.txtOpenedSingleTobj);
            this.grpSingle.Controls.Add(this.btnOpenSingleTobj);
            this.grpSingle.Controls.Add(this.btnSaveSingleTobj);
            this.grpSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSingle.Location = new System.Drawing.Point(12, 15);
            this.grpSingle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSingle.Name = "grpSingle";
            this.grpSingle.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSingle.Size = new System.Drawing.Size(776, 184);
            this.grpSingle.TabIndex = 3;
            this.grpSingle.TabStop = false;
            this.grpSingle.Text = "Edit/Create single TOBJ";
            // 
            // lblSingleStatus
            // 
            this.lblSingleStatus.AutoSize = true;
            this.lblSingleStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSingleStatus.Location = new System.Drawing.Point(380, 17);
            this.lblSingleStatus.Name = "lblSingleStatus";
            this.lblSingleStatus.Size = new System.Drawing.Size(0, 17);
            this.lblSingleStatus.TabIndex = 14;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblType.Location = new System.Drawing.Point(351, 130);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 20);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type:";
            // 
            // cboSingleType
            // 
            this.cboSingleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSingleType.FormattingEnabled = true;
            this.cboSingleType.Items.AddRange(new object[] {
            "Deduce from file",
            "Default texture",
            "Trailer skin",
            "UI Icon"});
            this.cboSingleType.Location = new System.Drawing.Point(426, 126);
            this.cboSingleType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSingleType.Name = "cboSingleType";
            this.cboSingleType.Size = new System.Drawing.Size(161, 28);
            this.cboSingleType.TabIndex = 1;
            // 
            // lblOpenedFile
            // 
            this.lblOpenedFile.AutoSize = true;
            this.lblOpenedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpenedFile.Location = new System.Drawing.Point(20, 44);
            this.lblOpenedFile.Name = "lblOpenedFile";
            this.lblOpenedFile.Size = new System.Drawing.Size(221, 17);
            this.lblOpenedFile.TabIndex = 3;
            this.lblOpenedFile.Text = "Currently opened TOBJ file: None";
            // 
            // btnSaveSingleTobj
            // 
            this.btnSaveSingleTobj.Location = new System.Drawing.Point(675, 124);
            this.btnSaveSingleTobj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSingleTobj.Name = "btnSaveSingleTobj";
            this.btnSaveSingleTobj.Size = new System.Drawing.Size(75, 36);
            this.btnSaveSingleTobj.TabIndex = 3;
            this.btnSaveSingleTobj.Text = "Save";
            this.btnSaveSingleTobj.UseVisualStyleBackColor = true;
            this.btnSaveSingleTobj.Click += new System.EventHandler(this.btnSaveSingleTobj_Click);
            // 
            // grpMult
            // 
            this.grpMult.Controls.Add(this.lblMultStatus);
            this.grpMult.Controls.Add(this.txtOpenedMultTobj);
            this.grpMult.Controls.Add(this.btnResetTobj);
            this.grpMult.Controls.Add(this.lblType2);
            this.grpMult.Controls.Add(this.cboMultType);
            this.grpMult.Controls.Add(this.txtFolderPath);
            this.grpMult.Controls.Add(this.lblOpenedTobj);
            this.grpMult.Controls.Add(this.btnOpenMultTobj);
            this.grpMult.Controls.Add(this.btnSaveMultTobj);
            this.grpMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpMult.Location = new System.Drawing.Point(12, 207);
            this.grpMult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMult.Name = "grpMult";
            this.grpMult.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMult.Size = new System.Drawing.Size(776, 348);
            this.grpMult.TabIndex = 4;
            this.grpMult.TabStop = false;
            this.grpMult.Text = "Edit texture folder path";
            // 
            // lblMultStatus
            // 
            this.lblMultStatus.AutoSize = true;
            this.lblMultStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMultStatus.Location = new System.Drawing.Point(380, 17);
            this.lblMultStatus.Name = "lblMultStatus";
            this.lblMultStatus.Size = new System.Drawing.Size(0, 17);
            this.lblMultStatus.TabIndex = 12;
            // 
            // txtOpenedMultTobj
            // 
            this.txtOpenedMultTobj.AllowDrop = true;
            this.txtOpenedMultTobj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOpenedMultTobj.Location = new System.Drawing.Point(23, 70);
            this.txtOpenedMultTobj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpenedMultTobj.Multiline = true;
            this.txtOpenedMultTobj.Name = "txtOpenedMultTobj";
            this.txtOpenedMultTobj.ReadOnly = true;
            this.txtOpenedMultTobj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpenedMultTobj.Size = new System.Drawing.Size(727, 155);
            this.txtOpenedMultTobj.TabIndex = 4;
            this.txtOpenedMultTobj.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtMultTobj_DragDrop);
            this.txtOpenedMultTobj.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtMultTobj_DragEnter);
            // 
            // btnResetTobj
            // 
            this.btnResetTobj.Location = new System.Drawing.Point(514, 287);
            this.btnResetTobj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetTobj.Name = "btnResetTobj";
            this.btnResetTobj.Size = new System.Drawing.Size(75, 36);
            this.btnResetTobj.TabIndex = 7;
            this.btnResetTobj.Text = "Reset";
            this.btnResetTobj.UseVisualStyleBackColor = true;
            this.btnResetTobj.Click += new System.EventHandler(this.btnResetTobj_Click);
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.BackColor = System.Drawing.Color.Transparent;
            this.lblType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblType2.Location = new System.Drawing.Point(269, 293);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(50, 20);
            this.lblType2.TabIndex = 7;
            this.lblType2.Text = "Type:";
            // 
            // cboMultType
            // 
            this.cboMultType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMultType.FormattingEnabled = true;
            this.cboMultType.Items.AddRange(new object[] {
            "Deduce from file",
            "Default texture",
            "Trailer skin",
            "UI Icon"});
            this.cboMultType.Location = new System.Drawing.Point(344, 288);
            this.cboMultType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMultType.Name = "cboMultType";
            this.cboMultType.Size = new System.Drawing.Size(161, 28);
            this.cboMultType.TabIndex = 6;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(23, 240);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(727, 26);
            this.txtFolderPath.TabIndex = 5;
            // 
            // lblOpenedTobj
            // 
            this.lblOpenedTobj.AutoSize = true;
            this.lblOpenedTobj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpenedTobj.Location = new System.Drawing.Point(21, 38);
            this.lblOpenedTobj.Name = "lblOpenedTobj";
            this.lblOpenedTobj.Size = new System.Drawing.Size(190, 17);
            this.lblOpenedTobj.TabIndex = 4;
            this.lblOpenedTobj.Text = "Currently opened TOBJ files:";
            // 
            // btnOpenMultTobj
            // 
            this.btnOpenMultTobj.Location = new System.Drawing.Point(595, 287);
            this.btnOpenMultTobj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenMultTobj.Name = "btnOpenMultTobj";
            this.btnOpenMultTobj.Size = new System.Drawing.Size(75, 36);
            this.btnOpenMultTobj.TabIndex = 8;
            this.btnOpenMultTobj.Text = "Open";
            this.btnOpenMultTobj.UseVisualStyleBackColor = true;
            this.btnOpenMultTobj.Click += new System.EventHandler(this.btnOpenMultTobj_Click);
            // 
            // btnSaveMultTobj
            // 
            this.btnSaveMultTobj.Location = new System.Drawing.Point(675, 287);
            this.btnSaveMultTobj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveMultTobj.Name = "btnSaveMultTobj";
            this.btnSaveMultTobj.Size = new System.Drawing.Size(75, 36);
            this.btnSaveMultTobj.TabIndex = 9;
            this.btnSaveMultTobj.Text = "Save";
            this.btnSaveMultTobj.UseVisualStyleBackColor = true;
            this.btnSaveMultTobj.Click += new System.EventHandler(this.btnSaveMultTobj_Click);
            // 
            // openSingleTobj
            // 
            this.openSingleTobj.Title = "Open a single TOBJ file";
            // 
            // saveSingleTobj
            // 
            this.saveSingleTobj.Title = "Save a single TOBJ file";
            // 
            // openMultTobj
            // 
            this.openMultTobj.Multiselect = true;
            this.openMultTobj.Title = "Open one or more TOBJ files";
            // 
            // grpDds
            // 
            this.grpDds.Controls.Add(this.lblModFolder);
            this.grpDds.Controls.Add(this.txtModFolder);
            this.grpDds.Controls.Add(this.lblGenerateStatus);
            this.grpDds.Controls.Add(this.txtOpenedDds);
            this.grpDds.Controls.Add(this.btnResetDds);
            this.grpDds.Controls.Add(this.label2);
            this.grpDds.Controls.Add(this.cboGenerateType);
            this.grpDds.Controls.Add(this.lblOpenedDds);
            this.grpDds.Controls.Add(this.btnOpenDds);
            this.grpDds.Controls.Add(this.btnGenerateTobj);
            this.grpDds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDds.Location = new System.Drawing.Point(12, 563);
            this.grpDds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDds.Name = "grpDds";
            this.grpDds.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDds.Size = new System.Drawing.Size(776, 379);
            this.grpDds.TabIndex = 5;
            this.grpDds.TabStop = false;
            this.grpDds.Text = "Generate TOBJs";
            // 
            // lblModFolder
            // 
            this.lblModFolder.AutoSize = true;
            this.lblModFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModFolder.Location = new System.Drawing.Point(18, 40);
            this.lblModFolder.Name = "lblModFolder";
            this.lblModFolder.Size = new System.Drawing.Size(79, 17);
            this.lblModFolder.TabIndex = 14;
            this.lblModFolder.Text = "Mod folder:";
            // 
            // txtModFolder
            // 
            this.txtModFolder.AllowDrop = true;
            this.txtModFolder.Location = new System.Drawing.Point(20, 72);
            this.txtModFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModFolder.Name = "txtModFolder";
            this.txtModFolder.Size = new System.Drawing.Size(727, 26);
            this.txtModFolder.TabIndex = 10;
            this.txtModFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtModFolder_DragDrop);
            this.txtModFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtModFolder_DragEnter);
            // 
            // lblGenerateStatus
            // 
            this.lblGenerateStatus.AutoSize = true;
            this.lblGenerateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenerateStatus.Location = new System.Drawing.Point(380, 17);
            this.lblGenerateStatus.Name = "lblGenerateStatus";
            this.lblGenerateStatus.Size = new System.Drawing.Size(0, 17);
            this.lblGenerateStatus.TabIndex = 13;
            // 
            // txtOpenedDds
            // 
            this.txtOpenedDds.AllowDrop = true;
            this.txtOpenedDds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOpenedDds.Location = new System.Drawing.Point(20, 144);
            this.txtOpenedDds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpenedDds.Multiline = true;
            this.txtOpenedDds.Name = "txtOpenedDds";
            this.txtOpenedDds.ReadOnly = true;
            this.txtOpenedDds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpenedDds.Size = new System.Drawing.Size(727, 155);
            this.txtOpenedDds.TabIndex = 11;
            this.txtOpenedDds.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDds_DragDrop);
            this.txtOpenedDds.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDds_DragEnter);
            // 
            // btnResetDds
            // 
            this.btnResetDds.Location = new System.Drawing.Point(493, 320);
            this.btnResetDds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetDds.Name = "btnResetDds";
            this.btnResetDds.Size = new System.Drawing.Size(75, 36);
            this.btnResetDds.TabIndex = 13;
            this.btnResetDds.Text = "Reset";
            this.btnResetDds.UseVisualStyleBackColor = true;
            this.btnResetDds.Click += new System.EventHandler(this.btnResetDds_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(248, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type:";
            // 
            // cboGenerateType
            // 
            this.cboGenerateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenerateType.FormattingEnabled = true;
            this.cboGenerateType.Items.AddRange(new object[] {
            "Default texture",
            "Trailer skin",
            "UI Icon"});
            this.cboGenerateType.Location = new System.Drawing.Point(323, 321);
            this.cboGenerateType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGenerateType.Name = "cboGenerateType";
            this.cboGenerateType.Size = new System.Drawing.Size(161, 28);
            this.cboGenerateType.TabIndex = 12;
            // 
            // lblOpenedDds
            // 
            this.lblOpenedDds.AutoSize = true;
            this.lblOpenedDds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpenedDds.Location = new System.Drawing.Point(18, 112);
            this.lblOpenedDds.Name = "lblOpenedDds";
            this.lblOpenedDds.Size = new System.Drawing.Size(183, 17);
            this.lblOpenedDds.TabIndex = 4;
            this.lblOpenedDds.Text = "Currently opened DDS files:";
            // 
            // btnOpenDds
            // 
            this.btnOpenDds.Location = new System.Drawing.Point(574, 320);
            this.btnOpenDds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenDds.Name = "btnOpenDds";
            this.btnOpenDds.Size = new System.Drawing.Size(75, 36);
            this.btnOpenDds.TabIndex = 14;
            this.btnOpenDds.Text = "Open";
            this.btnOpenDds.UseVisualStyleBackColor = true;
            this.btnOpenDds.Click += new System.EventHandler(this.btnOpenDds_Click);
            // 
            // btnGenerateTobj
            // 
            this.btnGenerateTobj.Location = new System.Drawing.Point(654, 320);
            this.btnGenerateTobj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateTobj.Name = "btnGenerateTobj";
            this.btnGenerateTobj.Size = new System.Drawing.Size(95, 36);
            this.btnGenerateTobj.TabIndex = 15;
            this.btnGenerateTobj.Text = "Generate";
            this.btnGenerateTobj.UseVisualStyleBackColor = true;
            this.btnGenerateTobj.Click += new System.EventHandler(this.btnGenerateTobj_Click);
            // 
            // openDds
            // 
            this.openDds.Multiselect = true;
            this.openDds.Title = "Open one or more TOBJ files";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCredits.Location = new System.Drawing.Point(12, 951);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(185, 17);
            this.lblCredits.TabIndex = 16;
            this.lblCredits.Text = "Created by Elitesquad Modz";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 981);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.grpDds);
            this.Controls.Add(this.grpSingle);
            this.Controls.Add(this.grpMult);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(818, 1028);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "TOBJEditor";
            this.grpSingle.ResumeLayout(false);
            this.grpSingle.PerformLayout();
            this.grpMult.ResumeLayout(false);
            this.grpMult.PerformLayout();
            this.grpDds.ResumeLayout(false);
            this.grpDds.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox txtOpenedSingleTobj;
        private System.Windows.Forms.Button btnOpenSingleTobj;
        private System.Windows.Forms.GroupBox grpSingle;
        private System.Windows.Forms.Button btnSaveSingleTobj;
        private System.Windows.Forms.Label lblOpenedFile;
        private System.Windows.Forms.GroupBox grpMult;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label lblOpenedTobj;
        private System.Windows.Forms.ComboBox cboSingleType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnOpenMultTobj;
        private System.Windows.Forms.Button btnSaveMultTobj;
        private System.Windows.Forms.OpenFileDialog openSingleTobj;
        private System.Windows.Forms.SaveFileDialog saveSingleTobj;
        private System.Windows.Forms.OpenFileDialog openMultTobj;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.ComboBox cboMultType;
        private System.Windows.Forms.Button btnResetTobj;
        private System.Windows.Forms.TextBox txtOpenedMultTobj;
        private System.Windows.Forms.Label lblMultStatus;
        private System.Windows.Forms.GroupBox grpDds;
        private System.Windows.Forms.TextBox txtOpenedDds;
        private System.Windows.Forms.Button btnResetDds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGenerateType;
        private System.Windows.Forms.Label lblOpenedDds;
        private System.Windows.Forms.Button btnOpenDds;
        private System.Windows.Forms.Button btnGenerateTobj;
        private System.Windows.Forms.OpenFileDialog openDds;
        private System.Windows.Forms.Label lblGenerateStatus;
        private System.Windows.Forms.Label lblModFolder;
        private System.Windows.Forms.TextBox txtModFolder;
        private System.Windows.Forms.Label lblSingleStatus;
        private System.Windows.Forms.Label lblCredits;
    }
}

