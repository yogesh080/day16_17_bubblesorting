namespace BubbleSort_Day16_17
{
    class Program
    {
        public int[] numarr;
        public Program()
        {
            numarr = new int[] { 87, 45, 7, 76, 46, 34, 85, 89, 32 };
        }


        public static void Main(string[] args)
        {
            Program program = new Program();
            
            program.BubbleSort(program.numarr);
            Console.WriteLine("Array after Bubble Sort: ");
            program.Display();

        }

        public void BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }

        public void Display()
        {

            foreach (int i in numarr)
            {
                Console.WriteLine(i);
            }

        }

    }
}