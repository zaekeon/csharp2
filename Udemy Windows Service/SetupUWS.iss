; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Udemy Windows Service"
#define MyAppVersion "1.0"
#define MyAppPublisher "Consulting"
#define MyAppURL "http://www.bacon.com"
#define MyAppExeName "Udemy Windows Service.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{A2E4D384-04D9-4A0E-AF10-6A69D24BD8F2}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputBaseFilename=SetupUWS
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\csharp\AdvancedCSharp\Udemy Windows Service\bin\Release\Udemy Windows Service.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\csharp\AdvancedCSharp\Udemy Windows Service\bin\Release\log4net.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\csharp\AdvancedCSharp\Udemy Windows Service\bin\Release\Udemy Windows Service.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\csharp\AdvancedCSharp\USAdmin\bin\Release\USAdmin.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\csharp\AdvancedCSharp\USAdmin\bin\Release\USAdmin.exe.config"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\USAdmin.exe"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\USAdmin.exe"; Tasks: desktopicon

[Run]
Filename:"{cmd}"; Parameters:"/c sc create ""{#MyAppName}"" binPath= ""{app}\{#MyAppExeName}"""

[UninstallRun]
Filename:"{cmd}"; Parameters:"/c sc delete ""{#MyAppName}"""