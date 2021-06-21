using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerClient.src.managers
{
    class ManagerInf
    {
        private int id;
        private string managerid;
        private string managername;
        private string managerpassword;

        public int Id { get => id; set => id = value; }
        public string Managerid { get => managerid; set => managerid = value; }
        public string Managername { get => managername; set => managername = value; }
        public string Managerpassword { get => managerpassword; set => managerpassword = value; }

        public ManagerInf()
        {

        }

        public ManagerInf(int id, string managerid, string managername, string managerpassword)
        {
            Id = id;
            Managerid = managerid;
            Managername = managername;
            Managerpassword = managerpassword;
        }

        public override bool Equals(object obj)
        {
            return obj is ManagerInf inf &&
                   Id == inf.Id &&
                   Managerid == inf.Managerid &&
                   Managername == inf.Managername &&
                   Managerpassword == inf.Managerpassword;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Managerid, Managername, Managerpassword);
        }
    }
}
