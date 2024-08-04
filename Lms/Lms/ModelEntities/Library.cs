using System.ComponentModel.DataAnnotations;

namespace Lms.ModelEntities
{
    public class Library
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
