namespace ClassLibrary1;

public class Class1 {
    public static void Main() {   
        Console.Write("Введіть розмір масиву: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        for (int i = 0; i < size; i++) {
            Console.Write($"Введіть елемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int positives = 0, evens = 0;

        foreach (var element in array) {
            if (element > 0) {
                positives += element;
            }

            if (element % 2 == 0) {
                evens++;
            }
        }

        Console.WriteLine($"Сума додатних елементів: {positives}. Кількість парних елементів: {evens}");
    }
}