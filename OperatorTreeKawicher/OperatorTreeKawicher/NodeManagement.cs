using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorTreeKawicher
{
    [Serializable]
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
                if (node.GetType() == typeof(Operator))
                    ((Operator) node).paintConn(g);
            }
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

        public Boolean isNear(int x, int y)
        {
            foreach (Node node in _nodes)
            {
                if (node.isNear(x, y))
                    return true;
            }
            return false;
        }

        public Boolean isValid()
        {
            if (_nodes.FindAll(node => node.GetType() == typeof(Operator)).Count == 0)
                return false;

            foreach (Node node in _nodes)
            {
                if (node.GetType() == typeof(Operator))
                {
                    if (((Operator)node).isValid() == false)
                        return false;
                }
            }
            return true;
        }

        private Operator getRoot()
        {
            if (this.isValid() == false)
                return null;

            List<Operator> operators = new List<Operator>();
            foreach (Node node in _nodes)
            {
                if (node.GetType() == typeof(Operator))
                {
                    if (((Operator)node).Left == null && ((Operator)node).Left.GetType() == typeof(Operator))
                        operators.Add((Operator)((Operator)node).Left);
                    if (((Operator)node).Right == null && ((Operator)node).Right.GetType() == typeof(Operator))
                        operators.Add((Operator)((Operator)node).Right);
                }
            }
            foreach (Node node in _nodes)
            {
                if (node.GetType() == typeof(Operator))
                {
                    if (operators.Contains((Operator)node) == false)
                        return (Operator)node;
                }
            }
            return null;
        }

        public String getPrefix()
        {
            if (isValid() == false)
                return "Invalid Tree";

            Operator root = this.getRoot();
            String prefix = "";
            //return "ah";
            return constructPrefix(prefix, root);
        }

        private String constructPrefix(String prefix, Operator op)
        {
            prefix += op.Symbol + " ";
            
            if (op.Left != null)
            {
                if (op.Left.GetType() == typeof(Operator))
                    prefix = constructPrefix(prefix, (Operator)op.Left);
                else if (op.Left.GetType() == typeof(Operand))
                    prefix += ((Operand)op.Left).Number + " ";
            }
            if (op.Right != null)
            {
                if (op.Right.GetType() == typeof(Operator))
                    prefix = constructPrefix(prefix, (Operator)op.Right);
                else if (op.Right.GetType() == typeof(Operand))
                    prefix += ((Operand)op.Right).Number + " ";
            }
            
            return prefix;
        }

        public String getInfix()
        {
            if (isValid() == false)
                return "Invalid Tree";

            Operator root = this.getRoot();
            String prefix = "";

            return constructInfix(prefix, root);
        }

        private String constructInfix(String infix, Operator op)
        {
            if (op.Left != null)
            {
                if (op.Left.GetType() == typeof(Operator))
                    infix = constructInfix(infix, (Operator)op.Left);
                else if (op.Left.GetType() == typeof(Operand))
                    infix += "(" + ((Operand)op.Left).Number + " ";
            }
            infix += op.Symbol + " ";
            if (op.Right != null)
            {
                if (op.Right.GetType() == typeof(Operator))
                    infix = constructInfix(infix, (Operator)op.Right);
                else if (op.Right.GetType() == typeof(Operand))
                    infix += ((Operand)op.Right).Number + ") ";
            }
            return infix;
        }

        public String getPostfix()
        {
            if (isValid() == false)
                return "Invalid Tree";

            Operator root = this.getRoot();
            String prefix = "";
            
            return constructPostfix(prefix, root);
        }

        private String constructPostfix(String postfix, Operator op)
        {
            if (op.Left != null)
            {
                if (op.Left.GetType() == typeof(Operator))
                    postfix = constructPostfix(postfix, (Operator)op.Left);
                else if (op.Left.GetType() == typeof(Operand))
                    postfix += ((Operand)op.Left).Number + " ";
            }
            if (op.Right != null)
            {
                if (op.Right.GetType() == typeof(Operator))
                    postfix = constructPostfix(postfix, (Operator)op.Right);
                else if (op.Right.GetType() == typeof(Operand))
                    postfix += ((Operand)op.Right).Number + " ";
            }
            postfix += op.Symbol + " ";
            return postfix;
        }

        public void clear()
        {
            _nodes.Clear();
        }

        //public void animatePrefix

    }
}
