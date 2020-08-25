using System;
using System.Linq;
using Model;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("List of pharaohs in database:");
            using (var context = new ModelContext())
            {
                context.Pharaohs.Add(new Pharaoh { Name = "Ramesses II (Ozymandias)" });
                context.SaveChanges();

                var pharaohs = context.Pharaohs.ToList();

                foreach (var pharaoh in pharaohs)
                    System.Console.WriteLine("" + pharaoh.Id + ": " + pharaoh.Name);
            }
        }
    }
}