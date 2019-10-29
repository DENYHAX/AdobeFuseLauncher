using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FuseLanucher
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteCacheFile();
            OpenFuse(10);
        }

        private static void OpenFuse(int loop)
        {
            string path = @"C:\Program Files (x86)\Adobe\Adobe Fuse CC (Beta)\Code\Build\Output\Fuse\bin\Release\";
            string executable = "Fuse.exe";
            for (int i = 0; i < loop; i++)
            {
            System.Diagnostics.Process.Start(Path.Combine(path, executable));
            }
        }

        private static void DeleteCacheFile()
        {
            string cacheFolder = @"C:\Program Files (x86)\Common Files\Adobe\SLCache";

            // Files to be deleted    
            string cacheFile = "Vjd7fUZ1c2UtMS4wLVdpbi1HTXt8fUFMTA==.slc";

            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(cacheFolder, cacheFile)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(cacheFolder, cacheFile));
                    Console.WriteLine("File deleted.");
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
        }
    }
}
