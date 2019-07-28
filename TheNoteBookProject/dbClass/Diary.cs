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
    class Diary
    {
        private int _id;
        private int _categoryId;
        private string _body;
        private DateTime _createdOn;
        private DateTime _updatedOn;
        private int _userId;
        private bool _isDeleted;

        #region Properties
        public DateTime UpdatedOn
        {
            get { return _updatedOn; }
            set { _updatedOn = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
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



        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }


        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
        #endregion

        CommonClass cmn = new CommonClass();

        public bool SaveDiaryNote(Diary diary)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_UpdateDiary";
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            comm.Parameters.Add("@Body", SqlDbType.VarChar).Value = diary._body;
            comm.Parameters.Add("@CategoryId", SqlDbType.Int).Value = diary._categoryId;
            comm.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = diary._createdOn;
            comm.Parameters.Add("@UpdatedOn", SqlDbType.DateTime).Value = DateTime.Now;
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
        public void GetDiaryNote(RichTextBox txtNote, int catID, DateTime noteDatetime)
        {
            string noteBody = "";
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("select body from Diary where Convert(varchar(20),createdOn,104)=Convert(varchar(20),@CreatedOn,104) and Diary.userId=@UserId and categoryId=@CategoryId and Diary.isDeleted=0", conn);
            comm.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = noteDatetime;
            comm.Parameters.Add("@CategoryId", SqlDbType.Int).Value = catID;
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                noteBody = Convert.ToString(comm.ExecuteScalar());
                if (noteBody != "")
                {
                    txtNote.Text = noteBody;
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
        }
        public DataTable GetDatagrid(int Categoryid)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlDataAdapter da = new SqlDataAdapter("select top 10  body as [İçerik], createdOn as [Oluşturulma tarihi ]  from  Diary where userId=@UserId and Diary.isDeleted=0 and categoryId=@CategoryId ", conn);
            da.SelectCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            da.SelectCommand.Parameters.Add("@CategoryId", SqlDbType.Int).Value = Categoryid;

            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            return dt;
        }
        public DataTable SearchNotes(string noteKeyword)
        {
            DataTable dt=new DataTable();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select id, body, createdOn from Diary where userId=@UserID and isDeleted=0 and body like '%'+@Keyword+'%'", conn);
            da.SelectCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            da.SelectCommand.Parameters.Add("@Keyword", SqlDbType.VarChar).Value = noteKeyword;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            return dt;
        }
        public DataTable GetAllNotes()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select id, body, createdOn from Diary where userId=@UserID and isDeleted=0", conn);
            da.SelectCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            return dt;
        }
        public bool DeleteDiaryNote(DateTime datetime, int catId)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("update Diary set isDeleted=1 where categoryId=@CategoryId and userId=@UserId and isDeleted=0 and Convert(varchar(20),createdOn,104)=Convert(varchar(20),@CreatedOn,104)", conn);
            comm.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = datetime;
            comm.Parameters.Add("@CategoryId", SqlDbType.Int).Value = catId;
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                result=Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            return result;
        }
    }
}
