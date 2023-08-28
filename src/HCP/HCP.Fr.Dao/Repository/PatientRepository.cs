using Dapper;
using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class PatientRepository : IRepository<Patients>
    {
        internal HcpFrEntities db = new HcpFrEntities();

        public int Delete(Patients entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Patients entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(Patients entity)
        {
            int result = 0;
            var query = $"UPDATE Patients SET Statut='InActif' WHERE Id='{entity.Id}'";
            using (IDbConnection sqlcon=new SqlConnection(db.Database.Connection.ConnectionString))
            {
                result = sqlcon.Execute(query);
            }
            return result;
        }

        public async Task<int> DisableAsync(Patients entity)
        {
            int result = 0;
            var query = $"UPDATE Patients SET Statut='InActif' WHERE Id='{entity.Id}'";
            using (IDbConnection sqlcon = new SqlConnection(db.Database.Connection.ConnectionString))
            {
                result =await sqlcon.ExecuteAsync(query).ConfigureAwait(false);
            }
            return result;
        }

        public int Enable(Patients entity)
        {
            int result = 0;
            var query = $"UPDATE Patients SET Statut='Actif' WHERE Id='{entity.Id}'";
            using (IDbConnection sqlcon = new SqlConnection(db.Database.Connection.ConnectionString))
            {
                result = sqlcon.Execute(query);
            }
            return result;
        }

        public async Task<int> EnableAsync(Patients entity)
        {
            int result = 0;
            var query = $"UPDATE Patients SET Statut='Actif' WHERE Id='{entity.Id}'";
            using (IDbConnection sqlcon = new SqlConnection(db.Database.Connection.ConnectionString))
            {
                result = await sqlcon.ExecuteAsync(query).ConfigureAwait(false);
            }
            return result;
        }

        public bool EnsureModelIsValidForInsert(Patients entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(Patients entity)
        {
            throw new NotImplementedException();
        }

        public List<Patients> GetAll()=>db.Patients.AsList();


        public async Task<List<Patients>> GetAllAsync()=>await db.Patients.ToListAsync().ConfigureAwait(false);


        public Patients GetById(Patients entity)=>db.Patients.SingleOrDefault(x=>x.Id == entity.Id);


        public async Task<Patients> GetByIdAsync(Patients entity)=>await db.Patients.SingleOrDefaultAsync(x=>x.Id == entity.Id);


        public int Save()=>db.SaveChanges();


        public async Task<int> SaveAsync()=>await db.SaveChangesAsync().ConfigureAwait(false);


        public int SaveOrUpdate(Patients entity)
        {
            int result = 0;
            try
            {
                if(entity.Id==Guid.Empty)
                {
                    entity.Id = Guid.NewGuid();
                    db.Entry(entity).State = EntityState.Added;
                    result = Save();
                }
                else
                {
                    var edit = GetById(entity);
                    if(edit != null)
                    {
                        edit.ssn_ou_identité = entity.ssn_ou_identité;
                        edit.numero_carte_identité = entity.numero_carte_identité;
                        edit.Identité_expiration = entity.Identité_expiration;
                        edit.Identité_expiration = entity.Identité_expiration;
                        edit.nom=entity.nom;
                        edit.prénom = entity.prénom;
                        edit.deuxième_nom = entity.deuxième_nom;
                        edit.date_naissance= entity.date_naissance;
                        edit.raison_de_la_visite = entity.raison_de_la_visite;
                        edit.taille=entity.taille;
                        edit.yeux=entity.yeux;
                        edit.cheveux=entity.cheveux;
                        edit.adresse=entity.adresse;
                        edit.appartement=entity.appartement;
                        edit.ville=entity.ville;
                        edit.état_ou_région = entity.état_ou_région;
                        edit.Pays=entity.Pays;
                        edit.boite_postale=entity.boite_postale;
                        edit.genre=entity.genre;
                        edit.naissance=entity.naissance;
                        edit.lieux_naissance = entity.lieux_naissance;
                        edit.téléphone = entity.téléphone;
                        edit.fax=entity.fax;
                        edit.email=entity.email;
                        edit.twitter=entity.twitter;
                        edit.whatsapp=entity.whatsapp;
                        edit.linkedin=entity.linkedin;
                        edit.employeur=entity.employeur;
                        edit.notes=entity.notes;
                        edit.statut = entity.statut;
                        edit.ajouter_au=entity.ajouter_au;
                        edit.ajouter_par=entity.ajouter_par;
                        edit.modifier_au=entity.modifier_au;
                        edit.modifier_par=entity.modifier_par;
                        edit.date_de_la_dernière_connexion = entity.date_de_la_dernière_connexion;
                        edit.adresse_carte_identité = entity.adresse_carte_identité;

                        db.Entry(edit).State = EntityState.Modified;
                        result =Save();
                    }
                }

            }
            catch (Exception ex)when(ex!=null)
            {

                throw ex;
            }
            return result;
        }

        public async Task<int> SaveOrUpdateAsync(Patients entity)
        {
            int result = 0;
            try
            {
                if (entity.Id == Guid.Empty)
                {
                    entity.Id = Guid.NewGuid();
                    db.Entry(entity).State = EntityState.Added;
                    result = Save();
                }
                else
                {
                    var edit = GetById(entity);
                    if (edit != null)
                    {
                        edit.ssn_ou_identité = entity.ssn_ou_identité;
                        edit.numero_carte_identité = entity.numero_carte_identité;
                        edit.Identité_expiration = entity.Identité_expiration;
                        edit.Identité_expiration = entity.Identité_expiration;
                        edit.nom = entity.nom;
                        edit.prénom = entity.prénom;
                        edit.deuxième_nom = entity.deuxième_nom;
                        edit.date_naissance = entity.date_naissance;
                        edit.raison_de_la_visite = entity.raison_de_la_visite;
                        edit.taille = entity.taille;
                        edit.yeux = entity.yeux;
                        edit.cheveux = entity.cheveux;
                        edit.adresse = entity.adresse;
                        edit.appartement = entity.appartement;
                        edit.ville = entity.ville;
                        edit.état_ou_région = entity.état_ou_région;
                        edit.Pays = entity.Pays;
                        edit.boite_postale = entity.boite_postale;
                        edit.genre = entity.genre;
                        edit.naissance = entity.naissance;
                        edit.lieux_naissance = entity.lieux_naissance;
                        edit.téléphone = entity.téléphone;
                        edit.fax = entity.fax;
                        edit.email = entity.email;
                        edit.twitter = entity.twitter;
                        edit.whatsapp = entity.whatsapp;
                        edit.linkedin = entity.linkedin;
                        edit.employeur = entity.employeur;
                        edit.notes = entity.notes;
                        edit.statut = entity.statut;
                        edit.ajouter_au = entity.ajouter_au;
                        edit.ajouter_par = entity.ajouter_par;
                        edit.modifier_au = entity.modifier_au;
                        edit.modifier_par = entity.modifier_par;
                        edit.date_de_la_dernière_connexion = entity.date_de_la_dernière_connexion;
                        edit.adresse_carte_identité = entity.adresse_carte_identité;

                        db.Entry(edit).State = EntityState.Modified;
                        result =await SaveAsync().ConfigureAwait(false);
                    }
                }

            }
            catch (Exception ex) when (ex != null)
            {

                throw ex;
            }
            return result;
        }
    }
}
