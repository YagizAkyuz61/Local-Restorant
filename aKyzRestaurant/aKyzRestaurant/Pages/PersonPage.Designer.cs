
namespace aKyzRestaurant.Pages
{
    partial class PersonPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idTXT = new System.Windows.Forms.TextBox();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.surnameTXT = new System.Windows.Forms.TextBox();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.insertBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.menuBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(105, 431);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(195, 25);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "11.01.2021 - 12:44";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role";
            // 
            // idTXT
            // 
            this.idTXT.Enabled = false;
            this.idTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idTXT.Location = new System.Drawing.Point(98, 66);
            this.idTXT.Name = "idTXT";
            this.idTXT.Size = new System.Drawing.Size(158, 21);
            this.idTXT.TabIndex = 5;
            // 
            // nameTXT
            // 
            this.nameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTXT.Location = new System.Drawing.Point(98, 93);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(158, 21);
            this.nameTXT.TabIndex = 6;
            // 
            // surnameTXT
            // 
            this.surnameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTXT.Location = new System.Drawing.Point(98, 120);
            this.surnameTXT.Name = "surnameTXT";
            this.surnameTXT.Size = new System.Drawing.Size(158, 21);
            this.surnameTXT.TabIndex = 7;
            // 
            // roleCB
            // 
            this.roleCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Items.AddRange(new object[] {
            "Waiter",
            "Chef"});
            this.roleCB.Location = new System.Drawing.Point(98, 147);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(158, 23);
            this.roleCB.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 245);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // insertBTN
            // 
            this.insertBTN.BackColor = System.Drawing.Color.White;
            this.insertBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.insertBTN.Location = new System.Drawing.Point(263, 71);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(141, 26);
            this.insertBTN.TabIndex = 10;
            this.insertBTN.Text = "Insert";
            this.insertBTN.UseVisualStyleBackColor = false;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.White;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateBTN.Location = new System.Drawing.Point(263, 103);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(141, 26);
            this.updateBTN.TabIndex = 11;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.White;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteBTN.Location = new System.Drawing.Point(262, 135);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(141, 26);
            this.deleteBTN.TabIndex = 12;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // menuBTN
            // 
            this.menuBTN.BackColor = System.Drawing.Color.White;
            this.menuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBTN.Location = new System.Drawing.Point(12, 9);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(80, 34);
            this.menuBTN.TabIndex = 13;
            this.menuBTN.Text = "Menu";
            this.menuBTN.UseVisualStyleBackColor = false;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // PersonPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(416, 463);
            this.Controls.Add(this.menuBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.roleCB);
            this.Controls.Add(this.surnameTXT);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.idTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Name = "PersonPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Page - aKyzRestaurant";
            this.Load += new System.EventHandler(this.PersonPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTXT;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.TextBox surnameTXT;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button menuBTN;
    }
}