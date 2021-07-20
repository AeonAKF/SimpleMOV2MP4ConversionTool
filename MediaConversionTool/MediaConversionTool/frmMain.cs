using System;
using System.Threading;
using System.Windows.Forms;

namespace MediaConversionTool
{
    public partial class frmMain : Form
    {
        // Select output folder
        private FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
        // Delegate for safe cross thread access from conversion thread to main window thead
        private delegate void SafeCallDelegate(bool blEnabled);
        private delegate void SafeCallDelegate1(int intZero);
        private delegate void SafeCallDelegate2(ProgressBarStyle cont);

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "mov files (*.mov)|*.mov|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtBoxOpen.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Opening File. Message - " + ex.Message);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxSave.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Disable controls to avoid multiple attempts at converting th same file
            btnConvert.Enabled = false;
            btnExit.Enabled = false;
            btnOpen.Enabled = false;
            btnSave.Enabled = false;
            txtBoxFileName.Enabled = false;
            txtBoxOpen.Enabled = false;
            txtBoxSave.Enabled = false;

            prgConvert.Style = ProgressBarStyle.Marquee;
            prgConvert.MarqueeAnimationSpeed = 30;

            // Create media conversion thread
            Thread th = new Thread(new ThreadStart(convert));

            // Start media conversion thread
            try
            {
                th.Start();
            }
            catch (Exception ex)
            {
                prgConvert.MarqueeAnimationSpeed = 0;
                prgConvert.Style = ProgressBarStyle.Continuous;
                btnConvert.Enabled = true;
                btnExit.Enabled = true;
                btnOpen.Enabled = true;
                btnSave.Enabled = true;
                txtBoxFileName.Enabled = true;
                txtBoxOpen.Enabled = true;
                txtBoxSave.Enabled = true;

                if (th.ThreadState != ThreadState.Aborted) { th.Abort(); }

                MessageBox.Show("Error converting file: " + ex.Message);
            }


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This program uses the MediaToolKit by Aydin Adn. I used it simply to convert MOV files to MP4, it is capable of a lot more but I have not tried anything else. Feel free to modify this program to suit your needs and explore the full functionality of the kit. \r\n\r\n More info can be found at https://github.com/AydinAdn/MediaToolkit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Convert MOV file to MP4
        private void convert()
        {
            var inputFile = new MediaToolkit.Model.MediaFile { Filename = txtBoxOpen.Text };
            var outputFile = new MediaToolkit.Model.MediaFile { Filename = txtBoxSave.Text + "\\" + txtBoxFileName.Text };

            using (var engine = new MediaToolkit.Engine())
            {
                engine.Convert(inputFile, outputFile);
            }

            // Safely enable controls
            SetEnabled();

            MessageBox.Show("Done", "Conversion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Check need for invocation of controls from conversion thread
        private void SetEnabledSafe(bool blEnabled1)
        {
            if (btnConvert.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetEnabledSafe);
                btnConvert.Invoke(d, new object[] { blEnabled1 });
            }
            else
            {
                btnConvert.Enabled = blEnabled1;
            }

            if (btnExit.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetEnabledSafe);
                btnExit.Invoke(d, new object[] { blEnabled1 });
            }
            else
            {
                btnExit.Enabled = blEnabled1;
            }

            if (btnOpen.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetEnabledSafe);
                btnOpen.Invoke(d, new object[] { blEnabled1 });
            }
            else
            {
                btnOpen.Enabled = blEnabled1;
            }

            if (btnSave.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetEnabledSafe);
                btnSave.Invoke(d, new object[] { blEnabled1 });
            }
            else
            {
                btnSave.Enabled = blEnabled1;
            }

            if (txtBoxFileName.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetEnabledSafe);
                txtBoxFileName.Invoke(d, new object[] { blEnabled1 });
            }
            else
            {
                txtBoxFileName.Enabled = blEnabled1;
            }

            if (txtBoxOpen.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetEnabledSafe);
                txtBoxOpen.Invoke(d, new object[] { blEnabled1 });
            }
            else
            {
                txtBoxOpen.Enabled = blEnabled1;
            }

            if (txtBoxSave.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetEnabledSafe);
                txtBoxSave.Invoke(d, new object[] { blEnabled1 });
            }
            else
            {
                txtBoxSave.Enabled = blEnabled1;
            }

            if (prgConvert.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetEnabledSafe);
                prgConvert.Invoke(d, new object[] { blEnabled1 });
            }
            else
            {
                prgConvert.MarqueeAnimationSpeed = 0;
            }

            if (prgConvert.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetEnabledSafe);
                prgConvert.Invoke(d, new object[] { blEnabled1 });
            }
            else
            {
                prgConvert.Style = ProgressBarStyle.Continuous;
            }
        }

        private void SetEnabledSafe1(int int1)
        {

            if (prgConvert.InvokeRequired)
            {
                var d = new SafeCallDelegate1(SetEnabledSafe1);
                prgConvert.Invoke(d, new object[] { int1 });
            }
            else
            {
                prgConvert.MarqueeAnimationSpeed = int1;
            }
        }

        private void SetEnabledSafe2(ProgressBarStyle prgCont)
        {

            if (prgConvert.InvokeRequired)
            {
                var d = new SafeCallDelegate2(SetEnabledSafe2);
                prgConvert.Invoke(d, new object[] { prgCont });
            }
            else
            {
                prgConvert.Style = prgCont;
            }

        }

        private void SetEnabled()
        {
            SetEnabledSafe(true);
            SetEnabledSafe1(0);
            SetEnabledSafe2(ProgressBarStyle.Continuous);
        }
    }
}
