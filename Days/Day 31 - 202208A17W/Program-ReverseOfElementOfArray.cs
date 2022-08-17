        static void ReadArray(short[] dataList, int size)
        {
            //Read numbers 
            for (int k = 0; k < size; k++)
            {
                Console.Write("Enter the number at " + k + ":");
                dataList[k] = short.Parse(Console.ReadLine());
            }
        }
        static void PrintArray(short[] dataList, int size)
        {
            //Print numbers
            foreach (short value in dataList)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
        }
        static short ReverseNumber(short num)
        {
            short rev = 0;
            while(num > 0)
            {
                short digit = (short)(num % 10);
                rev = (short)((rev * 10) + digit);
                num /= 10;
            }
            return rev;
        }
        static void ReverseElementOfArray(short[] dataList, int size, short[] reversed)
        {
            for (int k = 0; k < size; k++) 
            {
                short element = dataList[k];
                short rev = ReverseNumber(element);
                reversed[k] = rev;
            }
        }
        static void SortArray(short[] dataList, int size)
        {
            //Sort salaries ascending order 
            //size = 5,salary = 10,20,28,30,15,sorted salary = 10,15,20,28,30
            for (int i = 0; i < (size - 1); i++)//select element
            {
                for (int j = i + 1; j < size; j++)//next elements
                {
                    if (dataList[j] < dataList[i])// next element < selected element
                    {
                        //swap next element and selected element
                        short temp = dataList[i];
                        dataList[i] = dataList[j];
                        dataList[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number of numbers:");
            int N = int.Parse(Console.ReadLine());

            short[] numbers = new short[N];
            short[] reversedNumbers = new short[N];

            ReadArray(numbers, N);
            ReverseElementOfArray(numbers, N, reversedNumbers);
            Console.Write("The given array is ");
            PrintArray(numbers, N);
            Console.Write("The reverse of element of array is ");
            PrintArray(reversedNumbers, N);
            SortArray(reversedNumbers, N);
            Console.Write("The sorted reversed numbers of array is ");
            PrintArray(reversedNumbers, N);


            Console.Read();
        }
    }