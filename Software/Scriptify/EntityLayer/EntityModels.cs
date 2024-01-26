using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityLayer {
    public partial class EntityModels : DbContext {
        public EntityModels()
            : base("name=EntityModels") {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Librarian> Librarians { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<Library_has_Books> Library_has_Books { get; set; }
        public virtual DbSet<loans_of_books> loans_of_books { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<user_has_Library_has_Books> user_has_Library_has_Books { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Reservation_Projection> Reservation_Projection { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Book>()
                .Property(e => e.book_name)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.overview)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.genre)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Library_has_Books)
                .WithRequired(e => e.Book)
                .HasForeignKey(e => e.Books_idBook)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Books)
                .Map(m => m.ToTable("user_has_Books").MapLeftKey("Books_idBook").MapRightKey("user_id_user"));

            modelBuilder.Entity<Librarian>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Librarian>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Librarian>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Librarian>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Librarian>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Library>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Library>()
                .HasMany(e => e.Librarians)
                .WithRequired(e => e.Library)
                .HasForeignKey(e => e.Library_idLibrary)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Library>()
                .HasMany(e => e.Library_has_Books)
                .WithRequired(e => e.Library)
                .HasForeignKey(e => e.Library_idLibrary)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Library_has_Books>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Library_has_Books)
                .HasForeignKey(e => e.Library_has_Books_library_has_books_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Library_has_Books>()
                .HasMany(e => e.user_has_Library_has_Books)
                .WithRequired(e => e.Library_has_Books)
                .HasForeignKey(e => e.Library_has_Books_library_has_books_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Library_has_Books>()
                .HasMany(e => e.loans_of_books)
                .WithOptional(e => e.Library_has_Books)
                .HasForeignKey(e => e.library_book_id)
                .WillCascadeOnDelete();

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
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.loans_of_books)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_id_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.user_has_Library_has_Books)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.user_id_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.book_name)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.loan_status)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation_Projection>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation_Projection>()
                .Property(e => e.book_name)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation_Projection>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation_Projection>()
                .Property(e => e.last_name)
                .IsUnicode(false);
        }
    }
}
