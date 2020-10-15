using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HotelMg
{
    class Model
    {

        static MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=False;database=creds");
        static MySqlConnection conn1 = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=False;database=creds");
        public static string checkuname(string x, string pass)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM users WHERE user_name='{x}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["Password"].Equals(pass))
                    {
                        return null;
                    }
                    else
                    {
                        return "Invalid Password";
                    }
                }
                else
                {
                    return "Username not found";
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string CheckTitle(string x)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM title WHERE user_name='{x}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["Title"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static void AddRoom(int roomNo, string roomType)
        {
            try
            {

                if (checkRoom(roomNo))
                {
                    MessageBox.Show("Room Number already existed");

                }
                else
                {
                    conn.Open();
                    string query1 = $"SELECT * FROM room_types WHERE type='{roomType}'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.Read())
                    {
                        int x = Convert.ToInt32(reader1["ID"]);
                        string query2 = $"INSERT INTO room VALUES({roomNo},{x})";
                        MySqlCommand cm = new MySqlCommand(query2, conn);
                        reader1.Close();
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Room Added Successfully");

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace + "\n" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void delroom(int roomNo)
        {
            string title = $"Delete Room {roomNo}";
            if (checkRoom(roomNo))
            {
                MessageBoxButtons btns = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show("Are you sure to Delete Room" + roomNo, title, btns);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string query = $"DELETE FROM room WHERE room_no={roomNo}";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(roomNo + " Deleted Succcessfulyl", title);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Room Number Does not Exist", title);
            }
        }
        public static bool checkRoom(int roomNo)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM room WHERE room_no={roomNo}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public static ListViewItem[] loadRooms()
        {
            try
            {
                ListViewItem[] lvi = new ListViewItem[100];
                conn.Open();
                int i = 1;
                string[] arr = new string[3];
                string query = "SELECT * FROM room";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int roomID = Convert.ToInt32(reader["room_type"]);
                    int roomNo = Convert.ToInt32(reader["room_no"]);
                    string type = getRoomType(roomID);
                    float price = getRoomPrice(roomID);
                    arr[0] = roomNo.ToString();
                    arr[1] = type;
                    arr[2] = price.ToString();
                    lvi[i] = new ListViewItem(arr);
                    i++;
                }
                arr[0] = i.ToString();
                lvi[0] = new ListViewItem(arr);
                return lvi;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace + "\n" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string getRoomType(int id)
        {
            try
            {
                conn1.Open();
                string query = $"SELECT * FROM room_types WHERE ID={id}";
                MySqlCommand cmd = new MySqlCommand(query, conn1);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string x = reader["type"].ToString();
                    reader.Close();
                    conn1.Close();
                    return x;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                conn1.Close();
            }
            return null;
        }
        public static int getRoomType(string roomType)
        {
            try
            {
                conn1.Open();
                string query = $"SELECT * FROM room_types WHERE type='{roomType}'";
                MySqlCommand cmd = new MySqlCommand(query, conn1);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int x = Convert.ToInt32(reader["ID"]);
                    reader.Close();
                    conn1.Close();
                    return x;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                conn1.Close();
            }
            return 0;
        }
        public static float getRoomPrice(int id)
        {
            try
            {
                conn1.Open();
                string query = $"SELECT * FROM room_types WHERE ID={id}";
                MySqlCommand cmd = new MySqlCommand(query, conn1);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    float x = Convert.ToSingle(reader["Price"]);
                    reader.Close();
                    conn1.Close();
                    return x;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                conn1.Close();
            }
            return 0.00f;

        }
        public static void updateRoom(int roomNo, string roomType)
        {
            if (checkRoom(roomNo))
            {
                try
                {
                    int x = getRoomType(roomType);
                    conn.Open();
                    string query = $"UPDATE room SET room_no={roomNo},room_type={x} WHERE room_no={roomNo}";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Room Number does not exist");
            }
        }
        public static bool ChekUserExist(string uname)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM users WHERE user_name='{uname}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public static void AddUser(string uname, string fname, string lname, int pno, string pass, string title)
        {
            Addpass(uname, pass);
            AddTitle(uname, title);
            try
            {
                conn.Open();
                string query = $"INSERT INTO info (First_name,Last_name,phone_number,user_name) VALUES('{fname}','{lname}',{pno},'{uname}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void AddTitle(string uname, string title)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO title VALUES('{uname}','{title}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        public static void Addpass(string uname, string pass)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO users VALUES('{uname}','{pass}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static string[] getUsers()
        {
            try
            {
                string[] x = new string[100];
                int i = 1;
                conn.Open();
                string query = "SELECT * FROM users WHERE user_name!='NatAdm'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string uname = reader["user_name"].ToString();
                    x[i] = uname;
                    i++;
                }
                x[0] = i.ToString();
                return x;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string getTitle(string uname)
        {
            try
            {
                conn1.Open();
                string query = $"SELECT * FROM title WHERE user_name='{uname}'";
                MySqlCommand cmd = new MySqlCommand(query, conn1);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string x = reader["Title"].ToString();
                    reader.Close();
                    conn1.Close();
                    return x;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn1.Close();
            }
            return null;
        }
        public static string getInfo(string uname)
        {
            try
            {
                conn1.Open();
                string query = $"SELECT * FROM info WHERE user_name='{uname}'";
                MySqlCommand cmd = new MySqlCommand(query, conn1);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string infos = reader["First_name"].ToString();
                    infos += ":" + reader["Last_name"].ToString();
                    infos += ":" + reader["phone_number"].ToString();
                    reader.Close();
                    conn1.Close();
                    return infos;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn1.Close();
            }
            return null;
        }
        public static void updateinfo(string olduname, string newuname, string fname, string lname, int pno)
        {
            try
            {
                conn.Open();
                string query = $"UPDATE info SET user_name='{newuname}',First_name='{fname}',Last_name='{lname}',phone_number={pno} WHERE user_name='{olduname}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void updatetitle(string olduname, string newuname, string title)
        {
            try
            {
                conn.Open();
                string query = $"UPDATE title SET user_name='{newuname}', Title='{title}' WHERE user_name='{olduname}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void updateuser(string olduname, string newuname, string pass)
        {
            try
            {
                conn.Open();
                string query = $"UPDATE users SET user_name='{newuname}',Password='{pass}'  WHERE user_name='{olduname}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void deletee(string uname)
        {
            try
            {
                conn.Open();
                string query = $"DELETE FROM users WHERE user_name='{uname}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static string[] getRooms()
        {
            try
            {
                string[] arr = new string[100];
                int i = 1;
                conn.Open();
                string query = $"SELECT * FROM room WHERE room.room_no NOT IN(SELECT room_no FROM bookedroom)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int roomno = Convert.ToInt32(reader["room_no"]);
                    int x = Convert.ToInt32(reader["room_type"]);
                    string type = getRoomType(x);
                    float price = getRoomPrice(x);
                    arr[i] = roomno.ToString();
                    if (type.Equals("Normal"))
                    {
                        arr[i] += ":\t\t\t" + type + ":\t\t\t" + price;
                    }
                    else
                    {
                        arr[i] += ":\t\t\t" + type + ":\t\t" + price;
                    }
                    i++;
                }
                arr[0] = i.ToString();
                return arr;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static void addGuests(string fname, string lname, int pno, string address, string dattte)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO guest (First_name,Last_name,phone_number,Address,datte) VALUES ('{fname}','{lname}',{pno},'{address}','{dattte}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static int getRecieptId(string datte)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM reciept WHERE datte='{datte}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Rec_id"]);
                    reader.Close();
                    conn.Close();
                    return id;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }
        public static void addReciept(string gen_by, string name, string datte, float price, float tax, float total)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO reciept (generated_by,Name,datte,price,tax,total_price) VALUES('{gen_by}','{name}','{datte}',{price},{tax},{total})";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void bookguest(int romno, int id, int rec_id)
        {
            try
            {
                conn1.Open();
                string query = $"INSERT INTO bookedroom (room_no,guest_id,Rec_id) VALUES({romno},{id},{rec_id})";
                MySqlCommand cmd = new MySqlCommand(query, conn1);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn1.Close();
            }
        }
        public static int guestId(string dattte)
        {
            try
            {
                conn1.Open();
                string query = $"SELECT * FROM guest WHERE datte='{dattte}'";
                MySqlCommand cmd = new MySqlCommand(query, conn1);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    reader.Close();
                    conn1.Close();
                    return id;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn1.Close();
            }
            return 0;
        }
        public static string[] getBookedRooms()
        {
            try
            {
                string[] arr = new string[100];
                int i = 1;
                conn.Open();
                string query = $"SELECT * FROM room WHERE room.room_no IN(SELECT room_no FROM bookedroom)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int roomno = Convert.ToInt32(reader["room_no"]);
                    int x = Convert.ToInt32(reader["room_type"]);
                    string type = getRoomType(x);
                    float price = getRoomPrice(x);
                    arr[i] = roomno.ToString();
                    if (type.Equals("Normal"))
                    {
                        arr[i] += ":\t\t\t" + type + ":\t\t\t" + price;
                    }
                    else
                    {
                        arr[i] += ":\t\t\t" + type + ":\t\t" + price;
                    }
                    i++;
                }
                arr[0] = i.ToString();
                return arr;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string[] getGuestInfo(int id)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM guest WHERE ID={id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader["First_name"].ToString() + " " + reader["Last_name"];
                    string pno = reader["phone_number"].ToString();
                    string address = reader["Address"].ToString();
                    string datee = reader["datte"].ToString();
                    string[] x = new string[4];
                    x[0] = string.Format("Name: {0}", name);
                    x[1] = string.Format("Phone number: {0}", pno);
                    x[2] = string.Format("Address: {0}", address);
                    x[3] = string.Format("Date: {0}", datee);
                    reader.Close();
                    conn.Close();
                    return x;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string[] getRecieptInfo(int id)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM reciept WHERE Rec_id={id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string[] x = new string[6];
                    string rec_id = reader["generated_by"].ToString();
                    string name = reader["Name"].ToString();
                    string datte = reader["datte"].ToString();
                    string price = reader["price"].ToString();
                    string tax = reader["tax"].ToString();
                    string total = reader["total_price"].ToString();
                    x[0] = string.Format("Generated By: {0}", rec_id);
                    x[1] = string.Format("Name: {0}", name);
                    x[2] = string.Format("Date: {0}", datte);
                    x[3] = string.Format("Price: {0}", price);
                    x[4] = string.Format("Tax: {0}", tax);
                    x[5] = string.Format("Total Price: {0}", total);
                    reader.Close();
                    conn.Close();
                    return x;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string getguestidandrecid(int id)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM bookedroom WHERE room_no={id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string x = reader["guest_id"].ToString() + ":";
                    x += reader["Rec_id"].ToString();
                    reader.Close();
                    conn.Close();
                    return x;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;

        }
        public static void releasebooking(int roomno,int guest_id,int rec_id,string datte)
        {
            try
            {
                conn.Open();
                string query=$"INSERT INTO historyofbooking (room_no,guest_id,Rec_id,datte) VALUES({roomno},{guest_id},{rec_id},'{datte}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void delfrombooked(int roomno)
        {
            try
            {
                conn.Open();
                string query = $"DELETE FROM bookedroom WHERE room_no={roomno}";
                MySqlCommand cmd1 = new MySqlCommand(query, conn);
                cmd1.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static string[] searchGuest(string name)
        {
            try
            {
                string[] x = new string[100];
                int i = 1;
                conn.Open();
                string query = $"SELECT * FROM guest WHERE First_name LIKE '{name}%'";
                MySqlCommand cmd = new MySqlCommand(query,conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string namme = reader["First_name"].ToString() + " "+reader["Last_name"].ToString();
                    string pno = reader["phone_number"].ToString();
                    string address = reader["Address"].ToString();
                    string dattte = reader["datte"].ToString();
                    x[i] = string.Format("{0}: \t {1}: \t {2}: \t {3}",namme,pno,address,dattte);
                    i++;
                }
                x[0] = i.ToString();
                if (i == 1)
                {
                    return null;
                }
                else
                {
                    return x;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string[] searchguestbydate(string name,string datte)
        {
            try
            {
                string[] x = new string[100];
                int i = 1;
                conn.Open();
                string query = $"SELECT * FROM guest WHERE First_name LIKE '{name}%' AND datte LIKE '{datte}%'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string namme = reader["First_name"].ToString() + " " + reader["Last_name"].ToString();
                    string pno = reader["phone_number"].ToString();
                    string address = reader["Address"].ToString();
                    string dattte = reader["datte"].ToString();
                    x[i] = string.Format("{0}: \t {1}: \t {2}: \t {3}", namme, pno, address, dattte);
                    i++;
                }
                x[0] = i.ToString();
                if (i == 1)
                {
                    return null;
                }
                else
                {
                    return x;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static void regreserv(int noofguest,string date,string det,string tim,int tabno)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO reservations (no_of_guest,res_date,res_detail,res_time,table_no) VALUES({noofguest},'{date}','{det}','{tim}',{tabno})";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static string [] getreserv()
        {
            try
            {

                conn.Open();
                string[] x = new string[100];
                int i = 1;
                string query = $"SELECT * FROM reservations ORDER BY res_date ASC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader["res_id"].ToString();
                    string reservdet = reader["res_detail"].ToString();
                    string noofguest = reader["no_of_guest"].ToString();
                    string datte = reader["res_date"].ToString();
                    string[] h = datte.Split(' ');
                    datte = h[0];
                    x[i] = string.Format("{0}:{1} \t {2} \t\t {3}",id,reservdet,datte,noofguest);
                    i++;
                }
                x[0] = i.ToString();
                reader.Close();
                return x;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string[] getreserv1()
        {
            try
            {

                string[] cc = DateTime.Now.ToString().Split(' '); 
                conn.Open();
                string[] x = new string[100];
                int i = 1;
                string query = $"SELECT * FROM reservations WHERE res_date='{cc[0]}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader["res_id"].ToString();
                    string reservdet = reader["res_detail"].ToString();
                    string noofguest = reader["no_of_guest"].ToString();
                    string datte = reader["res_date"].ToString();
                    string[] h = datte.Split(' ');
                    datte = h[0];
                    x[i] = string.Format("{0}:{1} \t {2} \t\t {3}", id, reservdet, datte, noofguest);
                    i++;
                }
                x[0] = i.ToString();
                reader.Close();
                return x;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static int getCount(int res_id)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM reservations WHERE res_id={res_id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int noofguest = Convert.ToInt32(reader["no_of_guest"]);
                    reader.Close();
                    conn.Close();
                    return noofguest;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }
        public static int checkcount(int res_id)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM res_guest WHERE res_id={res_id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    i++;
                }
                reader.Close();
                conn.Close();
                return i;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }
        public static void reserveGuest(int gId,int rid)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO res_guest VALUES ({rid},{gId})";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static int [] getguestidfromres(int res)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM res_guest WHERE res_id={res}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int[] x = new int[10];
                int i = 1;
                while (reader.Read())
                {
                    int y = Convert.ToInt32(reader["guest_id"]);
                    x[i] = y;
                    i++;
                }
                x[0] = i;
                reader.Close();
                conn.Close();
                return x;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static void regoccasion(string ocname,string ocdate,string ocstarttime,string ocendtime,string ocdetail)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO occasions (oc_name,oc_date,oc_start_time,oc_end_time,oc_detail) VALUES ('{ocname}','{ocdate}','{ocstarttime}','{ocendtime}','{ocdetail}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static string[] getoccasions()
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM occasions";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader readr = cmd.ExecuteReader();
                string[] x = new string[100];
                int i = 1;
                while (readr.Read())
                {
                    string id = readr["oc_id"].ToString();
                    string ocname = readr["oc_name"].ToString();
                    string ocdate = readr["oc_date"].ToString();
                    x[i] = string.Format("{0}:{1} \t\t\t\t {2}",id,ocname,ocdate);
                    i++;
                }
                x[0] = i.ToString();
                readr.Close();
                conn.Close();
                return x;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string[] getoccasions1()
        {
            try
            {
                string[] cc = DateTime.Now.ToString().Split(' ');
                conn.Open();
                string query = $"SELECT * FROM occasions WHERE oc_date='{cc[0]}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader readr = cmd.ExecuteReader();
                string[] x = new string[100];
                int i = 1;
                while (readr.Read())
                {
                    string id = readr["oc_id"].ToString();
                    string ocname = readr["oc_name"].ToString();
                    string ocdate = readr["oc_date"].ToString();
                    x[i] = string.Format("{0}:{1} \t\t\t\t {2}", id, ocname, ocdate);
                    i++;
                }
                x[0] = i.ToString();
                readr.Close();
                conn.Close();
                return x;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public static string getoccs(int ocid)
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM occasions WHERE oc_id={ocid}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string x = string.Format("{0}:{1}:{2}:{3}:{4}",reader["oc_name"], reader["oc_date"], reader["oc_start_time"], reader["oc_end_time"], reader["oc_detail"]);
                    reader.Close();
                    conn.Close();
                    return x;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        } 
    }
}
