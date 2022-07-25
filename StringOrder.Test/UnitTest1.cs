using NUnit.Framework;
using StringOrder;

namespace StringOrder.Test
{
    public class Tests
    {

        [TestCase("45 34 24 108 76 58 64 130 80", ExpectedResult = "130 24 34 80 108 45 64 58 76")]
        [TestCase("    2022 70 123    3344 13", ExpectedResult = "13 123 2022 70 3344")]
        public string Order(string x)
        {
            return StringOrder.Order(x);
        }
    }
}