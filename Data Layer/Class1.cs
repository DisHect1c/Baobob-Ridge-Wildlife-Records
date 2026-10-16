using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_role2_code_kb.Data_Layer
{
    public class DataHandler
    {
        public DataHandler() { }
        
        public List<Animals> GetAnimals()
        {
            List<Animals > animals = new List<Animals>();
            try
            {
                using (StreamReader sr = new StreamReader("animals.txt"))
                {

                    while (!sr.EndOfStream)
                    {
                        string[] parts = sr.ReadLine().Split('|');
                        Animals animal = new Animals(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5], parts[6]);
                        animals.Add(animal);
                    }
                }
            }
            catch(Exception ex) 
            {
               MessageBox.Show(ex.Message);
            }
         
            return animals;
        }
    }
}
