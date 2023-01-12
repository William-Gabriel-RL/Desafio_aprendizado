﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorys.Migrations
{
    /// <inheritdoc />
    public partial class nomeparamesa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MesaNome",
                table: "Mesa",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MesaNome",
                table: "Mesa");
        }
    }
}
