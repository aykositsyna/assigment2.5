namespace assigment2._5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.vaccinateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sendToVaccButton = new System.Windows.Forms.Button();
            this.sendToPrimaryVaccButton = new System.Windows.Forms.Button();
            this.sendToSencondaryVaccButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vaccinateButton
            // 
            this.vaccinateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vaccinateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vaccinateButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.vaccinateButton.Location = new System.Drawing.Point(495, 252);
            this.vaccinateButton.Name = "vaccinateButton";
            this.vaccinateButton.Size = new System.Drawing.Size(313, 44);
            this.vaccinateButton.TabIndex = 0;
            this.vaccinateButton.Text = "vaccinate";
            this.vaccinateButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 267);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(495, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 209);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(838, 29);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 267);
            this.textBox3.TabIndex = 3;
            // 
            // sendToVaccButton
            // 
            this.sendToVaccButton.Location = new System.Drawing.Point(348, 29);
            this.sendToVaccButton.Name = "sendToVaccButton";
            this.sendToVaccButton.Size = new System.Drawing.Size(128, 75);
            this.sendToVaccButton.TabIndex = 4;
            this.sendToVaccButton.Text = "send to vaccination";
            this.sendToVaccButton.UseVisualStyleBackColor = true;
            // 
            // sendToPrimaryVaccButton
            // 
            this.sendToPrimaryVaccButton.Location = new System.Drawing.Point(348, 123);
            this.sendToPrimaryVaccButton.Name = "sendToPrimaryVaccButton";
            this.sendToPrimaryVaccButton.Size = new System.Drawing.Size(128, 75);
            this.sendToPrimaryVaccButton.TabIndex = 5;
            this.sendToPrimaryVaccButton.Text = "send to primary vaccination";
            this.sendToPrimaryVaccButton.UseVisualStyleBackColor = true;
            // 
            // sendToSencondaryVaccButton
            // 
            this.sendToSencondaryVaccButton.Location = new System.Drawing.Point(348, 214);
            this.sendToSencondaryVaccButton.Name = "sendToSencondaryVaccButton";
            this.sendToSencondaryVaccButton.Size = new System.Drawing.Size(128, 82);
            this.sendToSencondaryVaccButton.TabIndex = 6;
            this.sendToSencondaryVaccButton.Text = "send to secondary vaccination";
            this.sendToSencondaryVaccButton.UseVisualStyleBackColor = true;
            this.sendToSencondaryVaccButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 706);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendToSencondaryVaccButton);
            this.Controls.Add(this.sendToPrimaryVaccButton);
            this.Controls.Add(this.sendToVaccButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vaccinateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vaccinateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button sendToVaccButton;
        private System.Windows.Forms.Button sendToPrimaryVaccButton;
        private System.Windows.Forms.Button sendToSencondaryVaccButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

