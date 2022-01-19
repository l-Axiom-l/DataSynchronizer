using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DataSynchronizer
{
    public partial class Form1 : Form
    {
        string TargetLocation;
        string OriginLocation;

        List<string> CopyList = new List<string>();
        copyDelegate CopyDelegate;

        DateTime LastDate;

        delegate void copyDelegate(string name, string location);

        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SynchronizeButton_Click(object sender, EventArgs e)
        {
            SynchronizeButton.Enabled = false;
            Date();
            Compare();
            StartCopy();
            DialogTimer.Enabled = true;
        }

        private void SetTargetLocation_Click(object sender, EventArgs e)
        {
            TargetChange.ShowDialog();
            TargetLocation = TargetChange.SelectedPath;
            TargetLocationText.Text = TargetLocation;
            SavePath();
        }

        private void SetOriginLocation_Click(object sender, EventArgs e)
        {
            OriginChange.ShowDialog();
            OriginLocation = OriginChange.SelectedPath;
            OriginLocationText.Text = OriginLocation;
            SavePath();
        }

        private void CSD_Click(object sender, EventArgs e)
        {
            File.Create("Data/Dates.txt");
        }

        private void ImportDates_Click(object sender, EventArgs e)
        {
            DateImport.ShowDialog();

        }

        private void ExportDates_Click(object sender, EventArgs e)
        {

        }

        private void AdvancedOptions_CB_CheckedChanged(object sender, EventArgs e)
        {
            AdvancedOptions_Box.Visible = AdvancedOptions_CB.Checked;
        }

        void Start()
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");

            if (!File.Exists("Data/Dates.txt"))
            {
                FileStream temp = File.Create("Data/Dates.txt");
                temp.Close();
            }

            if (!File.Exists("Data/Settings.ax"))
            {
                FileStream temp = File.Create("Data/Settings.ax");
                temp.Close();
            }

            if (File.ReadAllLines("Data/Settings.ax").Length > 0)
            {
                TargetLocation = File.ReadAllLines("Data/Settings.ax")[0];
                TargetLocationText.Text = TargetLocation;
            }

            if (File.ReadAllLines("Data/Settings.ax").Length > 0)
            {
                OriginLocation = File.ReadAllLines("Data/Settings.ax")[1];
                OriginLocationText.Text = OriginLocation;
            }
        }

        void Date()
        {

            if (File.ReadAllText("Data/Dates.txt").Length != 0)
            {
                LastDate = DateTime.Parse(File.ReadLines("Data/Dates.txt").Last());
            }
            else
                LastDate = new DateTime(1, 1, 1, 0, 0, 0);

            using (StreamWriter writer = File.AppendText("Data/Dates.txt"))
            {
                writer.Write(DateTime.Now.ToString() + Environment.NewLine);
            }
        }

        void Compare()
        {
            foreach (string Name in Directory.GetFiles(OriginLocation))
            {
                if (File.GetLastWriteTime(Name).CompareTo(LastDate) >= 0)
                {
                    CopyList.Add(Name);
                }
            }
        }

        void StartCopy()
        {
            float Step = 10000 / (CopyList.Count);
            PB.Step = (int)Step + 1;
            string temp = DateTime.Now.ToString().Replace(' ', '-');
            temp = temp.Replace('.', '_');
            temp = temp.Replace(':', '_');
            string location = TargetLocation + "/" + temp;

            Directory.CreateDirectory(location);
            foreach (string name in CopyList)
            {

                Thread thread = new Thread(Copy);
                string[] array = new string[2];
                array[0] = name;
                array[1] = location;
                thread.Name = "Test";
                thread.Start(array);
            }
        }

        private void Copy(object Array)
        {
            string[] temp = (string[])Array;
            File.Copy(temp[0], temp[1] + "/" + Path.GetFileName(temp[0]));
            PB.PerformStep();
        }

        void Reset()
        {
            CopyList.Clear();
            PB.Value = 0;
            SynchronizeButton.Enabled = true;
        }

        private void DialogTimer_Tick(object sender, EventArgs e)
        {
            if (PB.Value >= 10000)
            {
                DialogTimer.Enabled = false;
                DialogResult result = MessageBox.Show("Copying successful", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK || result == DialogResult.None)
                    Reset();
            }
        }

        void SavePath()
        {
            File.WriteAllText("Data/Settings.ax", TargetLocation + Environment.NewLine + OriginLocation);
        }
    }
}
