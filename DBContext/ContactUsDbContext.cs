using FinalProjectWebServer.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectWebServer.DBContext
{
    public class ContactUsDbContext : DbContext
    {
        public ContactUsDbContext(DbContextOptions<ContactUsDbContext> options)
           : base(options)
        { }

        public DbSet<ContactUsDomainModel> ContactUs { get; set; }
    }
}