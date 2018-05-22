using System;
using NUnit.Framework;
using WebServiceConsumer.DateConverter;

namespace WebService.UnitTests
{
    [TestFixture]
    class DateConverterTests
    {
        [TestCase(0, 0, 0, 0)]
        [TestCase(1, 0, 0, 365)]
        [TestCase(0, 1, 0, 31)]
        [TestCase(0, 0, 1, 1)]
        [TestCase(0, 0, 31, 31)]
        public void ConvertDateIntoDays_InputDate_ReturnDays(int year, int month, int day, int expected)
        {
            var service = new DateConverter();

            int dateInDays = service.ConvertDateIntoDays(year, month, day);

            Assert.AreEqual(expected, dateInDays);
        }
    }
}
