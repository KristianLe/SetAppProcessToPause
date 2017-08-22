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
        public Form1()
        {
            InitializeComponent();
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(SetAppProcessToPause.ModifierKeys.Control, Keys.F12);
            object[] processesRows = Process.GetProcesses().Select((Process process) =>
            {
                string processState = process.Responding ? "R": "P";
                string row = String.Format("{0, -10} {1, -2} {2, -30}", process.Id.ToString(), processState, process.ProcessName);
                return (object)row;
            }).ToArray();

            runningProcessesListBox.Items.AddRange(processesRows);

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
                        string uid = processStr.Substring(processStr.LastIndexOf(' '));
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
                        string uid = processStr.Substring(processStr.LastIndexOf(' '));
                        DebugActiveProcessStop(Convert.ToUInt32(uid));
                    }
                    catch (Exception ex) { }
                }
                stateLabel.Text = "running";
            }
        }

        private void toChoosedProcessesButton_Click(object sender, EventArgs e)
        {
            try
            {
                choosedProcessesListBox.Items.Add(runningProcessesListBox.SelectedItem);
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
                choosedProcessesListBox.Items.Remove(choosedProcessesListBox.SelectedItem);
            }
            catch (Exception ex)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = ex.ToString();
            }
        }
    }
}
