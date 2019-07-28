using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteBookProject
{
    class Priority
    {
        private int _id;
        private string _priority;
        private bool _isDeleted;


        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public string Priority1
        {
            get { return _priority; }
            set { _priority = value; }
        }


        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        } 
        #endregion
    }
}
