﻿namespace BlazorTodo.Models
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool Editing { get; set; }
        public bool Completed { get; set; }

        public string GetClass()
        {
            var cssClass = "";

            if (Completed)
                cssClass += "completed";
            if (Editing)
                cssClass += " editing";
            return cssClass.Trim();
        }
    }
}
