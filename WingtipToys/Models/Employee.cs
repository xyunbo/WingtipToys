using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }


    }
}
