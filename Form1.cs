using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace TripodAccessMultiTasking
{
    public partial class Form1 : Form
    {
        //private BackgroundWorker imageLoader;
        public Form1()
        {
            InitializeComponent();
            //  this.imageLoader = new BackgroundWorker();
            //this.imageLoader.DoWork += HandleOnImageLoaderDoWork;
            //this.imageLoader.RunWorkerCompleted += HandleImageLoaderOnRunWorkerCompleted;

            //this.LoadUserDetails(1);
        }
        //public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        //MySqlConnection conn = DBUtils.GetDBConnection();
        //MySqlDataReader rdr = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadDeviceRealtimer();
            //Device_man dm = new Device_man();
            /*
            DeviceManager dm = new DeviceManager();
            dm.setForm(this);

            string device_ip_leftin = "10.10.200.61";
            int device_number_leftin = 1;
            //string device_ip_leftout = "10.10.200.62";

            //string device_ip_rightin = "10.10.200.59";
            string device_ip_rightin = "10.10.200.62";
            int device_number_rightin = 2;
            //string device_ip_rightout = "10.10.200.60";
            int isconnected_1 = dm.isConected(device_ip_leftin, device_number_leftin);
            //int isconnected_2 = dm.isConected(device_ip_rightin, device_number_rightin);
            int isconnected_2 = 1;
            if (isconnected_1 == 1 && isconnected_2 == 1)
            {
                Console.WriteLine("Device Connected !"+device_ip_leftin);
                Console.WriteLine("Device Connected !" + device_ip_rightin);
                dm.realEvent_OnAttTransaction(device_number_leftin);
                //dm.realEvent_OnAttTransaction(device_number_rightin);
            }*/

        }
        /*
        private void LoadDeviceRealtimer()
        {
            DeviceManager dm = new DeviceManager();
            dm.setForm(this);
            //Device numering done by clock-wise left side start order 1,2 3,4
            string device_ip_leftin = "10.10.200.61";
            int device_number_leftin = 1;

            string device_ip_leftout = "10.10.200.62";
            int device_number_leftout = 2;

            string device_ip_rightout = "10.10.200.60";
            int device_number_rightout = 3;

            string device_ip_rightin = "10.10.200.59";
            int device_number_rightin = 4;

            int isconnected_1 = dm.isConected(device_ip_leftin, device_number_leftin);
            //int isconnected_2 = dm.isConected(device_ip_leftout, device_number_leftout);
            int isconnected_2 = 1;
            if (isconnected_1 == 1 && isconnected_2 == 1)
            {
                Console.WriteLine("Device Connected !" + device_ip_leftin);
                //Console.WriteLine("Device Connected !" + device_ip_leftout);
                dm.realEvent_OnAttTransaction(device_number_leftin);
                dm.intervalRunner(device_number_leftin, device_ip_leftin);

                //dm.realEvent_OnAttTransaction(device_number_leftout);
            }



        }*/
        /*
        public void setImageToPictureBox(String imgName) {
            Console.WriteLine("From From1 Image name "+ imgName);
            const string imgFolderPath = @"D:\photos\";

            var fullImgPath = imgFolderPath + imgName;
            Console.WriteLine("From From1 Full Path  name " + fullImgPath);
            if (File.Exists(fullImgPath))
            {
                Console.WriteLine("From From1 file Exists loopps ");
                //  pictureBox1.Image = null;
                try
                {
                    pictureBox1.Image = Image.FromFile(fullImgPath);
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                }
                //this.Controls.Add(pictureBox1);
                // pictureBox1.Refresh();
                pictureBox1.Update();
                
            }
            else {
                Console.WriteLine("From From1 file Exists else ");
                fullImgPath = imgFolderPath + "gg.jpg";
                pictureBox1.Image = Image.FromFile(fullImgPath);
                pictureBox1.Update();
              //  pictureBox1.Refresh();
                

            }
          //  return 1;

        }*//*
        public String sta_getEmployeesByEnroll(int enrollNumber, int iMachineNumber)
        {
            int idwErrorCode = 0;
            int iPrivilege = 0;
            string strName = "";
            string strCardno = "";
            string strPassword = "";
            bool bEnabled = false;

            axCZKEM1.EnableDevice(1, false);
            Employee emp = new Employee();
            if (axCZKEM1.GetUserInfo(iMachineNumber, enrollNumber, ref strName, ref strPassword, ref iPrivilege, ref bEnabled))//upload the user's information(card number included)
            {
                axCZKEM1.GetStrCardNumber(out strCardno);
                if (strCardno.Equals("0"))
                {
                    strCardno = "";
                }


                Console.WriteLine("Get user information successfully" + strCardno);
                return strCardno;
            }
            else
            {

                Console.WriteLine("*Operation failed Getting User Information,ErrorCode=" + idwErrorCode.ToString());
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);



            return strCardno;
        }*/
        /*
        private void axCZKEM1_OnAttTransaction(int EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second)
        {   
            string time = Year + "-" + Month + "-" + Day + " " + Hour + ":" + Minute + ":" + Second;
            Console.WriteLine("Verify OK.UserID=" + EnrollNumber.ToString() + " isInvalid=" + IsInValid.ToString() + " state=" + AttState.ToString() + " verifystyle=" + VerifyMethod.ToString() + " time=" + time);
            string usr_rfid = sta_getEmployeesByEnroll(EnrollNumber, 1);
            Console.WriteLine("User Rfid card no" + usr_rfid);
            usr_rfid = "00000" + usr_rfid;
            string sqlMachines = String.Format("select image_path from employee where card_id='" + usr_rfid + "' and card_id!='' ");
            Console.WriteLine("Gettinge Image   Fom DB");

            // string cmdText = String.Format("INSERT INTO department(id,name) VALUES ({0}, '{1}')",id,name);
            string image_name = "gg.jpg";
            
            /*
            try
            {

                MySqlCommand cmd = new MySqlCommand(sqlMachines, conn);
                
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("Image From "+rdr.GetString(0));
                    image_name=rdr.GetString(0);
                }
                this.from.setImageToPictureBox(image_name);
            }
            catch (MySqlException e)
            {

                Console.WriteLine(e);
               // WriteLog(DateTime.Now + "---> DB ERROR!!!!!!" + e);
            }
            finally
            {
               // rdr.Close();

            }*//*
            Console.WriteLine("Finish DB path");
           // Form1 fm = new Form1();
            setImageToPictureBox(image_name);
            //textBox1.Text = "GGWP";

            // throw new NotImplementedException();
        }*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Rank_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RankLabel_Click(object sender, EventArgs e)
        {

        }
        /*
private void LoadUserDetails(Int32 userID)
{
Console.WriteLine("GG");
this.imageLoader.RunWorkerAsync(userID.ToString());
const string imgFolderPath = @"D:\photos\emp_photo\218.jpg";
pictureBox1.Image = Image.FromFile(imgFolderPath);
// get the user details
// populate the UI controls with the data....
}

private void HandleImageLoaderOnRunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
{
this.pictureBox1.Image = (Image)e.Result;
}

private void HandleOnImageLoaderDoWork(Object sender, DoWorkEventArgs e)
{
// simulate a web request for an image;
Thread.Sleep(3000);
Image image = Image.FromFile(@"D:\photos\emp_photo\218.jpg");
e.Result = image;
}
*/
    }
}
