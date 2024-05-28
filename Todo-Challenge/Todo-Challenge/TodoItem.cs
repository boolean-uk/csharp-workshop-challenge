﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Challenge
{
    internal class TodoItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Completed { get; set; } = false;
        public TodoItem? NextTodoItem { get; set; } = null;

        private readonly TodoList _list;

        private void LinkToPreviousItem()
        {
            if (_list.DoesNotContainFirstTodoItem())
            {
                _list.Head = this;
                return;
            } 
            if (_list.Tail != null)
            {
                _list.Tail.NextTodoItem = this;
            }
        }

        public string ReadCompletionStatus()
        {
            return Completed ? "done" : "to do";
        }

        public TodoItem(string name, TodoList todoList)
        {
            Id = todoList.NextId;
            Name = name;
            _list = todoList;
            todoList.IncreaseNextIdByOne();
            LinkToPreviousItem();
            todoList.Tail = this;
        }
    }
}
