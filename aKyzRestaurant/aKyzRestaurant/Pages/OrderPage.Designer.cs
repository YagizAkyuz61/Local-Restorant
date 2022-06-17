
namespace aKyzRestaurant.Pages
{
    partial class OrderPage
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLABEL = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.todayRB = new System.Windows.Forms.RadioButton();
            this.everydayRB = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.showBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.countBTN = new System.Windows.Forms.Button();
            this.menuBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(592, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(120, 25);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "18.01.2021";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "Order Page";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLABEL
            // 
            this.timeLABEL.AutoSize = true;
            this.timeLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLABEL.ForeColor = System.Drawing.Color.White;
            this.timeLABEL.Location = new System.Drawing.Point(701, 9);
            this.timeLABEL.Name = "timeLABEL";
            this.timeLABEL.Size = new System.Drawing.Size(87, 25);
            this.timeLABEL.TabIndex = 13;
            this.timeLABEL.Text = " - 23:41";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 372);
            this.dataGridView1.TabIndex = 14;
            // 
            // todayRB
            // 
            this.todayRB.AutoSize = true;
            this.todayRB.Checked = true;
            this.todayRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.todayRB.ForeColor = System.Drawing.Color.White;
            this.todayRB.Location = new System.Drawing.Point(642, 66);
            this.todayRB.Name = "todayRB";
            this.todayRB.Size = new System.Drawing.Size(70, 24);
            this.todayRB.TabIndex = 15;
            this.todayRB.TabStop = true;
            this.todayRB.Text = "Today";
            this.todayRB.UseVisualStyleBackColor = true;
            this.todayRB.CheckedChanged += new System.EventHandler(this.todayRB_CheckedChanged);
            // 
            // everydayRB
            // 
            this.everydayRB.AutoSize = true;
            this.everydayRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.everydayRB.ForeColor = System.Drawing.Color.White;
            this.everydayRB.Location = new System.Drawing.Point(642, 96);
            this.everydayRB.Name = "everydayRB";
            this.everydayRB.Size = new System.Drawing.Size(91, 24);
            this.everydayRB.TabIndex = 15;
            this.everydayRB.Text = "Everyday";
            this.everydayRB.UseVisualStyleBackColor = true;
            this.everydayRB.CheckedChanged += new System.EventHandler(this.everydayRB_CheckedChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(643, 127);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(69, 23);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // showBTN
            // 
            this.showBTN.BackColor = System.Drawing.Color.White;
            this.showBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showBTN.Location = new System.Drawing.Point(718, 127);
            this.showBTN.Name = "showBTN";
            this.showBTN.Size = new System.Drawing.Size(75, 23);
            this.showBTN.TabIndex = 17;
            this.showBTN.Text = "Show";
            this.showBTN.UseVisualStyleBackColor = false;
            this.showBTN.Click += new System.EventHandler(this.showBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(639, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(693, 418);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(19, 20);
            this.priceLabel.TabIndex = 18;
            this.priceLabel.Text = "0";
            // 
            // countBTN
            // 
            this.countBTN.BackColor = System.Drawing.Color.White;
            this.countBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.countBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countBTN.Location = new System.Drawing.Point(643, 156);
            this.countBTN.Name = "countBTN";
            this.countBTN.Size = new System.Drawing.Size(150, 50);
            this.countBTN.TabIndex = 19;
            this.countBTN.Text = "Count";
            this.countBTN.UseVisualStyleBackColor = false;
            this.countBTN.Click += new System.EventHandler(this.countBTN_Click);
            // 
            // menuBTN
            // 
            this.menuBTN.BackColor = System.Drawing.Color.White;
            this.menuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBTN.Location = new System.Drawing.Point(12, 7);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(80, 34);
            this.menuBTN.TabIndex = 20;
            this.menuBTN.Text = "Menu";
            this.menuBTN.UseVisualStyleBackColor = false;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuBTN);
            this.Controls.Add(this.countBTN);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showBTN);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.everydayRB);
            this.Controls.Add(this.todayRB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.timeLABEL);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Name = "OrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Page - aKyzRestaurant";
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLABEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton todayRB;
        private System.Windows.Forms.RadioButton everydayRB;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button showBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button countBTN;
        private System.Windows.Forms.Button menuBTN;
    }
}