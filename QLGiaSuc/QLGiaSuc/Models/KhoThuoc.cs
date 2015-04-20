namespace QLGiaSuc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoThuoc")]
    public partial class KhoThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoThuoc()
        {
            TheoDoiBenhs = new HashSet<TheoDoiBenh>();
            TiemChungs = new HashSet<TiemChung>();
        }

        [Key]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        public int MaLoaiThuoc { get; set; }

        public int SoLuong { get; set; }

        public DateTime NgayNhap { get; set; }

        public DateTime HanSuDung { get; set; }

        public int Gia { get; set; }

        public virtual LoaiThuoc LoaiThuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheoDoiBenh> TheoDoiBenhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiemChung> TiemChungs { get; set; }
    }
}
