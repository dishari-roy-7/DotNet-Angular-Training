// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] name = { "Anil", "Sharma", "Abdullah", "Imran", "Siva", "Naresh", "Suresh", "Suman" };
            //UsingLinq(name);
            //UsingLINQExtensions(name);
            //UsingLINQFunctions(name);
            //UsingAnonymousMethods(name);
            LINQReadXML();
            LINQtoXMLAddNode();
            LINQtoXMLDeleteNode();
        }

        /*
          //Method 1
        private static void UsingLinq(string[] name)
        {
            IEnumerable<string> query = from s in name //for loop
                                        where s.Length == 5
                                        orderby s
                                        select s.ToUpper();
            //select * from name
            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
           // Console.Read();
        }
        
        //Method 2
        private static void UsingLINQExtensions(string[] name)
        {
            IEnumerable<string> query = name
                                      .Where(s => s.Length == 5)
                                      .OrderBy(s => s)
                                      .Select(s => s.ToUpper());
            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
        } 
        
        //Method 3
        private static void UsingLINQFunctions(string[] name)
        {
            Func<string, bool> filter = s => s.Length == 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToUpper(); //imran->IMRAN

            IEnumerable<string> query = name.Where(filter)
                                            .OrderBy(extract)
                                            .Select(project);
            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
        }
        
        //Method 4
        private static void UsingAnonymousMethods(string[] name)
        {
            Func<string, bool> filter = delegate (string s)
            {
                return s.Length == 5;
            };
            Func<string, string> extract = delegate (string s)
            {
                return s;
            };
            Func<string, string> project = delegate (string s)
            {
                return s.ToUpper();
            };
            IEnumerable<string> query = name.Where(filter)
                                           .OrderBy(extract)
                                           .Select(project);
            foreach(string s in query) { 
                Console.WriteLine(s);
            }
        */
        //LINQ to XML
        private static void LINQReadXML()
        {
            string myXML = @"<Departments>
                           <Department>Account</Department>
                           <Department>Sales</Department>
                           <Department>Pre-Sales</Department>
                           <Department>Marketing</Department>
                           </Departments>";
            XDocument xdoc = new XDocument();
            xdoc=XDocument.Parse(myXML);

            var result = xdoc.Element("Departments").Descendants();
            foreach(XElement item in result)
            {
                Console.WriteLine("Department Name: "+item.Value);
            }
            Console.WriteLine("Press any key to continue");
        }
        
        //Add new node
        private static void LINQtoXMLAddNode()
        {
            string myXML = @"<Departments>
                           <Department>Account</Department>
                           <Department>Sales</Department>
                           <Department>Pre-Sales</Department>
                           <Department>Marketing</Department>
                           </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Add new element
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            //Add new element at first
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name: " + item.Value);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        
        //Delete a node
        private static void LINQtoXMLDeleteNode()
        {
            string myXML = @"<Departments>
                           <Department>Account</Department>
                           <Department>Sales</Department>
                           <Department>Pre-Sales</Department>
                           <Department>Marketing</Department>
                           </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Remove Sales Department
            xdoc.Descendants().Where(s=> s.Value == "Sales").Remove();
            
            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name: " + item.Value);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}

