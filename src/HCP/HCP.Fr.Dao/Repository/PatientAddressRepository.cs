using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class PatientAddressRepository : IRepository<Patient_Addresses>
    {
        private HcpFrEntities db = new HcpFrEntities();
        public int Delete(Patient_Addresses entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Patient_Addresses entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(Patient_Addresses entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(Patient_Addresses entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(Patient_Addresses entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(Patient_Addresses entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(Patient_Addresses entity)
        {
            throw new NotImplementedException();
        }
        public bool EnsureModelIsValidForUpdate(Patient_Addresses entity)
        {
            throw new NotImplementedException();
        }
        public List<Patient_Addresses> GetAll() => db.Patient_Addresses.AsParallel().ToList();

        public async Task<List<Patient_Addresses>> GetAllAsync() => await db.Patient_Addresses.ToListAsync().ConfigureAwait(false);

        public Patient_Addresses GetById(Patient_Addresses entity) => db.Patient_Addresses.SingleOrDefault(x => x.PadId == entity.PadId);


        public async Task<Patient_Addresses> GetByIdAsync(Patient_Addresses entity) =>
            await db.Patient_Addresses.SingleOrDefaultAsync(x => x.PadId == entity.PadId).ConfigureAwait(false);

        public int Save() => db.SaveChanges();

        public async Task<int> SaveAsync() => await db.SaveChangesAsync().ConfigureAwait(false);


        public int SaveOrUpdate(Patient_Addresses entity)
        {
            int result = 0;
            try
            {
                if (entity.PadId == 0)
                {
                    db.Entry(entity).State = EntityState.Added;
                    result = Save();
                }
                else
                {
                    var f = GetById(entity);
                    if (f != null)
                    {
                        f.Id = entity.Id;
                        f.adresse = entity.adresse;
                        f.appartement = entity.appartement;
                        f.ville = entity.ville;
                        f.état_ou_région = entity.état_ou_région;
                        f.Pays = entity.Pays;
                        f.boite_postale = entity.boite_postale;
                        f.téléphone = entity.téléphone;
                        f.ajouter_au = entity.ajouter_au;
                        f.ajouter_par = entity.ajouter_par;
                        f.Notes = entity.Notes;

                        db.Entry(f).State = EntityState.Modified;
                        result = Save();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public async Task<int> SaveOrUpdateAsync(Patient_Addresses entity)
        {
            int result = 0;
            try
            {
                if (entity.PadId == 0)
                {
                    db.Entry(entity).State = EntityState.Added;
                    result = Save();
                }
                else
                {
                    var f = await GetByIdAsync(entity);
                    if (f != null)
                    {
                        f.Id = entity.Id;
                        f.adresse = entity.adresse;
                        f.appartement = entity.appartement;
                        f.ville = entity.ville;
                        f.état_ou_région = entity.état_ou_région;
                        f.Pays = entity.Pays;
                        f.boite_postale = entity.boite_postale;
                        f.téléphone = entity.téléphone;
                        f.ajouter_au = entity.ajouter_au;
                        f.ajouter_par = entity.ajouter_par;
                        f.Notes = entity.Notes;

                        db.Entry(f).State = EntityState.Modified;
                        result = await SaveAsync();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
    }
}
