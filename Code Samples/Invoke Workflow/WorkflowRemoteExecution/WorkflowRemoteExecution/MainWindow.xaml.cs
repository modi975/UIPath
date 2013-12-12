using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using Microsoft.Win32;

// Add refrence to UiPath.RemoteWorkflow.dll 
using UiPath.RemoteWorkflow; 

namespace WorkflowRemoteExecution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnNotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private Guid generatedGuid;
        public Guid GeneratedGuid
        {
            get
            {
                return generatedGuid;
            }
            set
            {
                generatedGuid = value;
                OnNotifyPropertyChanged("GeneratedGuid");
                GuidTextBox.Text = "/w:" + generatedGuid.ToString();
            }
        }

        private string workflowPath;
        public string WorkflowPath
        {
            get
            {
                return workflowPath;
            }
            set
            {
                workflowPath = value;
                OnNotifyPropertyChanged("WorkflowPath");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            GeneratedGuid = Guid.NewGuid();
        }

        private void WorkflowPath_Click(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "workflow files (*.uiwf)|*.uiwf";
            ofd.FileOk += (s, ev) =>
                {
                    WorkflowPath = ofd.FileName;
                };
            ofd.ShowDialog();
        }

        private void ExecuteWorkflow_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WorkflowPath))
            {
                MessageBox.Show("Please choose a workflow to execute");
                return;
            }
            using (WorkflowRemoteInvoker invoker = new WorkflowRemoteInvoker(GeneratedGuid.ToString()))
            {
                var xamlWorkflow = File.ReadAllText(WorkflowPath);
                // Execute workflow
                IDictionary<string, object> outputArguments = invoker.Invoke(xamlWorkflow, null);
                // Close manually started UiLauncher
                invoker.CloseService();
            }
        }
    }
}
