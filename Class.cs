using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirişliEF
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }
        public bool Projeksiyon { get; set; }
        public bool HDMI { get; set; }
    }
}
