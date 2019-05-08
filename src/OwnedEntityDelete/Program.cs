using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace OwnedEntityDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TestContext())
            {
                // 1 - Simpler code, more recommended: 

                //var entity = context.Orders.First();
                //context.Remove(entity);
                //context.SaveChanges();

                // 2 - "Faulty, original OP" code - Will throw
                //var order = context.Orders.AsNoTracking().FirstOrDefault();
                //context.Entry(order).State = EntityState.Deleted;
                //context.SaveChanges();

                // 3 - Fixed - Delete Works, simulate a disconnected scenario
                //var order = context.Orders.AsNoTracking().FirstOrDefault();
                //context.Entry(order).State = EntityState.Deleted;
                //context.Entry(order.ShippingAddress).State = EntityState.Deleted;
                //context.SaveChanges();
            }
        }
    }
}
