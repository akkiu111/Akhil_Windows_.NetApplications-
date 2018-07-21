using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Akhil_3TierApplication
{
    class BAL_Student : DAL_Student
    {
        public int bal_sid
        {
            get;
            set;
        }
        public string bal_sname
        {
            get;
            set;
        }
        public string bal_sgrade
        {
            get;
            set;
        }

        public int Bal_insert_student()
        {
            return Dal_insert_student(this);
        }
        public int Bal_update_student()
        {
            return Dal_update_student(this);
        }
        public DataTable Bal_find_student()
        {
            return Dal_find_student(this);
        }
        public int Bal_delete_student()
        {
            return Dal_delete_student(this);
        }
        public DataTable Bal_display_student()
        {
            return Dal_display_student();
        }
    }
}
