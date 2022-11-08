using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Programa6
{
    public class ProgramaContext : DbContext
    {
        //public IConfiguration Configuration { get; }
        public DbSet<DadosPrensa> DadosPrensas { get; set; }
        public DbSet<ResumoPrensa> ResumoPrensas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            //string conectionString = "server=localhost;userid=root;password=123456789;database=bancoteste";
            //var serverConncetion = ServerVersion.AutoDetect(conectionString);
            //optionsBuilder.UseMySql(conectionString,serverConncetion);
            //optionsBuilder.UseMySql(@"server=localhost;database=BookStoreDb;uid=root;password=;");
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ProgramaDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            
            
        }
    }
}