using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using System;
using Xunit;

namespace HCP.Fr.IntegrationTests.Tests
{
    public class PatientIdentitiesRepositoryMust
    {
        internal IRepository<PatientIdentities> repos = new PatientIdentitiesRepository();

        [Fact]
        public void Upload_Identity_To_Db()
        {
            var photo = @"C:\GitApps\healthcareplus\src\HCP\HCP.Fr.IntegrationTests\Data\lucy.png";
            var id = 1;// Guid.Parse("1af39786-0b79-4363-aa4a-c619a861aa3a");
            var entity = new PatientIdentities
            {
                Id = id,
                ajouter_au="26/4/2023",
                ajouter_par="test",
                Chemin_Du_Fichier=photo,
                Type= "Photo"
            };

            var expected=repos.SaveOrUpdate(entity);
            var actual = 1;
            Assert.Equal(expected, actual);
        }
    }
}
