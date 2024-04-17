// See https://aka.ms/new-console-template for more information
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue1 = "a";
Console.WriteLine(myValue1 == "a");

//在檢查兩個字串值是否相等之前，尤其是當使用者輸入一或兩個值時，您應該：
//在任何字串值上使用 ToUpper() 或 ToLower() 協助程式方法，確保兩個字串皆為大寫或小寫。
//在任何字串值上使用 Trim() 協助程式方法，移除所有前後空格。

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//使用不等比較運算子
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");

/*
某些資料類型具有執行有用的公用程式工作的方法。
String 資料類型具有許多這類方法。 有些會傳回布林值，包括 Contains()、StartsWith() 與 EndsWith()。
*/

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

//不等比較運算子與邏輯否定
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

Console.WriteLine("實作條件運算子");
//條件運算子?:會評估布林運算式，
//並根據布林運算式評估為 true 或 false，傳回兩個運算式的結果之一。 條件運算子通常稱為三元條件運算子。
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
//以內嵌方式使用條件運算子
//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
Console.WriteLine("完成使用條件運算子的挑戰活動");
Random coin = new Random();
string result = coin.Next(1,3)>1 ? "heads":"tails";
Console.WriteLine($"Result is {result}");
