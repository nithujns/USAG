using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USAG_Appl.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace USAG_Appl.DAL
{
    public class MerchantContext : DbContext
    {
        public MerchantContext() : base("MerchantContext")
        {
        }

        public DbSet<Merchant> Merchants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}