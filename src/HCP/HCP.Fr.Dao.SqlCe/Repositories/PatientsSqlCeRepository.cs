// Ignore Spelling: Sql

using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using HCP.Fr.DS.SqlCe.ABIBOUPC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCP.Fr.Dao.SqlCe.Helpers;

namespace HCP.Fr.Dao.SqlCe.Repositories
{
    public class PatientsSqlCeRepository
    {
        public PatientsSqlCeRepository()
        {
            SetDataLayer();
        }
        void Delete(Patients entity)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                // Get an object
                var patient = uow.GetObjectByKey<Patients>(entity.Id);
                uow.Delete(patient);
                uow.CommitChanges();
            }
        }

        async void DeleteAsync(Patients entity)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                // Get an object
                var patient = uow.GetObjectByKey<Patients>(entity.Id);
                await uow.DeleteAsync(patient).ConfigureAwait(false);
                await uow.CommitChangesAsync().ConfigureAwait(false);
            }
        }

        int Disable(Patients entity)
        {
            throw new NotImplementedException();
        }

        Task<int> DisableAsync(Patients entity)
        {
            throw new NotImplementedException();
        }

        int Enable(Patients entity)
        {
            throw new NotImplementedException();
        }

        Task<int> EnableAsync(Patients entity)
        {
            throw new NotImplementedException();
        }

        bool EnsureModelIsValidForInsert(Patients entity)
        {
            throw new NotImplementedException();
        }

        bool EnsureModelIsValidForUpdate(Patients entity)
        {
            throw new NotImplementedException();
        }

        List<Patients> GetAll()
        {
            var result = new List<Patients>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                result = uow.Query<Patients>().ToList();
            }
            return result;
        }

        async Task<List<Patients>> GetAllAsync()
        {
            var result = new List<Patients>();
            var sql = "SELECT * FROM Patients";
            using (UnitOfWork uow = new UnitOfWork())
            {
                var result2 = await uow.GetObjectsFromQueryAsync<Patients>(sql).ConfigureAwait(false);
                result = result2.ToList();
            }
            return result;
        }

        Patients GetById(Patients entity)
        {
            return GetAll().SingleOrDefault(x => x.Id == entity.Id);
        }

        async Task<Patients> GetByIdAsync(Patients entity)
        {
            var patients = await GetAllAsync();//.SingleOrDefault(x => x.Id == entity.Id);
            return patients.SingleOrDefault(x => x.Id == entity.Id);
        }

        int Save()
        {
            throw new NotImplementedException();
        }

        Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        void SaveOrUpdate(Patients entity)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var pa = new Patients(uow) { Id = entity.Id, ssn_ou_identité = entity.ssn_ou_identité, numero_carte_identité = entity.numero_carte_identité, Identité_expiration = entity.Identité_expiration, Identité_date_de_publication = entity.Identité_date_de_publication, adresse_carte_identité = entity.adresse_carte_identité, nom = entity.nom, prénom = entity.prénom, deuxième_nom = entity.deuxième_nom, date_naissance = entity.date_naissance, raison_de_la_visite = entity.raison_de_la_visite, taille = entity.taille, yeux = entity.yeux, cheveux = entity.cheveux, adresse = entity.adresse, appartement = entity.appartement, ville = entity.ville, état_ou_région = entity.état_ou_région, Pays = entity.Pays, boite_postale = entity.boite_postale, genre = entity.genre, naissance = entity.naissance, lieux_naissance = entity.lieux_naissance, téléphone = entity.téléphone, fax = entity.fax, email = entity.email, twitter = entity.twitter, whatsapp = entity.whatsapp, linkedin = entity.linkedin, employeur = entity.employeur, notes = entity.notes, statut = entity.statut, ajouter_au = entity.ajouter_au, ajouter_par = entity.ajouter_par, modifier_au = entity.modifier_au, modifier_par = entity.modifier_par };
                uow.CommitChanges();
            }

        }

        async void SaveOrUpdateAsync(Patients entity)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var pa = new Patients(uow)
                {
                    Id = entity.Id,
                    ssn_ou_identité = entity.ssn_ou_identité,
                    numero_carte_identité = entity.numero_carte_identité,
                    Identité_expiration = entity.Identité_expiration,
                    Identité_date_de_publication = entity.Identité_date_de_publication,
                    adresse_carte_identité = entity.adresse_carte_identité,
                    nom = entity.nom,
                    prénom = entity.prénom,
                    deuxième_nom = entity.deuxième_nom,
                    date_naissance = entity.date_naissance,
                    raison_de_la_visite = entity.raison_de_la_visite,
                    taille = entity.taille,
                    yeux = entity.yeux,
                    cheveux = entity.cheveux,
                    adresse = entity.adresse,
                    appartement = entity.appartement,
                    ville = entity.ville,
                    état_ou_région = entity.état_ou_région,
                    Pays = entity.Pays,
                    boite_postale = entity.boite_postale,
                    genre = entity.genre,
                    naissance = entity.naissance,
                    lieux_naissance = entity.lieux_naissance,
                    téléphone = entity.téléphone,
                    fax = entity.fax,
                    email = entity.email,
                    twitter = entity.twitter,
                    whatsapp = entity.whatsapp,
                    linkedin = entity.linkedin,
                    employeur = entity.employeur,
                    notes = entity.notes,
                    statut = entity.statut,
                    ajouter_au = entity.ajouter_au,
                    ajouter_par = entity.ajouter_par,
                    modifier_au = entity.modifier_au,
                    modifier_par = entity.modifier_par
                };
                await uow.CommitChangesAsync().ConfigureAwait(false);
            }
        }

        #region Functions

        public static void SetDataLayer()
        {
            //string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string connectionString = DevExpress.Xpo.DB.MSSqlCEConnectionProvider.GetConnectionString(DbHelper.DbSource());
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.None);

        }
        #endregion
    }
}
