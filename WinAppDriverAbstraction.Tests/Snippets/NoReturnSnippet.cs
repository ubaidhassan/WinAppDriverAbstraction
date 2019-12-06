using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriverAbstraction.Tests.Models;

namespace WinAppDriverAbstraction.Tests.Snippets
{
    public class NoReturnSnippet : BaseSnippet<Student>
    {
        public NoReturnSnippet()
        {
        }

        public override void Execute()
        {
            int a = 0;
            Console.WriteLine("Execution ended");
        }
    }
}
