using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAST
{
    internal interface IVisitor
    {
        void VisitOperand(Operand element);
        void VisitOperation(Operation element);
    }
}
