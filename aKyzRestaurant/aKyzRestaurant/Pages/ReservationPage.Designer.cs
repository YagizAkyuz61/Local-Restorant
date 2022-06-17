
namespace aKyzRestaurant.Pages
{
    partial class ReservationPage
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cNameTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnTXT = new System.Windows.Forms.TextBox();
            this.tableCB = new System.Windows.Forms.ComboBox();
            this.dateTXT = new System.Windows.Forms.MaskedTextBox();
            this.explanationTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertBTN = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Explanation";
            // 
            // cNameTXT
            // 
            this.cNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cNameTXT.Location = new System.Drawing.Point(137, 97);
            this.cNameTXT.Name = "cNameTXT";
            this.cNameTXT.Size = new System.Drawing.Size(182, 23);
            this.cNameTXT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number";
            // 
            // pnTXT
            // 
            this.pnTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnTXT.Location = new System.Drawing.Point(138, 126);
            this.pnTXT.Name = "pnTXT";
            this.pnTXT.Size = new System.Drawing.Size(182, 23);
            this.pnTXT.TabIndex = 2;
            // 
            // tableCB
            // 
            this.tableCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableCB.FormattingEnabled = true;
            this.tableCB.Location = new System.Drawing.Point(137, 155);
            this.tableCB.Name = "tableCB";
            this.tableCB.Size = new System.Drawing.Size(182, 24);
            this.tableCB.TabIndex = 3;
            this.tableCB.Text = "Select table...";
            // 
            // dateTXT
            // 
            this.dateTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTXT.Location = new System.Drawing.Point(138, 185);
            this.dateTXT.Mask = "00/00/0000 90:00";
            this.dateTXT.Name = "dateTXT";
            this.dateTXT.Size = new System.Drawing.Size(182, 23);
            this.dateTXT.TabIndex = 4;
            this.dateTXT.ValidatingType = typeof(System.DateTime);
            // 
            // explanationTXT
            // 
            this.explanationTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.explanationTXT.Location = new System.Drawing.Point(137, 214);
            this.explanationTXT.Multiline = true;
            this.explanationTXT.Name = "explanationTXT";
            this.explanationTXT.Size = new System.Drawing.Size(182, 188);
            this.explanationTXT.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(96, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 54);
            this.label6.TabIndex = 6;
            this.label6.Text = "Reservation Page";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 343);
            this.dataGridView1.TabIndex = 7;
            // 
            // insertBTN
            // 
            this.insertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.insertBTN.Location = new System.Drawing.Point(137, 408);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(182, 32);
            this.insertBTN.TabIndex = 8;
            this.insertBTN.Text = "Accept";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(781, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(183, 25);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "8.01.2021 - 23:41";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuBTN
            // 
            this.menuBTN.BackColor = System.Drawing.Color.White;
            this.menuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBTN.Location = new System.Drawing.Point(10, 12);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(80, 34);
            this.menuBTN.TabIndex = 14;
            this.menuBTN.Text = "Menu";
            this.menuBTN.UseVisualStyleBackColor = false;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.menuBTN);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.explanationTXT);
            this.Controls.Add(this.dateTXT);
            this.Controls.Add(this.tableCB);
            this.Controls.Add(this.pnTXT);
            this.Controls.Add(this.cNameTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Page - aKyzRestaurant";
            this.Load += new System.EventHandler(this.ReservationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cNameTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pnTXT;
        private System.Windows.Forms.ComboBox tableCB;
        private System.Windows.Forms.MaskedTextBox dateTXT;
        private System.Windows.Forms.TextBox explanationTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button menuBTN;
    }
}