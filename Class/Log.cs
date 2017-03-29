using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAProject.Class
{
    class Log
    {
        private DateTime _logDate;
        private string _logMessage;
        private string _logCauser;

        public DateTime LogDate { get => _logDate; set => _logDate = value; }
        public string LogMessage { get => _logMessage; set => _logMessage = value; }
        public string LogCauser { get => _logCauser; set => _logCauser = value; }

        public Log(DateTime curDate , string message,string causer)
        {
            _logDate = curDate;
            _logMessage = message;
            _logCauser = causer;
        }

        public Log()
        {

        }

        public override string ToString()
        {
            if (_logDate != null && _logCauser !="" && _logMessage !="")
                return "[" + _logDate.ToShortDateString() +" - "+ _logDate.ToLongTimeString() + "] " + _logCauser + " - " + _logMessage;
            else
                return "";
        }
    }
}
