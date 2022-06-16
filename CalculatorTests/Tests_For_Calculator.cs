using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator1;
using Moq;

namespace CalculatorTests
{
    [TestFixture]
    class Tests_r_CalFoculator
    {
        private Mock<IDiagnostics> _mockAdd;
        private Mock<IDBSave> _mockDBSave;
        private Calculator GetCalculator()
        {
            _mockAdd = new Mock<IDiagnostics>();
            _mockDBSave = new Mock<IDBSave>();
            _mockAdd.Setup(x => x.Log(It.IsAny<string>()));
            _mockDBSave.Setup(m => m.Save(It.IsAny<string>()));
            var calc = new Calculator(_mockAdd.Object,_mockDBSave.Object);
            return calc;
        }

        [TestCase(2,3,5)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, 2, 0)]
        [TestCase(-3, -3, -6)]

        public void Test_Add_Numbers(int a, int b, int expected)
        {
            //Arrange
            //Mock<IDiagnostics> mockAdd = new Mock<IDiagnostics>();
            // _mockAdd.Setup(x => x.Log(It.IsAny<string>()));
            // _mockDBSave.Setup(m => m.Save(It.IsAny<string>()));
            // Calculator calc = new Calculator(mockAdd.Object);
            Calculator calc = GetCalculator();
            //Act
            int sum = calc.Add(a, b);
            
            //Assert
            Assert.That(sum, Is.EqualTo(expected));
            _mockAdd.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
            _mockDBSave.Verify(y => y.Save(It.IsAny<string>()), Times.Once);
            _mockAdd.VerifyAll();
        }

        [TestCase(0, 3, 5)]
        [TestCase(0, 0, 10)]
        [TestCase(-2, -2, 2)]
        [TestCase(-3, -3, 6)]

        public void Test_Add_NotNumbers(int a, int b, int expected)
        {
            //Arrange
            //Mock<IDiagnostics> mockAdd = new Mock<IDiagnostics>();
            // _mockAdd.Setup(x => x.Log(It.IsAny<string>()));
            // _mockDBSave.Setup(m => m.Save(It.IsAny<string>()));
            // Calculator calc = new Calculator(mockAdd.Object);
            Calculator calc = GetCalculator();
            //Act
            int sum = calc.Add(a, b);

            //Assert
            Assert.That(sum, Is.Not.EqualTo(expected));
            _mockAdd.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
            _mockDBSave.Verify(y => y.Save(It.IsAny<string>()), Times.Once);
            _mockAdd.VerifyAll();
        }
    }
}
