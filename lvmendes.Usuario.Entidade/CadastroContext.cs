using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvmendes.Usuario.Entidade
{
    public class CadastroContext : DbContext
    {

        //EntityFrameworkCore\Enable-Migrations
        //EntityFrameworkCore\Add-Migration teste
        //EntityFrameworkCore\Update-Database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=den1.mssql8.gear.host;Initial Catalog=provateste;Persist Security Info=True;User ID=provateste;Password=Uh3S-l0ps8?y");
        }


        public DbSet<UsuarioModel> Usuarios { get; set; }


    }
}
