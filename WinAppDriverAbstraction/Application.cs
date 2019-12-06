using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriverAbstraction.Interfaces;

namespace WinAppDriverAbstraction
{
    public sealed class Application
    {
        public List<ReturnType> StartUpAction<ReturnType>(ISnippet<ReturnType> t) where ReturnType:class, new()
        {
            t.Execute();
            return t.ExecutionResult();
        }

        public List<ReturnType> ShutDownAction<ReturnType>(ISnippet<ReturnType> t) where ReturnType : class, new()
        {
            t.Execute();
            return t.ExecutionResult();
        }
    }
}
