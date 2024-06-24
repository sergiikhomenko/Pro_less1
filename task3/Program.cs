namespace task3;
/*
 * Створіть колекцію, яка б за своєю структурою нагадувала «родове дерево»
 * (ім'я людини, рік народження), причому до неї можна додавати/вилучати
 * нового родича, є можливість побачити всіх спадкоємців обраної людини,
 * відібрати родичів за роком народження. 
 */
class Program
{
    static void Main(string[] args)
    {
        Person grandparent = new Person("Олексій", 1945);
        Person parent1 = new Person("Марія", 1970);
        Person parent2 = new Person("Іван", 1972);
        Person child1 = new Person("Анна", 1995);
        Person child2 = new Person("Петро", 2000);

        grandparent.AddDescendant(parent1);
        grandparent.AddDescendant(parent2);
        parent1.AddDescendant(child1);
        parent1.AddDescendant(child2);

        FamilyTree familyTree = new FamilyTree(grandparent);

        Console.WriteLine("Всі спадкоємці Олексія:");
        List<Person> descendants = familyTree.GetDescendantsOf("Олексій");
        foreach (var descendant in descendants)
        {
            Console.WriteLine($"{descendant.Name} ({descendant.YearOfBirth})");
        }

        Console.WriteLine("\nРодичі, народжені в 1970 році:");
        List<Person> relativesByYear = familyTree.FindRelativesByYearOfBirth(1970);
        foreach (var relative in relativesByYear)
        {
            Console.WriteLine($"{relative.Name} ({relative.YearOfBirth})");
        }
    }
}