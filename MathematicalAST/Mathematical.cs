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
            return new Operand(int.Parse(input));
        }
    }
}
