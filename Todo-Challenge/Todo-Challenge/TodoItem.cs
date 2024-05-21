namespace Todo_Challenge;

public class TodoItem(int itemId, string itemDescription, bool itemComplete)
{
    public int id = itemId;
    public bool complete = itemComplete;
    public string description = itemDescription;
}
