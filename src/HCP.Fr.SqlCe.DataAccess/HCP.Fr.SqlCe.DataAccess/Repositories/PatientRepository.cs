using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.SqlCe.DataAccess.Repositories
{
    public class PatientRepository
    {
        public List<Patient> GetAll()
        {
            var result = new List<Patient>();

            using (var ct = new HCPFrSqlCe())
            {
                result = ct.Patients.ToList();
            }
            return result;
        }
    }
}
