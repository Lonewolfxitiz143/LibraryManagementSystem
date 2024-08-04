using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudApi.Model_Entities
{
    public class Authordb
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Adress { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }

    }
}
