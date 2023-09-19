using NEWPROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWPROJECT.ViewModel
{
    public class IssueViewModel:ModelViewBase
    {
        private Book _book;
        private User _user;
        private MyIssues _myIssues;

        public Book Book
        {
            get
            {
                return _book;
            }
            set
            {
                _book = value;
            }
        }

        public User User
        {
            get
            {
                return _user;
            }

            set { _user = value; }
        }

        public MyIssues MyIssues
        {
            get
            {
                return _myIssues;
            }

            set
            {
                _myIssues = value;
            }
        }


    }
}
