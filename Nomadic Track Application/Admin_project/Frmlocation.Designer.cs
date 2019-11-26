namespace Admin_project
{
    partial class Frmlocation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadmid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 52);
            this.panel1.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(192, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            this.txtid.Visible = false;
            this.txtid.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Entry";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Location = new System.Drawing.Point(58, 256);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 92);
            this.panel2.TabIndex = 29;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(152, 29);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(102, 37);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(283, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(23, 29);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 37);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Location = new System.Drawing.Point(540, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 128);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(10, 20);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(132, 20);
            this.txtsearch.TabIndex = 17;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(21, 52);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(102, 37);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(167, 140);
            this.txtlname.Margin = new System.Windows.Forms.Padding(2);
            this.txtlname.MaxLength = 30;
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(207, 20);
            this.txtlname.TabIndex = 25;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(167, 111);
            this.txtlocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtlocation.MaxLength = 30;
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(207, 20);
            this.txtlocation.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Disrict";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Country";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtadmid
            // 
            this.txtadmid.Location = new System.Drawing.Point(167, 83);
            this.txtadmid.Margin = new System.Windows.Forms.Padding(2);
            this.txtadmid.Name = "txtadmid";
            this.txtadmid.Size = new System.Drawing.Size(207, 20);
            this.txtadmid.TabIndex = 31;
            this.txtadmid.TextChanged += new System.EventHandler(this.txtadmid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Admin ID";
            // 
            // Frmlocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 488);
            this.Controls.Add(this.txtadmid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frmlocation";
            this.Text = "Frmlocation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadmid;
        private System.Windows.Forms.Label label3;
    }
}