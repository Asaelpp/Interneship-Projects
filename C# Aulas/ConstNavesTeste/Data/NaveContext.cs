using ConstNavesTeste.Models;
using Microsoft.EntityFrameworkCore;

namespace ConstNavesTeste.Data
{
    public class NaveContext : DbContext
    {
        public NaveContext(DbContextOptions<NaveContext> options) : base(options)
        {

        }

        public DbSet<SpaceShip> Naves { get; set; }
    }
}
