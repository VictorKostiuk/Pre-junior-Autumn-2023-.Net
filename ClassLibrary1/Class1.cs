namespace ClassLibrary1;

public class Class1 {
    public static void Main() {   
        Console.Write("Введіть число A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введіть число B: ");
        int B = int.Parse(Console.ReadLine());

        if (A <= B)
        {
            Console.WriteLine("Помилка: A повинно бути більше за B.");
            return;
        }

        Console.WriteLine("Числа від A до B:");
        for (int i = A; i >= B; i--)
        {
            Console.WriteLine(i);
        }
    }
}