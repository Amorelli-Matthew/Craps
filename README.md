# Craps Game!

### Description
This program is a Windows Forms application that simulates the classic Craps dice game. The user clicks a button to roll two dice, and the program determines wins or losses based on the rules of Craps (with special handling for the first roll and subsequent rolls). It uses random number generation for the dice, updates the game state, and provides interactive gameplay through the graphical interface.

### Prerequisites To Compile
Windows 10 [But Windows 11 Recommended]
[Download and install Microsoft Visual studio 2019 or newer[**Not Code**]](https://visualstudio.microsoft.com/downloads/)
Choose the  .NET desktop Environment
Make sure the .NET Framework version 4.7.2 is installed(check the box when installing the .NET desktop env)

### To Compile
Open Developer Command Prompted for Visual Studio
go into the project directory(Something like `C:\Users\YourUsername\source\repos`)
Then run: `msbuild inclass1.sln /p:Configuration=Release`
### To Run
go to the inclass1/bin/Release/ where the Application is located.

### To Clean Build Files
In the current directory, run `msbuild inclass1.sln /t:Clean`

# License
This project is licensed under GPGL V3

## Credits
This project uses technologies licensed by Microsoft Corporation:
- **.NET Framework 4.7.2** – © Microsoft Corporation. Licensed under the [.NET Framework License Terms](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472).
- **Windows Forms** – Part of the .NET Framework. © Microsoft Corporation. Licensed under the same terms as the .NET Framework.
- **Visual Studio / MSBuild** – © Microsoft Corporation. Licensed under the [Visual Studio License Terms](https://visualstudio.microsoft.com/license-terms/).

No ownership of Microsoft trademarks or software is claimed. All Microsoft products are used under their respective licenses.
