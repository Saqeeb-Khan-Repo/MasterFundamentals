namespace MasterFundamentalsC_;

public class Program
{
    static void Main(string[] args)
    {
        //char operation = '+';

        //switch (operation)
        //{
        //    case '+':
        //        Console.WriteLine("Additon");
        //        break;

        //    case '-':
        //        Console.WriteLine("Substraction");
        //        break;
        //    case '*':
        //        Console.WriteLine("Multiplication");
        //        break;
        //    case '/':
        //        Console.WriteLine("Division");
        //        break;

        //}
        //bool activeLisence= true;
        //if (!activeLisence)
        //{
        //    Console.WriteLine("yes");
        //}
        //else
        //{
        //    Console.WriteLine("No");
        //}


        //bool username = true;
        //bool pass = false;
        //if(username == true && pass==true)
        //{
        //    Console.WriteLine("login successfull");
        //}
        //else
        //{
        //    Console.WriteLine("invalid credentails");
        //}

        //string user = "admin";

        //switch (user)
        //{
        //    case "admin":
        //        Console.WriteLine("full access");
        //        break;
        //    case "employe":
        //        Console.WriteLine("limited access");
        //        break;
        //    case "Manager":
        //        Console.WriteLine("half access");
        //        break;
        //    default:
        //        Console.WriteLine("normal user access");
        //        break;
        //}

        //Modern c#
        //string role = "admin";
        //string result = role switch
        //{
        //    "admin" => "full access",
        //    "manager" => "only half access",
        //    "employee" => "only Employee access" ,
        //    _ => "normal user access"
        //};
        //Console.WriteLine(result);




        //string letters = "Mohammed Sirajuddin";
        //string vowels = "aeiou";
        //int count = 0;

        //foreach (char c in letters.ToLower())
        //{
        //    if (vowels.Contains(c))
        //    {
        //        count++;
        //    }
        //}

        //Console.WriteLine("Number of Vowels: " + count);


        //// Find smallest and largest elements in the array
        //int[] Array = { 4, 1, 7, 3, 9 };
        //int largest = Array[0];
        //int smallest = Array[0];
        //for (int i = 0; i <= Array.Length - 1; i++)
        //{
        //    if (Array[i] > largest)
        //    {
        //        largest = Array[i];
        //    }

        //    if (Array[i] < smallest)
        //    {
        //        smallest = Array[i];
        //    }
        //}
        //Console.WriteLine("Smallest: " + smallest + ", " + "Largest: " + largest);



        //// Find the second smallest number in the array
        //int[] nums = { 4, 2, 9, 1, 5 };
        //int SecondSmallest = nums[0];
        //int smallest = nums[0];

        //for (int i = 0; i < nums.Length; i++)
        //{

        //    if (nums[i] < smallest)
        //    {
        //        SecondSmallest = smallest;
        //        smallest = nums[i];
        //    }
        //    else if (nums[i] < SecondSmallest && nums[i] != smallest)
        //    {
        //        SecondSmallest = nums[i];
        //    }
        //}
        //Console.WriteLine("Second Smallest: " + SecondSmallest);

        //// Remove vowels from the string
        //string text = "programming";
        //string vowels = "aeiou";
        //string removed = "";
        //foreach (char c in text)
        //{
        //    if (!vowels.Contains(c))
        //    {
        //        removed += c;
        //    }
        //}
        //Console.WriteLine("String without Vowels: " + removed);

        //Dictionary<int, string> employee = new Dictionary<int, string>();

        //employee.Add(101, "mrkhan");
        //employee.Add(1, "mister");

        //foreach (var item in employee)
        //{
        //    Console.WriteLine(item.Key + " --> " + item.Value);
        //}

        //int[] nums = [1, 2, 2, 3, 1, 4];
        //Dictionary<int, int> frequency = new Dictionary<int , int>();
        //foreach (int num in nums)
        //{
        //    if (frequency.ContainsKey(num))
        //    {
        //        frequency[num]++;
        //    }
        //    else
        //    {
        //        frequency[num] = 1;
        //    }
        //}
        //Console.WriteLine("frequency: ");
        //foreach(var n in frequency)
        //{
        //    Console.WriteLine(n.Key + ": " + n.Value);
        //}

        //BankAccount b1 = new BankAccount("Saqeeb", 0 , 
        //Guid.Parse("4958FF9F-9233-47E7-A994-583DB0E327AB"));

        //b1.DisplayDetails();

        //b1.CurrentBalance();

        //b1.Withdraw(5000);
        //b1.Deposite(10000);

        //b1.CurrentBalance();
        int[] nums = new int[50];

        for (int i = 0; i < 50; i++)
        {
            nums[i] = i + 1;
        }
        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }
    }
}

//public class BankAccount
//{
//    public string? AccountHolder { get; set; }
//    public double AccountBalance { get; set; }

//    public Guid AccountID { get; set; }

//    //constructor
//    public BankAccount(string name, double amount, Guid guid)
//    {
//        AccountHolder = name;
//        AccountBalance = amount;
//        AccountID = guid;
//    }

//    //methods
//    public void DisplayDetails()
//    {
//        Console.WriteLine("Account Details: ");
//        Console.WriteLine($"Name: {AccountHolder}");
//        Console.WriteLine($"AccountNo: {AccountID}");
//        Console.WriteLine();
//    }

//    public double Deposite(double amount)
//    {
//        double added = AccountBalance + amount;
//        Console.WriteLine($"Deposited Amount : {amount} + Balance({AccountBalance}) = {added}$ ");
//        AccountBalance = added;
//        return added;
//    }

//    public void Withdraw(double amount)
//    {
//        if (amount > AccountBalance)
//        {
//            Console.WriteLine("Insufficient Account Balance");
//        }
//        else
//        {
//            double withdraw = AccountBalance - amount;
//            Console.WriteLine($"withdrawn Amount : {amount} - Balance({AccountBalance}) = {withdraw}$ ");
//            AccountBalance = withdraw;
//        }
//    }
//    public double CurrentBalance()
//    {
//        Console.WriteLine("AccountBalance is : " + AccountBalance + "$");
//        return AccountBalance;
//    }
//}

