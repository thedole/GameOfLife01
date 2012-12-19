using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameOfLifeLib {
    public interface IGridDrawer {
        bool DrawGrid(List<Point> cells);
    }
}
