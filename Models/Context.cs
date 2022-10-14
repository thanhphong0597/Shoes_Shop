using Microsoft.EntityFrameworkCore;

namespace testpro.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<PaymentDetails> PaymentDetails { get; set; }
    }
}
