using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAST
{
    internal class Operation : IOperation
    {
        public char Type { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitOperation(this);
        }

    }
}
