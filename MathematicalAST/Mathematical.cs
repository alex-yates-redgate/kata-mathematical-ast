using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAST
{
    public class Mathematical
    {
        public static IExpression parse(string input)
        {
            var elements = input.Split(' ');
            
            var elementStack = new Stack<IExpression>();

            foreach (var element in elements)
            {
                if (int.TryParse(element, out var number))
                {
                    elementStack.Push(new Operand(number));
                } 
                else
                {
                    if (element == "+")
                    {
                        var right = elementStack.Pop();
                        var left = elementStack.Pop();
                        elementStack.Push(new Addition(left, right));
                    }
                }
            }

            return elementStack.Pop();
        }


    }
}
