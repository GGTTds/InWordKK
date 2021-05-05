namespace OTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leck")]
    public partial class leck
    {
        public int ID { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public DateTime? date { get; set; }

        [StringLength(300)]
        public string Head { get; set; }

        [StringLength(300)]
        public string linkS { get; set; }
    }
}
