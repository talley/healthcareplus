CREATE DATABASE HCPFR;
GO
USE HCPFR
GO
ALTER DATABASE HCPFR
SET COMPATIBILITY_LEVEL = 120--{ 160 sql 2022| 150 sql 2019 | sql 2017 140 | sql 2016 130 | 120 | 110 | 100 | 90 }
GO
--SELECT CONVERT(nvarchar(100),GETDATE(),103) AS FrenchDate
--SELECT CURRENT_USER,CURRENT_TIMESTAMP,SYSTEM_USER

CREATE TABLE Roles
(
 Id int identity(1,1) not null,
 nom_role nvarchar(40) not null,
 actif bit not null default 1,
 description nvarchar(200) not null,
 ajouter_au nvarchar(100) not null default CONVERT(nvarchar(100),GETDATE(),103),
 ajouter_par nvarchar(200) not null default system_user,
 modifier_au nvarchar(100) not null,
 modifier_par nvarchar(200) not null,
 primary key(nom_role)
)

CREATE TABLE UserStatuses
(
 Id uniqueidentifier not null default newid(),
 description nvarchar(200) not null,
 Statut nvarchar(100) not null,
 ajouter_au nvarchar(100) not null default CONVERT(nvarchar(100),GETDATE(),103),
 ajouter_par nvarchar(200) not null default system_user,
 modifier_au nvarchar(100) not null,
 modifier_par nvarchar(200) not null,
 primary key(Statut)
)

CREATE Table Users
(
 Id uniqueidentifier not null default newid(),
 email nvarchar(200) not null ,
 password varbinary(max) null,
 password_text varchar(200) not null,
 nom_role nvarchar(40) not null references Roles(nom_role),
 Statut nvarchar(100) not null  references UserStatuses(Statut),
 notes nvarchar(max) null,
 ajouter_au nvarchar(100) not null default CONVERT(nvarchar(100),GETDATE(),103),
 ajouter_par nvarchar(200) not null default system_user,
 modifier_au nvarchar(100) not null,
 modifier_par nvarchar(200) not null,
 date_de_la_dernière_connexion nvarchar(200) not null ,
 primary key(email)
)

CREATE VIEW view_gen_ssn
as
 SELECT  (CAST(CAST(100 + (898 * RAND()) AS INT) AS VARCHAR(3)) + '-' + CAST(CAST(10 + (88 * RAND()) AS INT) AS VARCHAR(2)) + '-' + CAST(CAST(1000 + (8998 * RAND()) AS INT) AS VARCHAR(4)))
 as SSN

CREATE FUNCTION func_gen_ssn()
returns char(11)
as
begin
 DECLARE @ssn char(11)
 SET @ssn=(SELECT TOP (1) [SSN] FROM dbo.view_gen_ssn)
 return @ssn
end 

CREATE TABLE sécurité_ssn
(
 Id uniqueidentifier not null default newid(),
 ssn_ou_identité nvarchar(100) not null,
 utilisateur_id uniqueidentifier not null,
 ajouter_au nvarchar(100) not null default CONVERT(nvarchar(100),GETDATE(),103),
 ajouter_par nvarchar(200) not null default system_user,
 modifier_au nvarchar(100) not null,
 modifier_par nvarchar(200) not null,
 date_de_la_dernière_connexion nvarchar(200) not null ,
 primary key(Id)
)

CREATE TABLE Patients
(
 Id uniqueidentifier not null default newid(),
 ssn_ou_identité nvarchar(100) not null default dbo.func_gen_ssn(),
 nom nvarchar(100) not null,
 prénom nvarchar(100) not null,
 deuxième_nom nvarchar(100)  null,
 date_naissance nvarchar(100) not null,
 raison_de_la_visite  nvarchar(max) not null,
 adresse nvarchar(300) not null,
 appartement nvarchar(20) null,
 ville nvarchar(300) not null,
 état_ou_région nvarchar(300)  null,
 Pays nvarchar(300) not null,
 boite_postale nvarchar(50)  not null,
 téléphone nvarchar(20) not null,
 fax nvarchar(20) null,
 email nvarchar(200) not null default 'na@na.com',
 twitter nvarchar(200)  null,
 whatsapp nvarchar(200)  null,
 linkedin nvarchar(200)  null,
 employeur nvarchar(200)  null,
 notes nvarchar(max) null,
 ajouter_au nvarchar(100) not null default CONVERT(nvarchar(100),GETDATE(),103),
 ajouter_par nvarchar(200) not null default system_user,
 modifier_au nvarchar(100) not null,
 modifier_par nvarchar(200) not null,
 date_de_la_dernière_connexion nvarchar(200) not null ,
 primary key(ssn_ou_identité)
)

CREATE TABLE PatientEmployers
(
 id int identity(1,1) not null,
 nom nvarchar(100) not null,
 domaine nvarchar(300) not null,
 adresse nvarchar(300) not null,
 appartement nvarchar(20) null,
 ville nvarchar(300) not null,
 état_ou_région nvarchar(300)  null,
 Pays nvarchar(300) not null,
 boite_postale nvarchar(50)  not null,
 téléphone nvarchar(20) not null,
 fax nvarchar(20) null,
 email nvarchar(200) not null default 'na@na.com',
 siteweb nvarchar(max) null,
 ajouter_au nvarchar(100) not null default CONVERT(nvarchar(100),GETDATE(),103),
 ajouter_par nvarchar(200) not null default system_user,
 modifier_au nvarchar(100) not null,
 modifier_par nvarchar(200) not null,
 date_de_la_dernière_connexion nvarchar(200) not null ,
 primary key(id)
)