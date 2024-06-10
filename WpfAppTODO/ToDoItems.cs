using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTODO
{
    class ToDoItems
    {
        private int _id;
        private string _subject;
        private string _description;
        private DateTime _whan;
        private int _remainingDay;

        public ToDoItems(int id, string subject, string description, DateTime whan)
        {
            Id = id;
            Subject = subject;
            Description = description;
            Whan = whan;
          
        }

        public int Id { get => _id; set => _id = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime Whan
        {
            get => _whan;
            set
            {
                _whan = value;
                _remainingDay = CalculateRemainingDays(_whan);
            }
        }
        public int RemainingDay { get => _remainingDay;  }
       
        private int CalculateRemainingDays(DateTime targetDate)
        {
            return (targetDate - DateTime.Now).Days;
        }
    }
}
