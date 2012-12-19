using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameOfLifeLib {
    public class Helper {
        public static CellState NextState(CellState cellState, int aliveNeighbourCount) {
            if (aliveNeighbourCount == 3)
                return CellState.Alive;

            if (cellState == CellState.Alive && aliveNeighbourCount == 2)
                return CellState.Alive;

            return CellState.Dead;
        }

        public static int AliveNeighbourCount(int x, int y, List<Point> cells) {
            return cells.Where(NotSameCell(x, y))
                .Where(DistanceLessThenOrEqualToOne(x, y))
                .Count();
        }

        public static Func<Point, bool> DistanceLessThenOrEqualToOne(int x, int y) {
            return (c) => !(Math.Abs(c.X - x) > 1) && !(Math.Abs(c.Y - y) > 1);
        }

        public static Func<Point, bool> NotSameCell(int x, int y) {
            return (c) => !(c.X == x && c.Y == y);
        }

        public enum CellState {
            Alive,
            Dead
        }
    }
}
