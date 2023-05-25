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
            foreach(Patient patient in patientsOnVaccination)
            {
                Vaccinate(patient);
            }
            allPatients.Clear();
        }

        public void SendOnFirstVacc()
        {
            for(int i = 0; i < allPatients.Count; i++)
            {
                Patient patient = allPatients[i];
                if(patient.VaccNumber == 0)
                {
                    patientsOnVaccination.Add(patient);
                    allPatients.Remove(patient); //maybe RemoveAt
                }
            }
        }

        public void SendOnSecondVacc() 
        {
            for (int i = 0; i < allPatients.Count; i++)
            {
                Patient patient = allPatients[i];
                if (patient.VaccNumber == 1)
                {
                    patientsOnVaccination.Add(patient);
                    allPatients.Remove(patient); //maybe RemoveAt
                }
            }
        }

        public void Vaccinate(Patient patient)
        {
            Random random = new Random();
            int chance = random.Next(0, 1);
            if (chance == 1)
            {
                patient.VaccNumber++;
            }
        }

        public void Update()
        {
            foreach(Patient patient in patientsOnVaccination)
            {
                if(patient.VaccNumber < 2)
                {
                    allPatients.Add(patient);
                }
                else
                {
                    vaccinatedPatients.Add(patient);
                }
            }
            patientsOnVaccination.Clear();
        }
    }
}
