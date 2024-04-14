// See https://aka.ms/new-console-template for more information
using System.Data.Common;

Console.WriteLine("Hello, C#!");

//類別的執行個體稱為物件。 若要建立類別的新執行個體，您會使用 new 運算子。 請考慮下列程式碼，這會建立 Random 類別的新執行個體，以建立稱為 dice 的新物件：
Random dice = new Random();
//Random dice = new();
int roll = dice.Next(1, 7);
//Random.Next 方法：Next(Int32, Int32)傳回指定範圍內的隨機整數。
Console.WriteLine(roll);

int number = 7;
string text = "seven";

Console.WriteLine($"int :{number}");
Console.WriteLine();
Console.WriteLine($"string :{text}");
/*
第一 WriteLine() 個方法會使用定義 int 參數的方法簽章。
第二 WriteLine() 種方法會使用定義零輸入參數的方法簽章。
第三 WriteLine() 個方法會使用定義 string 參數的方法簽章。
*/

Random dice2 = new Random();
int roll1 = dice2.Next();
int roll2 = dice2.Next(101);
int roll3 = dice2.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


//程式碼挑戰：實作會傳回兩個數字中較大數字之數學類別的方法。
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);