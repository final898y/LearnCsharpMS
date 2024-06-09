//string prefix = Convert.ToChar("").ToString();
//Console.WriteLine(prefix);

/*
string a = Convert.ToChar("a").ToString();
Console.WriteLine(a);
Random random = new Random();
string suffix = random.Next(1, 1000).ToString("000");
Console.WriteLine(suffix);

int i = 0; i = i++; Console.WriteLine(i);

int i2 = 0; i2 = ++i2; Console.WriteLine(i2);

dynamic dyVar = 50;
Console.WriteLine($"{dyVar,-20}");

dynamic dyVar2 = 5;
dyVar2 = "c#";
string s = dyVar2;
Console.WriteLine($"{s.GetType()}");


int n=15;
              int[] nums = new int[n+1];
for(int i = 0; i<n+1;i++)
{
    if(i<2)
    {
        nums[i]=i;
    }
    else  
    {
        if(i%2==0)
        {
            nums[i]=nums[i/2];
        }
        else
        {
            nums[i]=nums[(i-1)/2]+nums[((i-1)/2)+1];
        }
    }
}

return(nums.Max());


/*
    public int GetMaximumGenerated(int n) {
        int[] nums = new int[n+1];
        for(int i = 0; i<n+1;i++)
        {
            if(i<2)
            {
                nums[i]=i;
            }
            else  
            {
                if(i%2==0)
                {
                    nums[i]=nums[i/2];
                }
                else
                {
                    nums[i]=nums[(i-1)/2]+nums[(i-1)/2+1];
                }
            }
        }

        if(n==0)
        {
            return(0);
        }
        else if (n%2==0)
        {
            int max = nums[n-1];
            return(max);
        } 
        else 
        {
            int max = nums[n];
            return(max);
        }
        
    }
}

*/
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = [3,2,4];
        int target = 6;
        //foreach (var item in nums )
        //{
        //    Console.WriteLine($"   [{i++}]:  {item}");
        //}
        int i = 0;
        int j = 1;
        int x = 0;
        while (i<nums.Length-1)
            {
                
                while(j<nums.Length-i)
                { 
                    x  = nums[i]+nums[i+j];
                    Console.WriteLine($"while_{x}");
                    if(x!=target)
                    {
                       
                        Console.WriteLine($"while_if_{x}");
                        Console.WriteLine(j);
                        j++;
                        
                    }
                    else
                    {
                        Console.WriteLine($"bk1_{i}{j}");
                        break;
                    }
                }
                if(x==target)
                {
                    Console.WriteLine($"bk2_{i}{j}");
                    break;
                }
                else
                {
                    Console.WriteLine($"bk3_{i}{j}");
                    i++;
                    j = 1;
                    
                }

            }
        Console.WriteLine($"end{i}");
        Console.WriteLine($"end{j}");
        Console.WriteLine($"end{x}");
            
    }
}