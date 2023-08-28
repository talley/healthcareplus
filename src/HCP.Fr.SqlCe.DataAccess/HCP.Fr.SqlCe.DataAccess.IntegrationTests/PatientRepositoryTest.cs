using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HCP.Fr.SqlCe.DataAccess.Repositories;

namespace HCP.Fr.SqlCe.DataAccess.IntegrationTests
{
    [TestClass]
    public class PatientRepositoryTest
    {
        private PatientRepository repos = new PatientRepository();
        [TestMethod]
        public void Must_Return_Empty_Rows()
        {
            var actual = repos.GetAll().Count;
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
