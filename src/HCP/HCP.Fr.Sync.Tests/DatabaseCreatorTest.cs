using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HCP.Fr.Sync.Tests
{
    [TestClass]
    public class DatabaseCreatorTest
    {

        [TestMethod]
        public void Should_Return_Valid_DbPath()
        {
            var actual = DatabaseCreator.DbPath();
            var expected = "";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_Return_Valid_DbSource()
        {
            var actual = DatabaseCreator.DbSource();
            var expected = "";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Should_Create_Database_File()
        {
            var actual = DatabaseCreator.CreateDdIfNotExist();
            var expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
