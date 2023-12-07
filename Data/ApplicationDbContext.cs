using Microsoft.EntityFrameworkCore;
using parcel.Models;

namespace parcel.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<mail> Mails { get; set; }
	}
}
