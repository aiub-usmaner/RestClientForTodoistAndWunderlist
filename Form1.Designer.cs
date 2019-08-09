namespace Client3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxTaskTitel = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBoxTodoist = new System.Windows.Forms.CheckBox();
            this.checkBoxWunderlist = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aufgabe hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBoxTaskTitel
            // 
            this.textBoxTaskTitel.Location = new System.Drawing.Point(180, 65);
            this.textBoxTaskTitel.Name = "textBoxTaskTitel";
            this.textBoxTaskTitel.Size = new System.Drawing.Size(185, 22);
            this.textBoxTaskTitel.TabIndex = 2;
            this.textBoxTaskTitel.Text = "Aufgabe";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Notizen";
            // 
            // checkBoxTodoist
            // 
            this.checkBoxTodoist.AutoSize = true;
            this.checkBoxTodoist.Location = new System.Drawing.Point(182, 166);
            this.checkBoxTodoist.Name = "checkBoxTodoist";
            this.checkBoxTodoist.Size = new System.Drawing.Size(77, 21);
            this.checkBoxTodoist.TabIndex = 4;
            this.checkBoxTodoist.Text = "Todoist";
            this.checkBoxTodoist.UseVisualStyleBackColor = true;
            // 
            // checkBoxWunderlist
            // 
            this.checkBoxWunderlist.AutoSize = true;
            this.checkBoxWunderlist.Location = new System.Drawing.Point(267, 166);
            this.checkBoxWunderlist.Name = "checkBoxWunderlist";
            this.checkBoxWunderlist.Size = new System.Drawing.Size(97, 21);
            this.checkBoxWunderlist.TabIndex = 5;
            this.checkBoxWunderlist.Text = "Wunderlist";
            this.checkBoxWunderlist.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Aufgaben importieren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxWunderlist);
            this.Controls.Add(this.checkBoxTodoist);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxTaskTitel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxTaskTitel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBoxTodoist;
        private System.Windows.Forms.CheckBox checkBoxWunderlist;
        private System.Windows.Forms.Button button2;
    }
}

