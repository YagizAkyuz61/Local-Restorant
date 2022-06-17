
namespace aKyzRestaurant.Pages
{
    partial class HomePage
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reservationBTN = new System.Windows.Forms.Button();
            this.orderBTN = new System.Windows.Forms.Button();
            this.tekeawayBTN = new System.Windows.Forms.Button();
            this.foodBTN = new System.Windows.Forms.Button();
            this.tableBTN = new System.Windows.Forms.Button();
            this.personBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Page";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(7, 305);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(110, 25);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "DateLabel";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reservationBTN
            // 
            this.reservationBTN.BackColor = System.Drawing.Color.White;
            this.reservationBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservationBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reservationBTN.Location = new System.Drawing.Point(12, 66);
            this.reservationBTN.Name = "reservationBTN";
            this.reservationBTN.Size = new System.Drawing.Size(180, 77);
            this.reservationBTN.TabIndex = 2;
            this.reservationBTN.Text = "Reservation";
            this.reservationBTN.UseVisualStyleBackColor = false;
            this.reservationBTN.Click += new System.EventHandler(this.reservationBTN_Click);
            // 
            // orderBTN
            // 
            this.orderBTN.BackColor = System.Drawing.Color.White;
            this.orderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderBTN.Location = new System.Drawing.Point(200, 66);
            this.orderBTN.Name = "orderBTN";
            this.orderBTN.Size = new System.Drawing.Size(180, 77);
            this.orderBTN.TabIndex = 3;
            this.orderBTN.Text = "Order";
            this.orderBTN.UseVisualStyleBackColor = false;
            this.orderBTN.Click += new System.EventHandler(this.orderBTN_Click);
            // 
            // tekeawayBTN
            // 
            this.tekeawayBTN.BackColor = System.Drawing.Color.White;
            this.tekeawayBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tekeawayBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tekeawayBTN.Location = new System.Drawing.Point(387, 66);
            this.tekeawayBTN.Name = "tekeawayBTN";
            this.tekeawayBTN.Size = new System.Drawing.Size(180, 77);
            this.tekeawayBTN.TabIndex = 4;
            this.tekeawayBTN.Text = "Takeaway";
            this.tekeawayBTN.UseVisualStyleBackColor = false;
            this.tekeawayBTN.Click += new System.EventHandler(this.tekeawayBTN_Click);
            // 
            // foodBTN
            // 
            this.foodBTN.BackColor = System.Drawing.Color.White;
            this.foodBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.foodBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.foodBTN.Location = new System.Drawing.Point(12, 150);
            this.foodBTN.Name = "foodBTN";
            this.foodBTN.Size = new System.Drawing.Size(180, 77);
            this.foodBTN.TabIndex = 5;
            this.foodBTN.Text = "Food";
            this.foodBTN.UseVisualStyleBackColor = false;
            this.foodBTN.Click += new System.EventHandler(this.foodBTN_Click);
            // 
            // tableBTN
            // 
            this.tableBTN.BackColor = System.Drawing.Color.White;
            this.tableBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tableBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableBTN.Location = new System.Drawing.Point(200, 151);
            this.tableBTN.Name = "tableBTN";
            this.tableBTN.Size = new System.Drawing.Size(180, 77);
            this.tableBTN.TabIndex = 7;
            this.tableBTN.Text = "Table";
            this.tableBTN.UseVisualStyleBackColor = false;
            this.tableBTN.Click += new System.EventHandler(this.tableBTN_Click);
            // 
            // personBTN
            // 
            this.personBTN.BackColor = System.Drawing.Color.White;
            this.personBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.personBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personBTN.Location = new System.Drawing.Point(387, 151);
            this.personBTN.Name = "personBTN";
            this.personBTN.Size = new System.Drawing.Size(180, 77);
            this.personBTN.TabIndex = 9;
            this.personBTN.Text = "Person";
            this.personBTN.UseVisualStyleBackColor = false;
            this.personBTN.Click += new System.EventHandler(this.personBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(554, 68);
            this.button1.TabIndex = 10;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(582, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personBTN);
            this.Controls.Add(this.tableBTN);
            this.Controls.Add(this.foodBTN);
            this.Controls.Add(this.tekeawayBTN);
            this.Controls.Add(this.orderBTN);
            this.Controls.Add(this.reservationBTN);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page - aKyzRestaurant";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button reservationBTN;
        private System.Windows.Forms.Button orderBTN;
        private System.Windows.Forms.Button tekeawayBTN;
        private System.Windows.Forms.Button foodBTN;
        private System.Windows.Forms.Button tableBTN;
        private System.Windows.Forms.Button personBTN;
        private System.Windows.Forms.Button button1;
    }
}