using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FastFirewallSolution;

[SuppressMessage("ReSharper", "UnusedMethodReturnValue.Local")]
public partial class MainForm : Form
{
    /**
     * THIS IS SUPER FUCKIN' DIRTY, DON'T TRY AND LEARN FROM THIS CODE!
     * FIND YOURSELF SOMETHING THAT USES BETTER PRACTICES THAN WHATEVER
     * SPAGHETTI BULLSHIT I'VE GOT GOING ON DOWN HERE.
     */
    private readonly string _path = AppDomain.CurrentDomain.BaseDirectory;
    private readonly string _self = Process.GetCurrentProcess().MainModule!.FileName;
        
    public MainForm() { InitializeComponent(); }

    private void MainForm_Load(object sender, EventArgs e) { }

    private void AddButton_Click(object sender, EventArgs e)
    {
        foreach (var exe in Directory.GetFiles(_path, "*.exe").Where(p => !string.Equals(p, _self, StringComparison.OrdinalIgnoreCase)))
        {
            var name = Path.GetFileNameWithoutExtension(exe);
            MessageBox.Show(RunNetshCommand(name, exe, false) ? $"Successfully added {name}" : $"Failed to add {name}");
        }
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
        foreach (var exe in Directory.GetFiles(_path, "*.exe").Where(p => !string.Equals(p, _self, StringComparison.OrdinalIgnoreCase)))
        {
            var name = Path.GetFileNameWithoutExtension(exe);
            MessageBox.Show(RunNetshCommand(name, exe, true)
                ? $"Successfully removed {name}"
                : $"Failed to remove {name}");
        }
    }

    private bool RunNetshCommand(string name, string path, bool remove)
    {
        var op = remove ? "delete" : "add";
        var action = DenyCheckbox.Checked ? "block" : "allow";
        var dirIn = $"advfirewall firewall {op} rule name=\"{name}_IN\" dir=in action={action} program=\"{path}\" enable=yes";
        var dirOut = $"advfirewall firewall {op} rule name=\"{name}_OUT\" dir=out action={action} program=\"{path}\" enable=yes";
        return RunNetsh(dirIn) && RunNetsh(dirOut);
    }

    private static bool RunNetsh(string args)
    {
        try
        {
            var psi = new ProcessStartInfo("netsh", args)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
            };
            using var proc = Process.Start(psi);
            proc!.WaitForExit(8000);
            return proc.ExitCode == 0;
        }
        catch
        {
            return false;
        }
    }
}