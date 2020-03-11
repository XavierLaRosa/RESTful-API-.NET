using System;
using System.ComponentModel.DataAnnotations;

namespace StockUpAPI.Models
{
    public class User
    {
        [Key]
        public String Empy_id { get; set; }

        public String First { get; set; }
        public String Last { get; set; }
        public String Email { get; set; }
        public int IsAdmin { get; set; } // tiny int 0 1

        public User()
        {
        }
    }
}
