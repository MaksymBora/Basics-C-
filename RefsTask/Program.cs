// namespace RefsTask
// {
//     class Program
//     {
//         static void Resize<T>(ref T[] arr, int newSize)
//         {
//             T[] newArray = new T[newSize];
//
//             for (int i = 0; i < arr.Length && i < newArray.Length; i++)
//                 newArray[i] = arr[i];
//             
//             arr = newArray;
//         }
//
//         static void Main(string[] args)
//         {
//             // int[] arr = { 1, 4, 6 };
//             string[] arr = { "fsf", "fsdf", "fsd" };
//
//             Resize(ref arr, 10);
//         }
//     }
// }

// namespace RefsTask
// {
//     class Program
//     {
//         static void Insert(ref int[] array, int value, int index)
//         {
//             int[] newArray = new int [array.Length + 1];
//             newArray[index] = value;
//
//             for (int i = 0; i < index; i++)
//                 newArray[i] = array[i];
//             
//
//             for (int i = index; i < array.Length; i++)
//                 newArray[i + 1] = array[i];
//
//             array = newArray;
//         }
//
//         static void AddFirst(ref int[] array, int value)
//         {
//             Insert(ref array, value, 0);
//         }
//         
//         static void AddLast(ref int[] array, int value)
//         {
//             Insert(ref array, value, array.Length);
//         }
//
//         static void Main(string[] args)
//         {
//             int[] myArray = { 1, 4, 6, 2 };
//             
//             // Insert(ref myArray, -5, 2);
//             
//             // AddFirst(ref myArray, -5);
//             
//             AddLast(ref myArray, -5);
//         }
//     }



namespace RefsTask
{
    class Program
    {
        static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }

        static void RemoveFirst(ref int[] array)
        {
            RemoveAt(ref array, 0);
        }
        
        static void RemoveLast(ref int[] array)
        {
            RemoveAt(ref array, array.Length -1);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6, 2 };
            
           // RemoveAt(ref myArray, 2);
           RemoveFirst(ref myArray);
           // RemoveLast(ref myArray);
        }
    }
}