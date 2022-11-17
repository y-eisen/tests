using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit_Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnTrue()
        {
            var calc = new Calculator();
            Assert.True(calc.Additional(5, 12) == 17);                  
        }
        
        [Test]
        public void SubtractionMustReturnTrue()
        {
            var calc = new Calculator();
            Assert.True(calc.Additional(21, 12) == 9);
        }

        [Test]
        public void MiltiplicationMustReturnTrue()
        {
            var calc = new Calculator();
            Assert.True(calc.Additional(5, 4) == 20);
        }

        [Test]
        public void DivisionMustReturnTrue()
        {
            var calc = new Calculator();
            Assert.True(calc.Additional(30, 6) == 5);
        }

        [Test]
        public void DivisionMustReturnException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(30, 0));
        }
    }
}
