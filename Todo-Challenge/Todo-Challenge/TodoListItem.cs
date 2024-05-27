namespace Todo_Challenge
{
    internal class TodoListItem
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool Completed { get; set; }

        public TodoListItem(int id, string name, bool completed)
        {
            Id = id;    
            Name = name;
            Completed = completed;
        }

        public TodoListItem(int id, string name) : this(id, name, false)
        {
        }
    }
}
