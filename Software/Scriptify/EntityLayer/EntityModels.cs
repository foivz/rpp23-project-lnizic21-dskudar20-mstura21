using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityLayer
{
    public partial class EntityModels : DbContext
    {
        public EntityModels()
            : base("name=EntityModels")
        {
        }

        public virtual DbSet<Knjige> Knjige { get; set; }
        public virtual DbSet<Knjizara> Knjizara { get; set; }
        public virtual DbSet<Knjizara_has_Knjige> Knjizara_has_Knjige { get; set; }
        public virtual DbSet<Knjiznicari> Knjiznicari { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<user_has_Knjizara_has_Knjige> user_has_Knjizara_has_Knjige { get; set; }
        public virtual DbSet<Posudba> Posudba { get; set; }
        public virtual DbSet<Rezervacija_Projection> Rezervacija_Projection { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Knjige>()
                .Property(e => e.naziv_knjige)
                .IsUnicode(false);

            modelBuilder.Entity<Knjige>()
                .Property(e => e.opis)
                .IsUnicode(false);

            modelBuilder.Entity<Knjige>()
                .Property(e => e.autor)
                .IsUnicode(false);

            modelBuilder.Entity<Knjige>()
                .Property(e => e.zanr)
                .IsUnicode(false);

            modelBuilder.Entity<Knjige>()
                .HasMany(e => e.Knjizara_has_Knjige)
                .WithRequired(e => e.Knjige)
                .HasForeignKey(e => e.Knjige_idKnjige)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Knjige>()
                .HasMany(e => e.User)
                .WithMany(e => e.Knjige)
                .Map(m => m.ToTable("user_has_Knjige").MapRightKey("user_id_user"));

            modelBuilder.Entity<Knjizara>()
                .Property(e => e.ime)
                .IsUnicode(false);

            modelBuilder.Entity<Knjizara>()
                .HasMany(e => e.Knjizara_has_Knjige)
                .WithRequired(e => e.Knjizara)
                .HasForeignKey(e => e.Knjizara_idKnjizara)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Knjizara>()
                .HasMany(e => e.Knjiznicari)
                .WithRequired(e => e.Knjizara)
                .HasForeignKey(e => e.Knjizara_idKnjizara)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Knjizara_has_Knjige>()
                .HasMany(e => e.Rezervacija)
                .WithRequired(e => e.Knjizara_has_Knjige)
                .HasForeignKey(e => e.Knjizara_has_Knjige_knjizara_has_knjige_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Knjizara_has_Knjige>()
                .HasMany(e => e.user_has_Knjizara_has_Knjige)
                .WithRequired(e => e.Knjizara_has_Knjige)
                .HasForeignKey(e => e.Knjizara_has_Knjige_knjizara_has_knjige_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Knjiznicari>()
                .Property(e => e.ime)
                .IsUnicode(false);

            modelBuilder.Entity<Knjiznicari>()
                .Property(e => e.prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Knjiznicari>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Knjiznicari>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Knjiznicari>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Rezervacija)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_id_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.user_has_Knjizara_has_Knjige)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.user_id_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Posudba>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Posudba>()
                .Property(e => e.naziv_knjige)
                .IsUnicode(false);

            modelBuilder.Entity<Posudba>()
                .Property(e => e.ime)
                .IsUnicode(false);

            modelBuilder.Entity<Posudba>()
                .Property(e => e.prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Posudba>()
                .Property(e => e.StatusPosudbe)
                .IsUnicode(false);

            modelBuilder.Entity<Rezervacija_Projection>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Rezervacija_Projection>()
                .Property(e => e.naziv_knjige)
                .IsUnicode(false);

            modelBuilder.Entity<Rezervacija_Projection>()
                .Property(e => e.ime)
                .IsUnicode(false);

            modelBuilder.Entity<Rezervacija_Projection>()
                .Property(e => e.prezime)
                .IsUnicode(false);
        }
    }
}
