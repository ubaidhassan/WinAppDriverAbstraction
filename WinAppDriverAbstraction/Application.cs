﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriverAbstraction.Interfaces;

namespace WinAppDriverAbstraction
{
    public sealed class Application
    {
        public void StartUpAction<T>(T t) where T: ISnippet
        {
            t.Execute();
        }

        public void ShutDownAction<T>(T t) where T : ISnippet
        {
            t.Execute();
        }
    }
}
