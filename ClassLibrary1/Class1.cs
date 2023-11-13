namespace ClassLibrary1;

public class Class1 {
    public static void Main() {   
        Console.Write("Введіть кількість зошитів: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть ціну одного зошита: ");
        double notebookPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість ручок: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть ціну однієї ручки: ");
        double penPrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Загальна сума покупки: {(x * notebookPrice) + (y * penPrice)} гривень");
    }
}