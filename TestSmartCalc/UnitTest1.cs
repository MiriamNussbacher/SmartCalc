using Moq;
using SmartCalc;
using SmartCalc.Controllers;
using System;
using Xunit;

namespace TestSmartCalc
{
    public class UnitTest1
    {
        [Fact]
        public void TestPlus()
        {
          //  public Mock<Payload> mock = new Mock<Payload>();

        //arrange
        Payload p = new Payload()
        {
            Left = 5,
            Operator = "plus",
            Right = 7
        };
           
            //act
            string result = Calculator.plus(p.Left, p.Right);

            //Assert

            Assert.True(result == "5+7=12");

    }


        [Fact]
        public void TestMinus()
        {
            //  public Mock<Payload> mock = new Mock<Payload>();

            //arrange
            Payload p = new Payload()
            {
                Left = 10,
                Operator = "minus",
                Right = 3
            };

            //act
            string result = Calculator.minus(p.Left, p.Right);

            //Assert

            Assert.True(result == "10-3=7");

        }

        [Fact]
        public void TestMinusNegativeReslut()
        {
            //  public Mock<Payload> mock = new Mock<Payload>();

            //arrange
            Payload p = new Payload()
            {
                Left = 3,
                Operator = "minus",
                Right = 10
            };

            //act
            string result = Calculator.minus(p.Left, p.Right);

            //Assert

            Assert.True(result == "3-10=-7");

        }

        [Fact]
        public void TestMinusWrongExample()
        {
            //  public Mock<Payload> mock = new Mock<Payload>();

            //arrange
            Payload p = new Payload()
            {
                Left = 3,
                Operator = "minus",
                Right = 10
            };

            //act
            string result = Calculator.minus(p.Left, p.Right);

            //Assert

            Assert.False(!(result == "3-10=-7"));

        }


        [Fact]
        public void TestMultiple()
        {
            //  public Mock<Payload> mock = new Mock<Payload>();

            //arrange
            Payload p = new Payload()
            {
                Left = 4,
                Operator = "multiply",
                Right = 5
            };

            //act
            string result = Calculator.multiply(p.Left, p.Right);

            //Assert

            Assert.True((result == "4*5=20"));

        }

        [Fact]
        public void TestMinusMultiple()
        {
            //  public Mock<Payload> mock = new Mock<Payload>();

            //arrange
            Payload p = new Payload()
            {
                Left = -4,
                Operator = "multiply",
                Right = 5
            };

            //act
            string result = Calculator.multiply(p.Left, p.Right);

            //Assert

            Assert.True((result == "-4*5=-20"));

        }


        [Fact]
        public void TestDivideByZero()
        {
            //  public Mock<Payload> mock = new Mock<Payload>();

            //arrange
            Payload p = new Payload()
            {
                Left = 3,
                Operator = "divide",
                Right = 0
            };


            //Assert and assert


            Assert.Throws<DivideByZeroException>(() => Calculator.divide(p.Left, p.Right));

        }

    }
}

