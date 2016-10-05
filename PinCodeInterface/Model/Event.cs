using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;

namespace PinCodeInterface.Model
{
    class Event
    {
        public string _title;
        public string _description;
        public string _place;
        public DateTime _dateTime;
        

        public string Title { get;  set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }

        public Event() 
        {
            
        }

        public Event(string _title, string _description, string _place, DateTime _dateTime)

        {
            Title = _title;
            Description = _description;
            Place = _place;
            DateTime = _dateTime;

        }

        public override string ToString()
        {
            return string.Format("Title: {0}, Description: {1}, Place: {2}, DateTime: {3}", Title, Description, Place, DateTime);
        }

    }



}
