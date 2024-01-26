using System.Diagnostics;

class ProcessModules
{
    public void GetModules()
    {
        Process myProcess = new Process();
        // Get the process start information of notepad
        ProcessStartInfo myProcessStartInfo = new ProcessStartInfo("notepad.exe");
        // Assign 'StartInfo' of notepad to 'StartInfo' of 'myProcess' object.
        myProcess.StartInfo = myProcessStartInfo;
        // Create a notepad
        myProcess.Start();
        System.Threading.Thread.Sleep(1000);
        ProcessModule myProcessModule;
        // Get all the modules associated with 'myProcess'.
        ProcessModuleCollection myProcessModuleCollection = myProcess.Modules;
        Console.WriteLine("Properties of the modules associated with 'notepad' are:");
        // Display the properties of each of the modules.
        for (int i = 0; i < myProcessModuleCollection.Count; i++)
        {
            myProcessModule = myProcessModuleCollection[i];
            Console.WriteLine("The moduleName is " + myProcessModule.ModuleName);
            Console.WriteLine("The " + myProcessModule.ModuleName + "'s File Name is: " + myProcessModule.FileName);
            Console.WriteLine("The " + myProcessModule.ModuleName + "'s base address is: " + myProcessModule.BaseAddress);
            Console.WriteLine("For " + myProcessModule.ModuleName + " Entry point address is: " + myProcessModule.EntryPointAddress);
        }
        // Get the Main module associated with 'myProcess'.
        myProcessModule = myProcess.MainModule;
        Console.WriteLine("The Main Module associated");
        Console.WriteLine("The process's main module name is " + myProcessModule.ModuleName);
        Console.WriteLine("The process's main module name File Name is: " + myProcessModule.FileName);
        Console.WriteLine("The process's main module name base address is: " + myProcessModule.BaseAddress);
        Console.WriteLine("The process's main module name Entry point address is: " + myProcessModule.EntryPointAddress);
        myProcess.CloseMainWindow();
    }
    static void Main(string[] args)
    {
        ProcessModules obj = new ProcessModules();
        obj.GetModules();
    }


    }
