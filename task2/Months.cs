using System.Collections;

namespace task2;
/*
 * Створіть колекцію, в якій зберігалися б найменування 12 місяців,
 * порядковий номер і кількість днів у відповідному місяці. Реалізуйте
 * можливість вибору місяців як за порядковим номером, так і кількістю
 * днів у місяці, при цьому результатом може бути не тільки один місяць.
 */
public class Months
{
    public string MonthsName { get; set; }
    public int NomberMonths { get; set; }
    public int Dey { get; set; }
    


    public override string ToString()
    {
        string line;
        line = $"Місяць:{this.MonthsName} номер місяця:{this.NomberMonths} кількість:{this.Dey}";
        return line;
    }
}