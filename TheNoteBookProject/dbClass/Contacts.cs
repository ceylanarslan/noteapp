using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TheNoteBookProject
{
    class Contacts
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _phoneNumber;
        private string _email;
        private string _address;
        private int _userId;
        private bool _isDeleted;

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public string Telefon
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
        public int UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }

        
        #endregion

        CommonClass cmn = new CommonClass();

        public DataSet GetAllRehber()
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlDataAdapter da = new SqlDataAdapter("select * from Contacts where isDeleted=0 and userId=@UserId", conn);
            da.SelectCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            try
            {
                da.Fill(ds, "Contacts");
            }
            catch (SqlException Ex)
            {
                string error = Ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }
        public void GetAllRehber(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("select id,name,surname,phoneNumber,email,address,userId from Contacts where isDeleted=0 and userId=@UserId", conn);
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }

        }
        public void GetAllContactsByNameSurname(string NameSurname, ListView list)
        {
            list.Items.Clear();
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("select id,name,surname,phoneNumber,email,address from Contacts where isDeleted=0 and (name like @Name+'%' or surname like @Surname+'%') and userId=@UserId", conn);
            comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = NameSurname;
            comm.Parameters.Add("@Surname", SqlDbType.VarChar).Value = NameSurname;
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    list.Items.Add(dr["id"].ToString());
                    list.Items[i].SubItems.Add(dr["name"].ToString());
                    list.Items[i].SubItems.Add(dr["surname"].ToString());
                    list.Items[i].SubItems.Add(dr["phoneNumber"].ToString());
                    list.Items[i].SubItems.Add(dr["email"].ToString());
                    list.Items[i].SubItems.Add(dr["address"].ToString());
                    i++;
                }
            }
            catch (SqlException Ex)
            {

                string error = Ex.Message;
            }
            finally { conn.Close(); }
        }
        public int ContactOrder(int Id)
        {
            int cOrder = 0;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("Select count(*) from Contacts where id < @Id and isDeleted=0 and userId=@UserId", conn);
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                cOrder = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            finally { conn.Close(); }
            return cOrder;
        }
        public bool AddContact(Contacts cs)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("insert into Contacts (userId, name, surname, phoneNumber, email, address) values(@UserId, @Name, @Surname, @PhoneNumber, @Email, @Address)", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            comm.Parameters.Add("@UserId", SqlDbType.Int).Value = CommonClass.userNo;
            comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = cs._name;
            comm.Parameters.Add("@Surname", SqlDbType.VarChar).Value = cs._surname;
            comm.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = cs._phoneNumber;
            comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = cs._email;
            comm.Parameters.Add("@Address", SqlDbType.VarChar).Value = cs._address;
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public bool UpdateContact(Contacts cs)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("update Contacts set name=@name,surname=@surname,phoneNumber=@phoneNumber,email=@email,address=@address where id=@Id", conn) ;
            if (conn.State == ConnectionState.Closed) conn.Open();
            comm.Parameters.Add("@Id",SqlDbType.Int).Value = cs._id;
            comm.Parameters.Add("@Name",SqlDbType.VarChar).Value = cs._name;
            comm.Parameters.Add("@Surname", SqlDbType.VarChar).Value = cs._surname;
            comm.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = cs._phoneNumber;
            comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = cs._email;
            comm.Parameters.Add("@Address", SqlDbType.VarChar).Value = cs._address;
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public bool DeleteContact(int ID)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cmn.connStr);
            SqlCommand comm = new SqlCommand("update Contacts set isDeleted=1 where id=@ID", conn);
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
    }
}
