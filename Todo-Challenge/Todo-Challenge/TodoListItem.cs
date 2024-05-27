namespace Todo_Challenge
{
    internal class TodoListItem
    {
        public string Name { get; set; }
        public bool Completed { get; set; }
        public TodoListItem(string name, bool completed)
        {
            Name = name;
            Completed = completed;
        }

        public TodoListItem(string name) : this(name, false)
        {
        }
    }
}
