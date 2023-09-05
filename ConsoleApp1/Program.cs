using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IBillService billService = new BillManager(new EfBillDal(),new TableManager(new EfTableDal()),new OrderManager(new EfOrderDal()));
            ////foreach (var item in billService.GetList().Data)
            ////{
            ////    Console.WriteLine(item.TableId);
            ////}
            //var date = new DateTime();
            //Console.WriteLine(billService.GetByDate(date).Data.Count());
            
            //Console.WriteLine("Hello World!");
        }
        
    }
}
