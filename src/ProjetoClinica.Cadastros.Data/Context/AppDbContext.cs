using Microsoft.EntityFrameworkCore;
using ProjetoClinica.Business;
using ProjetoClinica.Business.Models;
using ProjetoClinica.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinica.Data.Context
{
    public class AppDbContext : DbContext, IUnitOfWork
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options) { }

        public DbSet<Fisioterapeuta> Fisioterapeutas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FisioterapeutaMap());
            modelBuilder.ApplyConfiguration(new PacienteMap());
        }
    }
}
