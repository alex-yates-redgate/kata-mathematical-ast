using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAST
{
    public record Operand(int Value): IExpression
    {
        public void Accept(IVisitor visitor) {
            visitor.VisitOperand(this);
        }
    }
}
