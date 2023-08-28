using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class PatientNoteRepository : IRepository<PatientsNotes>
    {
        private HcpFrEntities db=new HcpFrEntities();
        public int Delete(PatientsNotes entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(PatientsNotes entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(PatientsNotes entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(PatientsNotes entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(PatientsNotes entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(PatientsNotes entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(PatientsNotes entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(PatientsNotes entity)
        {
            throw new NotImplementedException();
        }

        public List<PatientsNotes> GetAll()
        {
            return db.PatientsNotes.ToList();
        }

        public async Task<List<PatientsNotes>> GetAllAsync()
        {
            return await db.PatientsNotes.ToListAsync().ConfigureAwait(false);
        }

        public PatientsNotes GetById(PatientsNotes entity)
        {
           return db.PatientsNotes.SingleOrDefault(x=>x.PnId==entity.PnId);
        }

        public async Task<PatientsNotes> GetByIdAsync(PatientsNotes entity)
        {
            return await db.PatientsNotes.SingleOrDefaultAsync(x => x.PnId == entity.PnId).ConfigureAwait(false);
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public int SaveOrUpdate(PatientsNotes entity)
        {
            var result = 0;
            try
            {
                if (entity.PnId==0)
                {
                    db.Entry(entity).State = EntityState.Added;
                    result = db.SaveChanges();
                }
                else
                {
                    var edit=db.PatientsNotes.SingleOrDefault(x=>x.PnId==entity.PnId);
                    if(edit != null)
                    {
                        edit.Id = entity.Id;
                        edit.Notes = entity.Notes;
                        edit.ajouter_par = entity.ajouter_par;
                        edit.ajouter_au= entity.ajouter_au;
                        edit.modifier_au = entity.modifier_au;
                        edit.modifier_par = entity.modifier_par;

                        db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
                        result = db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public async Task<int> SaveOrUpdateAsync(PatientsNotes entity)
        {
            var result = 0;
            try
            {
                if (entity.PnId == 0)
                {
                    db.Entry(entity).State = System.Data.Entity.EntityState.Added;
                    result = db.SaveChanges();
                }
                else
                {
                    var edit = db.PatientsNotes.SingleOrDefault(x => x.PnId == entity.PnId);
                    if (edit != null)
                    {
                        edit.Id = entity.Id;
                        edit.Notes = entity.Notes;
                        edit.ajouter_par = entity.ajouter_par;
                        edit.ajouter_au = entity.ajouter_au;
                        edit.modifier_au = entity.modifier_au;
                        edit.modifier_par = entity.modifier_par;

                        db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
                        result =await db.SaveChangesAsync().ConfigureAwait(false);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }
}
