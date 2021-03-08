using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ventas_Gonzalez_Nuñez.Web.Models
{
    public class Countries
    {
        public int CountryId { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Nombre Pais")]
    }
}
