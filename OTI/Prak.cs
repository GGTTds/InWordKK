namespace OTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prak")]
    public partial class Prak
    {
        public int ID { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(10)]
        public string date { get; set; }

        [StringLength(300)]
        public string Head { get; set; }

        [StringLength(300)]
        public string linkS { get; set; }

        public int? WhoHead { get; set; }

        public virtual HeadPark HeadPark { get; set; }
    }
}
