using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using GameOfLifeLib;

namespace ConsoleGameOfLife {
    internal class ConsoleGridDrawer : IGridDrawer {
        public int OriginX { get; set; }
        public int OriginY { get; set; }
        
        public bool DrawGrid(List<Point> cells) {
            try {
                OriginX = Console.CursorLeft;
                OriginY = Console.CursorTop;
                cells.ForEach((c) => WriteAt("Ø", c.X, c.Y));
                Console.CursorLeft = OriginX;
                Console.CursorTop = OriginY;
            }
            catch (Exception) {

                return false;
            }
            return true;
        }

        public void WriteAt(string s, int x, int y) {
            try {
                Console.SetCursorPosition(OriginX + x, OriginY + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e) {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
    }
}
