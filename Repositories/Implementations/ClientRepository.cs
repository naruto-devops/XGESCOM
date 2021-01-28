using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
    public class ClientRepository : IClientRepository
    {

        IConfiguration Configuration { get; }
        public ClientRepository(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(Configuration.GetConnectionString("DefaultConnection"));
            }

        }

        public List<Client> GetAll()
        {
            var res = new List<Client>();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    string sQuery = @"select CT_Num as Numero,
                                   CT_Intitule as Intitule,CT_Type as Type,CG_NumPrinc as NumeroPrincipale,
                                   CT_Contact as ContactPrincipale,CT_Complement as Complement,
                                   CT_CodePostal as CodePostal,CT_Ville as Ville,CT_CodeRegion as CodeRegion,
                                   CT_Pays as Pays,CT_Raccourci as Raccourcis,BT_Num as NumeroBanqueTier,
                                   CT_Ape as Ape,CT_Identifiant as MatriculeFiscale,CT_Siret as Siret,
                                    CT_Encours as Encours,CT_NumPayeur as NumeroPayeur,
                                    N_CatTarif as CategorieTarif,N_CatCompta as CategorieComptabilite,
                                    CT_DateCreate as DateCreation,CT_Sommeil as Sommeil,
                                    DE_No as Depot,CT_Telephone as Telephone,CT_Telecopie as Telecopie,
                                    CT_EMail as EMail,CT_Site as SiteWeb,cbMarq as CBMarque,
                                    Timbre as Timbre,CT_Remise as TauxRemise,CT_CTVA as CategorieTVA,
                                    CT_Categorie as Categorie,CT_Etranger as Etranger,
                                    CT_Devise as Devise,CT_CoursDevise as CoursDevise,
                                    CT_LIVADRESSE as AdresseLivraison,CT_LIVCP as CodePostalLivraison,
                                    CT_LIVVILLE as VilleLivraison,CT_LIVPAYS as PaysLivraison,
                                    CT_Qualite as Qualite,CT_Adresse as Adresse,
                                    CT_Commentaire as Commentaire,CT_Classement as Classement,
                                    CT_Jointe1 as Jointe1,CT_Jointe2 as Jointe2,CO_No as Collaborateur,
                                    EMR_Code as ModalitePaiement,IT_CODE as Incoterm,
                                    CT_AUXI as CompteAuxiliaire,CT_ICE as ICE,
                                    FC_NO as Familletier,CT_CREATEUR as CREATEUR,CT_MODIFICATEUR as MODIFICATEUR
                                    from F_COMPTET where CT_Type = '0' ";
                    dbConnection.Open();
                    res = dbConnection.Query<Client>(sQuery).ToList();

                }

            }
            catch (Exception)
            {
                return null;

            }

            return res;
        }

        public Client GetById(int id)
        {
            var res = new Client();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    string sQuery = @"select CT_Num as Numero,CT_Intitule as Intitule,CT_Type as Type,CG_NumPrinc as NumeroPrincipale,
                                   CT_Contact as ContactPrincipale,CT_Complement as Complement,
                                   CT_CodePostal as CodePostal,CT_Ville as Ville,CT_CodeRegion as CodeRegion,
                                   CT_Pays as Pays,CT_Raccourci as Raccourcis,BT_Num as NumeroBanqueTier ,
                                   CT_Ape as Ape,CT_Identifiant as MatriculeFiscale,CT_Siret as Siret,
                                    CT_Encours as Encours,CT_NumPayeur as NumeroPayeur,
                                    N_CatTarif as CategorieTarif,N_CatCompta as CategorieComptabilite,
                                    CT_DateCreate as DateCreation,CT_Sommeil as Sommeil,
                                    DE_No as Depot,CT_Telephone as Telephone,CT_Telecopie as Telecopie,
                                    CT_EMail as EMail,CT_Site as SiteWeb,cbMarq as CBMarque,
                                    Timbre as Timbre,CT_Remise as TauxRemise,CT_CTVA as CategorieTVA,
                                    CT_Categorie as Categorie,CT_Etranger as Etranger,
                                    CT_Devise as Devise,CT_CoursDevise as CoursDevise,
                                    CT_LIVADRESSE as AdresseLivraison,CT_LIVCP as CodePostalLivraison,
                                    CT_LIVVILLE as VilleLivraison,CT_LIVPAYS as PaysLivraison,
                                    CT_Qualite as Qualite,CT_Adresse as Adresse,
                                    CT_Commentaire as Commentaire,CT_Classement as Classement,
                                    CT_Jointe1 as Jointe1,CT_Jointe2 as Jointe2,CO_No as Collaborateur,
                                    EMR_Code as ModalitePaiement,IT_CODE as Incoterm,
                                    CT_AUXI as CompteAuxiliaire,CT_ICE as ICE,
                                    FC_NO as Familletier,CT_CREATEUR as CREATEUR,CT_MODIFICATEUR as MODIFICATEUR 
                                    from F_COMPTET where CT_Type = '0' and cbMarq =@Id ";
                    dbConnection.Open();
                    res = dbConnection.Query<Client>(sQuery, new { Id = id }).FirstOrDefault();

                }

            }
            catch (Exception)
            {
                return null;

            }
            return res;
        }
        public Client Add(Client client)
        {

            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    string sQuery = @"INSERT INTO F_COMPTET
                                    (   CT_Num,CT_Intitule,CT_Type,CG_NumPrinc,
                                         CT_Contact,CT_Complement,CT_CodePostal,CT_Ville,
                                        CT_CodeRegion,CT_Pays,CT_Raccourci,BT_Num,
                                        CT_Ape,CT_Identifiant,CT_Siret,CT_Encours,
                                        CT_NumPayeur,N_CatTarif,N_CatCompta,CT_DateCreate,
                                        CT_Sommeil,DE_No,CT_Telephone,CT_Telecopie,
                                        CT_EMail,CT_Site,Timbre,CT_Remise,
                                        CT_CTVA,CT_Categorie,CT_Etranger,CT_Devise,
                                        CT_CoursDevise,CT_LIVADRESSE,CT_LIVCP,CT_LIVVILLE,
                                        CT_LIVPAYS,CT_Qualite,CT_Adresse,CT_Commentaire,
                                        CT_Classement,CT_Jointe1,CT_Jointe2,CO_No,
                                        EMR_Code,IT_CODE,CT_AUXI,CT_ICE,FC_NO,
                                        CT_CREATEUR,CT_MODIFICATEUR
                                       )
                                     VALUES  (@Numero,@Intitule,@Type,@NumeroPrincipale,@ContactPrincipale,
                                                 @Complement,@CodePostal,@Ville,@CodeRegion,@Pays,@Raccourcis,
                                                 @NumeroBanqueTier,@Ape,@MatriculeFiscale,@Siret,@Encours,@NumeroPayeur,
                                                 @CategorieTarif,@CategorieComptabilite,@DateCreation,@Sommeil,
                                                @Depot,@Telephone,@Telecopie,@EMail,
                                                @SiteWeb,@Timbre,@TauxRemise,
                                                @CategorieTVA,@Categorie,@Etranger,@Devise,
                                                @CoursDevise,@AdresseLivraison,@CodePostalLivraison,
                                                @VilleLivraison,@PaysLivraison,@Qualite,
                                                @Adresse,@Commentaire,@Classement,@Jointe1,@Jointe2,
                                                @Collaborateur,@ModalitePaiement,@Incoterm,@CompteAuxiliaire,
                                                @ICE,@Familletier,@CREATEUR,@MODIFICATEUR



                                                        
                                                )";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery, client);

                }

            }
            catch (Exception)
            {
                return null;

            }
            return client;
        }

        public Client Update( Client client)
        {

            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    string sQuery = @"update F_COMPTET set 
                           CT_Intitule=@Intitule,CT_Type=@Type,
                                   CT_Contact=@ContactPrincipale,CT_Complement=@Complement,
                                    CT_CodePostal=@CodePostal,CT_Ville=@Ville,CT_CodeRegion=@CodeRegion,
                                   CT_Pays=@Pays,CT_Raccourci=@Raccourcis,BT_Num=@NumeroBanqueTier,
                                   CT_Ape=@Ape,CT_Identifiant=@MatriculeFiscale,CT_Siret=@Siret,
                                    CT_Encours=@Encours,CT_NumPayeur=@NumeroPayeur,
                                    N_CatTarif=@CategorieTarif,N_CatCompta=@CategorieComptabilite,
                                    CT_DateCreate=@DateCreation,CT_Sommeil=@Sommeil,
                                    DE_No=@Depot,CT_Telephone=@Telephone,CT_Telecopie=@Telecopie,
                                    CT_EMail=@EMail,CT_Site=@SiteWeb,
                                    Timbre=@Timbre,CT_Remise=@TauxRemise,CT_CTVA=@CategorieTVA,
                                    CT_Categorie=@Categorie,CT_Etranger=@Etranger,
                                    CT_Devise=@Devise,CT_CoursDevise=@CoursDevise,
                                    CT_LIVADRESSE=@AdresseLivraison,CT_LIVCP=@CodePostalLivraison,
                                    CT_LIVVILLE=@VilleLivraison,CT_LIVPAYS=@PaysLivraison,
                                    CT_Qualite=@Qualite,CT_Adresse=@Adresse,
                                    CT_Commentaire=@Commentaire,CT_Classement=@Classement,
                                    CT_Jointe1=@Jointe1,CT_Jointe2=@Jointe2,CO_No=@Collaborateur,
                                    EMR_Code=@ModalitePaiement,IT_CODE=@Incoterm,
                                    CT_AUXI=@CompteAuxiliaire,CT_ICE=@ICE,
                                    FC_NO=@Familletier,CT_CREATEUR=@CREATEUR,CT_MODIFICATEUR=@MODIFICATEUR
                                    

                                where cbMarq=@CBMarque ";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery,  client );
                }

            }
            catch (Exception)
            {
                return null;

            }
            return client;
        }

        public bool Delete(int id)
        {

            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    string sQuery = @"Delete from F_COMPTET where CT_Type = '0' and cbMarq =@Id ";
                    dbConnection.Open();
                    dbConnection.Execute(sQuery, new { ID = id });
                }

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
         public Client GetByDocLig(int id)
        {
            Client res = new Client();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    string sQuery = @"select CT_Num as Numero,CT_Intitule as Intitule,CT_Type as Type,CG_NumPrinc as NumeroPrincipale,
                                   CT_Contact as ContactPrincipale,CT_Complement as Complement,
                                   CT_CodePostal as CodePostal,CT_Ville as Ville,CT_CodeRegion as CodeRegion,
                                   CT_Pays as Pays,CT_Raccourci as Raccourcis,BT_Num as NumeroBanqueTier ,
                                   CT_Ape as Ape,CT_Identifiant as MatriculeFiscale,CT_Siret as Siret,
                                    CT_Encours as Encours,CT_NumPayeur as NumeroPayeur,
                                    N_CatTarif as CategorieTarif,N_CatCompta as CategorieComptabilite,
                                    CT_DateCreate as DateCreation,CT_Sommeil as Sommeil,
                                    DE_No as Depot,CT_Telephone as Telephone,CT_Telecopie as Telecopie,
                                    CT_EMail as EMail,CT_Site as SiteWeb,cbMarq as CBMarque,
                                    Timbre as Timbre,CT_Remise as TauxRemise,CT_CTVA as CategorieTVA,
                                    CT_Categorie as Categorie,CT_Etranger as Etranger,
                                    CT_Devise as Devise,CT_CoursDevise as CoursDevise,
                                    CT_LIVADRESSE as AdresseLivraison,CT_LIVCP as CodePostalLivraison,
                                    CT_LIVVILLE as VilleLivraison,CT_LIVPAYS as PaysLivraison,
                                    CT_Qualite as Qualite,CT_Adresse as Adresse,
                                    CT_Commentaire as Commentaire,CT_Classement as Classement,
                                    CT_Jointe1 as Jointe1,CT_Jointe2 as Jointe2,CO_No as Collaborateur,
                                    EMR_Code as ModalitePaiement,IT_CODE as Incoterm,
                                    CT_AUXI as CompteAuxiliaire,CT_ICE as ICE,
                                    FC_NO as Familletier,CT_CREATEUR as CREATEUR,CT_MODIFICATEUR as MODIFICATEUR 
                                    from F_COMPTET where CT_Type = '0' and cbMarq =@Id  and CT_Num in (select distinct(Ct_Num) from F_DOCLIGNE)";
                    dbConnection.Open();
                res = dbConnection.Query<Client>(sQuery, new { Id = id }).FirstOrDefault();

                }

            }
            catch (Exception)
            {
                return null;

            }
            return res;

        }

        public FamilleTier GetFamilleTier(int id)
        {
            FamilleTier res = new FamilleTier();
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    string sQuery = @"select * from F_FamilleTier Where FC_NO =@Id";
                    dbConnection.Open();
                    res = dbConnection.Query<FamilleTier>(sQuery, new { Id = id }).FirstOrDefault();

                }
            }
            catch (Exception)
            {
                return null;

            }

            return res;
        }

    }
}
