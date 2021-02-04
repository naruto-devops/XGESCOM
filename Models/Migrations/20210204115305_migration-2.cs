using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Utilisateur_CREATEURId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Utilisateur_MODIFICATEURId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_ModalitePaiement_ModalitePaiementId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Clients_ClientID",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Collaborateurs_CollaborateurId",
                table: "Utilisateur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilisateur",
                table: "Utilisateur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModalitePaiement",
                table: "ModalitePaiement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "Utilisateur",
                newName: "Utilisateurs");

            migrationBuilder.RenameTable(
                name: "ModalitePaiement",
                newName: "ModalitePaiements");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameIndex(
                name: "IX_Utilisateur_CollaborateurId",
                table: "Utilisateurs",
                newName: "IX_Utilisateurs_CollaborateurId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_ClientID",
                table: "Contacts",
                newName: "IX_Contacts_ClientID");

            migrationBuilder.AlterColumn<string>(
                name: "Intitule",
                table: "ModalitePaiements",
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ModalitePaiements",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "ModalitePaiements",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModalitePaiements",
                table: "ModalitePaiements",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "ModalitePaiements",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Utilisateurs_CREATEURId",
                table: "Clients",
                column: "CREATEURId",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Utilisateurs_MODIFICATEURId",
                table: "Clients",
                column: "MODIFICATEURId",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_ModalitePaiements_ModalitePaiementId",
                table: "Clients",
                column: "ModalitePaiementId",
                principalTable: "ModalitePaiements",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Clients_ClientID",
                table: "Contacts",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateurs_Collaborateurs_CollaborateurId",
                table: "Utilisateurs",
                column: "CollaborateurId",
                principalTable: "Collaborateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Utilisateurs_CREATEURId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Utilisateurs_MODIFICATEURId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_ModalitePaiements_ModalitePaiementId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Clients_ClientID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateurs_Collaborateurs_CollaborateurId",
                table: "Utilisateurs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModalitePaiements",
                table: "ModalitePaiements");

            migrationBuilder.DropIndex(
                name: "UnicityCode",
                table: "ModalitePaiements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Utilisateurs",
                newName: "Utilisateur");

            migrationBuilder.RenameTable(
                name: "ModalitePaiements",
                newName: "ModalitePaiement");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameIndex(
                name: "IX_Utilisateurs_CollaborateurId",
                table: "Utilisateur",
                newName: "IX_Utilisateur_CollaborateurId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_ClientID",
                table: "Contact",
                newName: "IX_Contact_ClientID");

            migrationBuilder.AlterColumn<string>(
                name: "Intitule",
                table: "ModalitePaiement",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 45,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ModalitePaiement",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "ModalitePaiement",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilisateur",
                table: "Utilisateur",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModalitePaiement",
                table: "ModalitePaiement",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Utilisateur_CREATEURId",
                table: "Clients",
                column: "CREATEURId",
                principalTable: "Utilisateur",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Utilisateur_MODIFICATEURId",
                table: "Clients",
                column: "MODIFICATEURId",
                principalTable: "Utilisateur",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_ModalitePaiement_ModalitePaiementId",
                table: "Clients",
                column: "ModalitePaiementId",
                principalTable: "ModalitePaiement",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Clients_ClientID",
                table: "Contact",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Collaborateurs_CollaborateurId",
                table: "Utilisateur",
                column: "CollaborateurId",
                principalTable: "Collaborateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
