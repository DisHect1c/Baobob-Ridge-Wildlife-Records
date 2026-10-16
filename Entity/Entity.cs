using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRG_role2_code_kb
{
    public class Animals
    {
        public  string ID {  get; set; }
        public string Name {  get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status {  get; set; }
        public string HousingUnit { get; set; }
        public Animals(string id, string name, string species,
                   int age, int recoveryScore,
                   string status, string housingUnit)
        {
            ID = id;
            Name = name;
            Species = species;
            RecoveryScore = recoveryScore;
            Age = age;
            Status = status;
            HousingUnit = housingUnit;
        }
    }
}

