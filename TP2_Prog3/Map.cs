using System;
using System.Collections.Generic;
using System.IO;
using TP2_Prog3.Util;

namespace TP2_Prog3
{
    public class Map
    {
        private static string _txtPath = Path.Combine(Environment.CurrentDirectory, "map.txt");

        private static int _height;
        private static int _width;

        private static readonly List<List<string>> ImportedMap = FileReader.ReadFile(_txtPath, out _width, out _height);

        public readonly List<List<string>> MapLines = new List<List<string>>();

        public int Height => _height;
        public int Width => _width;

        public Map()
        {
            GenerateMap();
        }

        private void GenerateMap()
        {
            foreach (var line in ImportedMap)
            {
                MapLines.Add(line);
            }
        }
    }
}