﻿using System;
using System.Data.SqlClient;
using EPR_Project_ToyStore.Models;
using Microsoft.EntityFrameworkCore;

namespace EPR_Project_ToyStore.Properties
{
    public class AppDbContext : DbContext
    {

        private readonly SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "ERP_DB",
            UserID = "sa",
            Password = "reallyStrongPwd123",
            TrustServerCertificate = true
        };

        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
            }
        }



        public DbSet<ItemModel> Items { get; set; }
            }
}