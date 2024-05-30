namespace Challenge4._3
{
    /*
     * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']'
     * Determine if the input string is valid.
     * An input string is valid if:
     * 1. Open brackets must be closed by the same type of brackets.
     * 2. Open brackets must be closed in the correct order.
     * 3. Every close bracket has a corresponding open bracket of the same type.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge4.3");
        }

        public static bool isValidString(string str)
        {
            Stack<char> stack = new Stack<char>();
            char top;
            foreach (char c in str)
            {
                // push all the opening brackets on the stack
                // for each closing brack we run into, the top
                // element of the stack should be its matching opening bracket
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    switch(c)
                    {
                        case ')':
                            // if the stack is empty, there was no opening brackets
                            // to match this closing one
                            if (stack.Count == 0) { return false; }
                            // pop the top element
                            top = stack.Pop();
                            // if the top element is not the matching bracket
                            // then this string is invalid
                            if (top != '(') { return false; }
                            break;
                        case '}':
                            if (stack.Count == 0) { return false; }
                            top = stack.Pop();
                            if (top != '{') { return false; }
                            break;
                        case ']':
                            if (stack.Count == 0) { return false; }
                            top = stack.Pop();
                            if (top != '[') { return false; }
                            break;
                        default:
                            return false;
                    }

                }
            }

            // If there are still any elements on the stack
            // then they were never properly closed
            if (stack.Count > 0) { return false; }
            
            // If we get to this line of code
            // it must be a valid string
            return true;
        }
    }
}
