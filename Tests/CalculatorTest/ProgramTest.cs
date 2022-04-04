using System;
using Xunit;
using CalculatorProject;


namespace CalculatorTest
{
    public class TestFixture
    {
        public double num1;
        public double num2;
        public TestFixture()
        {
            num1 = 12.1;
            num2 = 2;
        }

    }
    public class MathOperationTest : IClassFixture<TestFixture>
    {
        TestFixture fixture;
        public MathOperationTest(TestFixture fixture)
        {
            this.fixture = fixture;
        }
        [Fact]
        public void AdditionTest()
        {
            //Arrange

            Calculator sut = new Calculator();
            var expectedValue = 14.1;

            //Act
            
            var sum = Calculator.Addition(fixture.num1, fixture.num2);
            var sumArray = Calculator.Addition(new double[] { fixture.num1, fixture.num2 });
            //Assert

            Assert.Equal(expectedValue, sum);
            Assert.Equal(expectedValue, sumArray);

        }

        [Fact]
        public void SubtrationTest()
        {
            //Arrange.
            Calculator sut = new Calculator();
            var expectedValue = 10.1;
            //Act.

            var sum = Calculator.Subtraction(fixture.num1, fixture.num2);
            var sumArray = Calculator.Subtraction(new double[] { fixture.num1, fixture.num2 });
            //Assert.
            Assert.Equal(expectedValue, sum);
            Assert.Equal(expectedValue, sumArray);
        }

        [Fact]
        public void MultiplicationTest()
        {
            //Arrange.
            Calculator sut = new Calculator();
            var expectedValue = 24.2;
            //Act.
            var sum = Calculator.Multiplication(new double[] { fixture.num1, fixture.num2 });
            //Assert.
            Assert.Equal(expectedValue, sum);
        }

        [Fact]
        public void DivisionTest()
        {
            //Arrange.
            Calculator sut = new Calculator();
            var expectedValue = 6.05;
            //Act.
            var sum =Calculator.Division(new double[] { fixture.num1, fixture.num2 });
            //Assert.
            Assert.Equal(expectedValue, sum);
        }

        [Fact]
        public void DivisionByZero()
        {
            //Arrange.
            Calculator sut = new Calculator();
            var num2 = 0;
            var expectedValue = 0;
            //Act.
            var sum = Calculator.Division(new double[] { fixture.num1, num2 });
            //Assert.
            Assert.Equal(expectedValue, sum);
        }




    }
}
