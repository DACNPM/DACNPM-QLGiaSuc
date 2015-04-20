namespace QLGiaSuc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiThuoc")]
    public partial class LoaiThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiThuoc()
        {
            KhoThuocs = new HashSet<KhoThuoc>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiThuoc { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiThuoc { get; set; }

        public int MaBenh { get; set; }

        public int DonViTinh { get; set; }

        public virtual Benh Benh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoThuoc> KhoThuocs { get; set; }
    }
}
