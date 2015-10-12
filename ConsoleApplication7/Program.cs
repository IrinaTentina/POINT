using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class market
    {
        public int n; // число покупателей конкретного товара на рынке при определенных условиях, ед.
        public int k; //количество покупок среднего потребителя за некоторый период (за год), ед. в год
        public int p; // средняя цена за единицу товара, руб
        public int Q; // итоговый показатель - рыночный потенциал спроса

        static void Main(string[] args)
        {
            Console.WriteLine("Введите показатели:");
            Console.WriteLine("Число покупателей Вашего веб-сервиса за год:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число покупок Вашего веб-сервиса за год:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Средняя цена Вашего веб-сервиса:");
            int p = Convert.ToInt32(Console.ReadLine());



        }
    }
}
