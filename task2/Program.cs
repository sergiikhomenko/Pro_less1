namespace task2;
/*
 * Створіть колекцію, в якій зберігалися б найменування 12 місяців,
 * порядковий номер і кількість днів у відповідному місяці. Реалізуйте
 * можливість вибору місяців як за порядковим номером, так і кількістю
 * днів у місяці, при цьому результатом може бути не тільки один місяць.
 */
class Program
{
    static void Main(string[] args)
    {
        List<Months> monthsList = new List<Months>
        {
            new Months { MonthsName = "Січень", NomberMonths = 1, Dey = 31 },
            new Months { MonthsName = "Лютий", NomberMonths = 2, Dey = 28 },
            new Months { MonthsName = "Березень", NomberMonths = 3, Dey = 31 },
            new Months { MonthsName = "Квітень", NomberMonths = 4, Dey = 30 },
            new Months { MonthsName = "Травень", NomberMonths = 5, Dey = 31 },
            new Months { MonthsName = "Червень", NomberMonths = 6, Dey = 30 },
            new Months { MonthsName = "Липень", NomberMonths = 7, Dey = 31 },
            new Months { MonthsName = "Серпень", NomberMonths = 8, Dey = 31 },
            new Months { MonthsName = "Вересень", NomberMonths = 9, Dey = 30 },
            new Months { MonthsName = "Жовтень", NomberMonths = 10, Dey = 31 },
            new Months { MonthsName = "Листопад", NomberMonths = 11, Dey = 30 },
            new Months { MonthsName = "Грудень", NomberMonths = 12, Dey = 31 }
        };
        Console.WriteLine("nomber");
        Int32.TryParse(Console.ReadLine(), out int nomber);
        Console.WriteLine(FindToNomber(monthsList, nomber).ToString());

        Console.WriteLine("dey");
        Int32.TryParse(Console.ReadLine(), out int dey);
        foreach (var mount in FindToDeys(monthsList,dey))
        {
            Console.WriteLine(mount);
        }
        
        
    }
    public static Months FindToNomber(List<Months> monthsList, int nomber)
    {
        Months ms=null;
        var qvery = from mounth in monthsList
            where mounth.NomberMonths == nomber
            select new Months { Dey = mounth.Dey, MonthsName = mounth.MonthsName, NomberMonths = mounth.NomberMonths };
        foreach (var res in qvery )
        {
            ms= res;
        }
        return ms;
    }
    public static List<Months>FindToDeys(List<Months> monthsList,int deyOfMonth)
    {
        
        var qvery = from mount in monthsList
            where mount.Dey == deyOfMonth 
            select
                new Months { Dey = mount.Dey, MonthsName = mount.MonthsName, NomberMonths = mount.NomberMonths };
        return qvery.ToList();
    }
}