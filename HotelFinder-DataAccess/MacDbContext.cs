using Azure;
using HotelFinder.Entities;
using Mac.Entities;

using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace HotelFinder_DataAccess
{
    public class MacDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-555DIMH\\SQLCode;DataBase=CR_SFC;User Id=sa;Password=kaya6327;TrustServerCertificate=True;");
        }

          public DbSet<Connection>Connections { get; set; }
          public DbSet<Machines>Machines { get; set; }
          public DbSet<PLCQualityCriterionDatas> PLCQualityCriterionDatas { get; set; }

       

    }
}