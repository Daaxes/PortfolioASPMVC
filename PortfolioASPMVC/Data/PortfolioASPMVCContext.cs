using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortfolioASPMVC.Models;

namespace PortfolioASPMVC.Data
{
    public class PortfolioASPMVCContext : DbContext
    {
        public PortfolioASPMVCContext (DbContextOptions<PortfolioASPMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PortfolioASPMVC.Models.User> Users { get; set; }
        public DbSet<PortfolioASPMVC.Models.Experience> Experiences { get; set; }  = default!;
        public DbSet<PortfolioASPMVC.Models.Course> Courses { get; set; }
        public DbSet<PortfolioASPMVC.Models.Education> Educations { get; set; }
        public DbSet<PortfolioASPMVC.Models.Skill> Skills { get; set; }
    }
}
