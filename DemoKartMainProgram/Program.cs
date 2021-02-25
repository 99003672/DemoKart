using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKartBL;

namespace DemoKartMainProgram
{
    class Program
    {
        static List<Product> CartList = new List<Product>(20);

        static List<Product> ProductList = new List<Product>(20);
        public void Display(int id)
        {
            foreach(Product item in ProductList)
            {
                if(id==item.CategoryObj.categoriesId)
                {
                    Console.WriteLine("Product id : " + item.productId + "\t\nProduct Name : " + item.productName + "\t\nProduct Price : " + item.price + "\t\nProduct Quantity : " + item.quantity + "\t\nCategory Id : " + item.CategoryObj.categoriesId + "\t\nCategory Name : " + item.CategoryObj.categories);
                }
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Product[] ProductList = new Product[20];
                for (int i = 0; i < 15; i++)
                {
                    ProductList[0] = new Product(1, "TRIMMER", 1000, 8, 1, "Electronics");
                    ProductList[1] = new Product(2, "MIXER", 1000, 2, 1, "Electronics");
                    ProductList[2] = new Product(3, "TELEVISION", 500, 10, 1, "Electronics");
                    ProductList[3] = new Product(4, "PANTS", 100, 6, 3, "Clothing");
                    ProductList[4] = new Product(5, "LAPTOP", 500, 4, 1, "Electronics");
                    ProductList[5] = new Product(6, "SAREE", 500, 5, 3, "Clothing");
                    ProductList[6] = new Product(7, "SHIRT", 500, 8, 3, "Clothing");
                    ProductList[7] = new Product(8, "TRACKPANT", 500, 8, 3, "Clothing");
                    ProductList[8] = new Product(9, "TSHIRT", 500, 10, 3, "Clothing");
                    ProductList[9] = new Product(10, "EGGS", 50, 9, 2, "Grocery");
                    ProductList[10] = new Product(11, "MILK", 90, 5, 2, "Grocery");
                    ProductList[14] = new Product(15, "FRUITS", 50, 8, 2, "Grocery");
                    ProductList[11] = new Product(12, "LIPASTIC", 5000, 8, 4, "Cosmetics");
                    ProductList[12] = new Product(13, "KAJAL", 5000, 7, 4, "Cosmetics");
                    ProductList[13] = new Product(14, "BRUSHES", 500, 8, 4, "Cosmetics");

                    Program.ProductList.Add(ProductList[i]);

                }

                Category CategoryObj = new Category();
                Cart CartObj = new Cart();
                Program programObj = new Program();

                Order OrderObj = new DemoKartBL.Order();
                Payment paymentObj = new Payment();
                int num, num1, num2, num3, num4, id;
                double TotalPrice = 0, TotalPrice1 = 0, TotalPrice2 = 0, TotalPrice3 = 0, TotalPrice4 = 0;
                double GrandTotal1 = 0, GrandTotal2 = 0;
                User UserObj = new User();
                Console.WriteLine("\t\t\t\t\t\t\tSHOPPING KART\n");
                Console.WriteLine("LOGIN TO PROCEED");
                Console.WriteLine("USERNAME");
                String UserName = Console.ReadLine();
                Console.WriteLine("PASSWORD");
                String Password = Console.ReadLine();
                int value = UserObj.Login(UserName, Password);

                if (value == 1)
                {
                    do
                    {
                        Console.WriteLine("CHOOSE THE CATEGORY YOU WANT TO SHOP");
                        Console.WriteLine("1.ELECTRONICS\t\n2.GROCERY\t\n3.CLOTHINGS\t\n4.COSMETICS");
                        int Choice = Convert.ToInt32(Console.ReadLine());
                        if (Choice == 1)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nENTER THE PRODUCT ID OF THE ITEM YOU WANT TO BUY : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nHOW MANY?");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in Program.ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quantity);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Quantity Size Exceeded The Limit\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CategoryObj.CalculatePrice(Choice, item.price, quantity);
                                            TotalPrice1 = TotalPrice1 + TotalPric;
                                            Product cust_cart = new Product(item.productId, item.productName, item.price, quantity, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                            CartList.Add(cust_cart);
                                            Console.WriteLine("Add To cart Is Successfull\n");
                                        }

                                    }
                                }

                            }
                        }
                        if (Choice == 2)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter the product ID of the product you want to Add to Cart : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter the Quantity you want");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in Program.ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quantity);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Quantity Size Exceeded The Limit\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CategoryObj.CalculatePrice(Choice, item.price, quantity);
                                            TotalPrice1 = TotalPrice1 + TotalPric;
                                            Product cust_cart = new Product(item.productId, item.productName, item.price, quantity, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                            CartList.Add(cust_cart);
                                            Console.WriteLine("Add To cart Is Successfull\n");
                                        }

                                    }
                                }

                            }
                        }
                        if (Choice == 3)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter How Many Quantity You Want");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in Program.ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quantity);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Quantity Size Exceed The Limit\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CategoryObj.CalculatePrice(Choice, item.price, quantity);
                                            TotalPrice1 = TotalPrice1 + TotalPric;
                                            Product cust_cart = new Product(item.productId, item.productName, item.price, quantity, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                            CartList.Add(cust_cart);
                                            Console.WriteLine("Add To cart Is Successfull\n");
                                        }

                                    }
                                }

                            }
                        }
                        if (Choice == 4)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter How Many Quantity You Want");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in Program.ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quantity);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Quantity Exceeded\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CategoryObj.CalculatePrice(Choice, item.price, quantity);
                                            TotalPrice1 = TotalPrice1 + TotalPric;
                                            Product cust_cart = new Product(item.productId, item.productName, item.price, quantity, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                            CartList.Add(cust_cart);
                                            Console.WriteLine("Added To cart\n");
                                        }

                                    }
                                }

                            }
                        }
                        Console.WriteLine("1.WANT TO ADD MORE?\t\n2.SHOW CART AND MAKE PAYMENT");
                        num = Convert.ToInt32(Console.ReadLine());
                    } while (num == 1);
                }
                else
                {
                    Console.WriteLine("ENTERED WRONG CREDENTIALS");
                }
                foreach (Product item in CartList)
                {

                    Console.WriteLine("Product id : " + item.productId);
                    Console.WriteLine("Product Name : " + item.productName);
                    Console.WriteLine("Product Price : " + item.price);
                    Console.WriteLine("Product Quantity : " + item.quantity);
                    Console.WriteLine("category id : " + item.CategoryObj.categoriesId);
                    Console.WriteLine("category type : " + item.CategoryObj.categories);
                    Console.WriteLine("\n______________");
                    Console.WriteLine("\n");
                }
                Console.WriteLine("1.DELETE A PRODUCT FROM CART?\t\n2.PLACE ORDER");
                num2 = Convert.ToInt32(Console.ReadLine());
                do
                {

                    if (num2 == 1)
                    {
                        Console.WriteLine("ENTER THE ID OF THE PRODUCT YOU WANT TO DELETE");
                        int PI = Convert.ToInt32(Console.ReadLine());
                        foreach (Product item in CartList)
                        {
                            if (PI == item.productId)
                            {
                                CartList.Remove(item);
                                Console.WriteLine("Cart item " + PI + " Deleted");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Item is not available in Cart");
                                break;
                            }


                        }
                    }
                    else
                    {
                        break;
                    }

                    Console.WriteLine("1.Remove Another Cart\t2.Order");
                    num3 = Convert.ToInt32(Console.ReadLine());
                } while (num3 == 1);

                foreach (Product item in CartList)
                {
                    Console.WriteLine("Updated Cart List");
                    Console.WriteLine("Product id : " + item.productId);
                    Console.WriteLine("Product Name : " + item.productName);
                    Console.WriteLine("Product Price : " + item.price);
                    Console.WriteLine("Product Quantity : " + item.quantity);
                    Console.WriteLine("Category ID : " + item.CategoryObj.categoriesId);
                    Console.WriteLine("Category type : " + item.CategoryObj.categories);
                    Console.WriteLine("\n______________");
                    Console.WriteLine("\n");
                }

                Console.WriteLine("Enter Details To Complete Order");
                Console.WriteLine("Enter The First Name : ");
                OrderObj.firstName = Console.ReadLine();
                Console.WriteLine("Enter  The Last Name : ");
                OrderObj.lastName = Console.ReadLine();
                Console.WriteLine("Enter The Mobile Number : ");
                OrderObj.mobileNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Delivery Address : ");
                OrderObj.deliveryAddress = Console.ReadLine();
                Console.WriteLine("Enter Pincode : ");
                OrderObj.pinCode = Convert.ToInt32(Console.ReadLine());

                TotalPrice = TotalPrice1 + TotalPrice2 + TotalPrice3 + TotalPrice4;

                Console.WriteLine("Choose The Payment Method");
                Console.WriteLine("1.ByCash\t\n2.ByCard");
                num4 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("ORDER HAS BEEN PLACED");
                Console.WriteLine("First Name : " + OrderObj.firstName + "\nLast Name : " + OrderObj.lastName + "\nMobile Number : " + OrderObj.mobileNo + "\nDelivery Address : " + OrderObj.deliveryAddress + "\nPinCode : " + OrderObj.pinCode);
                if (num4 == 1)
                {
                    GrandTotal1 = paymentObj.CalculateCGST(num4, TotalPrice);
                    Console.WriteLine("Central GST is : " + GrandTotal1);
                    GrandTotal2 = paymentObj.CalculateSGST(num4, TotalPrice);
                    Console.WriteLine("AMOUNT TO BE PAIN INCLUDING GST : " + GrandTotal2);
                }
                else if (num4 == 2)
                {
                    double GrandTotal3 = paymentObj.CalculateCGST(num4, TotalPrice);
                    Console.WriteLine("C,S GST is : " + GrandTotal3);
                    double GrandTotal4 = paymentObj.CalculateSGST(num4, TotalPrice);
                    Console.WriteLine("AMOUNT TO BE PAIN INCLUDING GST: " + GrandTotal4);
                }
                else
                {
                    Console.WriteLine("Wrong Choice");
                }

                Console.WriteLine("\t\t\t\t\t\t\tTHANKYOU FOR SHOPPING VISIT AGAIN");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }
    }
}

