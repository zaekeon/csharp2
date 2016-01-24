using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace PowerShellTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                //use "AddScript" to add the contents of a script file to the end of the execution pipeline
                //use AddCommand to add individual commands/cmlets to the end of the execution pipeline.
                PowerShellInstance.AddScript("param($param1) $d= get-date; $s = 'test string value'; " + "$d; $s; $param1; get-service");

                //use "AddParamter" to add a single parameter to the last command/script on the pipeline

                PowerShellInstance.AddParameter("param1", "paramter 1 value!");

                //at this point you could simply execute the commands with
                //PowerShellinstance.Invoke()
                //If you want to collect output of the command you need to do the below.

                //invoke execution on the pipeline (collecting output)
                Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

                //loop through each output in object item
                foreach (PSObject outputItem in PSOutput)
                {
                    //Do something with output Item.
                    if (outputItem != null)
                    {
                        //outputItem.BaseObject
                        Console.WriteLine(outputItem.BaseObject.ToString());
                        Console.WriteLine(outputItem.BaseObject.GetType().FullName);
                    }
                }
            }

            

            
  
        }
    }
}
