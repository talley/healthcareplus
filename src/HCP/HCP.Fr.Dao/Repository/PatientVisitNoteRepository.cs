using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class PatientVisitNoteRepository : IRepository<PatientsVisitNotes>
    {
        private HcpFrEntities db = new HcpFrEntities();
        public int Delete(PatientsVisitNotes entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(PatientsVisitNotes entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(PatientsVisitNotes entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(PatientsVisitNotes entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(PatientsVisitNotes entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(PatientsVisitNotes entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(PatientsVisitNotes entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(PatientsVisitNotes entity)
        {
            throw new NotImplementedException();
        }

        public List<PatientsVisitNotes> GetAll()
        {
            return db.PatientsVisitNotes.ToList();
        }

        public async Task<List<PatientsVisitNotes>> GetAllAsync()
        {
            return await db.PatientsVisitNotes.ToListAsync().ConfigureAwait(false);
        }

        public PatientsVisitNotes GetById(PatientsVisitNotes entity)
        {
            return db.PatientsVisitNotes.SingleOrDefault(x => x.PvId == entity.PvId);
        }

        public async Task<PatientsVisitNotes> GetByIdAsync(PatientsVisitNotes entity)
        {
            return await db.PatientsVisitNotes.SingleOrDefaultAsync(x => x.PvId == entity.PvId).ConfigureAwait(false);
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public int SaveOrUpdate(PatientsVisitNotes entity)
        {
            var result = 0;
            try
            {
                if (entity.PvId == 0)
                {
                    db.Entry(entity).State = EntityState.Added;
                    result = db.SaveChanges();
                }
                else
                {
                    var edit = db.PatientsVisitNotes.SingleOrDefault(x => x.PvId == entity.PvId);
                    if (edit != null)
                    {
                        edit.Id = entity.Id;
                        edit.Notes = entity.Notes;
                        edit.ajouter_par = entity.ajouter_par;
                        edit.ajouter_au = entity.ajouter_au;
                        edit.modifier_au = entity.modifier_au;
                        edit.modifier_par = entity.modifier_par;

                        db.Entry(edit).State = EntityState.Modified;
                        result =  db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public async Task<int> SaveOrUpdateAsync(PatientsVisitNotes entity)
        {
            var result = 0;
            try
            {
                if (entity.PvId == 0)
                {
                    db.Entry(entity).State = EntityState.Added;
                    result = db.SaveChanges();
                }
                else
                {
                    var edit =await db.PatientsVisitNotes.SingleOrDefaultAsync(x => x.PvId == entity.PvId)
                        .ConfigureAwait(false);
                    if (edit != null)
                    {
                        edit.Id = entity.Id;
                        edit.Notes = entity.Notes;
                        edit.ajouter_par = entity.ajouter_par;
                        edit.ajouter_au = entity.ajouter_au;
                        edit.modifier_au = entity.modifier_au;
                        edit.modifier_par = entity.modifier_par;

                        db.Entry(edit).State = EntityState.Modified;
                        result = await db.SaveChangesAsync().ConfigureAwait(false);
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
