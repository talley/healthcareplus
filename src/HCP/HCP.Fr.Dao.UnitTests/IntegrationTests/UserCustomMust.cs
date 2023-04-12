using HCP.Fr.Dao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Text;
using HCP.Com.Helpers;

namespace HCP.Fr.Dao.UnitTests.IntegrationTests
{
    public class UserCustomMust
    {

        [Fact]
        public void ReturnValidPassword()
        {

            var password = "test";
            var expected = UserCustom.GetHashPassword(password);
            var actual = Encoding.ASCII.GetBytes("0x9F7D8627E02F97CC5A52DCB2BA96038FE12F2A34B0FAC50E041359AE13D5EDE8A8A50562DA58BA7916DA378E7343EF91E85EFBD6A0A70AB237ADA4C2274DF13D");

            Assert.Equivalent(expected,actual);
        }
        [Fact]
        public void ConvertHashToString()
        {
            var password = "test";
            var sexpected = UserCustom.GetHashPassword(password);
            var actual = Encoding.ASCII.GetBytes("0x9F7D8627E02F97CC5A52DCB2BA96038FE12F2A34B0FAC50E041359AE13D5EDE8A8A50562DA58BA7916DA378E7343EF91E85EFBD6A0A70AB237ADA4C2274DF13D");
            var expected = Encoding.ASCII.GetString(sexpected);
            var spassword = "0x9F7D8627E02F97CC5A52DCB2BA96038FE12F2A34B0FAC50E041359AE13D5EDE8A8A50562DA58BA7916DA378E7343EF91E85EFBD6A0A70AB237ADA4C2274DF13D";
            Assert.Equal(expected, spassword);
        }
    }
}
