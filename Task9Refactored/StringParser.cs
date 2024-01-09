namespace Task9Refactored;


    public class StringParser
    {
        public List<string> ConvertToRPN(string expression)
        {
            var output = new List<string>();
            var stack = new Stack<char>();
            var precedence = new Dictionary<char, int> { { '+', 1 }, { '-', 1 }, { '*', 2 }, { '/', 2 } };

            expression = expression.Replace(" ", "");

            foreach (char c in expression)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    int numStart = expression.IndexOf(c);
                    int numEnd = numStart + 1;
                    while (numEnd < expression.Length &&
                           (char.IsDigit(expression[numEnd]) || expression[numEnd] == '.'))
                    {
                        numEnd++;
                    }

                    output.Add(expression.Substring(numStart, numEnd - numStart));
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        output.Add(stack.Pop().ToString());
                    }

                    if (stack.Count == 0)
                    {
                        throw new InvalidOperationException("Mismatched parentheses");
                    }

                    stack.Pop();
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    while (stack.Count > 0 && precedence.ContainsKey(stack.Peek()) &&
                           precedence[c] <= precedence[stack.Peek()])
                    {
                        output.Add(stack.Pop().ToString());
                    }

                    stack.Push(c);
                }
                else
                {
                    throw new InvalidOperationException("Invalid character in expression");
                }
            }

            while (stack.Count > 0)
            {
                if (stack.Peek() == '(')
                {
                    throw new InvalidOperationException("Mismatched parentheses");
                }

                output.Add(stack.Pop().ToString());
            }

            return output;
        }

        public bool IsNumeric(string token)
        {
            return double.TryParse(token, out _);
        }

        public bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }
    }