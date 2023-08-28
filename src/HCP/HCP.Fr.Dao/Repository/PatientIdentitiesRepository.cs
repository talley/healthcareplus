using Dapper;
using HCP.Fr.Db;
using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class PatientIdentitiesRepository : IRepository<PatientIdentities>
    {
        private HcpFrEntities db=new HcpFrEntities();
        public int Delete(PatientIdentities entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(PatientIdentities entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(PatientIdentities entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(PatientIdentities entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(PatientIdentities entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(PatientIdentities entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(PatientIdentities entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(PatientIdentities entity)
        {
            throw new NotImplementedException();
        }

        public List<PatientIdentities> GetAll()
        {
            return db.PatientIdentities.AsList();
        }

        public async Task<List<PatientIdentities>> GetAllAsync()
        {
            return await db.PatientIdentities.ToListAsync().ConfigureAwait(false);
        }

        public PatientIdentities GetById(PatientIdentities entity)
        {
            return db.PatientIdentities.SingleOrDefault(x => x.Id == entity.Id);
        }

        public async Task<PatientIdentities> GetByIdAsync(PatientIdentities entity)
        {
            return await db.PatientIdentities.SingleOrDefaultAsync(x=>x.Id==entity.Id).ConfigureAwait(false);
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
           return await db.SaveChangesAsync().ConfigureAwait(false);
        }

        public int SaveOrUpdate(PatientIdentities entity)
        {
            var test = db.Database.Connection.ConnectionString;
            var result = 0;
           // var cs = db.Database.Connection.ConnectionString;

            try
            {
                if (entity.PatId == Guid.Empty)
                {
                    var fileTemp = Path.GetTempFileName();
                    var filePath = entity.Chemin_Du_Fichier;
                    using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            var fbytes = br.ReadBytes((int)fs.Length);
                            entity.Fichier = fbytes;
                            db.Entry(entity).State = EntityState.Added;
                            db.PatientIdentities.Add(entity);
                            result = Save();
                        }
                    }
                }
                else
                {
                    var fileTemp = Path.GetTempFileName();
                    var filePath = entity.Chemin_Du_Fichier;
                    using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            var fbytes = br.ReadBytes((int)fs.Length);
                            entity.Fichier = fbytes;

                            var edit = GetById(entity);
                            if(edit != null)
                            {
                                edit.ajouter_par = entity.ajouter_par;
                                edit.ajouter_au=entity.ajouter_au;
                                edit.modifier_par = entity.modifier_par;
                                edit.modifier_au = entity.modifier_au;
                                edit.Chemin_Du_Fichier = entity.Chemin_Du_Fichier;
                                edit.Fichier = fbytes;
                                edit.Id = entity.Id;
                                edit.Type = entity.Type;

                                db.Entry(edit).State = EntityState.Modified;
                                result = Save();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public async Task<int> SaveOrUpdateAsync(PatientIdentities entity)
        {
            var result = 0;
            // var cs = db.Database.Connection.ConnectionString;

            try
            {
                if (entity.PatId ==Guid.Empty)
                {
                    var fileTemp = Path.GetTempFileName();
                    var filePath = entity.Chemin_Du_Fichier;
                    using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            var fbytes = br.ReadBytes((int)fs.Length);
                            entity.Fichier = fbytes;
                            db.Entry(entity).State = EntityState.Added;
                            db.PatientIdentities.Add(entity);
                            result =await SaveAsync();
                        }
                    }
                }
                else
                {
                    var fileTemp = Path.GetTempFileName();
                    var filePath = entity.Chemin_Du_Fichier;
                    using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            var fbytes = br.ReadBytes((int)fs.Length);
                            entity.Fichier = fbytes;

                            var edit =await GetByIdAsync(entity);
                            if (edit != null)
                            {
                                edit.ajouter_par = entity.ajouter_par;
                                edit.ajouter_au = entity.ajouter_au;
                                edit.modifier_par = entity.modifier_par;
                                edit.modifier_au = entity.modifier_au;
                                edit.Chemin_Du_Fichier = entity.Chemin_Du_Fichier;
                                edit.Fichier = fbytes;
                                edit.Id = entity.Id;
                                edit.Type = entity.Type;

                                db.Entry(edit).State = EntityState.Modified;
                                result = await SaveAsync();
                            }
                        }
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
