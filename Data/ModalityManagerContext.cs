using Microsoft.EntityFrameworkCore;
using ModalityManager.Models;

namespace ModalityManager.Data
{
    public class ModalityManagerContext: DbContext
    {
        public ModalityManagerContext (DbContextOptions<ModalityManagerContext > options)
            : base(options)
        {

        }
        public DbSet<Machine> Machine { get; set; }
    }
}
