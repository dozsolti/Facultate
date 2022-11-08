using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager_Console
{
    public class Task
    {
        public int ID;
        public DateTime when;
        public string where;
        public string why;
        public List<string> what;
        public string how_much;
        public string how_long;

        public Task(int ID, DateTime when, string where, string why)
        {
            this.ID = ID;
            this.when = when;
            this.where = where;
            this.why = why;
        }

        public Task(int ID, DateTime when, string where, string why, List<string> what, string how_much, string how_long) : this(ID, when, where, why)
        {
            this.what = what;
            this.how_much = how_much;
            this.how_long = how_long;
        }

        public override string ToString()
        {
            return ID+"\nWhen:\t"+when+"\nWhere:\t"+where+"\nWhy:\t"+why+"\nWhat:\t"+what[0]+"\nHow much:\t"+how_much+"\nHow long:\t"+how_long;
        }
    }
}
