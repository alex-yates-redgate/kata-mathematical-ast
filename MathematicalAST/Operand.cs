using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAST
{
    internal class Operand: IOperand
    {
        public int Value { get; set; }

        public void Accept(IVisitor visitor) {
            visitor.VisitOperand(this);
        }
    }
}
