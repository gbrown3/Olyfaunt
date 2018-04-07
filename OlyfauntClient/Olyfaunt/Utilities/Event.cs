using System;
using System.Collections.Generic;
namespace Olyfaunt
{
    public class Event
    {
        private string name;
        private string description;
        private string date;    // For now have users fill these in-- ideally they would have a nice way to select them
        private string time;    //

        public string Name
        {
            get { return name; }
        }
        public string Descriptiotn
        {
            get { return description; }
        }
        public string Date
        {
            get { return date; }
        }
        public string Time
        {
            get { return time; }
        }

        public Event(string name, string description, string date, string time)
        {
            this.name = name;
            this.description = description;
            this.date = date;
            this.time = time;
        }
    }
}
