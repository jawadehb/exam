using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Models
{
    internal class User
    {
        public int Id { get; set; }
     
        public required string Nickname { get; set; }
      
        public required string Email { get; set; }
    }
}
