using System;

/*
// Low level module
public class EmailSender
{
    public void Send(string email, string content)
    {
        Console.WriteLine($"Sending email to {email}");
    }
}

// High level module
public class OrderService
{
    private readonly EmailSender _emailSender;

    public OrderService(EmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public void CreateOrder()
    {
        Console.WriteLine("Creating order");

        //Sending order details
        _emailSender.Send("tanvirarjel2@gmail.com", "This is order detail.");
    }
}
 */

interface IEmailSender
{
    void Send(string email, string content);
}
class EmailSender : IEmailSender
{
    public void Send(string email, string content)
    {
        Console.WriteLine($"Sending email to {email}");
    }
}


class OrderService
{
    private readonly IEmailSender _emailSender;

    public OrderService(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public void CreateOrder()
    {
        Console.WriteLine("Creating order");

        //Sending order details
        _emailSender.Send("tanvirarjel2@gmail.com", "This is order detail.");
    }
}

class Dip
{
    static void Main(string[] args)
    {
        IEmailSender email = new EmailSender();
        OrderService service = new OrderService(email);
        email.Send("abc12@gmail.com", "order detail.");
        service.CreateOrder();

    }
}