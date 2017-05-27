using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyGolfSocietyApp
{
    public static class Utility
    {
        
        public static bool EntityHasChanges(DbContext context)
        {
            if (context.ChangeTracker.Entries()
                .Any(e => e.State == EntityState.Added
                || e.State == EntityState.Modified
                || e.State == EntityState.Deleted))
                return true;
            else return false;
        }
    }
}
