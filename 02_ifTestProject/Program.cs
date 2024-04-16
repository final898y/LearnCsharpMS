// See https://aka.ms/new-console-template for more information
/*Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
*/

/*
程式碼區塊是一或多行程式碼的集合，以左和右大括弧符號 { } 來定義。 
其代表在您的軟體系統中具有單一用途的程式碼完整單位。 
在此案例中，若布林運算式為 True，即會在執行階段執行程式碼區塊中的所有程式碼。 
反之，若布林運算式為 False，則會忽略程式碼區塊中的所有程式碼。
*/


string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

//布林運算式是任何會傳回布林值 (true 或 false) 的程式碼。

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

/*首先，您會評估 (roll1 == roll2)。 若為 True，則整個運算式為 True。 
若為 False，您會評估 (roll2 == roll3)。 若為 True，則整個運算式為 True。 
若為 False，您會評估 (roll1 == roll3)。 若為 True，則整個運算式為 True。 
若為 False，則整個運算式為 False。
*/

/*
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
    Console.WriteLine($"Now Total :{total}");
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}


if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
*/    


if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
        Console.WriteLine($"Now Total :{total}");
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
        Console.WriteLine($"Now Total :{total}");
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}


