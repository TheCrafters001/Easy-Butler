# Src Folder
This folder contains everything from the coding area. This way you can edit it your self!

But there are a few things your should know first.

## Login, Logoff, Update, and Easy Butler are seperate files all together.
This means that there is no way for them to communicate until they are all in one folder. For butler to update, you are required to have the followign files:

 * butler.exe
 * 7z.dll
 * c7zip.dll
 
These files are required for butler to update, as they need to download and then get extracted.

There is another thing you should keep in mind.

## The installers are not included.
I did this so it does not cause anything to get messed up. To build the MSI, you will need [this tool (Visual Studio 2017-2019)](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects) or [this tool (Visual Studio 2015)](https://marketplace.visualstudio.com/items?itemName=visualstudioclient.MicrosoftVisualStudio2015InstallerProjects), and to build the exe installer, you need [this tool](http://www.jrsoftware.org/isinfo.php)

Easy Butler; updating your games just got easier!

Signed,
	TheCrafters001