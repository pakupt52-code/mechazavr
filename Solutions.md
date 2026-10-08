# Готовые решения практических работ по теме «Массивы в C#»

---

## ЧАСТЬ 1: Практическая работа «Алгоритмы поиска в массиве»

### Задание 1: Линейный поиск (5 баллов)
**Условие:** Считай размер массива `n`, сами элементы массива и число `key`. Найди `key` линейным поиском. Если элемент найден, выведи его индекс, иначе выведи «Не найден».

```csharp
using System;

class Task1_LinearSearch
{
    static void Main()
    {
        // 1. Считывание размера массива
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine()!);

        // 2. Считывание элементов массива
        Console.Write("Введите элементы массива через пробел: ");
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(input[i]);
        }

        // 3. Считывание искомого ключа
        Console.Write("Введите key: ");
        int key = int.Parse(Console.ReadLine()!);

        // 4. Линейный поиск
        int foundIndex = -1;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == key)
            {
                foundIndex = i; // Сохраняем индекс первого совпадения
                break;
            }
        }

        // 5. Вывод результата
        if (foundIndex != -1)
        {
            Console.WriteLine(foundIndex);
        }
        else
        {
            Console.WriteLine("Не найден");
        }
    }
}
```

---

### Задание 2: Метод линейного поиска (5 баллов)
**Условие:** Реализуй метод `static int LinearSearch(int[] a, int key)`, который возвращает индекс элемента или `-1`, если элемент не найден. В `Main` считай данные, вызови данный метод и выведи индекс или сообщение «Не найден».

```csharp
using System;

class Task2_LinearSearchMethod
{
    // Метод линейного поиска: возвращает индекс элемента или -1
    static int LinearSearch(int[] a, int key)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == key)
            {
                return i; // Возвращаем индекс при совпадении
            }
        }
        return -1; // Возвращаем -1, если элемент не найден
    }

    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Введите элементы массива через пробел: ");
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(input[i]);
        }

        Console.Write("Введите key: ");
        int key = int.Parse(Console.ReadLine()!);

        // Вызов метода линейного поиска
        int index = LinearSearch(a, key);

        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("Не найден");
        }
    }
}
```

---

### Задание 3: Бинарный поиск (5 баллов)
**Условие:** Считай отсортированный по возрастанию массив и число `key`. Реализуй алгоритм бинарного поиска. Выведи индекс элемента или «Не найден». *(Массив передается отсортированным).*

```csharp
using System;

class Task3_BinarySearch
{
    // Метод бинарного поиска в отсортированном массиве
    static int BinarySearch(int[] a, int key)
    {
        int left = 0;
        int right = a.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; // Вычисление среднего индекса

            if (a[mid] == key)
            {
                return mid; // Элемент найден
            }

            if (a[mid] < key)
            {
                left = mid + 1; // Ищем в правой половине
            }
            else
            {
                right = mid - 1; // Ищем в левой половине
            }
        }

        return -1; // Элемент не найден
    }

    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Введите отсортированные элементы массива через пробел: ");
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(input[i]);
        }

        Console.Write("Введите key: ");
        int key = int.Parse(Console.ReadLine()!);

        int index = BinarySearch(a, key);

        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("Не найден");
        }
    }
}
```

---

### Задание 4: Подсчёт количества вхождений (5 баллов)
**Условие:** Считай массив и число `key`. Подсчитай линейным проходом, сколько раз `key` встречается в массиве. Выведи количество.

```csharp
using System;

class Task4_CountOccurrences
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Введите элементы массива через пробел: ");
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(input[i]);
        }

        Console.Write("Введите key: ");
        int key = int.Parse(Console.ReadLine()!);

        // Подсчет количества вхождений линейным проходом
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == key)
            {
                count++; // Увеличиваем счетчик при каждом совпадении
            }
        }

        Console.WriteLine(count);
    }
}
```

---

## ЧАСТЬ 2: Практическая работа «Сортировка массивов»

### Задание 1: Сортировка по возрастанию (5 баллов)
**Условие:** Считай размер массива `n` и его элементы. Отсортируйте массив пузырьковой сортировкой по возрастанию и выведите результат через пробел.

```csharp
using System;

class Task1_BubbleSortAscending
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Введите элементы массива через пробел: ");
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(input[i]);
        }

        // Пузырьковая сортировка по возрастанию
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Если текущий элемент больше следующего, меняем их местами
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        // Вывод отсортированного массива
        Console.WriteLine(string.Join(" ", a));
    }
}
```

---

### Задание 2: Сортировка по убыванию (5 баллов)
**Условие:** Считай массив и отсортируй его по убыванию (от большего к меньшему), изменив условие сравнения элементов. Выведи результат.

```csharp
using System;

class Task2_BubbleSortDescending
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Введите элементы массива через пробел: ");
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(input[i]);
        }

        // Пузырьковая сортировка по убыванию
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Измененное условие: если текущий элемент меньше следующего, меняем их местами
                if (a[j] < a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        // Вывод результатов
        Console.WriteLine(string.Join(" ", a));
    }
}
```

---

### Задание 3: Сортировка + вывод минимального и максимального (5 баллов)
**Условие:** Считай массив, отсортируй его по возрастанию. После сортировки выведи отсортированный массив, минимальный элемент (`a[0]`) и максимальный элемент (`a[n-1]`).

```csharp
using System;

class Task3_SortWithMinMax
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Введите элементы массива через пробел: ");
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(input[i]);
        }

        // Сортировка пузырьком по возрастанию
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        // Минимальный элемент — первый, максимальный — последний
        int min = a[0];
        int max = a[n - 1];

        // Вывод результатов
        Console.WriteLine("Массив: " + string.Join(" ", a));
        Console.WriteLine("Мин: " + min);
        Console.WriteLine("Макс: " + max);
    }
}
```

---

### Задание 4: Метод сортировки (5 баллов)
**Условие:** Оформи пузырьковую сортировку в виде отдельного метода `static void BubbleSort(int[] a)`. В `Main` считай массив, вызови метод и выведи отсортированный массив.

```csharp
using System;

class Task4_BubbleSortMethod
{
    // Метод пузырьковой сортировки по возрастанию
    static void BubbleSort(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    // Обмен элементами через временную переменную temp
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Введите элементы массива через пробел: ");
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(input[i]);
        }

        // Вызов метода сортировки
        BubbleSort(a);

        // Вывод отсортированного массива
        Console.WriteLine(string.Join(" ", a));
    }
}
```
