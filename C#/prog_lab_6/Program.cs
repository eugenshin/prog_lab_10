using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                segments sm = new segments(101);
                Console.WriteLine("Объект успешно создан");
                sm.totalvivod();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка. Объект не был создан");
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}