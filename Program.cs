﻿// See https://aka.ms/new-console-template for more information
 Console.WriteLine("Hello, World!");

using (ECommerceContext db = new ECommerceContext())
{
    // products creation
    /*
    Product product1 = new Product("Neuralink", "Engineering with the Brain. We are designing the Link to connect to thousands of neurons in the brain. It will be able to record the activity of these neurons, process these signals in real time, and send that information to the Link. As a first application of this technology, we plan to help people with quadriplegia by giving them the ability to control computers and mobile devices directly with their brains. We would start by recording neural activity in the brain’s movement areas. As users think about moving their arms or hands, we would decode those intentions, which would be sent over Bluetooth to the user’s computer. Users would initially learn to control a virtual mouse. Later, as users get more practice and our adaptive decoding algorithms continue to improve, we expect that users would be able to control multiple devices, including a keyboard or a game controller.", 4999);
    Product product2 = new Product("Braindance 2077", "As braindance's popularity spread, public opinion divided into two camps: those who saw the new technology as a revalation, and those who saw it as a threat. Some predicted braindance would save humanity as we know it, bringing an end to unecessary conflict and ushering us into a new utopian age of mutual understanding and respect. After all, the argument went, if you look at yourself from your enemy's point of view, if you understand him deeply – and vice versa – he ceases to be your enemy.", 2699);
    Product product3 = new Product("Artificial Intelligence 2077", "Artificial intelligence began as simple algorithms meant to simplify our lives. With time, some became convincingly capable of simulating humans, with programmed personalities one could even grow to like. There were also weaponized AIs, essentially military technology used to break through enemy security in the Net. But then netrunner Rache Bartmoss arrived on the scene, and with him the infamous DataKrash.Bartmoss' target was the corporate data fortresses, his goal to steal the data held within and unleash it into the Net. What he achieved was a full-blown war that would transform cyberspace for good. As a direct result, AIs began to mutate, becoming deadly dangerous. Thus, rogue AIs were born.", 2699);
    db.Products.Add(product1);
    db.Products.Add(product2);
    db.Products.Add(product3);
    db.SaveChanges();
    */

    // customers creation
    /*
    Customer customer1 = new Customer("Judy", "Alvarez", "judy2077@cyber.punk");
    Customer customer2 = new Customer("Johnny", "Silverhand", "johnny@cyber.punk");
    Customer customer3 = new Customer("Dexter", "DeShawn", "dexter@cyber.punk");
    db.Customers.Add(customer1);
    db.Customers.Add(customer2);
    db.Customers.Add(customer3);
    db.SaveChanges();
    */

    // add new order
    /*
    Order newOrder = new Order(DateTime.Parse("13/07/2022"), 1, "Already delivered", 1);
    db.Orders.Add(newOrder);
    db.SaveChanges();
    */

    List<Order> orders = (from order in db.Orders select order).ToList<Order>();
    Console.WriteLine(orders); ;
}