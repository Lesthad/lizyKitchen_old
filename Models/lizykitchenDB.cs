using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lizykitchen.Models
{
    public class lizykitchenDB : DbContext
    {
        public lizykitchenDB(): base("name=DefaultConnection")
        {

        }
        public DbSet<Recipe> Recipes { get; set; }
    }
}