using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class SinsManager
    {
        List<List<Sins>> sinsList = new List<List<Sins>>();
        string filePath = "data/sinsData.txt";
        int numSins = 0;

        public SinsManager()
        {
            LoadSinsFromFile();
        }

        public Sins? searchID(int id) 
        {
            for (int i = 0; i < sinsList.Count; i++) 
            {
                for (int j = 0; j < sinsList[i].Count; j++) 
                {
                    if (sinsList[i][j].SinsID == id) 
                    {
                        return sinsList[i][j];
                    }
                }
            }

            return null;
        }

        public Sins? searchSin(string sin)
        {
            for (int i = 0; i < sinsList.Count; i++)
            {
                for (int j = 0; j < sinsList[i].Count; j++)
                {
                    if (sinsList[i][j].Sin == sin)
                    {
                        return sinsList[i][j];
                    }
                }
            }

            return null;
        }

        public int numberOfSins()
        {
            return numSins;
        }

        private void LoadSinsFromFile()
        {
            int currCommandment = 0;
            int sinsID = 1;

            if (!File.Exists(filePath))
            {
                // File not found - no data loaded. Consider logging or notifying.
                System.Diagnostics.Debug.WriteLine($"Sins file not found: {filePath}");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                if (line.Trim() == ";") { currCommandment++; continue; } // if a ";", we move to a new commandment.

                var parts = line.Split('/');
                if (parts.Length < 2)
                {
                    // malformed line; skip (or log)
                    System.Diagnostics.Debug.WriteLine($"Malformed line in {filePath}: '{line}'");
                    continue;
                }

                string sin = parts[0].Trim(); // first part is the sin
                string confession = parts[1].Trim(); // second part is the confession

                System.Diagnostics.Debug.WriteLine($"{sin} {confession}");
                var sinEntry = new Sins(sinsID, sin, confession, currCommandment+1);

                if (sinsList.Count <= currCommandment)
                {
                    sinsList.Add(new List<Sins>());
                }

                sinsList[currCommandment].Add(sinEntry);

                //MessageBox.Show($"Loaded sin {sinsID}: {sin} - {confession}");

                sinsID++;
                numSins++;
            }
        }
    }
}
