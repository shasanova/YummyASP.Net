using System;
using Microsoft.EntityFrameworkCore;
using Yummy.Entities;

namespace Yummy.DAL
{
	public class RelationsYummyDbContext:DbContext
	{

		public RelationsYummyDbContext(DbContextOptions<RelationsYummyDbContext> options):base(options)
		{

		}

		public DbSet<Chef> Chefs { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<ChefSocialMedia> ChefSocialMedia { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}

