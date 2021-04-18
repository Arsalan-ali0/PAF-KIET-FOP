using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project
{
    class Program
    {
        
        static Order[] allorders = new Order[500];
        static int currentOrders = 0;

        

        static void Main(string[] args)
        {
            PrintMenuItems();
            string input = TakeUserInput();
            
            input = input.ToUpper();
            ProcessUserInput(input);

        }

        public static void PrintMenuItems()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******Welcome to Star Seafood Corner Billing System******");
           Addnewline ("---------------------------------------------------------");

            Addnewline("          Please enter 'A' to add new order              ");
            Addnewline("          Please enter 'L' to add list of orders.        ");
            Addnewline("          Please enter 'D' to delete order.              ");
            Addnewline("---------------------------------------------------------");

        }

        private static string TakeUserInput()

        {
         
            string input = Console.ReadLine();
            return (input);
        }
        static void Addnewline(string text)
        {
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-");
            
        }

        private static void ProcessUserInput(string input)
        {
            if (input == "A")
            {
                Order newOrder = new Order();

                newOrder.orderNumber = currentOrders + 1;
                Console.WriteLine("Enter Customer Name");
                newOrder.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Customer Phone Number");
                newOrder.CustomerPhone = Console.ReadLine();
                Console.WriteLine("Enter fish type");
                newOrder.Fishtype = Console.ReadLine();
                Console.WriteLine("Enter quantity in KG ");
                newOrder.Quantity = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter price per Kg for fish");
                newOrder.Price = double.Parse(Console.ReadLine());
                newOrder.isDeleted = false;

                newOrder.totalprice = newOrder.Quantity * newOrder.Price;
                allorders[currentOrders] = newOrder;

                currentOrders++;

                Console.WriteLine("the total order cost is : {0}", newOrder.totalprice);
                Console.WriteLine("New order successfully added");
                Console.WriteLine("------------------------------------------------------");

                Console.WriteLine("Press any for main menu");
                Console.ReadLine();
                Console.Clear();
                PrintMenuItems();


                string input1 = TakeUserInput();
                ProcessUserInput(input1);

            }
            else if (input == "L")
            {
                Console.WriteLine("List of All Orders.");
               

                for (int i = 0; i < currentOrders; i++)
                {
                    if (allorders[i].isDeleted == false)
                    {

                        Console.WriteLine("OrderNumber:  {0} | CustomerName:  {1} | CustomePhone: {2} | FishType: {3} | OrderQuantity: {4} |  Price {4} | TotalPrice {5} | ", allorders[i].orderNumber, allorders[i].CustomerName, allorders[i].CustomerPhone, allorders[i].Fishtype, allorders[i].Quantity, allorders[i].Price, allorders[i].totalprice);
                    }
                }

                Console.WriteLine("Press any for main menu");
                Console.ReadLine();
                Console.Clear();
                PrintMenuItems();
                
                string input1 = TakeUserInput();
                ProcessUserInput(input1);
            }
            else if (input == "D")
            {
                Console.WriteLine("Please enter order number to delete");
                int orderToDelete=int.Parse(Console.ReadLine());
                for (int ind = 0; ind < currentOrders; ind++)
                {
                    if(allorders[ind].orderNumber == orderToDelete)
                    {
                        allorders[ind].isDeleted = true;
                        Console.WriteLine("Order deleted successfully");
                    }
                }


            }

            else
            {
                Console.WriteLine("You have entered invalid Key");
            }

            Console.WriteLine("Press any for main menu");
            Console.ReadLine();
            Console.Clear();
            PrintMenuItems();
                string input2 = TakeUserInput();
                
                ProcessUserInput(input2);



                    
            }



        }


    } 

       