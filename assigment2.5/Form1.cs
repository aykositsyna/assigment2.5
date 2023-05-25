using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment2._5
{
    public partial class Form1 : Form
    {
        PatientSystem patientSystem = new PatientSystem();
        public Form1()
        {
            InitializeComponent();
            tbAllPatientsListView
            
        }

        private void btnSendToVacc_Click(object sender, EventArgs e)
        {
            patientSystem.SendAllPatients();
        }

        private void btnSendToFirstVacc_Click(object sender, EventArgs e)
        {
            patientSystem.SendOnFirstVacc();
        }

        private void btnSendToSecondVacc_Click(object sender, EventArgs e)
        {
            patientSystem.SendOnSecondVacc();
        }

        public void Refresh()
        {
            tbAllPatientsListView
        }
    }
}
