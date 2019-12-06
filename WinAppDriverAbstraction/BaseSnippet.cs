using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriverAbstraction.Interfaces;

namespace WinAppDriverAbstraction
{
    public abstract class BaseSnippet<ReturnType> : ISnippet<ReturnType>
    {
        List<ReturnType> toRet = new List<ReturnType>();
        public abstract void Execute();

        public virtual List<ReturnType> ExecutionResult()
        {
            return toRet;
        }

        /// <summary>
        /// add to build list of return values
        /// </summary>
        /// <param name="returnType"></param>
        public virtual void AddReturnValue(object returnType)
        {
            ReturnType val = (ReturnType)Convert.ChangeType(returnType, typeof(ReturnType));
            toRet.Add(val);
        }

        
    }
}
