using Lab2.Controllers;

namespace Lab2.Models
{
    public class Calculator
    {
        public Operators? op { get; set; }
        public double? l1 { get; set; }
        public double? l2 { get; set; }

        public String Op
        {
            get
            {
                switch (op)
                {
                    case Operators.ADD:
                        return "+";
                    case Operators.SUB:
                        return "-";
                    case Operators.MUL:
                        return "*";
                    case Operators.DIV:
                        return "/";
                    default:
                        return "";
                }
            }
        }

        public bool IsValid()
        {
            return op != null && l1 != null && l2 != null;
        }

        public double Calculate()
        {
            switch (op)
            {
                case Operators.ADD:
                    return (double)(l1 + l2);
                case Operators.SUB:
                    return (double)(l1 - l2);
                case Operators.MUL:
                    return (double)(l1 * l2);
                case Operators.DIV:
                    return (double)(l1 / l2);
                default: return double.NaN;
            }
        }
    }
}
