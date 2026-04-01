using System.Collections;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<TaskItem> lol = new List<TaskItem>();
        RandomFillTaskList(lol, 6);
        lol[2].Description = "Делембуны";
        WriteTaskList(lol);

        Console.ReadLine();
        Console.Clear();

        UpDoneTasks(lol);
        WriteTaskList(lol);

        Console.ReadLine();
        Console.Clear();

        DownDoneTasks(lol);
        WriteTaskList(lol);

        Console.ReadLine();
        Console.Clear();

        WriteTasksByTitleWord(lol,"Task5");

        Console.ReadLine();
        Console.Clear();

        WriteTasksByDescWord(lol, "Делембуны");


    }
    static void WriteTaskList(List<TaskItem> list)
    {
        foreach (TaskItem h in list)
        {
            h.WriteInfo();
        }
    }
    static void RandomFillTaskList(List<TaskItem> list, int count)
    {
        Random r = new Random();

        for (int i = 0; i < count; i++)
        {
            list.Add(new TaskItem($"Task{i}", "", (r.Next(1, 3) == 1)));
        }
    }
    static void UpDoneTasks(List<TaskItem> list)
    {
        TaskItem item;
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (!list[i].IsDone)
            {
                item = list[i];
                list.RemoveAt(i);
                list.Add(item);
            }
        }
    }
    static void DownDoneTasks(List<TaskItem> list)
    {
        TaskItem item;
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i].IsDone)
            {
                item = list[i];
                list.RemoveAt(i);
                list.Add(item);
            }
        }
    }
    static void WriteTasksByTitleWord(List<TaskItem> list, string word)
    {
        foreach (TaskItem item in list) 
        {
            if (item.Title.Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                item.WriteInfo();
            }
        }
    }
    static void WriteTasksByDescWord(List<TaskItem> list, string word)
    {
        foreach (TaskItem item in list)
        {
            if (item.Description.Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                item.WriteInfo();
            }
        }
    }
}
public class TaskItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsDone { get; set; }

    public TaskItem(string title, string description, bool isDone)
    {  
        Title = title;
        Description = description;
        IsDone = isDone;
    }
    public void WriteInfo()
    {
        Console.WriteLine($"Имя: {Title}");
        Console.WriteLine($"Описание: {Description}");
        Console.WriteLine($"Статус: {IsDone}");
        Console.WriteLine();

    }
}
