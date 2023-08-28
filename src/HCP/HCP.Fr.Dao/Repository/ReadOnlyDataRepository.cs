using HCP.Fr.DS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HCP.Fr.Dao.Repository
{
    /// <summary>Readonly data</summary>
    public static class ReadOnlyDataRepository
    {
        internal static HcpFrEntities db = new HcpFrEntities();

        /// <summary>Gets genders.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public static IList<string> GetGenders()
        {
            var genders=new List<string>();

            genders=db.Genders.Select(x=>x.Genre).ToList();
            return genders;
        }

        /// <summary>Gets  countries.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public static IList<Pays> GetCountries()
        {
            var countries = new List<Pays>();

            countries = db.Pays.AsParallel().OrderBy(x=>x.Nom).ToList();
            return countries;
        }

        public static async Task<IList<Pays>> GetCountriesAsync()
        {
            var countries = new List<Pays>();

            countries =await db.Pays.OrderBy(x => x.Nom).ToListAsync().ConfigureAwait(false);
            return countries;
        }

        /// <summary>Gets  patient identities.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public static IList<PatientIdentities> GetPatientIdentities()
        {
            var pids = new List<PatientIdentities>();

            pids = db.PatientIdentities.OrderBy(x=>x.Type).AsParallel().ToList();
            return pids;
        }

        /// <summary>Gets identity types.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public static IList<IdentityTypes> GetIdentityTypes()
        {
            var pids = new List<IdentityTypes>();

            pids = db.IdentityTypes.OrderBy(x => x.Type).AsParallel().ToList();
            return pids;
        }

        /// <summary>Gets  identity types asynchronously</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public static async Task<IList<IdentityTypes>> GetIdentityTypesAsync()
        {
            var pids = new List<IdentityTypes>();

            pids =await db.IdentityTypes.OrderBy(x => x.Type).ToListAsync().ConfigureAwait(false);
            return pids;
        }
    }
}
