using System;
using System.Text.RegularExpressions;

namespace ProgramacionIntermedia.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador ternario*/
            int RandomNumber = new Random().Next(0, 1000);

            string result = RandomNumber > 500 ? "greater than 500" : "less than 500";

            Console.WriteLine($"The number {RandomNumber} is {result}");

            /*Nulleable*/
            int? NullValue = null;

            try
            {
                var aux = NullValue != null ? "Valor valido" : throw new NulleableException();

            }
            catch (NulleableException e)
            {
                Console.WriteLine(e.Message);
            }

            /*Anonimo y dinamico*/
            var People = new { Name = "Alex", Age = 18 };
            Console.WriteLine($"Nombre: {People.Name}, edad: {People.Age}");

            dynamic DynamicVar = 17;
            Console.WriteLine(DynamicVar);

            DynamicVar = "Chuleta";
            Console.WriteLine(DynamicVar);

            DynamicVar = new { Marca = "HP", Modelo = "Pavilion", Precio = 12000 };
            Console.WriteLine($"Marca: {DynamicVar.Marca}, modelo: {DynamicVar.Modelo}, precio: {DynamicVar.Precio}");

            /*Generics*/
            Map<Pair> MyMap = new();

            MyPairs myPairs = new MyPairs("uno", 45);


            MyMap.Put(0, myPairs);

            var helper = MyMap.GetAt(0);
            Console.WriteLine($"{helper.Value} y { helper.Key }");

            try
            {
                var helper2 = MyMap.Get("DOS");
                Console.WriteLine(helper2.Value);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            /*Extension methods*/
            Console.WriteLine($"{MyMap.GetFirstValueExtension().Key} y {MyMap.GetFirstValueExtension().Value}");

            /*Regex*/
            string validator = "Mess0007";
            Console.WriteLine(validator.Validation());

        }

        public class  MyPairs : Pair
        {
            public MyPairs(string key, dynamic value)
            {
                Key = key;
                Value = value;
            }
        }
    }

    public static class StringEtension
    {
        public static bool Validation(this string value)
        {
            string validation = value;

            if (Regex.IsMatch(value, @"^[A-Z][a-z]{3}\d{4}"))
            {
                return true;
            }
            return false;
        }
    }
}
