using KAutoHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoITControlPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C ping howkteam.com";
            Process.Start("cmd.exe", strCmdText);
        }

        private void btnCmdHide_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C \"How Kteam - Free Education How Kteam.html\"";

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = strCmdText;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();

            process.Kill();
        }

        private void btnCmdHideResult_Click(object sender, EventArgs e)
        {
            string cmdCommand;
            cmdCommand = "ping howkteam.com";

            Process process = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = strCmdText;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;

            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;

            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine(cmdCommand);
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();

            string result = process.StandardOutput.ReadToEnd();
            MessageBox.Show(result);

        }

        private void btnClickPoint_Click(object sender, EventArgs e)
        {
            int x = (Int32)pointCursorX.Value;
            int y = (Int32)pointCursorY.Value;

            //var hWnd = Process.GetProcessById(3652).MainWindowHandle;

            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtApplicationName.Text.Trim());


            var pointToClick = AutoControl.GetGlobalPoint(hWnd, x, y);

            EMouseKey eMouseKey = EMouseKey.LEFT;

            if (chkMouseRightClick.Checked)
            {
                if (chkMouseDoubleClick.Checked)
                {
                    eMouseKey = EMouseKey.DOUBLE_RIGHT;
                }
                else
                {
                    eMouseKey = EMouseKey.RIGHT;
                }
            }
            else
            {
                if (chkMouseDoubleClick.Checked)
                {
                    eMouseKey = EMouseKey.DOUBLE_LEFT;
                }
            }
            AutoControl.BringToFront(hWnd);

            AutoControl.MouseClick(pointToClick, eMouseKey);
        }

        private void btnClickControlApp_Click(object sender, EventArgs e)
        {
            int x = (Int32)pointCursorX.Value;
            int y = (Int32)pointCursorY.Value;

            //var hWnd = Process.GetProcessById(3652).MainWindowHandle;

            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtApplicationName.Text.Trim());


            var childWnd = IntPtr.Zero;
            childWnd = AutoControl.FindHandle(hWnd, txtClass.Text, txtClass.Text);

            var pointToClick = AutoControl.GetGlobalPoint(childWnd, x, y);

            EMouseKey eMouseKey = EMouseKey.LEFT;

            if (chkMouseRightClick.Checked)
            {
                if (chkMouseDoubleClick.Checked)
                {
                    eMouseKey = EMouseKey.DOUBLE_RIGHT;
                }
                else
                {
                    eMouseKey = EMouseKey.RIGHT;
                }
            }
            else
            {
                if (chkMouseDoubleClick.Checked)
                {
                    eMouseKey = EMouseKey.DOUBLE_LEFT;
                }
            }
            AutoControl.BringToFront(hWnd);

            AutoControl.MouseClick(pointToClick, eMouseKey);
        }

        private void btnSendKey_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtApplicationName.Text.Trim());

            AutoControl.BringToFront(hWnd);

            AutoControl.SendKeyFocus(KeyCode.ENTER);
        }

        private void btnSendMutilKey_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtApplicationName.Text.Trim());

            AutoControl.BringToFront(hWnd);

            AutoControl.SendMultiKeysFocus(new KeyCode[] { KeyCode.CONTROL, KeyCode.KEY_V });
        }

        private void btnEditTittle_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtApplicationName.Text.Trim());

            AutoControl.SendText(hWnd, "HowKteam.com");
        }

        private void btnSetTextToCbb_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtApplicationName.Text.Trim());

            var childWnd = AutoControl.FindHandle(hWnd, "ComboBoxEx32", null);

            AutoControl.SendText(childWnd, "HowKteam.com");
        }

        private void btnClickCtr_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtApplicationName.Text.Trim());

            var childWnd = AutoControl.FindHandle(hWnd, txtClass.Text, txtClass.Text);

            AutoControl.SendClickOnControlByHandle(childWnd);
        }

        private void btnClickPointHide_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtApplicationName.Text.Trim());

            var childWnd = AutoControl.FindHandle(hWnd, txtClass.Text, txtClass.Text);

            int x = (Int32)pointCursorX.Value;
            int y = (Int32)pointCursorY.Value;

            AutoControl.SendClickUpOnPosition(hWnd, x, y);
        }

        private void btnSendEnter_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, txtApplicationName.Text.Trim());

            var childWnd = AutoControl.FindHandle(hWnd, txtClass.Text, txtClass.Text);

            AutoControl.SendKeyBoardPress(childWnd, VKeys.VK_RETURN);
        }

        private void btnCheckImage_Click(object sender, EventArgs e)
        {
            var screen = CaptureHelper.CaptureScreen();
            screen.Save("mainScreen.PNG");

            var subBitmap = ImageScanOpenCV.GetImage("template.PNG");

            var resBitMap = ImageScanOpenCV.Find((Bitmap)screen, subBitmap);
            if (resBitMap != null)
            {
                resBitMap.Save("res.PNG");
            }
        }

        private void btnExportPoint_Click(object sender, EventArgs e)
        {
            var screen = CaptureHelper.CaptureScreen();
            screen.Save("mainScreen.PNG");

            var subBitmap = ImageScanOpenCV.GetImage("template.PNG");

            var resBitMap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitMap != null)
            {
                MessageBox.Show(resBitMap.ToString());
            }
        }
    }
}
