using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TripodAccessMultiTasking
{
    class Program
    {
        //[STAThread]
        static void Main(string[] args)
        {
            //WriteLog("Starting Application");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            //LoadDeviceRealtimer(form);
            //LoadSingleRealtimer(form);
            LoadDeviceWithConfiguration(form);
            Application.Run(form);
            //test();
            //Console.ReadLine();
            //string ddate = "04/12/2019";
            //DateTime oDate = DateTime.ParseExact(ddate, "dd/m/yyyy", null);

            //String dr = oDate.ToString("yyyy-mmm-dd");
            // Console.WriteLine("GGWP" + dr);

            // Form1 m = new Form1();
            // m.Show();




        }

        public static void LoadDeviceWithConfiguration(Form1 form)
        {
            //int deviceLength = Convert.ToInt32(ConfigurationManager.AppSettings["DeviceLength"]);

            //DeviceManager dm = new DeviceManager();
            //dm.setForm(form);
            /*
            for (int i=1;i<=deviceLength;i++)
            {
                
                string singleDeviceIp = ConfigurationManager.AppSettings["RealtimeDeviceIp"+i];
                int singleDeviceNumber = Convert.ToInt32(ConfigurationManager.AppSettings["RealtimeDeviceNumber" + i]);
                Task.Run(()=>
                LoadSingleRealtimerDisplay(dm, singleDeviceIp, singleDeviceNumber));
                //ConnectionRefresh(dm,singleDeviceIp,singleDeviceNumber);
            }*/
            string RealtimeDeviceIp1 = ConfigurationManager.AppSettings["RealtimeDeviceIp1"];
            int RealtimeDeviceNumber1 = Convert.ToInt32(ConfigurationManager.AppSettings["RealtimeDeviceNumber1"]);
            Thread t1 = new Thread(()=>LoadSingleRealtimerDisplay(form,RealtimeDeviceIp1, RealtimeDeviceNumber1));
            //t1.Start();

            string RealtimeDeviceIp2 = ConfigurationManager.AppSettings["RealtimeDeviceIp2"];
            int RealtimeDeviceNumber2 = Convert.ToInt32(ConfigurationManager.AppSettings["RealtimeDeviceNumber2"]);
            Thread t2 = new Thread(() => LoadSingleRealtimerDisplay(form, RealtimeDeviceIp2, RealtimeDeviceNumber2));
            //t2.Start();

            //one after another
            t1.Start();
            t1.Join();
            t2.Start();
            //t2.Join();
        }



        public static void LoadSingleRealtimerDisplay(Form1 form,string singleDeviceIp, int singleDeviceNumber)
        {
            DeviceManager dm = new DeviceManager();
            dm.setForm(form);
            //string singleDeviceIp = ConfigurationManager.AppSettings["singleDeviceIp"];
            //int singleDeviceNumber = Convert.ToInt32(ConfigurationManager.AppSettings["singleDeviceNumber"]);
            int connected = dm.isConected(singleDeviceIp, singleDeviceNumber);
            if (connected==1)
            {
                dm.realEvent_OnAttTransaction_Display(singleDeviceNumber, singleDeviceIp);
                dm.intervalRunner_Display(singleDeviceNumber, singleDeviceIp);
            }
        }
        



    }
}
