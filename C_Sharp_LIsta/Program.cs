
using System.Linq;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));
            payments.Add(new Payment(6));
            payments.Add(new Payment(7));

            //payments.Remove(new Payment());

            //foreach(var item in payments.Skip(1))
            //{
            //    Console.WriteLine(item.Id);
            //}

            //foreach(var item in payments.Take(3))
            //{
            //    Console.WriteLine(item.Id);
            //}

            foreach (var item in payments.Skip(2).Take(3))
            {
                Console.WriteLine(item.Id);
            }


            //var payment = payments.First(x=>x.Id == 3);
            //Console.WriteLine(payment.Id);
        }
    }

    public class Payment
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }
    }

}

