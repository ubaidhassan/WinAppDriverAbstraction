using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriverAbstraction.Interfaces;
using WinAppDriverAbstraction.Tests.Models;

namespace WinAppDriverAbstraction.Tests.Snippets
{
    class StartAppSnippet<ReturnType>: BaseSnippet<ReturnType>
    {
       
        public StartAppSnippet()
        {
        }

        
        public override void Execute()
        {
            InitiateIRMAApp();
        }

        
        public void InitiateIRMAApp()
        {
            Process alreadyOpenProcess = System.Diagnostics.Process.GetProcesses().Where(m => m.ProcessName.Contains("IRMA")).FirstOrDefault();
            //if (alreadyOpenProcess != null)
            //    TestStack.White.Application.Attach(alreadyOpenProcess.Id).Kill();
            string app = "file://C:/Users/2171282/Downloads/IRMA.application";
            ProcessStartInfo info = new ProcessStartInfo("rundll32.exe", "dfshim.dll,ShOpenVerbApplication " + app);
            System.Diagnostics.Process.Start(info);
            Student student = new Student() { FirstName = "Obaid" };
            this.AddReturnValue(student);
            
            //firstName = "Obaid Safdar";
            //BaseWindow.IRMAApplication = TestStack.White.Application.Launch(info);
            //Wait(10);
            //int process = System.Diagnostics.Process.GetProcesses().Where(m => m.ProcessName.Contains("IRMA")).FirstOrDefault().Id;
            //BaseWindow.IRMAApplication = TestStack.White.Application.Attach(process);

            ////BaseWindow.IRMAApplication = IRMAApplication;

            //BaseWindow.IRMAApplication.Login(conf.UserName, conf.Password);
            //System.Threading.Thread.Sleep(10000);

        }

    }
}
