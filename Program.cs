using DataStructuresRefresher;

//MyArray array = new MyArray(3);
//Console.WriteLine(array.Get(2));
//Console.WriteLine(array.Get(1));
//Console.WriteLine(array.Get(0));

//array.Push(1);
//Console.WriteLine(array.Get(3));
//array.Pop();
//Console.WriteLine(array.Get(3));
//array.Delete(1);
//Console.WriteLine(array.GetLength());

//static void ReverseString (string stringToReverse)
//{
//    if (string.IsNullOrEmpty(stringToReverse))
//    {
//        return;
//    }

//    char [] reversedString = new char [stringToReverse.Length];

//    int temp = 0;
//    for (int i = stringToReverse.Length - 1; i >= 0; i--) 
//    {
//        reversedString [temp] = stringToReverse [i];
//        temp++;
//    }

//    Console.WriteLine (reversedString);
//}

//ReverseString("Andrei");

//static void MergeTwoSortedArrays ( int[] firstArray, int[] secondArray)
//{
//    int arrayWithMaxChars = firstArray.Length + secondArray.Length;



//    int[] mergedArray = new int[arrayWithMaxChars];

//    int j = 0;
//    int k = 0;
//    int index = 0;

//    while (j < firstArray.Length && k < secondArray.Length)
//    {
//        if (firstArray[j] <= secondArray[k])
//        {
//            mergedArray[index] = firstArray[j];
//            j++;
//            index++;
//        } else
//        {
//            mergedArray[index] = secondArray[k];
//            k++;
//            index++;
//        }
//    }
//    while (j < firstArray.Length)
//    {
//        mergedArray[index] = firstArray[j];
//        j++;
//        index++;
//    }

//    while (k < secondArray.Length)
//    {
//        mergedArray[index] = secondArray[k];
//        k++;
//        index++;
//    }

//    foreach (int i in mergedArray)
//    {
//        Console.WriteLine(i);
//    }
//}

//MergeTwoSortedArrays([0, 3, 4, 31], [4, 6, 30]);

//static int[] TopKFrequent(int[] nums, int k)
//    {
//        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
//        foreach (var num in nums)
//        {
//            frequencyMap[num] = frequencyMap.GetValueOrDefault(num, 0) + 1;
//        }

//        // time complexity este de m log n unde m este numarul de elemente distincte si n este numarul total de elemente in input array
//        var topK = frequencyMap
//            .OrderByDescending(pair => pair.Value)
//            .Take(k)
//            .Select(pair => pair.Key)
//            .ToArray();

//    foreach (var num in topK)
//    {
//        Console.WriteLine(num);
//    }
//        return topK;
//    }

//TopKFrequent([2, 3, 4, 4, 4], 2);

static int[] ProductExceptSelf(int[] nums)
{
    // Folosim suffix si prefix 
    // trebuie sa aflam totalul rezultat din inmultirea cifrelor inainte 
    // de nums[i] si dupa fara sa includem si nums[i]
    // Putem creea un array prefix si unul suffix cu 
    // ex : 
    // nums = [a, b, c, d]
    // prefix = [1, a, ab, abc]
    // sufix = [abc, ab, a, 1] 
    // unde 1 este pus ca delimitator pentru a sti ca acolo este capatul si ca nu exista un prefix la primul element si un sufix la ultimul element
    // apoi inmultim prefix [i] cu suffix [i] si obtinem rezultatul pentru output[i]


    //    nums = (1) [1, 2, 4, 6] (1)

    //  prefix res = [1, 1, 2, 8]
    
    // postfix res = [       , 1]

    // outut res =   [       , 8]
  
    int[] result = new int[nums.Length];
    int prefix = 1;

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = prefix;
        prefix *= nums[i];
    }

    int postfix = 1;

    for (int i = nums.Length - 1; i >= 0; i--)
    {
        result[i] *= postfix;
        postfix *= nums[i];
    }

    return result;
}