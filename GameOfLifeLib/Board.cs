using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameOfLifeLib {
    public class Board {
        protected List<Point> _cells;
        protected IGridDrawer _drawer;
        
        public Board(IGridDrawer drawer, string grid = "") {
            _drawer = drawer;
            _cells = CellsFromString(grid);
        }

        public static List<Point> CellsFromString(string input, char alive = 'x') {
            string[] rows = input.Split(';');
            var cells = new List<Point>();
            for (int y = 0; y < rows.Length; y++) {
                for (int x = 0; x < rows[y].Length; x++) {
                    if (rows[y].ElementAt(x).Equals(alive)) {
                        cells.Add(new Point(x, y));
                    }
                }
            }
            return cells;
        }

        public void Draw() {
            _drawer.DrawGrid(_cells);
        }
    }
}
