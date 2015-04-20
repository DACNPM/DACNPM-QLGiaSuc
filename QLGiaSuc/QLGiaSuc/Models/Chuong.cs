namespace QLGiaSuc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chuong")]
    public partial class Chuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChuong { get; set; }

        [Required]
        [StringLength(10)]
        public string TenChuong { get; set; }

        public int MaKhuVuc { get; set; }

        public int MaDan { get; set; }

        public virtual Dan Dan { get; set; }

        public virtual KhuVuc KhuVuc { get; set; }
    }
}
