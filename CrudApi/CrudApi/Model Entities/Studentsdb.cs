using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudApi.Model_Entities
{
    public class Studentsdb
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string bookname { get; set; }
        [Required]
        public decimal price { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string description { get; set; }
      
    }
}
