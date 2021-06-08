namespace EsculapWpfApp.ModelBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reception")]
    public partial class Reception
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reception()
        {
            Patients = new HashSet<Patients>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TreatyID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateStart { get; set; }

        [Required]
        [StringLength(10)]
        public string TimeStart { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        public int? DoctorID { get; set; }

        public virtual Doctors Doctors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patients> Patients { get; set; }
    }
}
