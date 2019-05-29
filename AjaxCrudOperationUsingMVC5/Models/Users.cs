using System.ComponentModel.DataAnnotations;

namespace AjaxCrudOperationUsingMVC5.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}