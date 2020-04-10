using System;
using System.Diagnostics;
using System.IO;

namespace NetExtensions.ServiceContentRoot
{
    public class ServiceContentRoot
    {
        public string GetContentRoot() => Process.GetCurrentProcess().MainModule != null ? Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) : throw new ApplicationException("processModule is not found");
    }
}