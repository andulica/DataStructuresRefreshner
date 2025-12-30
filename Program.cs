using DataStructuresRefresher;

MyArray array = new MyArray(3);
Console.WriteLine(array.Get(2));
Console.WriteLine(array.Get(1));
Console.WriteLine(array.Get(0));

array.Push(1);
Console.WriteLine(array.Get(3));
array.Pop();
Console.WriteLine(array.Get(3));
array.Delete(1);
Console.WriteLine(array.GetLength());