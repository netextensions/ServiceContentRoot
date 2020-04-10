using System;
using System.Diagnostics;
using System.IO;

namespace NetExtensions
{
    public class ServiceContentRoot
    {
        public static string GetContentRoot() =>
            Process.GetCurrentProcess().MainModule != null
                ? Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)
                : throw new ApplicationException("processModule is not found");
    }
}