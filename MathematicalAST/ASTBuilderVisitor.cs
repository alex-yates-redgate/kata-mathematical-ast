using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalAST
{
    internal class ASTBuilderVisitor : IVisitor
    {
        void IVisitor.VisitOperand(Operand element)
        {
            Console.WriteLine($"Operand is {element.Value}");
        }

        void IVisitor.VisitOperation(Operation element)
        {
            Console.WriteLine($"Operation is { element.Type }");
        }

        public string CreateAST(Operand operand1, Operand operand2, Operation operation)
        {
            int num1 = operand1.Value;
            int num2 = operand2.Value;
            char op = operation.Type;
            return $"{num1} {op} {num2}";
        }


    }
}
