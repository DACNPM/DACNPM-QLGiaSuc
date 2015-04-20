namespace QLGiaSuc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheoDoiBenh")]
    public partial class TheoDoiBenh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTheoDoiBenh { get; set; }

        public int MaBenh { get; set; }

        public int MaDan { get; set; }

        public int SoLuong { get; set; }

        [StringLength(10)]
        public string MaThuoc { get; set; }

        public int? SoLuongThuoc { get; set; }

        public DateTime Ngay { get; set; }

        [Required]
        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual Benh Benh { get; set; }

        public virtual Dan Dan { get; set; }

        public virtual KhoThuoc KhoThuoc { get; set; }
    }
}
