namespace NorthwindEntity
{
    using System;
    using System.Linq;

    public class CustomerFunctionality
    {
        private const string NullParameterError = "You can not pass null as parameter";

        public static string Insert(Customer customer )
        {
           
            if (customer == null)
            {
                throw new ArgumentNullException(NullParameterError);
            }

            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return customer.CustomerID;
            }
        }

        public static void UpdatePhone(string customerId, string phone)
        {
            if (customerId == null)
            {
                throw new ArgumentNullException(NullParameterError);
            }

            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers
                .FirstOrDefault(c => c.CustomerID == customerId);
                customer.Phone = phone;
                db.SaveChanges();
            }
        }

        public static void Delete(string customerId)
        {
            if (customerId == null)
            {
                throw new ArgumentNullException(NullParameterError);
            }

            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers
                .FirstOrDefault(c => c.CustomerID == customerId);

                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

    }
}
