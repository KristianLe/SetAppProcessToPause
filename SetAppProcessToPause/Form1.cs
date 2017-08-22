using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SetAppProcessToPause
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool DebugActiveProcess(uint dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool DebugActiveProcessStop(uint dwProcessId);

        KeyboardHook hook = new KeyboardHook();

        List<int> selectedProcesses = new List<int>();
        public Form1()
        {
            InitializeComponent();
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(SetAppProcessToPause.ModifierKeys.Control, Keys.F12);

            updateProcessList();
        }

        void updateProcessList()
        {
            List<object> generalProcessesRowsList = Process.GetProcesses().Select((Process process) =>
            {
                if (!selectedProcesses.Contains(process.Id))
                {
                    string processState = process.Responding ? "R" : "P";
                    string row = String.Format("{0, -10} {1, -2} {2, -30}", process.Id.ToString(), processState, process.ProcessName);
                    return (object)row;
                }
                else return null;
            }).ToList();

            generalProcessesRowsList.RemoveAll(item => item == null);

            object[] generalProcessesRows = generalProcessesRowsList.ToArray();

            runningProcessesListBox.Items.Clear();
            runningProcessesListBox.Items.AddRange(generalProcessesRows);

            List<object> selectedProcessesRowsList = Process.GetProcesses().Select((Process process) =>
            {
                if (selectedProcesses.Contains(process.Id))
                {
                    string processState = process.Responding ? "R" : "P";
                    string row = String.Format("{0, -10} {1, -2} {2, -30}", process.Id.ToString(), processState, process.ProcessName);
                    return (object)row;
                }
                else return null;
            }).ToList();

            selectedProcessesRowsList.RemoveAll(item => item == null);

            object[] selectedProcessesRows = selectedProcessesRowsList.ToArray();

            try
            {
                choosedProcessesListBox.Items.Clear();
                choosedProcessesListBox.Items.AddRange(selectedProcessesRows);
            }
            catch (Exception ex) { }
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (stateLabel.Text == "HZ" || stateLabel.Text == "running")
            {
                foreach (object obj in choosedProcessesListBox.Items)
                {
                    try
                    {
                        string processStr = (string)obj;
                        string uid = processStr.Substring(0, processStr.IndexOf(' '));
                        DebugActiveProcess(Convert.ToUInt32(uid));
                    }
                    catch (Exception ex) { }
                }
                stateLabel.Text = "paused";
            }
            else if(stateLabel.Text == "paused")
            {
                foreach (object obj in choosedProcessesListBox.Items)
                {
                    try
                    {
                        string processStr = (string)obj;
                        string uid = processStr.Substring(0, processStr.IndexOf(' '));
                        DebugActiveProcessStop(Convert.ToUInt32(Int32.Parse(uid)));
                    }
                    catch (Exception ex) { }
                }
                stateLabel.Text = "running";
            }
        }

        private void toChoosedProcessesButton_Click(object sender, EventArgs e)
        {
            try {
                choosedProcessesListBox.Items.Add(runningProcessesListBox.SelectedItem);
               

                string processStr = (string)runningProcessesListBox.SelectedItem;
                string uid = processStr.Substring(0, processStr.IndexOf(' '));
                selectedProcesses.Add(Int32.Parse(uid));

                runningProcessesListBox.Items.Remove(runningProcessesListBox.SelectedItem);
            } 
            catch(Exception ex)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = ex.ToString();
            }
        }

        private void FromChoosedProcessesButton_Click(object sender, EventArgs e)
        {
            try { 
                runningProcessesListBox.Items.Add(choosedProcessesListBox.SelectedItem);
               

                string processStr = (string)choosedProcessesListBox.SelectedItem;
                string uid = processStr.Substring(0, processStr.IndexOf(' '));
                selectedProcesses.Remove(Int32.Parse(uid));

                choosedProcessesListBox.Items.Remove(choosedProcessesListBox.SelectedItem);
            }
            catch (Exception ex)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = ex.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateProcessList();
        }
    }
}
