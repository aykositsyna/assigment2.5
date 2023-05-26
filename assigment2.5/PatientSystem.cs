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
        {
            for(int i = 0; i < allPatients.Count; i++)
            {
                Patient patient = allPatients[i];
                if(patient.VaccNumber == 0)
                {
                    patientsOnVaccination.Add(patient);
                    allPatients.RemoveAt(i); //maybe RemoveAt
                    i--;
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
                    allPatients.RemoveAt(i); //maybe RemoveAt
                    i--;
                }
            }
        }

        public void Vaccinate()
        {
            Random random = new Random();
            for (int i = 0; i < patientsOnVaccination.Count; i++)
            {
                Patient patient = patientsOnVaccination[i];
                int chance = random.Next(0, 2);
                if (patient.VaccNumber != 2 && chance == 1)
                {
                    patient.VaccNumber++;
                }

                if (patient.VaccNumber == 2)
                {
                    vaccinatedPatients.Add(patient);
                    patientsOnVaccination.RemoveAt(i);
                    i--;
                }

                if(patient.VaccNumber == 0 || patient.VaccNumber == 1)
                {
                    allPatients.Add(patient);
                    patientsOnVaccination.RemoveAt(i);
                    i--;
                }
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
