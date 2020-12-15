using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementService.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {


            context.SaveChanges();
        }
    }
}
