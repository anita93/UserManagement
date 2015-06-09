using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [Required]
        [Display(Name = "User Name")]

        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string Roles { get; set; }

    }
}
