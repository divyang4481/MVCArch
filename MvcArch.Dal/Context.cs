﻿using System.Data.Entity;

namespace MvcArch.Dal
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public Context()
        {
            // Instructions:
            //  * You can add custom code to this file. Changes will *not* be lost when you re-run the scaffolder.
            //  * If you want to regenerate the file totally, delete it and then re-run the scaffolder.
            //  * You can delete these comments if you wish
            //  * If you want Entity Framework to drop and regenerate your database automatically whenever you 
            //    change your model schema, uncomment the following line:
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
    }
}
