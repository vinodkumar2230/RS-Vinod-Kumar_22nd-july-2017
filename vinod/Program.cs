using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Asignment_22nd_july2017
{
    public class Phone
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public int age { get; set; }



    }
    public class Item
    {

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public int age { get; set; }

    }

    class Program
    {


        static void Main(string[] args)
        {
            List<Phone> list = new List<Phone>() {
                   new Phone { id= 1,name="vinod",  phone=367476474,email="vinod@gmail.com",age=27},
                   new Phone { id= 2,name="Shashank", phone=744784874,email="shahsank@gmail.com",age=30},
                   new Phone { id= 3,name="pracheer", phone=882474674,email="pracheer@gmail.com",age=40},
                   new Phone { id= 4,name="Vishnu",phone=984347556,email="Vishnu@gmail.com",age=26},
                   new Phone { id= 5,name="Akhil", phone=584312378,email="Akhil@gmail.com",age=25},
                   new Phone { id= 6,name="Jais",  phone=984316788,email="jais@gmail.com",age=24},
                   new Phone { id= 7,name="Nishant",  phone=854314758,email="Nishant@gmail.com",age=34},
                   new Phone { id= 8,name="Luvesh",phone=738313683,email="luvesh@gmail.com",age=30},
                   new Phone { id= 9,name="Suresh",  phone=5347476,email="yadav@gmail.com",age=26},
                   new Phone { id= 10,name="Mahesh" ,phone=513676362,email="mahesh@gmail.com",age=26},


            };

            string json = JsonConvert.SerializeObject(list.ToArray());
                var dir = @"D:\log";

            if(!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

            File.WriteAllText(Path.Combine(dir,"vinod.json"),json);

           // System.IO.File.WriteAllText(@"C:\Users\RS Vinod Kumar\Desktop\vinod.json", json);
            dynamic array = JsonConvert.DeserializeObject(json);

            foreach (var a in array)
            {
                Console.WriteLine(a);
            }
            foreach (var a in array)
            {
                Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
            }
            bool z = true;
            while (z)
            {
                Console.WriteLine("Enter choice:");
                Console.WriteLine("press 1 for Adding New Data");
                Console.WriteLine("Press 2 for Deleting Data");
                Console.WriteLine("Press 3 for Updating Data");
                Console.WriteLine("Press 4 for Sorting Data");
                Console.WriteLine("press 5 for Displaying All data");
                Console.WriteLine("press 6 for Exit");
               
                int choice = Convert.ToInt32(Console.ReadLine());
                

                switch (choice)
                {
                    case 1:

                        Phone t = new Phone();
                        Console.WriteLine("Enter id");
                        t.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        t.name = Console.ReadLine();
                        Console.WriteLine("Enter phone");
                        t.phone = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Email");
                        t.email = Console.ReadLine();
                        Console.WriteLine("Enter Age");
                        t.age = Convert.ToInt32(Console.ReadLine());
                        list.Add(t);



                        string json1 = JsonConvert.SerializeObject(list.ToArray());
                        System.IO.File.WriteAllText(@"D:\log\vinod.json", json1);
                        dynamic array1 = JsonConvert.DeserializeObject(json1);

                        foreach (var a in array1)
                        {
                            Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                        }

                        break;


                    case 2:
                        Console.WriteLine("Enter the id you want to Delete:");
                        var delete = Convert.ToInt32(Console.ReadLine());
                        var del = list.Where(sa => sa.id == delete).ToList();
                        foreach (var b in del)
                        {
                            list.Remove(b);
                        }
                        foreach (var a in list)
                        {
                            Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                        }
                        string json2 = JsonConvert.SerializeObject(list.ToArray());
                        System.IO.File.WriteAllText(@"D:\log\vinod.json", json2);
                        Console.ReadKey();
                        break;


                    case 3:
                        Console.WriteLine("Enter the id which wants to update:");
                        var search1 = Convert.ToInt32(Console.ReadLine());
                        
                        foreach (var a in list)
                        {
                            if (string.Equals(search1, a.id))
                            {
                                Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                                Console.WriteLine("What do you want to update?");
                                Console.WriteLine("1.id");
                                Console.WriteLine("2.name");
                                Console.WriteLine("3.phone");
                                Console.WriteLine("4.email");
                                Console.WriteLine("5.age");

                                int choice1 = Convert.ToInt32(Console.ReadLine());

                                if (choice1 == 1)
                                {
                                    Console.WriteLine("enter new value");
                                    var j = Convert.ToInt32(Console.ReadLine());
                                    a.id = j;
                                    Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);


                                }
                                else if (choice1 == 2)
                                {
                                    Console.WriteLine("enter new value");
                                    var l = Console.ReadLine();
                                    a.name = l;
                                    Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                                }
                                else if (choice1 == 3)
                                {
                                    Console.WriteLine("enter new value");
                                    int o = Convert.ToInt32(Console.ReadLine());
                                    a.phone = o;
                                    Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                                }
                                else if (choice1 == 4)
                                {
                                    Console.WriteLine("enter new value");
                                    string x = Console.ReadLine();
                                    a.email = x;
                                    Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                                }
                                else if (choice1 == 4)
                                {
                                    Console.WriteLine("enter new value");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    a.age = x;
                                    Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                                }

                            }
                        }

                        Console.WriteLine("final list");

                        foreach (var a in list)
                        {
                            Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                        }
                        string json3 = JsonConvert.SerializeObject(list.ToArray());
                        System.IO.File.WriteAllText(@"D:\log\vinod.json", json3);
                        Console.ReadKey();

                        break;

                    case 4:

                        Console.WriteLine("1.In Ascending");
                        Console.WriteLine("2.In Descending");

                        int choice3 = Convert.ToInt32(Console.ReadLine());
                        if (choice3 == 1)
                        {
                            var sortedDoubles =
                                from w in list
                                orderby w.age ascending
                                select w;


                            Console.WriteLine("List in Ascending order");
                            foreach (var a in sortedDoubles)
                            {
                                Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                            }
                        }
                        else
                        {
                            var sortedDoubles =
                            from w in list
                            orderby w.age descending
                            select w;


                            Console.WriteLine("List in descending order");
                            foreach (var a in sortedDoubles)
                            {
                                Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Displaying all elements:");
                        foreach (var a in list)
                        {
                            Console.WriteLine(a.id + " " + a.name + " " + a.phone + " " + a.email + " " + a.age);
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        z = false;
                        break;
                    default:
                        Console.WriteLine("Enter Correct choice:");
                        break;
                }



            }
        }

            public void LoadJson()
        {
            using (StreamReader r = new StreamReader(@"D:\log\vinod.json"))
            {
                string json = r.ReadToEnd();
                List<Item> item = JsonConvert.DeserializeObject<List<Item>>(json);
            }


        }

    }
}
