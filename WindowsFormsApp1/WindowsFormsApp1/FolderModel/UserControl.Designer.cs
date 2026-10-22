namespace WindowsFormsApp1.FolderModel
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelIDData = new System.Windows.Forms.Label();
            this.labelModelData = new System.Windows.Forms.Label();
            this.labelBrandData = new System.Windows.Forms.Label();
            this.labelPriceData = new System.Windows.Forms.Label();
            this.labelHorsepowerData = new System.Windows.Forms.Label();
            this.labelMileageData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(221, 125);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "ID";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Модель";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Марка";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Цена";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Л/С";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Пробег";
            // 
            // labelIDData
            // 
            this.labelIDData.AutoSize = true;
            this.labelIDData.Location = new System.Drawing.Point(90, 146);
            this.labelIDData.Name = "labelIDData";
            this.labelIDData.Size = new System.Drawing.Size(63, 13);
            this.labelIDData.TabIndex = 7;
            this.labelIDData.Text = "labelIDData";
            // 
            // labelModelData
            // 
            this.labelModelData.AutoSize = true;
            this.labelModelData.Location = new System.Drawing.Point(90, 159);
            this.labelModelData.Name = "labelModelData";
            this.labelModelData.Size = new System.Drawing.Size(81, 13);
            this.labelModelData.TabIndex = 8;
            this.labelModelData.Text = "labelModelData";
            // 
            // labelBrandData
            // 
            this.labelBrandData.AutoSize = true;
            this.labelBrandData.Location = new System.Drawing.Point(90, 172);
            this.labelBrandData.Name = "labelBrandData";
            this.labelBrandData.Size = new System.Drawing.Size(80, 13);
            this.labelBrandData.TabIndex = 9;
            this.labelBrandData.Text = "labelBrandData";
            // 
            // labelPriceData
            // 
            this.labelPriceData.AutoSize = true;
            this.labelPriceData.Location = new System.Drawing.Point(90, 185);
            this.labelPriceData.Name = "labelPriceData";
            this.labelPriceData.Size = new System.Drawing.Size(76, 13);
            this.labelPriceData.TabIndex = 10;
            this.labelPriceData.Text = "labelPriceData";
            // 
            // labelHorsepowerData
            // 
            this.labelHorsepowerData.AutoSize = true;
            this.labelHorsepowerData.Location = new System.Drawing.Point(90, 198);
            this.labelHorsepowerData.Name = "labelHorsepowerData";
            this.labelHorsepowerData.Size = new System.Drawing.Size(109, 13);
            this.labelHorsepowerData.TabIndex = 11;
            this.labelHorsepowerData.Text = "labelHorsepowerData";
            // 
            // labelMileageData
            // 
            this.labelMileageData.AutoSize = true;
            this.labelMileageData.Location = new System.Drawing.Point(90, 211);
            this.labelMileageData.Name = "labelMileageData";
            this.labelMileageData.Size = new System.Drawing.Size(89, 13);
            this.labelMileageData.TabIndex = 12;
            this.labelMileageData.Text = "labelMileageData";
            // 
            // UserControl1
            // 
            this.Controls.Add(this.labelMileageData);
            this.Controls.Add(this.labelHorsepowerData);
            this.Controls.Add(this.labelPriceData);
            this.Controls.Add(this.labelBrandData);
            this.Controls.Add(this.labelModelData);
            this.Controls.Add(this.labelIDData);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox3);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(227, 334);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelIDData;
        private System.Windows.Forms.Label labelModelData;
        private System.Windows.Forms.Label labelBrandData;
        private System.Windows.Forms.Label labelPriceData;
        private System.Windows.Forms.Label labelHorsepowerData;
        private System.Windows.Forms.Label labelMileageData;
    }
}
