using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VetApp_prj.Models;

public partial class VetBddContext : DbContext
{
    private readonly IConfiguration _configuration;

    public VetBddContext()
    {
    }

    public VetBddContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /*public VetBddContext(DbContextOptions<VetBddContext> options)
        : base(options)
    {
    }*/

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientPatient> ClientPatients { get; set; }

    public virtual DbSet<DiagnosPrediction> DiagnosPredictions { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Produit> Produits { get; set; }

    public virtual DbSet<Rdv> Rdvs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Vet_Bdd;Trusted_Connection=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin);

            entity.ToTable("Admin");

            entity.Property(e => e.IdAdmin)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("idAdmin");
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
            entity.Property(e => e.MicroPuce).HasMaxLength(50);
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.Race).HasMaxLength(50);
            entity.Property(e => e.Sexe).HasMaxLength(50);
            entity.Property(e => e.Sterilise).HasMaxLength(50);
            entity.Property(e => e.Image).HasColumnName("image");
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
            entity.Property(e => e.Fin)
                    .HasColumnType("datetime")
                    .HasColumnName("fin");
            entity.Property(e => e.IdRdv).HasColumnName("idRdv");
            entity.Property(e => e.IdClient).HasColumnName("idClient");
            entity.Property(e => e.IdPatient).HasColumnName("idPatient");
            entity.Property(e => e.PlageHoraire).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
