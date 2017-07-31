using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC4.Models
{
   public class Standard
    {
       public Standard()
       {

       }
       public int StandardID { get; set; }
       public string StandardName { get; set; }

       public ICollection<Student> Students { get; set; }
    }
}
