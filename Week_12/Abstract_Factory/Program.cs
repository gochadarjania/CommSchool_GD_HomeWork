using System;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client(new FurnitureFactory(), new Sofa(), "Art Decor");

            client.Run();
        }
    }
}
