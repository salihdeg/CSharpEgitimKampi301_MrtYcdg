namespace CSharpEgitimKampi301_MrtYcdg.EFProject
{
    partial class FormLocation
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDayNight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbGuide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MistyRose;
            this.btnClear.Location = new System.Drawing.Point(128, 423);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 39);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Alanları Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.Cyan;
            this.btnGetById.Location = new System.Drawing.Point(128, 378);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(124, 39);
            this.btnGetById.TabIndex = 24;
            this.btnGetById.Text = "ID\'ye göre getir";
            this.btnGetById.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.Location = new System.Drawing.Point(128, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 39);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(128, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 39);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(128, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 39);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(718, 450);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnList.Location = new System.Drawing.Point(128, 198);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(124, 39);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(143, 20);
            this.txtId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lokasyon Id:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(109, 41);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(143, 20);
            this.txtCity.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Şehir:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(109, 67);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(143, 20);
            this.txtCountry.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ülke:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kapasite:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(109, 119);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 20);
            this.txtPrice.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fiyat:";
            // 
            // txtDayNight
            // 
            this.txtDayNight.Location = new System.Drawing.Point(109, 145);
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(143, 20);
            this.txtDayNight.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Gün/Gece:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Rehber:";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(109, 93);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(143, 20);
            this.nudCapacity.TabIndex = 38;
            // 
            // cmbGuide
            // 
            this.cmbGuide.FormattingEnabled = true;
            this.cmbGuide.Location = new System.Drawing.Point(109, 171);
            this.cmbGuide.Name = "cmbGuide";
            this.cmbGuide.Size = new System.Drawing.Size(143, 21);
            this.cmbGuide.TabIndex = 39;
            // 
            // FormLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 474);
            this.Controls.Add(this.cmbGuide);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDayNight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "FormLocation";
            this.Text = "FormLocation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDayNight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.ComboBox cmbGuide;
    }
}