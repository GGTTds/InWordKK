namespace OTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int ID { get; set; }

        [StringLength(300)]
        public string FIO { get; set; }

        [StringLength(15)]
        public string Logg { get; set; }

        [StringLength(15)]
        public string Pass { get; set; }

        public int? Rol { get; set; }

        public virtual Roul Roul { get; set; }
    }
}
