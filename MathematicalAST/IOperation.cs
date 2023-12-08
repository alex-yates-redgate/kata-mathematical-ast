using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAST
{
    internal interface IOperation
    {
        void Accept(IVisitor visitor);
    }
}
