using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VetApp_prj.Models
{
    public partial class Vet_BddContext : DbContext
    {
        public Vet_BddContext()
        {
        }

        public Vet_BddContext(DbContextOptions<Vet_BddContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<ClientPatient> ClientPatients { get; set; } = null!;
        public virtual DbSet<DiagnosPrediction> DiagnosPredictions { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<Produit> Produits { get; set; } = null!;
        public virtual DbSet<Rdv> Rdvs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Vet_Bdd;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin);

                entity.ToTable("Admin");

                entity.Property(e => e.IdAdmin)
                    .HasMaxLength(10)
                    .HasColumnName("idAdmin")
                    .IsFixedLength();

                entity.Property(e => e.Pwd).HasColumnName("pwd");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient);

                entity.ToTable("Client");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Prenom).HasMaxLength(50);
            });

            modelBuilder.Entity<ClientPatient>(entity =>
            {
                entity.HasKey(e => e.IdRelation);

                entity.ToTable("Client_Patient");

                entity.Property(e => e.IdRelation).HasColumnName("idRelation");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.IdPatient).HasColumnName("idPatient");
            });

            modelBuilder.Entity<DiagnosPrediction>(entity =>
            {
                entity.HasKey(e => e.IdDiangnos);

                entity.ToTable("Diagnos_Prediction");

                entity.Property(e => e.IdDiangnos).HasColumnName("id_Diangnos");

                entity.Property(e => e.Hyperunicerie).HasColumnName("hyperunicerie");

                entity.Property(e => e.InfoParo).HasColumnName("Info_Paro");

                entity.Property(e => e.LaMaladiePredict)
                    .HasMaxLength(50)
                    .HasColumnName("LaMaladie_Predict");

                entity.Property(e => e.PentDapp).HasColumnName("Pent_Dapp");

                entity.Property(e => e.Trc).HasColumnName("TRC");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.IdPatient);

                entity.ToTable("Patient");

                entity.Property(e => e.IdPatient).HasColumnName("idPatient");

                entity.Property(e => e.AlerteMedical).HasColumnName("Alerte_Medical");

                entity.Property(e => e.Couleur).HasMaxLength(50);

                entity.Property(e => e.DateNaissance)
                    .HasColumnType("date")
                    .HasColumnName("Date_Naissance");

                entity.Property(e => e.Espece).HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.MicroPuce).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Race).HasMaxLength(50);

                entity.Property(e => e.Sexe).HasMaxLength(50);

                entity.Property(e => e.Sterilise).HasMaxLength(50);
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(e => e.IdProduit);

                entity.ToTable("Produit");

                entity.Property(e => e.IdProduit).HasColumnName("idProduit");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.QuantiteDispo).HasColumnName("Quantite_Dispo");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Rdv>(entity =>
            {
                entity.HasKey(e => e.IdRdv);

                entity.ToTable("RDV");

                entity.Property(e => e.IdRdv).HasColumnName("idRdv");

                entity.Property(e => e.Fin)
                    .HasColumnType("datetime")
                    .HasColumnName("fin");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.IdPatient).HasColumnName("idPatient");

                entity.Property(e => e.PlageHoraire).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
