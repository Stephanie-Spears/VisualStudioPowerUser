using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Treehouse.Helper
{
    public class AssemblyNameHelper
    {
        public string GetAssemblyName(bool includeVersion)
        {
            var assemblyInfo = typeof(AssemblyNameHelper).Assembly.GetName();
            string assemblyName = assemblyInfo.Name;
            assemblyName += assemblyInfo.Version;
            return assemblyName;
        }
    }
}