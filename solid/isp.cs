using System;

/*
public interface IEmployeeTasks
{
   void CreateTask();
   void AssginTask();
   void WorkOnTask();
}

public class TeamLead : IEmployeeTasks
{
   public void CreateTask()
   {
       Console.WriteLine("Task created.");
   }

   public void AssginTask()
   {
       Console.WriteLine("Task assigned.");
   }

   public void WorkOnTask()
   {
       Console.WriteLine("Started working on the task.");
   }
}

public class Manager : IEmployeeTasks
{
   public void CreateTask()
   {
       Console.WriteLine("Task created.");
   }

   public void AssginTask()
   {
       Console.WriteLine("Task assigned.");
   }

   // The Manager client has been forced to implement `WorkOnTask()` method although Manager does not work on task.
   public void WorkOnTask()
   {
       throw new NotImplementedException();
   }
}

public class Programmer : IEmployeeTasks
{
   // The Programmer client has been forced to implement `CreateTask()` method although Programmer cannot create task.
   public void CreateTask()
   {
       throw new NotImplementedException();
   }

   // The Programmer client has been forced to implement `AssginTask()` method although Programmer cannot assign task.
   public void AssginTask()
   {
       throw new NotImplementedException();
   }

   public void WorkOnTask()
   {
       Console.WriteLine("Started working on the task.");
   }
}
 */

interface ILead
{ 
    void CreateSubTask();
    void AssginTask();
}

interface IProgrammer
{
    void WorkOnTask();
}

// Clients
class Manager : ILead
{
    public void CreateSubTask()
    {
        Console.WriteLine("Task created.");
    }

    public void AssginTask()
    {
        Console.WriteLine("Task assigned.");
    }
}

class TeamLead : ILead, IProgrammer
{
    public void CreateSubTask()
    {
        Console.WriteLine("Task created.");
    }

    public void AssginTask()
    {
        Console.WriteLine("Task assigned.");
    }

    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}

class Programmer : IProgrammer
{
    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}
public class Isp
{ 
    public static void Main()
    {
        Manager mng = new Manager();
        TeamLead tl = new TeamLead();
        Programmer prog = new Programmer();
        mng.AssginTask();
        mng.CreateSubTask();
        tl.CreateSubTask();
        tl.AssginTask();
        tl.WorkOnTask();
        prog.WorkOnTask();
    }
}