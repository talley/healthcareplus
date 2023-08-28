using Xunit;

namespace HCP.Fr.Dao.UnitTests
{
    public class DummyUnitTestMust
    {
        [Fact]
        public void Pass()
        {
            Assert.Equal(5, Add(2, 2));
        }

        [Fact]
        public void Fail()
        {
            Assert.Equal(4, Add(2, 2));
        }

        private int Add(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}
