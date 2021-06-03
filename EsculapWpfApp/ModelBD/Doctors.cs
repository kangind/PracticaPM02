namespace EsculapWpfApp.ModelBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doctors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctors()
        {
            Reception = new HashSet<Reception>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DoctorID { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string Patronymic { get; set; }

        public int Room { get; set; }

        [Required]
        [StringLength(40)]
        public string University { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        public int Experience { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone { get; set; }

        public int Born { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reception> Reception { get; set; }
    }
}
