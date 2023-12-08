using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAST
{
    public record Addition (IExpression left, IExpression right) : Operation (left, right)
    {

    }
}
