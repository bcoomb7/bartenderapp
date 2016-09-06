using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BartenderApp.Models
{
    public class Drinks : DbContext
    {
        public DbSet<Drink> Drank { get; set; }

    }
}