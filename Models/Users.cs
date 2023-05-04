using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Users
    {
        private string nombre; 
        private string documento; 
        private string cargo; 
        private int TipoDocumento;

        
        [Required(ErrorMessage ="Oppss no existe un Usuario sin Nombre Colocalo")]
        public string Nombre 
        { 
            get => nombre; 
            set => nombre = value; 
        }
        [Required(ErrorMessage ="Oppss y el DNI")]
        public string Documento 
        { 
            get => documento; 
            set => documento = value; 
        }
        [Required(ErrorMessage ="Dale un Cargo o Ingresa uno")]
        public string Cargo 
        { 
            get => cargo; 
            set => cargo = value; 
        }
        [Required(ErrorMessage ="Sabemos que tienes un documento pero indicanos que tipo")]
        public int TipoDocumento1
        { 
            get => TipoDocumento; 
            set => TipoDocumento = value; 
        }

        public string area { get; set; }
    }
}
