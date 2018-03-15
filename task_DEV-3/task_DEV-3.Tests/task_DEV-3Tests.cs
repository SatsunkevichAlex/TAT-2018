using NUnit.Framework;

namespace task_DEV_3.Tests
{
    [TestFixture]
    public class task_DEV3Tasts
    {
        [TestCase]
        public void Converter_CheckMaxBaseSystem_ConvertCorrect()
        {
            //arrange
            Converter converter = new Converter();
            int systemBase = 20;
            int value = 12;
            string expectedValue = "M";
            string newValue;

            //act
            newValue = converter.ToNewNumberSystem(value, systemBase);

            bool flag = false;
            if (expectedValue == newValue)
            {
                flag = true;
            }

            //assert
            Assert.IsTrue(flag);
        }

        [TestCase]
        public void Converter_CheckMinBaseSystem_ConvertCorrect()
        {
            //arrange
            Converter converter = new Converter();
            int systemBase = 2;
            int value = 12;
            string expectedValue = "1100";
            string newValue;

            //act
            newValue = converter.ToNewNumberSystem(value, systemBase);

            bool flag = false;
            if (expectedValue == newValue)
            {
                flag = true;
            }

            //assert
            Assert.IsTrue(flag);
        }

        [TestCase]
        public void Converter_CompareWithInvalidValue_TheyNotEqual()
        {
            //arrange
            Converter converter = new Converter();
            int systemBase = 2;
            int value = 120;
            string expectedValue = "1111";
            string newValue;

            //act
            newValue = converter.ToNewNumberSystem(value, systemBase);

            bool flag = false;
            if (expectedValue == newValue)
            {
                flag = true;
            }

            //assert
            Assert.IsFalse(flag);
        }
    }
}
