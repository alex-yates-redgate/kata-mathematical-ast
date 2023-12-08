using System.Linq.Expressions;

namespace MathematicalAST.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleOperand()
        {
            IExpression actual = Mathematical.parse("3");
            IExpression expected = new Operand(3);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void SimpleAddition()
        {
            IExpression actual = Mathematical.parse("3 6 +");
            IExpression expected = new Addition(new Operand(3), new Operand(6));
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ComplexAddition()
        {
            IExpression actual = Mathematical.parse("3 6 + 4 9 + +");
            IExpression expected = new Addition(new Addition(new Operand(3), new Operand(6)), new Addition(new Operand(4), new Operand(9)));
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}