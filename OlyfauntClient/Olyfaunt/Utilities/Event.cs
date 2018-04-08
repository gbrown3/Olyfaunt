using System;
using System.Collections.Generic;
namespace Olyfaunt
{
    public class Event
    {
        const int MAX_NUM_NAME_CHARS = 32;
        const int MAX_NUM_DESC_CHARS = 200;
        private string name;
        private string description;
        private string date;    // For now have users fill these in-- ideally they would have a nice way to select them
        private string time;    //

        public string Name
        {
            get { return name; }
        }
        public string Description
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
            if (name.Length <= MAX_NUM_NAME_CHARS) { this.name = name; }
            else { throw new Exception("Too many chars in name"); }

            if (description.Length <= MAX_NUM_DESC_CHARS) { this.description = description; }
            else { throw new Exception("Too many chars in description"); }

            this.date = date;
            this.time = time;
        }
    }
}
