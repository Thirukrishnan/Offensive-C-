using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using System.Collections.ObjectModel;

public class Program
{
    public static void Main()
    {

        PowerShell ps1 = PowerShell.Create();
        ps1.AddScript("Start-Process calc.exe");
        ps1.Invoke();


    }
}
