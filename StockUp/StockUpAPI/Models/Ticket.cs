using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
namespace StockUpAPI.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Game { get; set; }

        [Required]
        public int Pack { get; set; }

        [Required]
        public int Nbr { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public String Name { get; set; }
        public String Store { get; set; }
        public int Activated { get; set; } // tiny int 0 1
        public int LoadedPack { get; set; } // tiny int 0 1
        public int Price { get; set; }
        public int Start_Inv { get; set; } // tiny int 0 1 
        public int End_Inv { get; set; } // tiny int 0 1
        public String Emp_id { get; set; }

        public Ticket()
        {
        }
    }
}
