using Xunit;

namespace task_DEV_2.Tests
{
    public class task_DEV2Tests
    {
        [Fact]
        public void EvenNumberSequance_CompareWithString_TheyIdentical()
        {
            // arrange
            string sequance = "123456";
            StringCreater creator = new StringCreater();
            string expectedNewSequance = "246";

            // act
            string newsequance = creator.EvenNumberSequance(sequance);

            bool flag = false;
            if (newsequance == expectedNewSequance)
            {
                flag = true;
            }

            // assert
            Assert.True(flag);
        }

        [Fact]
        public void EvenNumberSequance_CompareWithString_TheyNOTIdentical()
        {
            // arrange
            string sequance = "123456";
            StringCreater creator = new StringCreater();
            string expectedWrongNewSequance = "245";

            // act
            string newsequance = creator.EvenNumberSequance(sequance);

            bool flag = false;
            if (newsequance == expectedWrongNewSequance)
            {
                flag = true;
            }

            // assert
            Assert.False(flag);
        }

        [Fact]
        public void EvenNumberSequance_CompareWithEString_EmptyString()
        {
            // arrange
            string sequance = "1";
            StringCreater creator = new StringCreater();

            // act
            string newsequance = creator.EvenNumberSequance(sequance);

            bool flag = false;
            if (newsequance == null)
            {
                flag = true;
            }

            // assert
            Assert.True(flag);
        }
    }
}
