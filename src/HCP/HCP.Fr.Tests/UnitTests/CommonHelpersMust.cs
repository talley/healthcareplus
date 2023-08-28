using HCP.Fr.Tests.Helpers;
using System;
using Xunit;

namespace HCP.Fr.Tests.UnitTests
{
    public class CommonHelpersMust
    {
        [Fact]
        public void ReturnCorrectEuDate()
        {
            var today = DateTime.Today;
            var expected = CommonHelpers.GetEuDate();
            var actual = "09/04/2023";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnCorrectSystemUserWithEmail()
        {
            var email = "talleyouro@outlook.com";
            var expected = CommonHelpers.GetSystemUserName(email);
            var machineName=Environment.MachineName;
            var actual = string.Concat(email, "@", machineName);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnCorrectSystemUserWithoutEmail()
        {
            var email = "";
            var expected = CommonHelpers.GetSystemUserName(email);
            var machineName = Environment.MachineName;
            var actual =machineName;

            Assert.Equal(expected, actual);
        }
    }
}
