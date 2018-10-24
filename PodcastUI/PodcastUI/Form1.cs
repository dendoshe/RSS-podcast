using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastUI
{
    public partial class Form1 : Form
    {
        PodcastMani logicLayer = new PodcastMani(); //Här har vi skapat ett object av PostcastMani som ligger i LogicLayer. Den körs en gång vid uppstart.

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
