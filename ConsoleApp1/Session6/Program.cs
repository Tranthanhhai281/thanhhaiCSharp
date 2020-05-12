using System;

namespace ConsoleApp1.Session6
{
    // khai bao 1 delegate tra ve int va co 2 
    public delegate int IntegerToInteger(int a, int b);
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // tao 1 doi tuong delegate 
            IntegerToInteger ii = new IntegerToInteger(Calculator.Add); // tham chieu den o nho cua ham 
            ii += Calculator.Subtract; // nap them ham vao chuoi thuc hien cua delegate
            ii +=new Calculator().division;

            int a = ii(5, 2); // thuc thi cac ham duoc nap vao delegate
            Console.WriteLine("a= " + a);
            
            // Calculator.Add(2, 5);
            //Calculator.Subtract(2, 5);
            // // luon luon can chay 2 dong voi moi cap

            TaxMoney tm = TaxCalc.GetTax("VN"); // tm la 1 delagate
            float tax = tm(100000000);
            Console.WriteLine("Thue phai nop: " + tax);
            
            // Tao 1 ham an danh bang delegate
            TaxMoney tm2 = delegate(float salary) { return salary * 40 / 100; };
            float frTax = tm2(10000);
            Console.WriteLine("Thue tai Phap: "+frTax);
        } 
     }
}