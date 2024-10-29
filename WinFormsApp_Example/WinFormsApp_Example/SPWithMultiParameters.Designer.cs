namespace WinFormsApp_Example
{
    partial class SPWithMultiParameters
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
            btninsert = new Button();
            btndelet = new Button();
            btnupdate = new Button();
            btnclear = new Button();
            lblempid = new Label();
            lblempname = new Label();
            lblempdesig = new Label();
            lbldoj = new Label();
            lblempsal = new Label();
            lblempdeptno = new Label();
            txtempid = new TextBox();
            txtempname = new TextBox();
            txtempdesig = new TextBox();
            txtempdoj = new TextBox();
            txtempsal = new TextBox();
            txtempdeptno = new TextBox();
            btnfind = new Button();
            SuspendLayout();
            // 
            // btninsert
            // 
            btninsert.Location = new Point(150, 298);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(128, 51);
            btninsert.TabIndex = 0;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click;
            // 
            // btndelet
            // 
            btndelet.Location = new Point(150, 355);
            btndelet.Name = "btndelet";
            btndelet.Size = new Size(128, 45);
            btndelet.TabIndex = 1;
            btndelet.Text = "Delete";
            btndelet.UseVisualStyleBackColor = true;
            btndelet.Click += btndelet_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(293, 298);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(124, 51);
            btnupdate.TabIndex = 2;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(293, 355);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(124, 45);
            btnclear.TabIndex = 3;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // lblempid
            // 
            lblempid.AutoSize = true;
            lblempid.Location = new Point(68, 72);
            lblempid.Name = "lblempid";
            lblempid.Size = new Size(44, 15);
            lblempid.TabIndex = 4;
            lblempid.Text = "Emp Id";
            // 
            // lblempname
            // 
            lblempname.AutoSize = true;
            lblempname.Location = new Point(68, 112);
            lblempname.Name = "lblempname";
            lblempname.Size = new Size(66, 15);
            lblempname.TabIndex = 5;
            lblempname.Text = "Emp Name";
            // 
            // lblempdesig
            // 
            lblempdesig.AutoSize = true;
            lblempdesig.Location = new Point(68, 150);
            lblempdesig.Name = "lblempdesig";
            lblempdesig.Size = new Size(97, 15);
            lblempdesig.TabIndex = 6;
            lblempdesig.Text = "Emp Designation";
            // 
            // lbldoj
            // 
            lbldoj.AutoSize = true;
            lbldoj.Location = new Point(68, 185);
            lbldoj.Name = "lbldoj";
            lbldoj.Size = new Size(55, 15);
            lbldoj.TabIndex = 7;
            lbldoj.Text = "Emp DOJ";
            // 
            // lblempsal
            // 
            lblempsal.AutoSize = true;
            lblempsal.Location = new Point(68, 223);
            lblempsal.Name = "lblempsal";
            lblempsal.Size = new Size(65, 15);
            lblempsal.TabIndex = 8;
            lblempsal.Text = "Emp Salary";
            // 
            // lblempdeptno
            // 
            lblempdeptno.AutoSize = true;
            lblempdeptno.Location = new Point(68, 259);
            lblempdeptno.Name = "lblempdeptno";
            lblempdeptno.Size = new Size(75, 15);
            lblempdeptno.TabIndex = 9;
            lblempdeptno.Text = "Emp DeptNo";
            // 
            // txtempid
            // 
            txtempid.Location = new Point(201, 72);
            txtempid.Name = "txtempid";
            txtempid.Size = new Size(216, 23);
            txtempid.TabIndex = 10;
            // 
            // txtempname
            // 
            txtempname.Location = new Point(201, 112);
            txtempname.Name = "txtempname";
            txtempname.Size = new Size(216, 23);
            txtempname.TabIndex = 11;
            // 
            // txtempdesig
            // 
            txtempdesig.Location = new Point(201, 150);
            txtempdesig.Name = "txtempdesig";
            txtempdesig.Size = new Size(216, 23);
            txtempdesig.TabIndex = 12;
            // 
            // txtempdoj
            // 
            txtempdoj.Location = new Point(201, 185);
            txtempdoj.Name = "txtempdoj";
            txtempdoj.Size = new Size(216, 23);
            txtempdoj.TabIndex = 13;
            // 
            // txtempsal
            // 
            txtempsal.Location = new Point(201, 223);
            txtempsal.Name = "txtempsal";
            txtempsal.Size = new Size(216, 23);
            txtempsal.TabIndex = 14;
            // 
            // txtempdeptno
            // 
            txtempdeptno.Location = new Point(201, 259);
            txtempdeptno.Name = "txtempdeptno";
            txtempdeptno.Size = new Size(216, 23);
            txtempdeptno.TabIndex = 15;
            // 
            // btnfind
            // 
            btnfind.Location = new Point(234, 406);
            btnfind.Name = "btnfind";
            btnfind.Size = new Size(109, 37);
            btnfind.TabIndex = 16;
            btnfind.Text = "Find";
            btnfind.UseVisualStyleBackColor = true;
            btnfind.Click += btnfind_Click;
            // 
            // SPWithMultiParameters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 455);
            Controls.Add(btnfind);
            Controls.Add(txtempdeptno);
            Controls.Add(txtempsal);
            Controls.Add(txtempdoj);
            Controls.Add(txtempdesig);
            Controls.Add(txtempname);
            Controls.Add(txtempid);
            Controls.Add(lblempdeptno);
            Controls.Add(lblempsal);
            Controls.Add(lbldoj);
            Controls.Add(lblempdesig);
            Controls.Add(lblempname);
            Controls.Add(lblempid);
            Controls.Add(btnclear);
            Controls.Add(btnupdate);
            Controls.Add(btndelet);
            Controls.Add(btninsert);
            Name = "SPWithMultiParameters";
            Text = "SPWithMultiParameters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btninsert;
        private Button btndelet;
        private Button btnupdate;
        private Button btnclear;
        private Label lblempid;
        private Label lblempname;
        private Label lblempdesig;
        private Label lbldoj;
        private Label lblempsal;
        private Label lblempdeptno;
        private TextBox txtempid;
        private TextBox txtempname;
        private TextBox txtempdesig;
        private TextBox txtempdoj;
        private TextBox txtempsal;
        private TextBox txtempdeptno;
        private Button btnfind;
    }
}