# TOBJEditor

This tool can be used to edit and create TOBJ (Texture Object) files. 
.tobj is a mixed file format used by SCS Software to specify texture detail information needed to construct materials.
The file format is used in both Euro Truck Simulator 2 and American Truck Simulator.  

### Motivation

I used to spend way too much time editing texture paths for basically all my modding projects.
Due to the .tobj files being partially binary, they are cumbersome to work with and had to be edited with Hex-editing tools.
There exist a few tools that allow you to directly change the texture path of a single .tobj file. 
However, none of them enables you to do batch creation and updates in an efficient way. 
Hence, I decided to create a dedicated tool to easily and concurrently edit .tobj files. 

### Functionality 

TOBJEditor is everything you need when working with .tobj files. 
It enables you to open and edit existing .tobj files directly and intuitively, without having to convert them into mid-format. 
You can also (batch) create new .tobj files for various applications in the game.
The tool is devided into three subsections on the GUI: 

#### 1. Create/Edit single TOBJ file
Here you can open/edit/create a single .tobj file by navigating to the folder or by simply dropping the file on the textbox.
When an existing file is opened, the textbox will display the full texture path, which can then easily be modified. 
To create a new TOBJ file, you specify the type and the texture path and click save. 

#### 2. Edit texture folder path
Here you can edit the texture folder path of multiple .tobj files at the same time. 
Files can be opened by navigating to the folders via the open button or by simply dropping the files on the multi-line spanning textbox.
The program will display the texture folder path of the last opened .tobj file in the dedicated textbox. 
A file with the following texture path "/vehicle/truck/update/paintjob/empty.dds" will lead to the texture folder "/vehicle/truck/update/paintjob" being displayed.
When clicking the save button, all opened .tobj files will be updated to point to the specified texture folder.
Note that the names of the .dds files in the texture paths will remain untouched. Just the folder in which they are expected to be found will change. 
The reset button will close all opened files. 

#### 3. Generate TOBJs
Here you can generate new TOBJ files of a specified type for texture files (.dds) that you select. 
First, you have to specify the folder that forms the root of your SCS mod project, so that the program is able to retrieve the relative path of the texture files
within the SCS archive and create TOBJs pointing to them. 
Texture files for which you want to generate a TOBJ file can again be opened via the open button or by dropping the files on the textbox.
The reset button will close all opened files and emtpy the mod folder field.

Lastly, there are a few export options, related to the resulting TOBJ type:  
* Deduce from file; to keep all the parameters the same as in the opened file. (Default if no file is opened)
* Default texture; used for nearly all squared resolution standard texture in the game such as truck paintjobs and model textures.
* Trailer skin; used for (non squared resolution) trailer skins.
* UI Icon; used for textures displayed in the user interface of the game.  


![image](https://user-images.githubusercontent.com/55321868/125977845-8b912731-7018-49c0-a1a8-931bcc254072.png)


I hope that this tool will save you a lot of time so that you can focus more on content creation rather than dealing with files!

### Installation/Compatibility
This program is written in C# using the .NET framework and aimed at Windows operating systems.  
To use this program, simply download the executable file and save it on a location of your preference. 

### Contribute to this project
Feel free to open issues here on GitHub when you happen to find any bug, so that I can solve them as soon as possible!

### Credits
This tool is created by Matthijs de Goede, a developer of the ProMods team, owner of the MDG Logistics and publisher under the name Elitesquad Modz. 
