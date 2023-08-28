using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAutomation.Migrations
{
    /// <inheritdoc />
    public partial class ModifyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VehicleRequisitions");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "VehicleRequisitions");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "VehicleRequisitions");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "VehicleRequisitions");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "VehicleRequisitions");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "VehicleRequisitions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VehicleClasses");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "VehicleClasses");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "VehicleClasses");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "VehicleClasses");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "VehicleClasses");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "VehicleClasses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RequisitionStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "RequisitionStatuses");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "RequisitionStatuses");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "RequisitionStatuses");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "RequisitionStatuses");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "RequisitionStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FuelType");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FuelType");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "FuelType");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "FuelType");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "FuelType");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "FuelType");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FuelRequisitions");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FuelRequisitions");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "FuelRequisitions");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "FuelRequisitions");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "FuelRequisitions");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "FuelRequisitions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "VehicleTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "VehicleTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "VehicleTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "VehicleTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "VehicleTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "VehicleTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Vehicles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Vehicles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Vehicles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "Vehicles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Vehicles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "VehicleRequisitions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "VehicleRequisitions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "VehicleRequisitions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "VehicleRequisitions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "VehicleRequisitions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "VehicleRequisitions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "VehicleClasses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "VehicleClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "VehicleClasses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "VehicleClasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "VehicleClasses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "VehicleClasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "RequisitionStatuses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "RequisitionStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "RequisitionStatuses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "RequisitionStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "RequisitionStatuses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "RequisitionStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "FuelType",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "FuelType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "FuelType",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "FuelType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "FuelType",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "FuelType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "FuelRequisitions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "FuelRequisitions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "FuelRequisitions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "FuelRequisitions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "FuelRequisitions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "FuelRequisitions",
                type: "datetime2",
                nullable: true);
        }
    }
}
