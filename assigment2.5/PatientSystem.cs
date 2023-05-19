using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment2._5
{
    internal class PatientSystem
    {
        public List<Patient> allPatients = new List<Patient>();
        public List<Patient> patientsOnVaccination = new List<Patient>();
        public List<Patient> vaccinatedPatients = new List<Patient>();

        public PatientSystem() 
        {
            allPatients.Add(new Patient()
            {
                Name = "Iron man",
                VaccNumber = 0,
            });
            allPatients.Add(new Patient()
            {
                Name = "Thor",
                VaccNumber = 1,
            });
            allPatients.Add(new Patient()
            {
                Name = "Black widow",
                VaccNumber = 1,
            });
            allPatients.Add(new Patient()
            {
                Name = "Captain America",
                VaccNumber = 0,
            });
            allPatients.Add(new Patient()
            {
                Name = "Hulk",
                VaccNumber = 0,
            });
            allPatients.Add(new Patient()
            {
                Name = "Hawkeye",
                VaccNumber = 1,
            });
        }

        public void SendAllPatients()
        {
            patientsOnVaccination.AddRange(allPatients);
            allPatients.Clear();
        }

        public void SendOnFirstVacc()
        { }

        public void SendOnSecondVacc() 
        { }
    }
}
