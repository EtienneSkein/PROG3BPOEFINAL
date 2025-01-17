﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }

        public Event(int id, string title, string description, DateTime date, string category)
        {
            Id = id;
            Title = title;
            Description = description;
            Date = date;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Title} - {Date:MMMM dd, yyyy}";
        }
    }

}
