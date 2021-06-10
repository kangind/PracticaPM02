namespace UnitTestEsculapWpfApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patients
    {
        [Key]
        public int Number { get; set; }

        [Required]
        [StringLength(60)]
        public string Fio { get; set; }

        [Required]
        [StringLength(80)]
        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        public string District { get; set; }

        [Required]
        [StringLength(20)]
        public string PolicyNumber { get; set; }

        public int Year { get; set; }

        public bool Sign { get; set; }

        [StringLength(40)]
        public string Department { get; set; }

        public int? ExemptID { get; set; }

        public int? TreatyID { get; set; }

        public virtual Privileges Privileges { get; set; }

        public virtual Reception Reception { get; set; }
    }
}
