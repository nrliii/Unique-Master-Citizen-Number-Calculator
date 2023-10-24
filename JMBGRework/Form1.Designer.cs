namespace JMBGRework
{
    partial class Form1
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
            this.izracunajButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.checkBoxZ = new System.Windows.Forms.CheckBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.drzComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.regComboBox = new System.Windows.Forms.ComboBox();
            this.labelProvera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // izracunajButton
            // 
            this.izracunajButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.izracunajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.izracunajButton.Location = new System.Drawing.Point(20, 218);
            this.izracunajButton.Name = "izracunajButton";
            this.izracunajButton.Size = new System.Drawing.Size(182, 39);
            this.izracunajButton.TabIndex = 0;
            this.izracunajButton.Text = "Izracunaj";
            this.izracunajButton.UseVisualStyleBackColor = true;
            this.izracunajButton.Click += new System.EventHandler(this.izracunajButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.Location = new System.Drawing.Point(20, 158);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(58, 17);
            this.checkBoxM.TabIndex = 2;
            this.checkBoxM.Text = "Musko";
            this.checkBoxM.UseVisualStyleBackColor = true;
            this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
            // 
            // checkBoxZ
            // 
            this.checkBoxZ.AutoSize = true;
            this.checkBoxZ.Location = new System.Drawing.Point(140, 158);
            this.checkBoxZ.Name = "checkBoxZ";
            this.checkBoxZ.Size = new System.Drawing.Size(62, 17);
            this.checkBoxZ.TabIndex = 3;
            this.checkBoxZ.Text = "Zensko";
            this.checkBoxZ.UseVisualStyleBackColor = true;
            this.checkBoxZ.CheckedChanged += new System.EventHandler(this.checkBoxZ_CheckedChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(20, 263);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(182, 20);
            this.textBoxOutput.TabIndex = 4;
            // 
            // drzComboBox
            // 
            this.drzComboBox.FormattingEnabled = true;
            this.drzComboBox.Location = new System.Drawing.Point(20, 73);
            this.drzComboBox.Name = "drzComboBox";
            this.drzComboBox.Size = new System.Drawing.Size(182, 21);
            this.drzComboBox.TabIndex = 5;
            this.drzComboBox.SelectedIndexChanged += new System.EventHandler(this.drzComboBox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSelect.Location = new System.Drawing.Point(20, 12);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(182, 39);
            this.buttonSelect.TabIndex = 7;
            this.buttonSelect.Text = "Selektuj";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // regComboBox
            // 
            this.regComboBox.FormattingEnabled = true;
            this.regComboBox.Location = new System.Drawing.Point(20, 113);
            this.regComboBox.Name = "regComboBox";
            this.regComboBox.Size = new System.Drawing.Size(182, 21);
            this.regComboBox.TabIndex = 8;
            this.regComboBox.SelectedIndexChanged += new System.EventHandler(this.regComboBox_SelectedIndexChanged);
            // 
            // labelProvera
            // 
            this.labelProvera.AutoSize = true;
            this.labelProvera.Location = new System.Drawing.Point(17, 57);
            this.labelProvera.Name = "labelProvera";
            this.labelProvera.Size = new System.Drawing.Size(0, 13);
            this.labelProvera.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 310);
            this.Controls.Add(this.labelProvera);
            this.Controls.Add(this.regComboBox);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.drzComboBox);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.checkBoxZ);
            this.Controls.Add(this.checkBoxM);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.izracunajButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "JMBG Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izracunajButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxM;
        private System.Windows.Forms.CheckBox checkBoxZ;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ComboBox drzComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ComboBox regComboBox;
        private System.Windows.Forms.Label labelProvera;
    }
}

