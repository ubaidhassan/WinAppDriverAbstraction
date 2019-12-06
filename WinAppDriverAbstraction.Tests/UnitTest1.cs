using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinAppDriverAbstraction.Interfaces;
using WinAppDriverAbstraction.Tests.Models;
using WinAppDriverAbstraction.Tests.Snippets;

namespace WinAppDriverAbstraction.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Application application = new Application();
            //StartAppSnippet<Student> startupSnipper = new StartAppSnippet<Student>();
            //var students = application.StartUpAction(startupSnipper);

            NoReturnSnippet snippet = new NoReturnSnippet();
            var result = application.StartUpAction(snippet);
            
        }
    }
}
