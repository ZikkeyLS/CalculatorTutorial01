
public class Program
{
    private static void Main()
    {
        int numberCount = 0;
        float[] numbers = new float[0];
        float result = 0;

        while (true)
        {
            Console.Write("Введите количество аргументов: ");
            numberCount = int.Parse(Console.ReadLine());

            numbers = new float[numberCount];
            for (int i = 0; i < numberCount; i++)
            {
                Console.Write($"Введите число {i + 1}: ");

                if (float.TryParse(Console.ReadLine(), out numbers[i]) == false)
                {
                    Console.WriteLine("Введено некорректное значение!");
                    i--;
                }
            }

            result = numbers[0];

            Console.Write("Введите операцию над числами: ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    for (int i = 1; i < numbers.Length; i++)
                        result += numbers[i];
                    break;
                case "-":
                    for (int i = 1; i < numbers.Length; i++)
                        result -= numbers[i];
                    break;
                case "*":
                    for (int i = 1; i < numbers.Length; i++)
                        if (numbers[i] == 0)
                        {
                            result = 0;
                            break;
                        }
                        else
                            result *= numbers[i];
                    break;
                case "/":
                    for (int i = 1; i < numbers.Length; i++)
                        if (numbers[i] == 0)
                        {
                            Console.WriteLine("Деление на ноль! Программа вернёт результат - 0.");
                            result = 0;
                            break;
                        }
                        else
                            result /= numbers[i];
                    break;
                default:
                    Console.WriteLine("Неизвестный оператор!");
                    result = 0;
                    break;
            }

            Console.WriteLine($"Ответ: {result}");
        }
    }
}
