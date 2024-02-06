using System;
using System.Collections.Generic;
using System.IO;

using AODb.Common;
using AODb.Data;

namespace Parser
{
    internal class RDBParser
    {
        public static RdbController rdbController;

        static void Main(string[] args)
        {
            string aoPath = args[0];
            Directory.SetCurrentDirectory(aoPath);
            rdbController = new RdbController(aoPath);
            Console.WriteLine(aoPath);
        }
    }
}

