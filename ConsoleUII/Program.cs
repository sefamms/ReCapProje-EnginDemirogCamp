using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUII
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager car = new CarManager(new InMemoryCarDal());
            foreach (var item in car.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
