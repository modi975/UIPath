using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Activities;
using System.Activities.XamlIntegration;


namespace uiwfsample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Use calculator by simulating clicks.
                String digitOne = this.comboBox1.SelectedItem.ToString();
                String digitTwo = this.comboBox2.SelectedItem.ToString();
                String operation = this.comboBox3.SelectedItem.ToString();

                WorkflowInvoker invoker = new WorkflowInvoker(ActivityXamlServices.Load(@"calc.uiwf"));
                var arguments = new Dictionary<string, object>();
                arguments.Add("digitOne", digitOne);
                arguments.Add("digitTwo", digitTwo);
                arguments.Add("op", operation);

                IDictionary<string, object> outArgs = invoker.Invoke(arguments);

                String sResult = (String)outArgs["calcResult"];
                this.textBox1.Text = sResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "ERROR: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Use calculator by simulating keystrokes.
                String exp = this.textBox2.Text;
                exp.Replace(" ", "");
                exp += "=";

                WorkflowInvoker invoker = new WorkflowInvoker(ActivityXamlServices.Load(@"calc2.uiwf"));
                var arguments = new Dictionary<string, object>();
                arguments.Add("expr", exp);

                IDictionary<string, object> outArgs = invoker.Invoke(arguments);

                String sResult = (String)outArgs["calcResult"];
                this.textBox3.Text = sResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "ERROR: " + ex.Message);
            }
        }
    }
}
