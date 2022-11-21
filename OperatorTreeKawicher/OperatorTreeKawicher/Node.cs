using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTreeKawicher
{
    internal abstract class Node
    {
        int X { get; set; }
        int Y { get; set; }

        Node(int x, int y)
        {
            X = x;
            Y = y;
        }

        // TODO paint
    }
}
