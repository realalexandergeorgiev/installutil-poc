# installutil-poc

demo installutil.exe usage to bypass applocker or other whitelisting solution. will open only a messagebox to demonstrate that it works. can also be used to bypass powershell contrained language mode CLM etc. see references for CLM. 

usage `C:\Users\USER\Desktop>c:\windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe HelloWorld.exe`

# build

if you want to build it using VS you will need to add System.Configuration.Install as reference:
- Right-click your project's References, choose Add -> xReference.
- There will be a list of assemblies.
- Check System.Configuration.Install from that list and press OK.

if you do not have system automation installed, use nuget and run `NuGet\Install-Package System.Management.Automation.dll -Version 10.0.10586
`
for csc building you might need to add references using `-r:System.Windows.Forms.dll` etc. 


# references
- https://www.nuget.org/packages/System.Management.Automation.dll/
- https://github.com/padovah4ck/PSByPassCLM/ (stolen most of the code here)
- https://github.com/padovah4ck/PSByPassCLM/blob/master/PSBypassCLM/PSBypassCLM/Program.cs (mainly here)
- https://github.com/mono/winforms/blob/master/forms/make-csc.bat (csc build help)
- https://www.learningkoala.com/c-csharp-cscexe-the-compiler-cli.html (further csc flags help)
- https://evi1cg.me/archives/AppLocker_Bypass_Techniques.html#menu_index_12 (explanation of the attack with more sample code)

