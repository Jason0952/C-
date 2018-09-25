namespace 銷售員業績.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("salesman")]
    public partial class salesman
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string salesname { get; set; }

        public int? pen { get; set; }

        public int? pencil { get; set; }

        public int? eraser { get; set; }

        public int? ruler { get; set; }

        public int? reply { get; set; }
    }
}
