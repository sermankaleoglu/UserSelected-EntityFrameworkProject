using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirişliEF
{
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
        public string InstructorSurname { get; set; }
        public int InstructorAge { get; set; }

    }
}
