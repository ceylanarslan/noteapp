using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteBookProject
{
    class ListTitle
    {
        private int _id;
        private int _userId;
        private string _baslik;
        private DateTime _createdOn;
        private DateTime _updatedOn;
        private bool _isDeleted;

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }


        public string Baslik
        {
            get { return _baslik; }
            set { _baslik = value; }
        }


        public DateTime CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }


        public DateTime UpdatedOn
        {
            get { return _updatedOn; }
            set { _updatedOn = value; }
        }


        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        } 
        #endregion


        private void GetLists()
        {}
    }
}
