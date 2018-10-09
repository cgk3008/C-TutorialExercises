using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript_Exercises_in_CSharp
{
    class Customer
    {

        public int Id;
        public string Name;
        public List<Order> Orders;


        public Customer()
        // must initialize Orders object! otherwise get null reference exception when call it in Main class.  
        //    var order = new Order();
        //customer.Orders.Add(order); 

        {
            Orders = new List<Order>();
        }





        public Customer( int id)
            : this() // this snippet of code will call the empty public Customer() constructor which will then initialize the Orders List!!!  If we had multiple Lists, it will grab them all!
        {
            this.Id = id;

        }

        public  Customer(int id, string name)
            : this(id)
        {
            // now we don't need the line below, because the this(id) will go to the Customer (int id) which will already call the one before......however it could start to get confusing by using " :this() " several times!
            //this.Id = id;
            this.Name = name;
        }

    }
}
