using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamControl.Domain
{
    class Training
    {
        public int Id { get; set; }
        public string SessionNote { get; set; }
        public string Date { get; set; }

        public Training(int id, String sessionNote, String date)
        {
            this.Id = id;
            this.SessionNote = sessionNote;
            this.Date = date;
        }
    }
}
