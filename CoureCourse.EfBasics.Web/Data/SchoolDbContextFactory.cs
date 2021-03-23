using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoureCourse.EfBasics.Web.Data
{
    //overerven van IDesignTimeDbContextFactory<T> is nodig
    //om de migration automatisch te laten lopen
    //adhv het dotnet-ef migration commando
    public class SchoolDbContextFactory : IDesignTimeDbContextFactory<SchoolDbContext>
    {
        //zorgt voor een factory principe
        //wanneer deze class geInstantieerd wordt
        //maakt men een database connectie
        public SchoolDbContext CreateDbContext(string[] args)
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=SchoolDb;Trusted_Connection=true;MultipleActiveResultSets=true";
            DbContextOptionsBuilder<SchoolDbContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
            dbContextOptionsBuilder.UseSqlServer(connectionString);
            var schoolDbcontext = new SchoolDbContext(dbContextOptionsBuilder.Options);
            return schoolDbcontext;
        }
    }
}
