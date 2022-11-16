using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace QuanLyThuVien.Models
{
    public partial class quanlythuvienContext : DbContext
    {
        public quanlythuvienContext()
        {
        }

        public quanlythuvienContext(DbContextOptions<quanlythuvienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DocGium> DocGia { get; set; }
        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<MuonTraSach> MuonTraSaches { get; set; }
        public virtual DbSet<MuonTraSachChiTiet> MuonTraSachChiTiets { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<TacGium> TacGia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conf = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", true, true)
               .Build();
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(conf.GetConnectionString("DBconnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DocGium>(entity =>
            {
                entity.HasKey(e => e.MaDocGia)
                    .HasName("PK__DocGia__F165F945BC4E5EFC");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.SoDienThoai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoaiSach>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSach)
                    .HasName("PK__LoaiSach__2F9B373F5C628BE8");

                entity.ToTable("LoaiSach");

                entity.Property(e => e.TenLoaiSach)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MuonTraSach>(entity =>
            {
                entity.HasKey(e => e.MaMuonTraSach)
                    .HasName("PK__MuonTraS__86BECB62B966A542");

                entity.ToTable("MuonTraSach");

                entity.HasOne(d => d.MaDocGiaNavigation)
                    .WithMany(p => p.MuonTraSaches)
                    .HasForeignKey(d => d.MaDocGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MuonTraSa__MaDoc__2E1BDC42");
            });

            modelBuilder.Entity<MuonTraSachChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaMuonTraSachChiTiet)
                    .HasName("PK__MuonTraS__1AFC84F290BA2C98");

                entity.ToTable("MuonTraSachChiTiet");

                entity.Property(e => e.NgayHenTra).HasColumnType("date");

                //entity.Property(e => e.NgayMuon).HasColumnType("date");

                entity.Property(e => e.NgayTra).HasColumnType("date");

                entity.HasOne(d => d.MaMuonTraSachNavigation)
                    .WithMany(p => p.MuonTraSachChiTiets)
                    .HasForeignKey(d => d.MaMuonTraSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MuonTraSa__MaMuo__30F848ED");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.MuonTraSachChiTiets)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MuonTraSa__MaSac__31EC6D26");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.MaSach)
                    .HasName("PK__Sach__B235742D40264C34");

                entity.ToTable("Sach");

                entity.Property(e => e.TenSach)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.MaLoaiSachNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.MaLoaiSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sach__MaLoaiSach__286302EC");

                entity.HasOne(d => d.MaTacGiaNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.MaTacGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sach__MaTacGia__29572725");
            });

            modelBuilder.Entity<TacGium>(entity =>
            {
                entity.HasKey(e => e.MaTacGia)
                    .HasName("PK__TacGia__F24E6756A0399EEF");

                entity.Property(e => e.DiaChi).HasMaxLength(1000);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenTacGia)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
