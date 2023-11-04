namespace EB_DZ_50.Entities;
public class ToDoTask
{
    public int ID {get; set;}
    public string Name {get; set;}
    public int PriorityID {get; set;}
    public int StatusID {get; set;}

    public ToDoTask(int id, string name, int priorityID, int statusID)
    {
        this.ID = id;
        this.Name = name;
        this.PriorityID = priorityID;
        this.StatusID = statusID;
    }

    public ToDoTask(string name, int priorityID, int statusID)
    {
        this.Name = name;
        this.PriorityID = priorityID;
        this.StatusID = statusID;
    }
}