using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNoteBookProject
{
    class Category
    {
        private int _id;
        private int _userId;
        private string _category;
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


        public string Category1
        {
            get { return _category; }
            set { _category = value; }
        }


        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
        #endregion

        CommonClass cmn = new CommonClass();

        public bool AddCategory(string catName)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("insert into category(userId,category) values(@UserId,@Category)", conn);
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            comm.Parameters.Add("@Category", SqlDbType.VarChar).Value = catName;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public int GetCategoryId(string CategoryName)
        {
            int id = 0;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select id from Category where category=@Category and userId=@UserId", conn);
            comm.Parameters.Add("@Category", SqlDbType.VarChar).Value = CategoryName;
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                id = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            conn.Close();
            return id;
        }

    }

}
