using System;
using System.Collections.Generic;

namespace Lunch_Time
{
    public class LogFile
    {
        public DateTime DateCreated { get; set; }
        public List<Log> Logs { get; set; }

        public LogFile()
        {
            DateCreated = DateTime.Now; //.ToString("MM-dd-yyyy");
            Logs = new List<Log>();
        }

        public string getYear()
        {
            return DateCreated.ToString("yyyy");
        }

        public string getMonth()
        {
            return DateCreated.ToString("MMMM");
        }

        public string getDay()
        {
            return DateCreated.ToString("dd");
        }
    }

    public class Log
    {
        public string DisplayName { get; set; }
        public string NoteOut { get; set; }
        public string NoteIn { get; set; }
        public string Out { get; set; }
        public string In { get; set; }

        public Log()
        {
            this.DisplayName = "";
            this.NoteOut = "";
            this.NoteIn = "";
            this.Out = "";
            this.In = "";
        }

        public Log(string displayname, string noteout, string notein, string _out, string _in)
        {
            this.DisplayName = displayname;
            this.NoteOut = noteout;
            this.NoteIn = notein;
            this.Out = _out;
            this.In = _in;
        }

    }
}
