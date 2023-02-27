    using Data;

    namespace TestExample;
    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void AddingTest()
        {
            Assert.That(Calculator.Add(2,2), Is.EqualTo(4));
        }
        
        [Test]
        public void SubtractingTest()
        {
            Assert.That(Calculator.Subtract(8,2), Is.EqualTo(6));
        }

        [Test]
        public void Multiplication()
        {
            Assert.That(Calculator.Multiply(4,4), Is.EqualTo(16));
        }

        [Test]
        public void DivisionTest()
        {
            Assert.That(Calculator.Division(20,4), Is.EqualTo(5));
        }

        [Test]
        public void ModuloTest()
        {
            Assert.That(Calculator.Modulo(12,4), Is.EqualTo(0));
        }
        
    }
