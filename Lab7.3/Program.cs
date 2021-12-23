using System;

namespace rabots7._3
{
    class Program
    {

        //7.3 - базовый уровень 8 вариант

        struct Sale //создали структуры 
        {
            public string seller;
            public string name;
            public int number;
            public double price;
            public string dateOfSale;

        }

        static void Main(string[] args)
        {
            //ввести данные


            Sale[] sale = new Sale[3];      
            

            //создаем интерфейс для ввода данных
            for (int i = 0; i < sale.Length; i++)
            {
                int max = 0;
                int k = 0;


                Console.Write("Введите фамилию продавца: ");
                sale[i].seller = Console.ReadLine();
                Console.WriteLine("Введите наименование товара: ");
                sale[i].name = Console.ReadLine();
                Console.WriteLine("Введите количество: ");
                sale[i].number = int.Parse(Console.ReadLine());
                Console.Write("Введите стоимость:");
                sale[i].price = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите дату продажи: ");
                Console.Write("Введите год:");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Введите месяц:");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Введите день:");
                int d = int.Parse(Console.ReadLine());
                if (sale[i].seller == "Иванов")
                {
                    k++;
                }
                else
                    Console.WriteLine("Такого продавца нет");
                if (sale[i].price > sale[max].price)
                {
                    max = i;
                }

            }
           
            Console.WriteLine("Количество товаров, проданных продавцом Иванов:", );
            Console.WriteLine("Товар с максимальной стоимостью:", );


        }
    }
}