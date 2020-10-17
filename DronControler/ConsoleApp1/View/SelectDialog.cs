using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DronApp
{
    public partial class SelectDialog : Form
    {
        public String selectedPort { get; set; }
       
        public SelectDialog(String[] ports)
        {
            InitializeComponent();
            

            //Dictionary <string, string> bindPorsts = new Dictionary<string, string>();
            //foreach (string i in ports)
            //{
            //    bindPorsts.Add(i, i);
            //}
            this.ports.DataSource = new BindingSource(ports, null);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.ports.SelectedValue != null)
            {
                this.selectedPort = this.ports.SelectedValue.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
                
        }
    }
}
