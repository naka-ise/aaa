using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.View
{
    public interface IView
    {
        DataTable SearchLesson(string[] param);
        void lessonPayment(string[] param);
        void insertUser(string[] param, string user);
        void updateUser(string[] param, string user);
        void deleteUser(string[] param, string user);
    }
}
