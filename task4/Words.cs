namespace task4;
/*
 * Створіть колекцію, в яку можна записувати два значення одного слова,
 * на кшталт російсько-англо-українського словника. І в ній можна для
 * українського слова знайти або лише російське значення, або лише
 * англійське та вивести його на екран.
 */
public class Words
{
     public string Uk { get; set; }
     public string Ru { get; set; }
     public string En { get; set; }

     private Words(string uk,string ru,string en)
     {
         Uk = uk;
         Ru = ru;
         En = en;
     }

     public static Words AddWord(string uk, string ru, string en)
     {
         return new Words(uk,ru,en);
     }
}