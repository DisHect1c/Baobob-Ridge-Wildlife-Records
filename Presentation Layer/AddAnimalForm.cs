using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG_role2_code_kb.Entity;

namespace PRG_role2_code_kb.Presentation_Layer
{
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //inputs and validation
                string id = txtAnimalID.Text.Trim();
                string name = txtName.Text.Trim();
                string species = txtSpecies.Text.Trim();
                int age = (int)numAge.Value;
                int recoveryScore = (int)numRecoveryScore.Value;

                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(species))
                {
                    MessageBox.Show("Please ensure all text boxes are filled in (ID, Name, and Species).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //trigger auto classification
                Animal newAnimal = new Animal(id, name, species, age, recoveryScore);

                //confirm success and display
                MessageBox.Show($"Animal successfully recorded.\n\nDetails:\n{newAnimal.ToString()}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Recovery Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            numAge.Value = 0;
            numRecoveryScore.Value = 0;
            txtAnimalID.Focus();
        }
    }
}
