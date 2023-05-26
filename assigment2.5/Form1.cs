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
            AllPatientsListView.Columns.Add("Vaccines");
            AllPatientsListView.Columns.Add("Patient");

            PatientsONVaccListView.Columns.Add("Vaccines");
            PatientsONVaccListView.Columns.Add("Patient");

            VaccinatedPatientsListView.Columns.Add("Vaccines");
            VaccinatedPatientsListView.Columns.Add("Patient");

            Refresh();
        }

        private void btnSendToVacc_Click(object sender, EventArgs e)
        {
            patientSystem.SendAllPatients();
            Refresh();
        }

        private void btnSendToFirstVacc_Click(object sender, EventArgs e)
        {
            patientSystem.SendOnFirstVacc();
            Refresh();
        }

        private void btnSendToSecondVacc_Click(object sender, EventArgs e)
        {
            patientSystem.SendOnSecondVacc();
            Refresh();
        }
        private void btnVaccinate_Click(object sender, EventArgs e)
        {
            patientSystem.Vaccinate();
            Refresh();
        }

        public void Refresh()
        {
            AllPatientsListView.Items.Clear();
            foreach (Patient patient in patientSystem.allPatients)
            {
                ListViewItem item = new ListViewItem(patient.VaccNumber.ToString());
                item.SubItems.Add(patient.Name);
                AllPatientsListView.Items.Add(item);
            }

            PatientsONVaccListView.Items.Clear();
            foreach (Patient patient in patientSystem.patientsOnVaccination)
            {
                ListViewItem item = new ListViewItem(patient.VaccNumber.ToString());
                item.SubItems.Add(patient.Name);
                PatientsONVaccListView.Items.Add(item);
            }

            VaccinatedPatientsListView.Items.Clear();
            foreach (Patient patient in patientSystem.vaccinatedPatients)
            {
                ListViewItem item = new ListViewItem(patient.VaccNumber.ToString());
                item.SubItems.Add(patient.Name);
                VaccinatedPatientsListView.Items.Add(item);
            }
        }

    }
}
