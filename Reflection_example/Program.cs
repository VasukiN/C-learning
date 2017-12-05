using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflection_example
{
    public class mainclass
    {
        private static void Main()
        {
            Type t = Type.GetType("Reflection_example.Customers");
            Console.WriteLine("Jsut the name: {0}", t.FullName);
            Console.WriteLine("Jsut the namespace: {0}", t.Namespace);
            Console.WriteLine();
            Console.WriteLine("-------------Property Info----------------");
            PropertyInfo[] Properties = t.GetProperties();
            foreach (PropertyInfo Property in Properties)
            {
                Console.WriteLine(Property.Name + " " + Property.PropertyType.Name);

            }
            Console.WriteLine("-------------Method Info----------------");
            MethodInfo[] Methods = t.GetMethods();
            foreach (MethodInfo Method in Methods)
            {
                Console.WriteLine(Method.Name + " " + Method.ReturnType.Name);

            }
            Console.WriteLine("-------------Constructor Info----------------");
            ConstructorInfo[] Constructors = t.GetConstructors();
            foreach (ConstructorInfo Constructor in Constructors)
            {
                Console.WriteLine(Constructor.Name + " " + Constructor.Attributes + "" +Constructor.GetType() + " " +Constructor.ToString());

            }
            Console.ReadLine();


        }
    }
    class Customers
    {
        public string name;
        public int id;
        public Customers()
        {
            this.id++;

            this.name = null;
        }
        public Customers(int _id, string _name)
        {
            _id = id;
            _name = name;
        }
        public void printmethod()
        {
            Console.WriteLine("Name and Id are :", name, id);
        }
        public void Name()
        {
            Console.WriteLine("Names are suggested above are belongs to class1");
        }
    }
      
    }

