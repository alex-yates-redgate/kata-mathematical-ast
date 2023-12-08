using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAST
{
    public record Operation(IExpression left, IExpression right) : IExpression
    {

        public void Accept(IVisitor visitor)
        {
            visitor.VisitOperation(this);
        }


    }
}
