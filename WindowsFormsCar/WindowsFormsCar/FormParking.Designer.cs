namespace WindowsFormsCar
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonParkingCar = new System.Windows.Forms.Button();
            this.buttonParkingCravelCar = new System.Windows.Forms.Button();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.labelParkingCar = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelParkingTake = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.labelParkings = new System.Windows.Forms.Label();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonDeleteParking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(2, -9);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(627, 458);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkingCar
            // 
            this.buttonParkingCar.Location = new System.Drawing.Point(646, 216);
            this.buttonParkingCar.Name = "buttonParkingCar";
            this.buttonParkingCar.Size = new System.Drawing.Size(142, 43);
            this.buttonParkingCar.TabIndex = 1;
            this.buttonParkingCar.Text = "припарковать автомобиль";
            this.buttonParkingCar.UseVisualStyleBackColor = true;
            this.buttonParkingCar.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // buttonParkingCravelCar
            // 
            this.buttonParkingCravelCar.Location = new System.Drawing.Point(646, 265);
            this.buttonParkingCravelCar.Name = "buttonParkingCravelCar";
            this.buttonParkingCravelCar.Size = new System.Drawing.Size(141, 45);
            this.buttonParkingCravelCar.TabIndex = 2;
            this.buttonParkingCravelCar.Text = "припарковать гусенечный автомобиль";
            this.buttonParkingCravelCar.UseVisualStyleBackColor = true;
            this.buttonParkingCravelCar.Click += new System.EventHandler(this.buttonSetCrawlerCar_Click);
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.buttonTakeCar);
            this.groupBoxParking.Controls.Add(this.labelParkingCar);
            this.groupBoxParking.Controls.Add(this.maskedTextBox);
            this.groupBoxParking.Controls.Add(this.labelParkingTake);
            this.groupBoxParking.Location = new System.Drawing.Point(646, 316);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(137, 101);
            this.groupBoxParking.TabIndex = 3;
            this.groupBoxParking.TabStop = false;
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(22, 64);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(95, 21);
            this.buttonTakeCar.TabIndex = 3;
            this.buttonTakeCar.Text = "Забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // labelParkingCar
            // 
            this.labelParkingCar.AutoSize = true;
            this.labelParkingCar.Location = new System.Drawing.Point(19, 35);
            this.labelParkingCar.Name = "labelParkingCar";
            this.labelParkingCar.Size = new System.Drawing.Size(42, 13);
            this.labelParkingCar.TabIndex = 2;
            this.labelParkingCar.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(88, 32);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelParkingTake
            // 
            this.labelParkingTake.AutoSize = true;
            this.labelParkingTake.Location = new System.Drawing.Point(6, 16);
            this.labelParkingTake.Name = "labelParkingTake";
            this.labelParkingTake.Size = new System.Drawing.Size(112, 13);
            this.labelParkingTake.TabIndex = 0;
            this.labelParkingTake.Text = "забрать автомобиль";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(653, 100);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(135, 56);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // labelParkings
            // 
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(647, 18);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(60, 13);
            this.labelParkings.TabIndex = 5;
            this.labelParkings.Text = "Парковки:";
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(650, 73);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(131, 21);
            this.buttonAddParking.TabIndex = 6;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(648, 42);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(132, 20);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // buttonDeleteParking
            // 
            this.buttonDeleteParking.Location = new System.Drawing.Point(657, 169);
            this.buttonDeleteParking.Name = "buttonDeleteParking";
            this.buttonDeleteParking.Size = new System.Drawing.Size(125, 27);
            this.buttonDeleteParking.TabIndex = 8;
            this.buttonDeleteParking.Text = "Удалить парковку";
            this.buttonDeleteParking.UseVisualStyleBackColor = true;
            this.buttonDeleteParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.labelParkings);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.buttonParkingCravelCar);
            this.Controls.Add(this.buttonParkingCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkingCar;
        private System.Windows.Forms.Button buttonParkingCravelCar;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.Label labelParkingCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelParkingTake;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Label labelParkings;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonDeleteParking;
    }
}