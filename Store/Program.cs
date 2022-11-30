using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Store st = new Store("Шаражка", "Стромынка 20");
            Audio au1 = new Audio("Честер Беннингтон", "школа Агура", 100, "Numb", "Rock");
            Audio au2 = new Audio("TF", "Sony", 40, "My Life", "Rap");
            DVD dv1 = new DVD("Дима", "ДимаПикчерс", 1234321, "Алгосы", "Хоррор");
            DVD dv2 = new DVD("Гай Ричи", "Metro-Goldwyn-Mayer-Miramax", 120, "Гнев человеческий", "Триллер");
            List<Audio> audios = st + au1;
            audios = st + au2;
            List<DVD> dvds = st + dv1;
            dvds = st + dv2;
            Console.WriteLine(st.ToString()); 
            dv1.Burn("Ваня", "Гений");
            Console.WriteLine(dv1.ToString());
            Console.ReadKey();
        }
    }
}

