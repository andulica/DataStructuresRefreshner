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

//static int[] ProductExceptSelf(int[] nums)
//{
//    // Folosim suffix si prefix 
//    // trebuie sa aflam totalul rezultat din inmultirea cifrelor inainte 
//    // de nums[i] si dupa fara sa includem si nums[i]
//    // Putem creea un array prefix si unul suffix cu 
//    // ex : 
//    // nums = [a, b, c, d]
//    // prefix = [1, a, ab, abc]
//    // sufix = [abc, ab, a, 1] 
//    // unde 1 este pus ca delimitator pentru a sti ca acolo este capatul si ca nu exista un prefix la primul element si un sufix la ultimul element
//    // apoi inmultim prefix [i] cu suffix [i] si obtinem rezultatul pentru output[i]


//    //    nums = (1) [1, 2, 4, 6] (1)

//    //  prefix res = [1, 1, 2, 8]

//    // postfix res = [       , 1]

//    // outut res =   [       , 8]

//    int[] result = new int[nums.Length];
//    int prefix = 1;

//    for (int i = 0; i < nums.Length; i++)
//    {
//        result[i] = prefix;
//        prefix *= nums[i];
//    }

//    int postfix = 1;

//    for (int i = nums.Length - 1; i >= 0; i--)
//    {
//        result[i] *= postfix;
//        postfix *= nums[i];
//    }

//    return result;
//}


//static bool IsPalindrome(string s)
//{

//    // Easy solution using two pointers and built in functions for checks
//    int left = 0;
//    int right = s.Length - 1;

//    while (left < right)
//    {
//        while (left < right && !char.IsLetterOrDigit(s[left]))
//            left++;

//        while (left < right && !char.IsLetterOrDigit(s[right]))
//            right--;

//        if (char.ToLower(s[left]) != char.ToLower(s[right]))
//            return false;

//        left++;
//        right--;
//    }

//    return true;
//}

//Console.WriteLine(IsPalindrome("Was it a car or a cat I saw?"));

//static bool IsValidSudoku(char[][] board)
//{
//    HashSet<char>[] rows = new HashSet<char>[9];
//    for (int i = 0; i < 9; i++) rows[i] = new HashSet<char>();

//    HashSet<char>[] cols = new HashSet<char>[9];
//    for (int i = 0; i < 9; i++) cols[i] = new HashSet<char>();

//    Dictionary<(int, int), HashSet<char>> squares = new Dictionary<(int, int), HashSet<char>>();
//    for (int r = 0; r < 3; r++)
//        for (int c = 0; c < 3; c++)
//            squares[(r, c)] = new HashSet<char>();


//    for (int i = 0; i < board.Length; i++)
//    {
//        for (int j = 0; j < board[i].Length; j++)
//        {
//            char val = board[i][j];
//            if (val == '.')
//                continue;

//            if (rows[i].Contains(val) || cols[j].Contains(val) || squares[(i / 3, j / 3)].Contains(val))
//                return false;

//            rows[i].Add(val);
//            cols[j].Add(val);
//            squares[(i / 3, j / 3)].Add(val);
//        }
//    }
//    return true;
//}

//static int LongestConsecutive(int[] nums)
//{
//    //la fiecare element din array ne uitam si vedem daca exista un element mai mic
//    // cu 1 decat elementul actual pentru a ne da seama daca este un sequence valid 
//    // cu 1 mai mare decat elementul actual pentru a sti daca avem un sequence mai mare
//    // transcriem int [] nums intr-un set pentru a face lookup de O(1)  ~
//    // la final o sa avem un traversal de O(n) fiindca trecem pe la fiecare element o data
//    HashSet<int> setNums = new HashSet<int>(nums.Length);
//    int longestStreak = 0;

//    for (int i = 0; i < nums.Length; i++)
//    {
//        setNums.Add(nums[i]);
//    }

//    foreach (int num in setNums)
//    {
//        int currentStreak = 0;
//        int currentNum = 0;

//        if (!setNums.Contains(num - 1))
//        {
//            currentStreak++;
//            currentNum = num;
//        }

//        while (setNums.Contains(currentNum + 1))
//        {
//            currentNum++;
//            currentStreak++;
//        }

//        if (currentStreak > longestStreak)
//        {
//            longestStreak = currentStreak;
//        }

//    }

//    return longestStreak;
//}

//LongestConsecutive(new int[] { 2, 20, 4, 10, 3, 4, 5 });