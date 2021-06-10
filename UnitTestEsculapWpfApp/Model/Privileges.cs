namespace UnitTestEsculapWpfApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Privileges
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Privileges()
        {
            Patients = new HashSet<Patients>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExemptID { get; set; }

        [Required]
        [StringLength(60)]
        public string ExemptType { get; set; }

        [Column(TypeName = "money")]
        public decimal Exempt { get; set; }

        [Column(TypeName = "money")]
        public decimal Summa { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patients> Patients { get; set; }
    }
}
