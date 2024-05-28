namespace Todo_Challenge
{
    internal class TodoListItem
    {
        private static int lastId = -1;

        public int Id { get; private set; } 
        public string Name { get; set; }
        public bool Completed { get; set; }

        public TodoListItem(string name, bool completed)
        {
            Id = ++lastId;    
            Name = name;
            Completed = completed;
        }

        public TodoListItem(string name) : this( name, false)
        {
        }
    }
}
