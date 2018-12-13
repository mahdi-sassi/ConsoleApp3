using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   public interface ITestAppContext : IDisposable
    {
        DbSet<Item> Items { get; }
        int SaveChanges();
        void MarkAsModified(Item item);
    }
}
