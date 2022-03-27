using System.Diagnostics;
using System.Runtime.InteropServices;

namespace T4AutoClicker
{
    public partial class Form1 : Form
    {

        int clicks = 0;// Clicks left 

        Process[] processCollection;
        Process fastClickProcess;
        public Form1()
        {
            InitializeComponent();
            track_count_Scroll(null, null);
            track_time_Scroll(null, null);

        }

        private void track_count_Scroll(object sender, EventArgs e)
        {
            label_show_count.Text = track_count.Value.ToString() + " кликов";
        }

        private void track_time_Scroll(object sender, EventArgs e)
        {
            label_show_time.Text = track_time.Value.ToString() + " мс";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            make_click();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Rect rect = getWindowRect(fastClickProcess);

            // create X,Y point (0,0) explicitly with System.Drawing 
            System.Drawing.Point centerFormPosition = new System.Drawing.Point((rect.Left + rect.Right) / 2, (rect.Top + rect.Bottom) / 2);

            Point delta = new Point(0, -120);
            Point newCursorPosition = new Point(centerFormPosition.X + delta.X, centerFormPosition.Y + delta.Y);

            timerStart.Enabled = true;
            // set mouse position
            Cursor.Position = newCursorPosition;
            DoMouseClick();

        }

        void start_clicker()
        { 
            clicks = track_count.Value;
            button_start.Enabled = false;
            timer.Interval = track_time.Value;
            timer.Enabled = true;

          
        }

        void make_click()
        {
            clicks--;
            DoMouseClick();    
            if(clicks == 0)
            {
                stop_clicker();
            }
        }
        void stop_clicker()
        {
            timer.Enabled=false;
            button_start.Enabled=true;
        }
        // https://stackoverflow.com/questions/2416748/how-do-you-simulate-mouse-click-in-c

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentMyComboBoxIndex = comboBox1.SelectedIndex;

            fastClickProcess = processCollection[currentMyComboBoxIndex];

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

           processCollection = Process.GetProcesses();

            string[] process_names = new string[processCollection.Length];
               
            int i = 0;
            foreach (Process p in processCollection)
            {
                process_names[i] = p.ProcessName;
                
                i++;
            }

            comboBox1.Items.Clear();

            comboBox1.Items.AddRange(process_names);
        }

        /* Get window position by process name */
       [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        Rect getWindowRect(Process process) { 

            IntPtr ptr = process.MainWindowHandle;
            Rect windowRect = new Rect();
            GetWindowRect(ptr, ref windowRect);
            return windowRect;
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            Rect rect = getWindowRect(fastClickProcess);

            System.Drawing.Point centerFormPosition = new System.Drawing.Point((rect.Left + rect.Right) / 2, (rect.Top + rect.Bottom) / 2);
            Cursor.Position = centerFormPosition;
            timerStart.Enabled = false;

            start_clicker();
        }
    }
}