// Ignore Spelling: sqlcon sql valeur

using Dapper;
using DatabaseSwitcher;
using HCP.Fr.DS;
using HCP.Fr.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Helpers
{
    public static class PatientHelpers
    {
        public static int AddPatientIdentity(Guid PatId,string Type,string FileName,
            string FilePath,string Size,string Height,string Width,string addedOn,string addedBy)
        {
            int result = 0;
            var cs = ConnectionFrHelper.CS;
            var sql = new StringBuilder();
            sql.Append("INSERT INTO dbo.PatientIdentities(Type,Fichier,PatId,Taille,longueur,largeur,Chemin_Du_Fichier,ajouter_au,ajouter_par)");
            sql.Append(" VALUES(@Type,@Fichier,@PatId,@Taille,@longueur,@largeur,@Chemin_Du_Fichier,@ajouter_au,@ajouter_par)");
            using (var sqlcon = new SqlConnection(cs))
            {
                sqlcon.Open();
                using (var fs = File.Open(FilePath, FileMode.Create))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        byte[] bytes = br.ReadBytes((int)fs.Length);
                        using (var cmd = new SqlCommand(sql.ToString(), sqlcon))
                        {

                            cmd.Parameters.AddWithValue("@Type", Type);
                            cmd.Parameters.AddWithValue("@Fichier", bytes);
                            cmd.Parameters.AddWithValue("@PatId", PatId);
                            cmd.Parameters.AddWithValue("@Taille", Size);
                            cmd.Parameters.AddWithValue("@longueur", Height);
                            cmd.Parameters.AddWithValue("@largeur", Width);
                            cmd.Parameters.AddWithValue("@Chemin_Du_Fichier", FilePath);
                            cmd.Parameters.AddWithValue("@ajouter_au", addedOn);
                            cmd.Parameters.AddWithValue("@ajouter_par", addedBy);

                           result= cmd.ExecuteNonQuery();
                        }
                    }
                }

                if (sqlcon.State == System.Data.ConnectionState.Open) {

                    sqlcon.Close();
                }
            }
            return result;
           }

        //Byte array to photo
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        // convert image to byte array
        public static byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static async Task<int> AddPatientIdentityAsync(Guid PatId, string Type,
           string FilePath, string Size, string Height, string Width, string addedOn, string addedBy)
        {
            var copyFilePath = Path.Combine(Path.GetTempPath(), new FileInfo(FilePath).Name);
            if (File.Exists(copyFilePath))
            {
                File.Delete(copyFilePath);
            }
            File.Copy(FilePath,copyFilePath);

            int result = 0;
            var cs = ConnectionFrHelper.CS;
            var sql = new StringBuilder();
            sql.Append("INSERT INTO dbo.PatientIdentities(Type,Fichier,PatId,Taille,longueur,largeur,Chemin_Du_Fichier,ajouter_au,ajouter_par)");
            sql.Append(" VALUES(@Type,@Fichier,@PatId,@Taille,@longueur,@largeur,@Chemin_Du_Fichier,@ajouter_au,@ajouter_par)");
            using (var sqlcon = new SqlConnection(cs))
            {
               await sqlcon.OpenAsync().ConfigureAwait(false);
                using (var fs = File.Open(copyFilePath, FileMode.OpenOrCreate))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        byte[] bytes = br.ReadBytes((int)fs.Length);
                      // myStudent.photo = imageToByteArray(Image.FromFile(openFileDialog1.FileName));
                        using (var cmd = new SqlCommand(sql.ToString(), sqlcon))
                        {

                            cmd.Parameters.AddWithValue("@Type", Type);
                            cmd.Parameters.AddWithValue("@Fichier", bytes);
                            cmd.Parameters.AddWithValue("@PatId", PatId);
                            cmd.Parameters.AddWithValue("@Taille", Size);
                            cmd.Parameters.AddWithValue("@longueur", Height);
                            cmd.Parameters.AddWithValue("@largeur", Width);
                            cmd.Parameters.AddWithValue("@Chemin_Du_Fichier", FilePath);
                            cmd.Parameters.AddWithValue("@ajouter_au", addedOn);
                            cmd.Parameters.AddWithValue("@ajouter_par", addedBy);

                            result =await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                        }
                        br.Dispose();
                    }
                    fs.Close();

                }

                if (sqlcon.State == System.Data.ConnectionState.Open)
                {

                    sqlcon.Close();
                }
            }
            return result;
        }


        public static int UpdatePatientIdentity(int Id,Guid PatId, string Type,
           string FilePath, string Size, string Height, string Width, string updatedOn, string updatedBy)
        {
            int result = 0;
            var cs = ConnectionFrHelper.CS;
            var sql = new StringBuilder();
            sql.Append("UPDATE dbo.PatientIdentities SET Type=@Type,Fichier=@Fichier,PatId=@PatId,Taille=@Taille,");
            sql.Append("longueur=@longueur,largeur=@largeur,Chemin_Du_Fichier=@Chemin_Du_Fichier,modifier_au=@modifier_au,modifier_par=@modifier_par ");
            sql.Append(" WHERE Id=@Id");
            using (var sqlcon = new SqlConnection(cs))
            {
                sqlcon.Open();
                using (var fs = File.Open(FilePath, FileMode.Create))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        byte[] bytes = br.ReadBytes((int)fs.Length);
                        using (var cmd = new SqlCommand(sql.ToString(), sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@Id", Id);
                            cmd.Parameters.AddWithValue("@Type", Type);
                            cmd.Parameters.AddWithValue("@Fichier", bytes);
                            cmd.Parameters.AddWithValue("@PatId", PatId);
                            cmd.Parameters.AddWithValue("@Taille", Size);
                            cmd.Parameters.AddWithValue("@longueur", Height);
                            cmd.Parameters.AddWithValue("@largeur", Width);
                            cmd.Parameters.AddWithValue("@Chemin_Du_Fichier", FilePath);
                            cmd.Parameters.AddWithValue("@modifier_au", updatedOn);
                            cmd.Parameters.AddWithValue("@modifier_par", updatedBy);//

                            result = cmd.ExecuteNonQuery();
                        }
                    }
                }

                if (sqlcon.State == System.Data.ConnectionState.Open)
                {

                    sqlcon.Close();
                }
            }
            return result;
        }


        public static async Task<int> UpdatePatientIdentityAsync(int Id, Guid PatId, string Type,
          string FilePath, string Size, string Height, string Width, string updatedOn, string updatedBy)
        {
            int result = 0;
            var cs = ConnectionFrHelper.CS;
            var sql = new StringBuilder();
            sql.Append("UPDATE dbo.PatientIdentities SET Type=@Type,Fichier=@Fichier,PatId=@PatId,Taille=@Taille,");
            sql.Append("longueur=@longueur,largeur=@largeur,Chemin_Du_Fichier=@Chemin_Du_Fichier,modifier_au=@modifier_au,modifier_par=@modifier_par ");
            sql.Append(" WHERE Id=@Id");
            using (var sqlcon = new SqlConnection(cs))
            {
               await sqlcon.OpenAsync().ConfigureAwait(false);
                using (var fs = File.Open(FilePath, FileMode.Create))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        byte[] bytes = br.ReadBytes((int)fs.Length);
                        using (var cmd = new SqlCommand(sql.ToString(), sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@Id", Id);
                            cmd.Parameters.AddWithValue("@Type", Type);
                            cmd.Parameters.AddWithValue("@Fichier", bytes);
                            cmd.Parameters.AddWithValue("@PatId", PatId);
                            cmd.Parameters.AddWithValue("@Taille", Size);
                            cmd.Parameters.AddWithValue("@longueur", Height);
                            cmd.Parameters.AddWithValue("@largeur", Width);
                            cmd.Parameters.AddWithValue("@Chemin_Du_Fichier", FilePath);
                            cmd.Parameters.AddWithValue("@modifier_au", updatedOn);
                            cmd.Parameters.AddWithValue("@modifier_par", updatedBy);//

                            result = await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                        }
                    }
                }

                if (sqlcon.State == System.Data.ConnectionState.Open)
                {

                    sqlcon.Close();
                }
            }
            return result;
        }
        public static string GetExtension(this string file)
        {
            return Path.GetExtension(file);
        }

        public static List<PatientSearchColumns> GetPatientSearchColumns()
        {
            //procPatientSeach2
            IEnumerable<PatientSearchColumns> result=new List<PatientSearchColumns>();
            var query = "SELECT * FROM PatientSearchColumns as p ORDER BY p.colonne ASC";
            try
            {
                using(IDbConnection sqlcon=new SqlConnection(ConnectionFrHelper.CS))
                {
                    result = sqlcon.Query<PatientSearchColumns>(query);
                }
            }
            catch (Exception ex)
            {

                ex.LogToDb("public static List<PatientSearchColumns>", "PatientHelpers.cs","sys@sys.com");
                throw ex;
            }
            return result.ToList();
        }

        public static List<Patients> PatientSearch(string term,string valeur)
        {
            IEnumerable<Patients> result = new List<Patients>();
            var parameters = new { term = term,valeur=valeur };
            try
            {
                using (IDbConnection sqlcon = new SqlConnection(ConnectionFrHelper.CS))
                {
                    result = sqlcon.Query<Patients>("procPatientSeach2",parameters,
                        commandType:CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result.ToList();
        }

        public static async Task<int> UpdateGeneralInformationAsync(Patients entity)
        {
            var result = 0;
            try
            {
                var query = new StringBuilder();
                query.Append($"UPDATE Patients SET Nom='{entity.nom}',prénom='{entity.prénom}',deuxième_nom='{entity.deuxième_nom}',");
                query.Append($"date_naissance='{entity.date_naissance}',lieux_naissance='{entity.lieux_naissance}',");
                query.Append($"téléphone='{entity.téléphone}',Fax='{entity.fax}',Email='{entity.email}',genre='{entity.genre}',");
                query.Append($"employeur='{entity.employeur}',linkedin='{entity.linkedin}',whatsapp='{entity.whatsapp}',");
                query.Append($"twitter='{entity.twitter}' WHERE Id='{entity.Id}'");

                var sql = query.ToString();

                using (IDbConnection sqlcon = new SqlConnection(ConnectionFrHelper.CS))
                {
                    result =await sqlcon.ExecuteAsync(sql: sql, commandType: CommandType.Text).ConfigureAwait(false);
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
