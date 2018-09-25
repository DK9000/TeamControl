using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamControl.Domain
{
    public class Division
    {
        public int Id { get; set; }
        public string Game { get; set; }
        public string DivName { get; set; }

        public Division()
        {
            Id = 0;
        }
        public Division(int id, string game, string divName)
        {
            this.Id = id;
            this.Game = game;
            this.DivName = divName;
        }
    }
}
