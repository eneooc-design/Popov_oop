namespace WinFormsApp46
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
            txtTitle = new TextBox();
            txtVersion = new TextBox();
            numPrice = new NumericUpDown();
            txtLicenseKey = new TextBox();
            numLicenseDays = new NumericUpDown();
            btnAdd = new Button();
            btnSort = new Button();
            btnClone = new Button();
            btnModifyClone = new Button();
            lstSoftware = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLicenseDays).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(418, 48);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtVersion
            // 
            txtVersion.Location = new Point(312, 48);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(100, 23);
            txtVersion.TabIndex = 1;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(329, 115);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 2;
            // 
            // txtLicenseKey
            // 
            txtLicenseKey.Location = new Point(357, 214);
            txtLicenseKey.Name = "txtLicenseKey";
            txtLicenseKey.Size = new Size(100, 23);
            txtLicenseKey.TabIndex = 3;
            // 
            // numLicenseDays
            // 
            numLicenseDays.Location = new Point(347, 275);
            numLicenseDays.Name = "numLicenseDays";
            numLicenseDays.Size = new Size(120, 23);
            numLicenseDays.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(246, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(357, 322);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 6;
            btnSort.Text = "btnSort";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // btnClone
            // 
            btnClone.Location = new Point(473, 322);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(75, 23);
            btnClone.TabIndex = 7;
            btnClone.Text = "btnClone";
            btnClone.UseVisualStyleBackColor = true;
            // 
            // btnModifyClone
            // 
            btnModifyClone.Location = new Point(361, 362);
            btnModifyClone.Name = "btnModifyClone";
            btnModifyClone.Size = new Size(75, 23);
            btnModifyClone.TabIndex = 8;
            btnModifyClone.Text = "btnModifyClone";
            btnModifyClone.UseVisualStyleBackColor = true;
            // 
            // lstSoftware
            // 
            lstSoftware.FormattingEnabled = true;
            lstSoftware.ItemHeight = 15;
            lstSoftware.Location = new Point(312, 77);
            lstSoftware.Name = "lstSoftware";
            lstSoftware.Size = new Size(120, 94);
            lstSoftware.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 21);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 10;
            label1.Text = "Версия";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 21);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 11;
            label2.Text = "Название программы";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 84);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 12;
            label3.Text = "Название программы";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstSoftware);
            Controls.Add(btnModifyClone);
            Controls.Add(btnClone);
            Controls.Add(btnSort);
            Controls.Add(btnAdd);
            Controls.Add(numLicenseDays);
            Controls.Add(txtLicenseKey);
            Controls.Add(numPrice);
            Controls.Add(txtVersion);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLicenseDays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtVersion;
        private NumericUpDown numPrice;
        private TextBox txtLicenseKey;
        private NumericUpDown numLicenseDays;
        private Button btnAdd;
        private Button btnSort;
        private Button btnClone;
        private Button btnModifyClone;
        private ListBox lstSoftware;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
