namespace Task9Refactored;

    public class Calculator
    {
        private readonly StringParser _parser = new StringParser();

        public double CalculateExpression(string expression)
        {
            var tokens = _parser.ConvertToRPN(expression);
            var result = EvaluateRPN(tokens);
            return result;
        }

        private double EvaluateRPN(List<string> tokens)
        {
            var stack = new Stack<double>();

            foreach (var token in tokens)
            {
                if (_parser.IsNumeric(token))
                {
                    stack.Push(double.Parse(token));
                }
                else if (_parser.IsOperator(token))
                {
                    if (stack.Count < 2)
                    {
                        throw new InvalidOperationException("Invalid expression format");
                    }

                    double operand2 = stack.Pop();
                    double operand1 = stack.Pop();
                    double res = PerformOperation(token, operand1, operand2);
                    stack.Push(res);
                }
                else
                {
                    throw new InvalidOperationException("Invalid token found in expression");
                }
            }

            if (stack.Count != 1)
            {
                throw new InvalidOperationException("Invalid expression format");
            }

            return stack.Pop();
        }

        private double PerformOperation(string operation, double operand1, double operand2)
        {
            switch (operation)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    if (operand2 == 0)
                        throw new DivideByZeroException("Cannot divide by zero");
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }

    
