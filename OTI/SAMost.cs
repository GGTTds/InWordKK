namespace OTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAMost")]
    public partial class SAMost
    {
        public int ID { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public DateTime? date { get; set; }

        [StringLength(300)]
        public string Thems { get; set; }

    }
}
