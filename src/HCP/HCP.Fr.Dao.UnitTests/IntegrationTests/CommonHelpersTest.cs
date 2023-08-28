using Xunit;
namespace HCP.Fr.Dao.UnitTests.IntegrationTests
{
    public class CommonHelpersTest
    {
        [Fact]
        public void Must_Return_List_Of_Ssns()
        {

        }

        [Fact]
        public void Must_Return_Empty_List_Of_Ssns()
        {
            var ssns = HCP.Helpers.CommonHelpers.GetAvailabeSsns();
            var expected = 0;
            var actual = ssns?.Count;
            Assert.Equal(expected, actual);

        }
        [Fact]
        public static void Return_Valid_Ssn_Count()
        {
            var ssns = HCP.Helpers.CommonHelpers.GenerateSsn();
            var expected = 11;
            var actual = ssns.Length;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void Show_Non_Existing_Ssn()
        {
            var expected = false;
            var actual = HCP.Helpers.CommonHelpers.SsnExist("111-11-1111");
            Assert.Equal(expected, actual);
        }
    }
}
