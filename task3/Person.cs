namespace task3;
/*
   * Створіть колекцію, яка б за своєю структурою нагадувала «родове дерево»
   * (ім'я людини, рік народження), причому до неї можна додавати/вилучати
   * нового родича, є можливість побачити всіх спадкоємців обраної людини,
   * відібрати родичів за роком народження. 
*/

public class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
    public List<Person> Children { get; set; } = new List<Person>();

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public void AddDescendant(Person person)
    {
        this.Children.Add(person);
    }

    public void RemoveDescendant(Person person)
    {
        this.Children.Remove(person);
    }

    public  List<Person> GetDescendants()
    {
        List<Person> desten = new List<Person>();
         foreach (var chaild in Children )
        {
            desten.Add(chaild);
            desten.AddRange(chaild.GetDescendants());
        }

        return desten;
    }
    
    public List<Person> GetRelativesByYearOfBirth(int yearOfBirth)
    {
        List<Person> relatives = new List<Person>();
        if (YearOfBirth == yearOfBirth)
        {
            relatives.Add(this);
        }
        foreach (var child in Children)
        {
            relatives.AddRange(child.GetRelativesByYearOfBirth(yearOfBirth));
        }
        return relatives;
    }
    
}

public class FamilyTree
{
    public Person Root { get; set; }

    public FamilyTree(Person root)
    {
        Root = root;
    }

    public List<Person> FindRelativesByYearOfBirth(int yearOfBirth)
    {
        return Root.GetRelativesByYearOfBirth(yearOfBirth);
    }

    public List<Person> GetDescendantsOf(string name)
    {
        Person person = FindPersonByName(Root, name);
        return person != null ? person.GetDescendants() : new List<Person>();
    }

    private Person FindPersonByName(Person current, string name)
    {
        if (current.Name == name)
        {
            return current;
        }
        foreach (var child in current.Children)
        {
            Person found = FindPersonByName(child, name);
            if (found != null)
            {
                return found;
            }
        }
        return null;
    }
}