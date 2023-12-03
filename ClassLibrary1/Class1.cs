namespace ClassLibrary1;

public class Class1 {
    
    static double CalculateAverage(int a, int b) { 
        double average = (a + b) / 2.0;

        return average;
    }
    static double MaxNumber(int[] arr,int size) { 
        int max = arr[0];

        for (int i = 0; i < size; i++) {
            if (max < arr[i]) {
                max = arr[i];
            }
        }

        return max;
    }
    public static void Main() {   
        Console.Write("Введіть 1 число: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введіть 2 число: ");
        int b = int.Parse(Console.ReadLine());
        
        Console.Write("Введіть розмір масиву: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        for (int i = 0; i < size; i++) {
            Console.Write($"Введіть елемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine(CalculateAverage(a, b));
        Console.WriteLine(MaxNumber(array, size));
    }
}