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
    class Agenda
    {
        private int _id;
        private int _userId;
        private string _body;
        private int _priorityId;
        private bool _isReminder;
        private DateTime _noteDate;
        private DateTime _remindOn;
        private DateTime _createdOn;
        private DateTime _updatedOn;
        private bool _isDeleted;

        #region Properties
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        public DateTime UpdatedOn
        {
            get { return _updatedOn; }
            set { _updatedOn = value; }
        }

        public DateTime CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }

        public DateTime RemindOn
        {
            get { return _remindOn; }
            set { _remindOn = value; }
        }

        public bool IsReminder
        {
            get { return _isReminder; }
            set { _isReminder = value; }
        }

        public DateTime NoteDate
        {
            get { return _noteDate; }
            set { _noteDate = value; }
        }

        public int PriorityId
        {
            get { return _priorityId; }
            set { _priorityId = value; }
        }

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        } 
        #endregion

        CommonClass cmn = new CommonClass();

        public bool SaveNote(Agenda Note)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "sp_UpdateAgenda";
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            comm.Parameters.Add("@Body", SqlDbType.VarChar).Value = Note._body;
            comm.Parameters.Add("@PriorityId", SqlDbType.Int).Value = Note._priorityId;
            comm.Parameters.Add("@IsReminder", SqlDbType.Bit).Value = Note._isReminder;
            if (Note._remindOn != Convert.ToDateTime(null))
            {
                //comm.Parameters.Add("@RemindOn", SqlDbType.DateTime).Value = Note._remindOn;
                comm.Parameters.Add("@RemindOn", SqlDbType.DateTime).Value = Note._remindOn;
            }
            else
            {
                comm.Parameters.Add("@RemindOn", SqlDbType.DateTime).Value = DBNull.Value;
            }
            comm.Parameters.Add("@NoteDate", SqlDbType.DateTime).Value = Note._noteDate;
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
        public void GetNotesByDate(ListView liste, ListView saatListesi, DateTime date)
        {
            liste.Items.Clear();
            for (int i = 0; i < saatListesi.Items.Count; i++)
            {
                liste.Items.Add("");
            }
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select noteDate, body, Priority.priority as priority, remindOn, Agenda.priorityId as priorityId, Agenda.id as Id from Agenda inner join Priority on Priority.id=Agenda.priorityId where Convert(varchar(20),noteDate,104)=Convert(varchar(20),@NoteDate,104) and Agenda.userId=@UserId and Agenda.isDeleted=0 order by noteDate", conn);
            comm.Parameters.Add("@NoteDate", SqlDbType.DateTime).Value = date;
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    while (i < saatListesi.Items.Count)
                    {
                        if (saatListesi.Items[i].SubItems[0].Text == Convert.ToDateTime(dr["noteDate"]).ToShortTimeString())
                        {
                            liste.Items[i].SubItems.Add(dr[1].ToString());
                            liste.Items[i].SubItems.Add(dr[2].ToString());
                            liste.Items[i].SubItems.Add(dr[3].ToString());
                            liste.Items[i].SubItems.Add(dr[4].ToString());
                            liste.Items[i].SubItems.Add(dr[5].ToString());
                            i++;
                            break;
                        }
                        else
                        {
                            liste.Items[i].SubItems.Add("");
                            liste.Items[i].SubItems.Add("");
                            liste.Items[i].SubItems.Add("");
                            liste.Items[i].SubItems.Add("");
                            liste.Items[i].SubItems.Add("");
                            i++;
                        }
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
        }
        public DataTable GetImportantNotes()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select body as [Önemli Notlar], Priority.priority as [Önem Derecesi], noteDate as [Not Tarihi] from Agenda inner join Priority on Priority.id=Agenda.priorityId where userId=@UserId and Agenda.isDeleted=0 and (Convert(varchar(20),noteDate,104)=Convert(varchar(20),getdate(),104) or Convert(varchar(20),noteDate,104)>Convert(varchar(20),getdate(),104)) order by priorityId, Agenda.noteDate", conn);
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
        public bool DeleteNote(int noteID)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Update Agenda set isDeleted=1 where id=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = noteID;
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
        public DataTable SearchNotes(string noteKeyword)
        {
            DataTable dt=new DataTable();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select id, body, noteDate from Agenda where userId=@UserID and isDeleted=0 and body like '%'+@Keyword+'%'", conn);
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
            SqlDataAdapter da = new SqlDataAdapter("Select id, body, noteDate from Agenda where userId=@UserID and isDeleted=0", conn);
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
        public DataTable GetNotesByRemindOn()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlDataAdapter da = new SqlDataAdapter("Select body as Notunuz, noteDate as [Hatırlatma Tarihi] from Agenda where userId=@UserID and isDeleted=0 and Convert(varchar(20),remindOn,104)=Convert(varchar(20),getdate(),104)", conn);
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
        public bool ReminderControl()
        {
            bool result=false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select body from Agenda where userID=@UserId and isDeleted=0 and Convert(varchar(20),remindOn,104)=Convert(varchar(20),getdate(),104)", conn);
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
                }
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            return result;
        }
    }
}
