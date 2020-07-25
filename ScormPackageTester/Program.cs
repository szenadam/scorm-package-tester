using System;
using System.IO;

namespace ScormPackageTester
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(Messages.NotEnoughArguments);
                return -1;
            }
            
            var file = new FileInfo(args[0]);

            if (file.Extension != ".xml")
            {
                Console.WriteLine(Messages.InvalidFileExtension);
            }

            return 0;
        }
    }
}