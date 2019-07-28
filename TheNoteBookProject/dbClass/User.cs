using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TheNoteBookProject
{
    class User
    {
        private int _id;
        private string _userName;
        private string _name;
        private string _surname;
        private string _password;
        private DateTime _createdOn;
        private string _email;
        private bool _isDeleted;

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public DateTime CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
        #endregion

        CommonClass cmn = new CommonClass();

        //public bool UserControl(string UserName, string Email)
        //{
        //    bool result = false;
        //    SqlConnection conn = new SqlConnection(cmn.connStr);
        //    SqlCommand comm = new SqlCommand("Select * from [User] where (userName=@UserName or email=@Email) and isDeleted=0", conn);
        //    comm.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
        //    comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr;
        //    try
        //    {
        //        dr = comm.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            result = true;
        //        }
        //        dr.Close();
        //    }
        //    catch (SqlException ex)
        //    {
        //        string error = ex.Message;
        //    }
        //    finally { conn.Close(); }
        //    return result;
        //}
        public bool UserNameControl(string UserName)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select * from [User] where UserName = @UserName and isDeleted=0", conn);
            comm.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return result;
        }
        public bool UserMailControl(string Email)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select * from [User] where email=@Email and isDeleted=0", conn);
            comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return result;
        }
        public bool PasswordControl(string UserName, string Password)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select * from [User] where UserName = @UserName and Password = @Password and isDeleted=0", conn);
            comm.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
            comm.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return result;
        }
        public bool AddUser(User u)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("insert into [User] (userName,name,surname,email,password) values(@UserName,@Name,@Surname,@Email,@Password)", conn);
            comm.Parameters.Add("@UserName", SqlDbType.VarChar).Value = u._userName;
            comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = u._name;
            comm.Parameters.Add("@Surname", SqlDbType.VarChar).Value = u._surname;
            comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = u._email;
            comm.Parameters.Add("@Password", SqlDbType.VarChar).Value = u._password;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                result = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return result;
        }
        public string PasswordByEmail(string Email)
        {
            string pwd = "";
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select password from [User] where email=@Email", conn);
            comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                pwd = comm.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return pwd;
        }
        public string UserNameByEmail(string Email)
        {
            string userName = "";
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select userName from [User] where email=@Email", conn);
            comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                userName = comm.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return userName;
        }
        public int IdByUserName(string userName)
        {
            int id = 0;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select id from [User] where UserName = @UserName and isDeleted=0", conn);
            comm.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                id = Convert.ToInt32(comm.ExecuteScalar().ToString());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return id;
        }
        public DateTime SignUpDate()
        {
            DateTime signupDate = DateTime.Now;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select createdOn from [User] where id=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            signupDate = Convert.ToDateTime(comm.ExecuteScalar());
            conn.Close();
            return signupDate;
        }
        public bool PasswordByUserID(string pwd)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select * from [User] where id=@UserId and password=@Password", conn);
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            comm.Parameters.Add("@Password", SqlDbType.VarChar).Value = pwd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return result;
        }
        public User GetUserInfo()
        {
            User u = new User();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select username,name,surname,password,email from [User] where id=@UserId and isDeleted=0", conn);
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    u._email = Convert.ToString(dr[5]);
                    u._name = dr[1].ToString();
                    u._password = dr[4].ToString();
                    u._surname = dr[3].ToString();
                    u._userName = dr[0].ToString();
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return u;
        }
        public bool DeleteUser()
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("update [User] set isDeleted=1 where id=@UserId", conn);
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                result = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            conn.Close();
            return result;
        }
    }
}