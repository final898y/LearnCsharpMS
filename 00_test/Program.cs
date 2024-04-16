// See https://aka.ms/new-console-template for more information

//string prefix = Convert.ToChar("").ToString();
//Console.WriteLine(prefix);
string a = Convert.ToChar("a").ToString();
Console.WriteLine(a);
Random random = new Random();
string suffix = random.Next(1, 1000).ToString("000");
Console.WriteLine(suffix);
