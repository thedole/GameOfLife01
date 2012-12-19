using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using GameOfLifeLib;

namespace ConsoleGameOfLife {
    class ConsoleGameOfLife {
        static void Main(string[] args) {
            var board = new Board(new ConsoleGridDrawer(),
                                "   xx   ;" +
                                " xx  xx ;" +
                                "x      x;" +
                                "x x  x x;" +
                                "x      x;" +
                                "x  xx  x;" +
                                " xx  xx ;" +
                                "   xx   ");
            Console.Clear();
            board.Draw();
            Console.ReadLine();
        }
    }
}
