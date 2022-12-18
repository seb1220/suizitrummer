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

    // This class is used to manage the nodes in the tree
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
            _nodes.FindAll(n => n is Operator).ForEach(n => ((Operator)n).paintConn(g));
            _nodes.ForEach(n => n.paint(g));
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

            foreach (Node node in _nodes.FindAll(node => node is Operator))
            {
                if (((Operator)node).isValid() == false)
                    return false;
            }
            
            foreach (Node node in _nodes.FindAll(op => op is Operand))
            {
                if (_nodes.FindAll(n => n is Operator @operator && (@operator.Left == node || @operator.Right == node)).Count == 0)
                    return false;
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
                    if (((Operator)node).Left != null && ((Operator)node).Left.GetType() == typeof(Operator))
                        operators.Add((Operator)((Operator)node).Left);
                    if (((Operator)node).Right != null && ((Operator)node).Right.GetType() == typeof(Operator))
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

        public List<Node> getPrefix()
        {
            if (isValid() == false)
                return null;

            Operator root = this.getRoot();
            List<Node> prefix = new List<Node>();
            
            constructPrefix(prefix, root);

            return prefix;
        }

        private void constructPrefix(List<Node> prefix, Operator op)
        {
            prefix.Add(op);
            
            if (op.Left != null)
            {
                if (op.Left.GetType() == typeof(Operator))
                    constructPrefix(prefix, (Operator)op.Left);
                else if (op.Left.GetType() == typeof(Operand))
                    prefix.Add((Operand)op.Left);
            }
            if (op.Right != null)
            {
                if (op.Right.GetType() == typeof(Operator))
                     constructPrefix(prefix, (Operator)op.Right);
                else if (op.Right.GetType() == typeof(Operand))
                    prefix.Add((Operand)op.Right);
            }
        }

        public List<Node> getInfix()
        {
            if (isValid() == false)
                return null;

            Operator root = this.getRoot();
            List<Node> prefix = new List<Node>();

            constructInfix(prefix, root);

            return prefix;
        }

        private void constructInfix(List<Node> infix, Operator op)
        {
            if (op.Left != null)
            {
                if (op.Left.GetType() == typeof(Operator))
                    constructInfix(infix, (Operator)op.Left);
                else if (op.Left.GetType() == typeof(Operand))
                    infix.Add((Operand)op.Left);
            }
            infix.Add(op);
            if (op.Right != null)
            {
                if (op.Right.GetType() == typeof(Operator))
                    constructInfix(infix, (Operator)op.Right);
                else if (op.Right.GetType() == typeof(Operand))
                    infix.Add((Operand)op.Right);
            }
        }

        public List<Node> getPostfix()
        {
            if (isValid() == false)
                return null;

            Operator root = this.getRoot();
            List<Node> postfix = new List<Node>();

            constructPostfix(postfix, root);
            
            return postfix;
        }

        private void constructPostfix(List<Node> postfix, Operator op)
        {
            if (op.Left != null)
            {
                if (op.Left.GetType() == typeof(Operator))
                    constructPostfix(postfix, (Operator)op.Left);
                else if (op.Left.GetType() == typeof(Operand))
                    postfix.Add((Operand)op.Left);
            }
            if (op.Right != null)
            {
                if (op.Right.GetType() == typeof(Operator))
                    constructPostfix(postfix, (Operator)op.Right);
                else if (op.Right.GetType() == typeof(Operand))
                    postfix.Add((Operand)op.Right);
            }
            postfix.Add(op);
        }

        public void clear()
        {
            _nodes.Clear();
        }

    }
}
