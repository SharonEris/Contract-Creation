using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

namespace ContractManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        public override IModel TargetModel => base.TargetModel;

        public override IReadOnlyList<MigrationOperation> UpOperations => base.UpOperations;

        public override IReadOnlyList<MigrationOperation> DownOperations => base.DownOperations;

        public override string ActiveProvider { get => base.ActiveProvider; set => base.ActiveProvider = value; }

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractedParty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ContractFile = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
