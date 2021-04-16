using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace arpKartkowka4
{
    class Program
    {

        static void Main(string[] args)
        {
            var context = new MyDB();
            Random rand = new Random();

            for (int i = 0; i < 3; ++i)
            {
                context.MyTbl.Add(new MojaEncja {Age = rand.Next(99)}) ;
                context.SaveChanges();
            }

            var toPrint = context.MyTbl.ToList();
            toPrint.ForEach(x => Console.WriteLine("ID: " + x.ID + "\nAge: "+ x.Age + "\n"));

            Console.ReadLine();
        }
    }
}
