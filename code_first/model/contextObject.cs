using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace code_first.model
{
    class ConnectContext : DbContext
    {
        public virtual DbSet<StoreDTO> StoreDTO{
            set;
            get;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Uid=root;Pwd=Ritzzxi1.;Database=OMS;");
        }
        
    }
    
}