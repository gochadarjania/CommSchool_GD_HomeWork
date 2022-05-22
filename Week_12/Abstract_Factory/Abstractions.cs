using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public abstract class AbstractCategory
    {
        public string Name { get; set; }
    }
    public abstract class AbstractFurniture
    {
        public string Name { get; set; }
        public abstract void Category(AbstractCategory category);
        public void Print(string fur, string cat)
        {
            Console.WriteLine($"Furniture: {fur} \nCategory: {cat}");
        }
    }
    public abstract class AbstractFactory
    {
        public abstract AbstractCategory CreateCategory();
        public abstract AbstractFurniture CreateFurniture(AbstractFurniture abstractFurniture);
    }
}
