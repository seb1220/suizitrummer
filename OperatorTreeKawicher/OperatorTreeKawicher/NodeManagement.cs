using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorTreeKawicher
{
    internal class NodeManagement
    {
        List<Node> _nodes;

        public NodeManagement()
        {
            _nodes = new List<Node>();
        }

        public void newOperand(int x, int y, int number)
        {
            _nodes.Add(new Operand(x, y, number));
        }

        public void newOperator(int x, int y, string symbol)
        {
            _nodes.Add(new Operator(x, y, symbol));
        }

        public void paint(Graphics g)
        {
            foreach (Node node in _nodes)
            {
                node.paint(g);
            }
        }

        public Node isIn(int x, int y)
        {
            foreach (Node node in _nodes)
            {
                if (node.isIn(x, y))
                    return node;
            }
            return null;
        }
    }
}
