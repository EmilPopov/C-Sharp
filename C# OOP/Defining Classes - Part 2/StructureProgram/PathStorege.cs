﻿namespace StructureProgram
{
    using System;
    using System.IO;

    static class PathStorage
    {
        public static Path Load(string file)
        {
            return Path.Parse(File.ReadAllText(file));
        }

        public static void Write(Path path, string file)
        {
            File.WriteAllText(file, path.ToString());
        }
    }
}
