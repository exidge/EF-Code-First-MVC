using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EF_Code_First_MVC.DAL
{
    public class UczestnicyKonferencji : DbContext
    {
        //public UczestnicyKonferencji() : base("EntityContext")
        //{

        //}
        public UczestnicyKonferencji(string ConnectionString) : base(ConnectionString)
        {
            Database.SetInitializer<UczestnicyKonferencji>(null);
        }
        public DbSet<Uczestnik> Uczestnicy { get; set; }
        
    }
}