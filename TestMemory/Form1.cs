using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMemory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int[]> list = new List<int[]>();

        private void button1_Click(object sender, EventArgs e)
        {
            int[] i = new int[1024*1024];
            list.Add(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Clear();
        }
    }
}
