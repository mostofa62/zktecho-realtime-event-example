using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripodAccessMultiTasking
{
    class DeviceManager
    {

        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private int idwErrorCode;
        private Form1 form = null;
        public void setForm(Form1 form)
        {
            this.form = form;
        }

        public Form1 getForm()
        {
            return form;
        }

        public void intervalRunner_Display(int iMachineNumber, string IPAddr)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            int min = Convert.ToInt32(ConfigurationManager.AppSettings["ReRegisterEventInterval"]), factor = 60000;
            int interval = min * factor;// 4 * 1 minutes
            timer.Elapsed += new System.Timers.ElapsedEventHandler((object sender, System.Timers.ElapsedEventArgs e) =>
            {

                if (axCZKEM1.GetDeviceIP(iMachineNumber, IPAddr))
                {
                    Console.WriteLine("---Device(" + iMachineNumber + ")[" + IPAddr + "]--Connected!Checking after Interval:=" + min + "(minutes)---");
                    //this.realEvent_OnAttTransaction(iMachineNumber[i]);
                }
                //Refresh
                Form1 tempForm = getForm();
                tempForm.Invoke((MethodInvoker)delegate ()
                {
                    //Console.WriteLine("[Setting Data To Form]");
                    tempForm.TablePanel.Visible = false;

                });

            });
            timer.Interval = interval;
            timer.Enabled = true;

        }

        public void intervalRunner(int[] iMachineNumber, string[] IPAddr)
        {


            System.Timers.Timer timer = new System.Timers.Timer();
            int min = Convert.ToInt32(ConfigurationManager.AppSettings["ReRegisterEventInterval"]), factor = 60000;
            int interval = min * factor;// 4 * 1 minutes
            timer.Elapsed += new System.Timers.ElapsedEventHandler((object sender, System.Timers.ElapsedEventArgs e) =>
            {
                for (int i = 0; i < IPAddr.Length; i++)
                {

                    if (axCZKEM1.GetDeviceIP(iMachineNumber[i], IPAddr[i]))
                    {
                        Console.WriteLine("---Device(" + iMachineNumber[i] + ")[" + IPAddr[i] + "]-Connected!Checking after Interval:=" + min + "(minutes)---");
                        //this.realEvent_OnAttTransaction(iMachineNumber[i]);
                    }
                }

                

            });
            timer.Interval = interval;
            timer.Enabled = true;
        }

        public int isConected(String div_ip, int machineNo)
        {


            bool isConnected = axCZKEM1.Connect_Net(div_ip, 4370);
            Console.WriteLine("Device(" + machineNo + ")[" + div_ip + "]=" + isConnected);
            if (isConnected == true)
            {
                int machineNumber = machineNo;
                bool gg = axCZKEM1.EnableDevice(machineNumber, true);
                return 1;
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                Console.WriteLine("Device Conection Fialed" + idwErrorCode);
                Console.ReadLine();

                return idwErrorCode;
            }

        }
        /** Event Maincast **/
        /*
        public void realEvent_OnAttTransaction(int iMachineNumber)
        {

            Console.WriteLine("Flash Registering Realtime Event For Machine:" + iMachineNumber);

            axCZKEM1.OnAttTransaction -= new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler((int EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second) =>
            {
                axCZKEM1_OnAttTransaction(EnrollNumber, IsInValid, AttState, VerifyMethod, Year, Month, Day, Hour, Minute, Second, iMachineNumber);
            });

            if (axCZKEM1.RegEvent(iMachineNumber, 65535))
            {
                Console.WriteLine("Registering Realtime Event For Machine:" + iMachineNumber);
                axCZKEM1.OnAttTransaction += new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler((int EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second) =>
                {
                    axCZKEM1_OnAttTransaction(EnrollNumber, IsInValid, AttState, VerifyMethod, Year, Month, Day, Hour, Minute, Second, iMachineNumber);
                });
            }
        }*/

        public void realEvent_OnAttTransaction_Display(int iMachineNumber, string deviceIp)
        {

            Console.WriteLine("Flash Registering Realtime Event For Machine:" + iMachineNumber+", Ip:"+deviceIp);

            axCZKEM1.OnAttTransaction -= new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler((int EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second) =>
            {
                axCZKEM1_OnAttTransaction_Display(EnrollNumber, IsInValid, AttState, VerifyMethod, Year, Month, Day, Hour, Minute, Second, iMachineNumber, deviceIp);
            });

            if (axCZKEM1.RegEvent(iMachineNumber, 65535))
            {
                Console.WriteLine("Registering Realtime Event For Machine:" + iMachineNumber + ", Ip:" + deviceIp);
                axCZKEM1.OnAttTransaction += new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler((int EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second) =>
                {
                    axCZKEM1_OnAttTransaction_Display(EnrollNumber, IsInValid, AttState, VerifyMethod, Year, Month, Day, Hour, Minute, Second, iMachineNumber, deviceIp);
                });
            }
        }

        //the actual event
        public void axCZKEM1_OnAttTransaction_Display(int EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second, int MachineNo, string deviceIp)
        {

            Console.WriteLine("--------------- Per Log Device(" + MachineNo + ")+Ip("+deviceIp+") --------------");
            string time = Year + "-" + Month + "-" + Day + " " + Hour + ":" + Minute + ":" + Second;
            Console.WriteLine("Verified(" + MachineNo + ") [ UserID=" + EnrollNumber.ToString() + " isInvalid=" + IsInValid.ToString() + " state=" + AttState.ToString() + " verifystyle=" + VerifyMethod.ToString() + " time=" + time + "]");
            //global data for setting

            string image_name = null;
            string officer_name = null;
            string mobile_number = null;
            string rank_name = null;
            string serviceid = null;

            //end global data for setting

            //Read Data From Machine
            int idwErrorCode = 0;
            int iPrivilege = 0;
            string strName = null;
            string strCardno = null;
            string strPassword = null;
            bool bEnabled = false;

            axCZKEM1.EnableDevice(MachineNo, false);
            if (axCZKEM1.GetUserInfo(MachineNo, EnrollNumber, ref strName, ref strPassword, ref iPrivilege, ref bEnabled))//upload the user's information(card number included)
            {
                axCZKEM1.GetStrCardNumber(out strCardno);
                if (strCardno.Equals("0"))
                {
                    strCardno = null;
                }


                //Console.WriteLine("Get user information successfully = " + strCardno);

            }
            else
            {

                Console.WriteLine("*Operation failed Getting User Information,ErrorCode=" + idwErrorCode.ToString());
            }
            axCZKEM1.EnableDevice(MachineNo, true);
            Console.WriteLine("CARD NUMBER=" + strCardno);
            //end Read Data From Machine

            //Database Part
            string host = "10.10.200.49";
            int port = 3306;
            string database = "cghq_access";
            string username = "btl";
            string password = "ggwp1234";
            string cs = "Server=" + host + ";Database=" + database + ";Port=" + port + ";User Id=" + username + ";password=" + password + ";Connect Timeout=1;";

            if (strCardno != null)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    try
                    {
                        con.Open();

                        using (MySqlCommand cmd = con.CreateCommand())
                        {

                            cmd.CommandText = @"select officer_name, mobile_no, rnk.rank_name, service_id, image_path from cghq_access.employee em
left join cghq_access.ranks rnk on em.rank_code = rnk.rank_code 
where em.card_id like '%" + strCardno + "%' limit 1";
                            using (MySqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.HasRows)
                                {
                                    dr.Read();
                                    officer_name = dr.GetValue(0).ToString();
                                    mobile_number = dr.GetValue(1).ToString();
                                    rank_name = dr.GetValue(2).ToString();
                                    serviceid = dr.GetValue(3).ToString();
                                    image_name = dr.GetValue(4).ToString();
                                    Console.WriteLine("[Name: " + officer_name + ", Mobile: " + mobile_number + ", Rank: " + rank_name + ", Service No: " + serviceid + ", Image File: " + image_name + "]");
                                }
                            }


                        }

                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Database Exception: " + ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }



                }
            }

            //end Database Part


            //Image Operation Related
            string imgFolderPath = @"D:\photos\emp_photo\";
            if (image_name != null)
            {
                string fullImgPath = imgFolderPath + image_name;
                if (File.Exists(fullImgPath))
                {
                    image_name = fullImgPath;

                }
                else
                {
                    image_name = imgFolderPath + "gg.jpg";
                }

            }
            else
            {
                image_name = imgFolderPath + "gg.jpg";
            }
            Console.WriteLine("Showing Image This: " + image_name);
            Image image = Image.FromFile(image_name);
            //end Image Operation Related

            //Set Data To Form
            Form1 tempForm = getForm();
            
            tempForm.Invoke((MethodInvoker)delegate ()
            {
                //Console.WriteLine("[Setting Data To Form]");
                tempForm.TablePanel.Visible = true;
                tempForm.pictureBox1.Image = image;
                tempForm.OfficerName.Text = officer_name;
                tempForm.Rank.Text = rank_name;
                tempForm.ServiceId.Text = serviceid;
                tempForm.MobileNumber.Text = mobile_number;
            });
            image = null;
            //end Set Data Form

            Console.WriteLine("-------End Per Log(" + MachineNo + ")+("+deviceIp+") --------");
        }
        //end actual event

        /** End Event MainCast **/
    }
}
