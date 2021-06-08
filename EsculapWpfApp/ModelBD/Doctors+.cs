namespace EsculapWpfApp.ModelBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doctors
    {
        public string FIO { get 
            {
                return $"{LastName} {FirstName[0]}.{Patronymic[0]}";
            } }
    }
}
