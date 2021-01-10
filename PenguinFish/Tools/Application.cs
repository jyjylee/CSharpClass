using System;
using System.Collections.Generic;
using System.Text;

namespace PenguinFish.Tools
{
    public static class Application
    {
        public static string Root
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;                
            }
        }
    }
}
