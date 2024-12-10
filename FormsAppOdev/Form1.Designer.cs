namespace FormsAppOdev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTarih = new Label();
            comboBoxyil = new ComboBox();
            comboBoxay = new ComboBox();
            comboBoxgun = new ComboBox();
            SuspendLayout();
            // 
            // labelTarih
            // 
            labelTarih.AutoSize = true;
            labelTarih.Location = new Point(51, 102);
            labelTarih.Name = "labelTarih";
            labelTarih.Size = new Size(40, 20);
            labelTarih.TabIndex = 0;
            labelTarih.Text = "Tarih";
            // 
            // comboBoxyil
            // 
            comboBoxyil.FormattingEnabled = true;
            comboBoxyil.Location = new Point(158, 99);
            comboBoxyil.Name = "comboBoxyil";
            comboBoxyil.Size = new Size(151, 28);
            comboBoxyil.TabIndex = 1;
            // 
            // comboBoxay
            // 
            comboBoxay.FormattingEnabled = true;
            comboBoxay.Location = new Point(373, 99);
            comboBoxay.Name = "comboBoxay";
            comboBoxay.Size = new Size(151, 28);
            comboBoxay.TabIndex = 2;
            // 
            // comboBoxgun
            // 
            comboBoxgun.FormattingEnabled = true;
            comboBoxgun.Location = new Point(586, 99);
            comboBoxgun.Name = "comboBoxgun";
            comboBoxgun.Size = new Size(151, 28);
            comboBoxgun.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxgun);
            Controls.Add(comboBoxay);
            Controls.Add(comboBoxyil);
            Controls.Add(labelTarih);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTarih;
        private ComboBox comboBoxyil;
        private ComboBox comboBoxay;
        private ComboBox comboBoxgun;
    }
}
