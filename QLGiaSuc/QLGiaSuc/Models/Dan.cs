namespace QLGiaSuc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dan")]
    public partial class Dan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dan()
        {
            ChamSocs = new HashSet<ChamSoc>();
            Chuongs = new HashSet<Chuong>();
            TheoDoiBenhs = new HashSet<TheoDoiBenh>();
            TiemChungs = new HashSet<TiemChung>();
            XuatChuongs = new HashSet<XuatChuong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDan { get; set; }

        public int MaLoaiGiaSuc { get; set; }

        public int SoLuongNhap { get; set; }

        public int GiaNhap { get; set; }

        public double TongCanNangNhap { get; set; }

        public DateTime NgayNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChamSoc> ChamSocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chuong> Chuongs { get; set; }

        public virtual LoaiGiaSuc LoaiGiaSuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheoDoiBenh> TheoDoiBenhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiemChung> TiemChungs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XuatChuong> XuatChuongs { get; set; }
    }
}
