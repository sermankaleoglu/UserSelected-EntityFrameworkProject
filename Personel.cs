using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirişliEF
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        public int PersonelAge { get; set; }
    }
}
