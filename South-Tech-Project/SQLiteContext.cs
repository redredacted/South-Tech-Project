using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SQLite.CodeFirst;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace South_Tech_Project
{
    class MedicalSQLiteContext : MedicalEntities
    {
        public MedicalSQLiteContext() : base("MedicalDB")
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MedicalEntities>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
