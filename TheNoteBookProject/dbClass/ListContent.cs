using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteBookProject
{
    class ListContent
    {
        private int _id;   
        private int _listid;
        private int _userid;
        private string _body;
        private DateTime _createdOn;
        private DateTime _updatedOn;
        private bool _isDeleted;

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Listid
        {
            get { return _listid; }
            set { _listid = value; }
        }

        public int Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }

        public string Body
        {
            get { return _body; }
            set { _body = value; }
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
    }
}
