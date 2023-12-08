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
        public void Test1()
        {
            IExpression actual = Mathematical.parse("3");
            IExpression expected = new Operand(3);
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}