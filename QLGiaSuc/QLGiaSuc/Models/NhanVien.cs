namespace QLGiaSuc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            ChamSocs = new HashSet<ChamSoc>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNhanVien { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhanVien { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(50)]
        public string ChucVu { get; set; }

        public int Luong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChamSoc> ChamSocs { get; set; }
    }
}
