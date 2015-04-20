namespace QLGiaSuc
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLGiaSucContext : DbContext
    {
        public QLGiaSucContext()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Benh> Benhs { get; set; }
        public virtual DbSet<ChamSoc> ChamSocs { get; set; }
        public virtual DbSet<Chuong> Chuongs { get; set; }
        public virtual DbSet<CongViec> CongViecs { get; set; }
        public virtual DbSet<Dan> Dans { get; set; }
        public virtual DbSet<KhoThuoc> KhoThuocs { get; set; }
        public virtual DbSet<KhuVuc> KhuVucs { get; set; }
        public virtual DbSet<LoaiGiaSuc> LoaiGiaSucs { get; set; }
        public virtual DbSet<LoaiThuoc> LoaiThuocs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheoDoiBenh> TheoDoiBenhs { get; set; }
        public virtual DbSet<TiemChung> TiemChungs { get; set; }
        public virtual DbSet<XuatChuong> XuatChuongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhoThuoc>()
                .HasMany(e => e.TiemChungs)
                .WithRequired(e => e.KhoThuoc)
                .WillCascadeOnDelete(false);
        }
    }
}
