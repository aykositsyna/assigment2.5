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
            this.btnVaccinate = new System.Windows.Forms.Button();
            this.tbAllPatients = new System.Windows.Forms.TextBox();
            this.tbInProgress = new System.Windows.Forms.TextBox();
            this.tbVaccinated = new System.Windows.Forms.TextBox();
            this.btnSendToVacc = new System.Windows.Forms.Button();
            this.btnSendToFirstVacc = new System.Windows.Forms.Button();
            this.btnSendToSecondVacc = new System.Windows.Forms.Button();
            this.labelAllPatients = new System.Windows.Forms.Label();
            this.labelInProgress = new System.Windows.Forms.Label();
            this.labelVaccinated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVaccinate
            // 
            this.btnVaccinate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaccinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVaccinate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVaccinate.Location = new System.Drawing.Point(495, 252);
            this.btnVaccinate.Name = "btnVaccinate";
            this.btnVaccinate.Size = new System.Drawing.Size(313, 44);
            this.btnVaccinate.TabIndex = 0;
            this.btnVaccinate.Text = "vaccinate";
            this.btnVaccinate.UseVisualStyleBackColor = true;
            // 
            // tbAllPatients
            // 
            this.tbAllPatients.Location = new System.Drawing.Point(12, 29);
            this.tbAllPatients.Multiline = true;
            this.tbAllPatients.Name = "tbAllPatients";
            this.tbAllPatients.Size = new System.Drawing.Size(319, 267);
            this.tbAllPatients.TabIndex = 1;
            // 
            // tbInProgress
            // 
            this.tbInProgress.Location = new System.Drawing.Point(495, 29);
            this.tbInProgress.Multiline = true;
            this.tbInProgress.Name = "tbInProgress";
            this.tbInProgress.Size = new System.Drawing.Size(313, 209);
            this.tbInProgress.TabIndex = 2;
            // 
            // tbVaccinated
            // 
            this.tbVaccinated.Location = new System.Drawing.Point(838, 29);
            this.tbVaccinated.Multiline = true;
            this.tbVaccinated.Name = "tbVaccinated";
            this.tbVaccinated.Size = new System.Drawing.Size(337, 267);
            this.tbVaccinated.TabIndex = 3;
            // 
            // btnSendToVacc
            // 
            this.btnSendToVacc.Location = new System.Drawing.Point(348, 29);
            this.btnSendToVacc.Name = "btnSendToVacc";
            this.btnSendToVacc.Size = new System.Drawing.Size(128, 75);
            this.btnSendToVacc.TabIndex = 4;
            this.btnSendToVacc.Text = "send al to vaccination";
            this.btnSendToVacc.UseVisualStyleBackColor = true;
            this.btnSendToVacc.Click += new System.EventHandler(this.btnSendToVacc_Click);
            // 
            // btnSendToFirstVacc
            // 
            this.btnSendToFirstVacc.Location = new System.Drawing.Point(348, 123);
            this.btnSendToFirstVacc.Name = "btnSendToFirstVacc";
            this.btnSendToFirstVacc.Size = new System.Drawing.Size(128, 75);
            this.btnSendToFirstVacc.TabIndex = 5;
            this.btnSendToFirstVacc.Text = "send to primary vaccination";
            this.btnSendToFirstVacc.UseVisualStyleBackColor = true;
            this.btnSendToFirstVacc.Click += new System.EventHandler(this.btnSendToFirstVacc_Click);
            // 
            // btnSendToSecondVacc
            // 
            this.btnSendToSecondVacc.Location = new System.Drawing.Point(348, 214);
            this.btnSendToSecondVacc.Name = "btnSendToSecondVacc";
            this.btnSendToSecondVacc.Size = new System.Drawing.Size(128, 82);
            this.btnSendToSecondVacc.TabIndex = 6;
            this.btnSendToSecondVacc.Text = "send to secondary vaccination";
            this.btnSendToSecondVacc.UseVisualStyleBackColor = true;
            this.btnSendToSecondVacc.Click += new System.EventHandler(this.btnSendToSecondVacc_Click);
            // 
            // labelAllPatients
            // 
            this.labelAllPatients.AutoSize = true;
            this.labelAllPatients.Location = new System.Drawing.Point(12, 10);
            this.labelAllPatients.Name = "labelAllPatients";
            this.labelAllPatients.Size = new System.Drawing.Size(72, 16);
            this.labelAllPatients.TabIndex = 7;
            this.labelAllPatients.Text = "All patients";
            // 
            // labelInProgress
            // 
            this.labelInProgress.AutoSize = true;
            this.labelInProgress.Location = new System.Drawing.Point(495, 9);
            this.labelInProgress.Name = "labelInProgress";
            this.labelInProgress.Size = new System.Drawing.Size(161, 16);
            this.labelInProgress.TabIndex = 8;
            this.labelInProgress.Text = "Patients being vaccinated";
            // 
            // labelVaccinated
            // 
            this.labelVaccinated.AutoSize = true;
            this.labelVaccinated.Location = new System.Drawing.Point(838, 8);
            this.labelVaccinated.Name = "labelVaccinated";
            this.labelVaccinated.Size = new System.Drawing.Size(125, 16);
            this.labelVaccinated.TabIndex = 9;
            this.labelVaccinated.Text = "Vaccinated patients";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 706);
            this.Controls.Add(this.labelVaccinated);
            this.Controls.Add(this.labelInProgress);
            this.Controls.Add(this.labelAllPatients);
            this.Controls.Add(this.btnSendToSecondVacc);
            this.Controls.Add(this.btnSendToFirstVacc);
            this.Controls.Add(this.btnSendToVacc);
            this.Controls.Add(this.tbVaccinated);
            this.Controls.Add(this.tbInProgress);
            this.Controls.Add(this.tbAllPatients);
            this.Controls.Add(this.btnVaccinate);
            this.Name = "Form1";
            this.Text = "send all to vaccination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVaccinate;
        private System.Windows.Forms.TextBox tbAllPatients;
        private System.Windows.Forms.TextBox tbInProgress;
        private System.Windows.Forms.TextBox tbVaccinated;
        private System.Windows.Forms.Button btnSendToVacc;
        private System.Windows.Forms.Button btnSendToFirstVacc;
        private System.Windows.Forms.Button btnSendToSecondVacc;
        private System.Windows.Forms.Label labelAllPatients;
        private System.Windows.Forms.Label labelInProgress;
        private System.Windows.Forms.Label labelVaccinated;
    }
}

