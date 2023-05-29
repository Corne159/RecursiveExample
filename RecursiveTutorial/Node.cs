namespace RecursiveTutorial
{
    internal class Node
    {
        public string op;
        public dynamic val1;
        public dynamic val2;

        public double DoCalculation(dynamic node)
        {
            double answer = 0;
            double node1Val = 0;
            double node2Val = 0;

            if (IsNumeric(node.val1))
            {
                node1Val = node.val1;
            }
            else
            {
                node1Val = DoCalculation(node.val1);
            }

            if (IsNumeric(node.val2))
            {
                node2Val = node.val2;
            }
            else
            {
                node2Val = DoCalculation(node.val2);
            }

            if (!string.IsNullOrEmpty(node.op))
            {
                switch (node.op)
                {
                    case "add":
                        answer = node1Val + node2Val;
                        break;
                    case "sub":
                        answer = node1Val - node2Val;
                        break;
                    case "mult":
                        answer = node1Val * node2Val;
                        break;
                    case "div":
                        answer = node1Val / node2Val;
                        break;
                }
            }

            return answer;
        }

        public bool IsNumeric(object o)
        {
            switch (Type.GetTypeCode(o.GetType()))
            {
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                    return true;
                default:
                    return false;
            }
        }
    }
}
