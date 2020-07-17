using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

namespace myAlarm
{
    public partial class MainForm : Form
    {
        private int TotalTime = 0;
        private bool AlarmOn = false;
        private WindowsMediaPlayer Media = new WindowsMediaPlayer();

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Media.URL = string.Format(@"{0}\{1}", Application.StartupPath, "monogram.mp3");
            this.Media.controls.stop();
            this.timer_main.Start();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            this.label_time_main.Text = DateTime.Now.ToString("HH:mm:ss");
            this.label_time_remain.Text = TimeSpan.FromSeconds(this.TotalTime).ToString(@"hh\:mm\:ss");
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            this.label_time_main.Text = DateTime.Now.ToString("HH:mm:ss");

            if (this.TotalTime > 0)
            {
                this.TotalTime--;
                this.label_time_remain.Text = TimeSpan.FromSeconds(this.TotalTime).ToString(@"hh\:mm\:ss");

                if (this.TotalTime == 0 && this.AlarmOn)
                {
                    this.AlarmOn = false;
                    AlarmStart();
                }
            }
        }

        private void AddAlarmTime(int min)
        {
            this.AlarmOn = true;
            this.TotalTime += min * 60;
            this.label_time_remain.Text = TimeSpan.FromSeconds(this.TotalTime).ToString(@"hh\:mm\:ss");
        }

        private void AlarmStart()
        {
            for (int i = 0; i < 50; i++)
            {
                VolumeUp();
            }
            this.Media.controls.play();
        }

        private void AlarmStop()
        {
            for (int i = 0; i < 50; i++)
            {
                VolumeDown();
                Delay(90);
            }
            this.Media.controls.stop();
        }

        private void button_10min_Click(object sender, EventArgs e)
        {
            AddAlarmTime(10);
        }

        private void button_30min_Click(object sender, EventArgs e)
        {
            AddAlarmTime(30);
        }

        private void button_60min_Click(object sender, EventArgs e)
        {
            AddAlarmTime(60);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.AlarmOn = false;
            this.TotalTime = 0;
            this.label_time_remain.Text = TimeSpan.FromSeconds(this.TotalTime).ToString(@"hh\:mm\:ss");
            AlarmStop();
        }

        private void label_time_remain_DoubleClick(object sender, EventArgs e)
        {
            // test place
            AddAlarmTime(1);
        }

        /// <summary>
        /// Set System Volume Windows 10 in C# 
        /// https://stackoverflow.com/questions/35597458/set-system-volume-windows-10-in-c-sharp
        /// </summary>
        private const byte VK_VOLUME_MUTE = 0xAD;
        private const byte VK_VOLUME_DOWN = 0xAE;
        private const byte VK_VOLUME_UP = 0xAF; //0xAF;
        private const UInt32 KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const UInt32 KEYEVENTF_KEYUP = 0x0002;

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, UInt32 dwFlags, UInt32 dwExtraInfo);

        [DllImport("user32.dll")]
        static extern Byte MapVirtualKey(UInt32 uCode, UInt32 uMapType);

        public static void VolumeUp()
        {
            keybd_event(VK_VOLUME_UP, MapVirtualKey(VK_VOLUME_UP, 0), KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event(VK_VOLUME_UP, MapVirtualKey(VK_VOLUME_UP, 0), KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        public static void VolumeDown()
        {
            keybd_event(VK_VOLUME_DOWN, MapVirtualKey(VK_VOLUME_DOWN, 0), KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event(VK_VOLUME_DOWN, MapVirtualKey(VK_VOLUME_DOWN, 0), KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        public static void Mute()
        {
            keybd_event(VK_VOLUME_MUTE, MapVirtualKey(VK_VOLUME_MUTE, 0), KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event(VK_VOLUME_MUTE, MapVirtualKey(VK_VOLUME_MUTE, 0), KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        /// <summary>
        /// delay
        /// https://bananamandoo.tistory.com/27 [바나나만두의 넋두리]
        /// </summary>
        /// <param name="MS"></param>
        /// <returns></returns>
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

    }
}
