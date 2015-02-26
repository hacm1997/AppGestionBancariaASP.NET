using System;


namespace AppGestionBnacaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Object o =new Object();
            Cuentas p = new Cuentas();
            Console.WriteLine(p.GetHashCode());
            
            Console.ReadLine();
        }
    }
}
