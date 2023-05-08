using System;

/*class Program  
    {  
        static void Main(string[] args)  
        {  
            Console.WriteLine("Welcome to the Application");  
  
            //Ask for Information  
            Person user = new Person();  
            Console.WriteLine("What is your First Name");  
            user.FirstName = Console.Readline();  
            Console.WriteLine("What is your Last Name");  
            user.LastName = Console.Readline();  
  
            //Ask for Validation  
            if(String.IsNullOrWhiteSpace(user.FirstName))  
            {  
                 Console.WriteLine("You didnt have valid First Name");  
                 Console.Readline();  
                 return;  
            }    
            if(String.IsNullOrWhiteSpace(user.LastName))  
            {  
                 Console.WriteLine("You didnt have valid Last Name");  
                 Console.Readline();  
                 return;  
            }  
  
            //Final output to User  
            Console.WriteLine($"Your UserName is {user.FirstName}{user.LastName}");  
            Console.Readline();  
        }  
    }  
}  */

public class WelcomeMessage
{
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Application");
    }
}

public class ValidationMessage
{
    public static void DisplayValidationErrorMessage(string fieldName)
    {
        Console.WriteLine($"You didnt give us valid {fieldName}");
    }
}

public class PersonalInformationMessage
{
    public static void DisplayPersonalInformationMessage(string fieldName)
    {
        Console.WriteLine($"What is your {fieldName}");
    }
}



class Srp
{
    static void Main(string[] args)
    {
        WelcomeMessage.DisplayWelcomeMessage();
        ValidationMessage.DisplayValidationErrorMessage("abc");
        PersonalInformationMessage.DisplayPersonalInformationMessage("abc");

    }
}