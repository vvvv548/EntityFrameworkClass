using System;
using System.Data.Entity;
using System.Web;

namespace ConsoleApplication1
{
    public partial class ContosoUniversityEntities1 : DbContext
    {
        public override int SaveChanges()
        {
            var entities = this.ChangeTracker.Entries();

            foreach (var entry in entities)
            {
                if (entry.State == EntityState.Modified)
                {
                    if(entry.Entity is Course)
                    {
                        Console.WriteLine(entry.OriginalValues.GetValue<int>("Credits"));
                        //OriginalValues 原始值
                        //CurrentValues  新的值
                        entry.CurrentValues.SetValues(
                            new { ModifyTime = DateTime.Now });
                    }
                    
                }
            }

            return base.SaveChanges();
        }
    }
}

