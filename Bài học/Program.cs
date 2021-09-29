using System

namespace Bài_học
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Endcoding.Unicode
            Console.InputEncoding = Endcoding.Unicode
            string chuỗi = "Vac xin tiem som nhat tot nhat"
            Console.WriteLine(chuỗi)
            string[] Taphopchuoi = chuỗi.Split(' ')
            foreach(string S in Taphopchuoi)
            {
                Console.WriteLine(S)
            }
            Console.WriteLine(chuỗi.Contains("tiêm"))
            Console.WriteLine(chuỗi.EndsWith("nhất"))
            Console.WriteLine(chuỗi.Trim())
            Console.ReadLine()
        }
    }
}
