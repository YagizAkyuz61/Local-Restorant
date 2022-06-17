
namespace aKyzRestaurant.Pages
{
    partial class TakeawayPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oaBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.foodDGV = new System.Windows.Forms.DataGridView();
            this.showBTN = new System.Windows.Forms.Button();
            this.beverageRB = new System.Windows.Forms.RadioButton();
            this.ffRB = new System.Windows.Forms.RadioButton();
            this.soupRB = new System.Windows.Forms.RadioButton();
            this.cnTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTXT = new System.Windows.Forms.TextBox();
            this.pnTXT = new System.Windows.Forms.TextBox();
            this.explantionTXT = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculatorBTN = new System.Windows.Forms.Button();
            this.dateLabel2 = new System.Windows.Forms.Label();
            this.menuBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(841, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(195, 25);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "18.01.2021 - 17:13";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "Takeaway Page";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 264);
            this.dataGridView1.TabIndex = 13;
            // 
            // oaBTN
            // 
            this.oaBTN.BackColor = System.Drawing.Color.White;
            this.oaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oaBTN.Location = new System.Drawing.Point(931, 579);
            this.oaBTN.Name = "oaBTN";
            this.oaBTN.Size = new System.Drawing.Size(109, 49);
            this.oaBTN.TabIndex = 38;
            this.oaBTN.Text = "Order Accept";
            this.oaBTN.UseVisualStyleBackColor = false;
            this.oaBTN.Click += new System.EventHandler(this.oaBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.White;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearBTN.Location = new System.Drawing.Point(806, 579);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(117, 49);
            this.clearBTN.TabIndex = 37;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // orderDGV
            // 
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Location = new System.Drawing.Point(454, 338);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.Size = new System.Drawing.Size(343, 258);
            this.orderDGV.TabIndex = 35;
            // 
            // foodDGV
            // 
            this.foodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDGV.Location = new System.Drawing.Point(13, 368);
            this.foodDGV.Name = "foodDGV";
            this.foodDGV.Size = new System.Drawing.Size(435, 260);
            this.foodDGV.TabIndex = 34;
            this.foodDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodDGV_CellClick);
            // 
            // showBTN
            // 
            this.showBTN.BackColor = System.Drawing.Color.White;
            this.showBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showBTN.Location = new System.Drawing.Point(292, 338);
            this.showBTN.Name = "showBTN";
            this.showBTN.Size = new System.Drawing.Size(156, 23);
            this.showBTN.TabIndex = 33;
            this.showBTN.Text = "Show";
            this.showBTN.UseVisualStyleBackColor = false;
            this.showBTN.Click += new System.EventHandler(this.showBTN_Click);
            // 
            // beverageRB
            // 
            this.beverageRB.AutoSize = true;
            this.beverageRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beverageRB.ForeColor = System.Drawing.Color.White;
            this.beverageRB.Location = new System.Drawing.Point(190, 338);
            this.beverageRB.Name = "beverageRB";
            this.beverageRB.Size = new System.Drawing.Size(95, 24);
            this.beverageRB.TabIndex = 30;
            this.beverageRB.Text = "Beverage";
            this.beverageRB.UseVisualStyleBackColor = true;
            // 
            // ffRB
            // 
            this.ffRB.AutoSize = true;
            this.ffRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ffRB.ForeColor = System.Drawing.Color.White;
            this.ffRB.Location = new System.Drawing.Point(84, 338);
            this.ffRB.Name = "ffRB";
            this.ffRB.Size = new System.Drawing.Size(100, 24);
            this.ffRB.TabIndex = 31;
            this.ffRB.Text = "Fast Food";
            this.ffRB.UseVisualStyleBackColor = true;
            // 
            // soupRB
            // 
            this.soupRB.AutoSize = true;
            this.soupRB.Checked = true;
            this.soupRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soupRB.ForeColor = System.Drawing.Color.White;
            this.soupRB.Location = new System.Drawing.Point(13, 338);
            this.soupRB.Name = "soupRB";
            this.soupRB.Size = new System.Drawing.Size(65, 24);
            this.soupRB.TabIndex = 32;
            this.soupRB.TabStop = true;
            this.soupRB.Text = "Soup";
            this.soupRB.UseVisualStyleBackColor = true;
            // 
            // cnTXT
            // 
            this.cnTXT.Location = new System.Drawing.Point(930, 335);
            this.cnTXT.Name = "cnTXT";
            this.cnTXT.Size = new System.Drawing.Size(109, 20);
            this.cnTXT.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(803, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(803, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(803, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(803, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Explantion:";
            // 
            // addressTXT
            // 
            this.addressTXT.Location = new System.Drawing.Point(930, 361);
            this.addressTXT.Multiline = true;
            this.addressTXT.Name = "addressTXT";
            this.addressTXT.Size = new System.Drawing.Size(109, 104);
            this.addressTXT.TabIndex = 40;
            // 
            // pnTXT
            // 
            this.pnTXT.Location = new System.Drawing.Point(931, 471);
            this.pnTXT.Name = "pnTXT";
            this.pnTXT.Size = new System.Drawing.Size(109, 20);
            this.pnTXT.TabIndex = 41;
            // 
            // explantionTXT
            // 
            this.explantionTXT.Location = new System.Drawing.Point(931, 497);
            this.explantionTXT.Multiline = true;
            this.explantionTXT.Name = "explantionTXT";
            this.explantionTXT.Size = new System.Drawing.Size(108, 76);
            this.explantionTXT.TabIndex = 42;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(517, 599);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(24, 25);
            this.priceLabel.TabIndex = 43;
            this.priceLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Price:";
            // 
            // calculatorBTN
            // 
            this.calculatorBTN.BackColor = System.Drawing.Color.White;
            this.calculatorBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculatorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calculatorBTN.Location = new System.Drawing.Point(548, 599);
            this.calculatorBTN.Name = "calculatorBTN";
            this.calculatorBTN.Size = new System.Drawing.Size(123, 29);
            this.calculatorBTN.TabIndex = 45;
            this.calculatorBTN.Text = "Calculator";
            this.calculatorBTN.UseVisualStyleBackColor = false;
            this.calculatorBTN.Click += new System.EventHandler(this.calculatorBTN_Click);
            // 
            // dateLabel2
            // 
            this.dateLabel2.AutoSize = true;
            this.dateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel2.ForeColor = System.Drawing.Color.White;
            this.dateLabel2.Location = new System.Drawing.Point(841, 9);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(120, 25);
            this.dateLabel2.TabIndex = 12;
            this.dateLabel2.Text = "18.01.2021";
            // 
            // menuBTN
            // 
            this.menuBTN.BackColor = System.Drawing.Color.White;
            this.menuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBTN.Location = new System.Drawing.Point(13, 7);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(80, 34);
            this.menuBTN.TabIndex = 46;
            this.menuBTN.Text = "Menu";
            this.menuBTN.UseVisualStyleBackColor = false;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // TakeawayPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1048, 640);
            this.Controls.Add(this.menuBTN);
            this.Controls.Add(this.calculatorBTN);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.explantionTXT);
            this.Controls.Add(this.pnTXT);
            this.Controls.Add(this.addressTXT);
            this.Controls.Add(this.cnTXT);
            this.Controls.Add(this.oaBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.orderDGV);
            this.Controls.Add(this.foodDGV);
            this.Controls.Add(this.showBTN);
            this.Controls.Add(this.beverageRB);
            this.Controls.Add(this.ffRB);
            this.Controls.Add(this.soupRB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateLabel2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Name = "TakeawayPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takeaway Page - aKyzRestaurant";
            this.Load += new System.EventHandler(this.TakeawayPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button oaBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.DataGridView orderDGV;
        private System.Windows.Forms.DataGridView foodDGV;
        private System.Windows.Forms.Button showBTN;
        private System.Windows.Forms.RadioButton beverageRB;
        private System.Windows.Forms.RadioButton ffRB;
        private System.Windows.Forms.RadioButton soupRB;
        private System.Windows.Forms.TextBox cnTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressTXT;
        private System.Windows.Forms.TextBox pnTXT;
        private System.Windows.Forms.TextBox explantionTXT;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculatorBTN;
        private System.Windows.Forms.Label dateLabel2;
        private System.Windows.Forms.Button menuBTN;
    }
}