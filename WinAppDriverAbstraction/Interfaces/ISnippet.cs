using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDriverAbstraction.Interfaces
{
    public interface ISnippet<ReturnType>
    {
        void Execute();
        List<ReturnType> ExecutionResult();

        void AddReturnValue(object returnType);
    }
}
