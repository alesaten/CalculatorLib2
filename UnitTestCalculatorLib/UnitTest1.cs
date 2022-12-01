namespace UnitTestCalculatorLib
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdding2And2()
        {
            //подготовка
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new CalculatorLib2.Calculator();

            //действие
            double actual = calc.Add(a, b);

            //проверка
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2And3()
        {
            double a = 2;
            double b = 3;
            double expected = 5;
            var calc = new CalculatorLib2.Calculator();

            double actual = calc.Add(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtracting5And1()
        {
            double a = 5;
            double b = 1;
            double expected = 4;
            var calc = new CalculatorLib2.Calculator();

            double actual = calc.Subtraction(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtracting10And11()
        {
            double a = 10;
            double b = 11;
            double expected = -1;
            var calc = new CalculatorLib2.Calculator();

            double actual = calc.Subtraction(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplying3And9()
        {
            double a = 3;
            double b = 9;
            double expected = 27;
            var calc = new CalculatorLib2.Calculator();

            double actual = calc.Multiply(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplying1And0()
        {
            double a = 1;
            double b = 0;
            double expected = 0;
            var calc = new CalculatorLib2.Calculator();

            double actual = calc.Multiply(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDividing9And3()
        {
            double a = 9;
            double b = 3;
            double expected = 3;
            var calc = new CalculatorLib2.Calculator();

            double actual = calc.Division(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDividing10And100()
        {
            double a = 10;
            double b = 100;
            double expected = 0.1;
            var calc = new CalculatorLib2.Calculator();

            double actual = calc.Division(a, b);

            Assert.Equal(expected, actual);
        }
    }
}