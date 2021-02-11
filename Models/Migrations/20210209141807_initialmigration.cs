using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategorieTarifs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categorie = table.Column<string>(maxLength: 12, nullable: true),
                    PrixTTC = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieTarifs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Devises",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DEVISE = table.Column<string>(maxLength: 12, nullable: true),
                    CODEISO = table.Column<string>(maxLength: 12, nullable: true),
                    CODEBANQUE = table.Column<string>(maxLength: 12, nullable: true),
                    LIBELLE = table.Column<string>(maxLength: 50, nullable: true),
                    SYMBOLE = table.Column<string>(maxLength: 12, nullable: true),
                    DECIMALE = table.Column<int>(maxLength: 1, nullable: false),
                    COURS = table.Column<double>(maxLength: 18, nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devises", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ModalitePaiements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Intitule = table.Column<string>(maxLength: 45, nullable: true),
                    Code = table.Column<string>(maxLength: 6, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalitePaiements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Parametres",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    INCFRS = table.Column<bool>(nullable: false, defaultValue: false),
                    INCCLI = table.Column<bool>(nullable: false, defaultValue: false),
                    NUMFRS = table.Column<string>(maxLength: 17, nullable: true),
                    NUMCLI = table.Column<string>(maxLength: 17, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(maxLength: 12, nullable: true),
                    ModePasse = table.Column<string>(maxLength: 12, nullable: true),
                    C_ModePasse = table.Column<string>(maxLength: 12, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    Droit = table.Column<int>(nullable: false),
                    Date_connexion = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FamilleTiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 19, nullable: true),
                    Libelle = table.Column<string>(maxLength: 19, nullable: true),
                    Exonere = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CategorieTarifId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilleTiers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FamilleTiers_CategorieTarifs_CategorieTarifId",
                        column: x => x.CategorieTarifId,
                        principalTable: "CategorieTarifs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Collaborateurs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(maxLength: 35, nullable: true),
                    Prenom = table.Column<string>(maxLength: 35, nullable: true),
                    Fonction = table.Column<string>(maxLength: 35, nullable: true),
                    Adresse = table.Column<string>(maxLength: 60, nullable: true),
                    CodePostal = table.Column<string>(maxLength: 9, nullable: true),
                    Ville = table.Column<string>(maxLength: 35, nullable: true),
                    Service = table.Column<string>(maxLength: 35, nullable: true),
                    Telephone = table.Column<string>(maxLength: 21, nullable: true),
                    EMail = table.Column<string>(maxLength: 69, nullable: true),
                    Matricule = table.Column<string>(maxLength: 11, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false),
                    UtilisateurId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborateurs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Collaborateurs_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(maxLength: 17, nullable: true),
                    Intitule = table.Column<string>(maxLength: 35, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    NumeroPrincipale = table.Column<string>(maxLength: 13, nullable: true),
                    ContactPrincipale = table.Column<string>(maxLength: 35, nullable: true),
                    Complement = table.Column<string>(maxLength: 35, nullable: true),
                    CodePostal = table.Column<string>(maxLength: 9, nullable: true),
                    Ville = table.Column<string>(maxLength: 35, nullable: true),
                    CodeRegion = table.Column<string>(maxLength: 25, nullable: true),
                    Pays = table.Column<string>(maxLength: 35, nullable: true),
                    Raccourcis = table.Column<string>(maxLength: 7, nullable: true),
                    NumeroBanqueTier = table.Column<int>(nullable: false),
                    Ape = table.Column<string>(maxLength: 7, nullable: true),
                    MatriculeFiscale = table.Column<string>(maxLength: 25, nullable: true),
                    Siret = table.Column<string>(maxLength: 15, nullable: true),
                    Encours = table.Column<double>(maxLength: 24, nullable: false),
                    NumeroPayeur = table.Column<string>(maxLength: 17, nullable: true),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CategorieComptabilite = table.Column<int>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    Sommeil = table.Column<bool>(nullable: false),
                    Depot = table.Column<int>(nullable: false),
                    Telephone = table.Column<string>(maxLength: 21, nullable: true),
                    Telecopie = table.Column<string>(maxLength: 21, nullable: true),
                    EMail = table.Column<string>(maxLength: 69, nullable: true),
                    SiteWeb = table.Column<string>(maxLength: 69, nullable: true),
                    Timbre = table.Column<bool>(nullable: false),
                    TauxRemise = table.Column<double>(maxLength: 18, nullable: false),
                    CategorieTVA = table.Column<string>(maxLength: 7, nullable: true),
                    Categorie = table.Column<string>(maxLength: 7, nullable: true),
                    Etranger = table.Column<bool>(nullable: false),
                    CoursDevise = table.Column<double>(maxLength: 18, nullable: false),
                    ADRESSELivraison = table.Column<string>(maxLength: 70, nullable: true),
                    CodePostalLivraison = table.Column<string>(maxLength: 10, nullable: true),
                    VilleLivraison = table.Column<string>(maxLength: 35, nullable: true),
                    PaysLivraison = table.Column<string>(maxLength: 35, nullable: true),
                    Qualite = table.Column<string>(maxLength: 35, nullable: true),
                    Adresse = table.Column<string>(maxLength: 60, nullable: true),
                    Commentaire = table.Column<string>(maxLength: 100, nullable: true),
                    Classement = table.Column<string>(maxLength: 35, nullable: true),
                    Jointe1 = table.Column<string>(maxLength: 150, nullable: true),
                    Jointe2 = table.Column<string>(maxLength: 150, nullable: true),
                    Incoterm = table.Column<string>(nullable: true),
                    CompteAuxiliaire = table.Column<string>(maxLength: 20, nullable: true),
                    ICE = table.Column<string>(maxLength: 20, nullable: true),
                    CREATEURId = table.Column<int>(nullable: true),
                    MODIFICATEURId = table.Column<int>(nullable: true),
                    CategorieTarifId = table.Column<int>(nullable: true),
                    CollaborateurId = table.Column<int>(nullable: true),
                    DeviseId = table.Column<int>(nullable: true),
                    FamilleTierId = table.Column<int>(nullable: true),
                    ModalitePaiementId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clients_Utilisateurs_CREATEURId",
                        column: x => x.CREATEURId,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_CategorieTarifs_CategorieTarifId",
                        column: x => x.CategorieTarifId,
                        principalTable: "CategorieTarifs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Collaborateurs_CollaborateurId",
                        column: x => x.CollaborateurId,
                        principalTable: "Collaborateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Devises_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_FamilleTiers_FamilleTierId",
                        column: x => x.FamilleTierId,
                        principalTable: "FamilleTiers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Utilisateurs_MODIFICATEURId",
                        column: x => x.MODIFICATEURId,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_ModalitePaiements_ModalitePaiementId",
                        column: x => x.ModalitePaiementId,
                        principalTable: "ModalitePaiements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomPrenom = table.Column<string>(maxLength: 35, nullable: true),
                    Fonction = table.Column<string>(maxLength: 35, nullable: true),
                    Adresse = table.Column<string>(maxLength: 35, nullable: true),
                    CodePostal = table.Column<string>(maxLength: 10, nullable: true),
                    Ville = table.Column<string>(maxLength: 35, nullable: true),
                    Pays = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(maxLength: 35, nullable: true),
                    Portable = table.Column<string>(maxLength: 35, nullable: true),
                    Fax = table.Column<string>(maxLength: 35, nullable: true),
                    Email = table.Column<string>(maxLength: 35, nullable: true),
                    Type = table.Column<int>(maxLength: 1, nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false),
                    ClientID = table.Column<int>(nullable: true),
                    ClienttId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacts_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UnicityCategorie",
                table: "CategorieTarifs",
                column: "Categorie",
                unique: true,
                filter: "[Categorie] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CREATEURId",
                table: "Clients",
                column: "CREATEURId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CategorieTarifId",
                table: "Clients",
                column: "CategorieTarifId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CollaborateurId",
                table: "Clients",
                column: "CollaborateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DeviseId",
                table: "Clients",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_FamilleTierId",
                table: "Clients",
                column: "FamilleTierId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_MODIFICATEURId",
                table: "Clients",
                column: "MODIFICATEURId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ModalitePaiementId",
                table: "Clients",
                column: "ModalitePaiementId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateurs_UtilisateurId",
                table: "Collaborateurs",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ClientID",
                table: "Contacts",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "UnicityDEVISE",
                table: "Devises",
                column: "DEVISE",
                unique: true,
                filter: "[DEVISE] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FamilleTiers_CategorieTarifId",
                table: "FamilleTiers",
                column: "CategorieTarifId");

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "FamilleTiers",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "ModalitePaiements",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UnicityNomUtilisateur",
                table: "Utilisateurs",
                column: "User",
                unique: true,
                filter: "[User] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Parametres");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Collaborateurs");

            migrationBuilder.DropTable(
                name: "Devises");

            migrationBuilder.DropTable(
                name: "FamilleTiers");

            migrationBuilder.DropTable(
                name: "ModalitePaiements");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "CategorieTarifs");
        }
    }
}
