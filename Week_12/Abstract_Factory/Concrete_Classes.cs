using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Chair : AbstractFurniture
    {
        public override void Category(AbstractCategory category)
        {
            Name = "Chair";
            Print(Name, category.Name);
        }
    }
    class Sofa : AbstractFurniture
    {
        public override void Category(AbstractCategory category)
        {
            Name = "Sofa";
            Print(Name, category.Name);
        }
    }
    class CoffeTable : AbstractFurniture
    {
        public override void Category(AbstractCategory category)
        {
            Name = "Coffe Table";
            Print(Name, category.Name);
        }
    }

    class Category : AbstractCategory
    {
    }

    class FurnitureFactory : AbstractFactory
    {
        public override AbstractCategory CreateCategory()
        {
            return new Category();
        }

        public override AbstractFurniture CreateFurniture(AbstractFurniture abstractFurniture)
        {
            return abstractFurniture;
        }
    }

    public class Client
    {
        private AbstractFurniture furniture;
        private AbstractCategory category;
        public Client(AbstractFactory factory, AbstractFurniture abstractFurniture, string cat)
        {
            furniture = factory.CreateFurniture(abstractFurniture);
            category = factory.CreateCategory();

            category.Name = cat;
        }

        public void Run()
        {
            furniture.Category(category);
        }
    }
}
