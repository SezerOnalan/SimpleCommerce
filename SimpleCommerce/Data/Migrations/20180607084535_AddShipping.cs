using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SimpleCommerce.Data.Migrations
{
    public partial class AddShipping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShippingAdresss",
                table: "Customers",
                newName: "ShippingAddress");

            migrationBuilder.RenameColumn(
                name: "BillingAdresss",
                table: "Customers",
                newName: "BillingAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShippingAddress",
                table: "Customers",
                newName: "ShippingAdresss");

            migrationBuilder.RenameColumn(
                name: "BillingAddress",
                table: "Customers",
                newName: "BillingAdresss");
        }
    }
}
