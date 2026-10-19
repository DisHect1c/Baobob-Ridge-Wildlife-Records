namespace PRG_role2_code_kb.Presentation_Layer
{
    partial class AddAnimalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblRecoveryScore = new System.Windows.Forms.Label();
            this.numRecoveryScore = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecoveryScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.Location = new System.Drawing.Point(33, 35);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(67, 16);
            this.lblAnimalID.TabIndex = 0;
            this.lblAnimalID.Text = "Animal ID:";
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(209, 32);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(100, 22);
            this.txtAnimalID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(444, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(533, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(33, 119);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(60, 16);
            this.lblSpecies.TabIndex = 4;
            this.lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(209, 116);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(100, 22);
            this.txtSpecies.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(444, 122);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 16);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(533, 122);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 22);
            this.numAge.TabIndex = 7;
            // 
            // lblRecoveryScore
            // 
            this.lblRecoveryScore.AutoSize = true;
            this.lblRecoveryScore.Location = new System.Drawing.Point(33, 213);
            this.lblRecoveryScore.Name = "lblRecoveryScore";
            this.lblRecoveryScore.Size = new System.Drawing.Size(151, 16);
            this.lblRecoveryScore.TabIndex = 8;
            this.lblRecoveryScore.Text = "Recovery Score (0-100):";
            // 
            // numRecoveryScore
            // 
            this.numRecoveryScore.Location = new System.Drawing.Point(209, 213);
            this.numRecoveryScore.Name = "numRecoveryScore";
            this.numRecoveryScore.Size = new System.Drawing.Size(120, 22);
            this.numRecoveryScore.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(36, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Animal";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(447, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numRecoveryScore);
            this.Controls.Add(this.lblRecoveryScore);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAnimalID);
            this.Controls.Add(this.lblAnimalID);
            this.Name = "AddAnimalForm";
            this.Text = "AddAnimalForm";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecoveryScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblRecoveryScore;
        private System.Windows.Forms.NumericUpDown numRecoveryScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}