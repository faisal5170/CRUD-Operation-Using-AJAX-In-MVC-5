using System.Data.Entity;

namespace AjaxCrudOperationUsingMVC5.Models
{
    public class Context:DbContext
    {
        public Context() : base("StringDBContext"){}
        public DbSet<Users> User { get; set; }
    }
}