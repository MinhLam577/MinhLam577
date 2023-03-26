namespace QLSV_EntityAdoNet.GUI
{
    partial class AddOrEditForm
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
            this.dtpker_Date = new System.Windows.Forms.DateTimePicker();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gb_Valid = new System.Windows.Forms.GroupBox();
            this.cb_cccd = new System.Windows.Forms.CheckBox();
            this.cb_hb = new System.Windows.Forms.CheckBox();
            this.cb_Anh = new System.Windows.Forms.CheckBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.txb_Dtb = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Id = new System.Windows.Forms.TextBox();
            this.lb_dtb = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_CLassName = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_MSSV = new System.Windows.Forms.Label();
            this.gb_Valid.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpker_Date
            // 
            this.dtpker_Date.CustomFormat = "dd/MM/yyyy";
            this.dtpker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpker_Date.Location = new System.Drawing.Point(256, 271);
            this.dtpker_Date.Name = "dtpker_Date";
            this.dtpker_Date.Size = new System.Drawing.Size(214, 34);
            this.dtpker_Date.TabIndex = 30;
            this.dtpker_Date.Value = new System.DateTime(2023, 2, 23, 22, 1, 29, 0);
            // 
            // cb_class
            // 
            this.cb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            ""});
            this.cb_class.Location = new System.Drawing.Point(256, 180);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(214, 37);
            this.cb_class.TabIndex = 29;
            this.cb_class.DropDown += new System.EventHandler(this.cb_class_DropDown);
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.Black;
            this.btn_OK.Location = new System.Drawing.Point(205, 444);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(105, 72);
            this.btn_OK.TabIndex = 28;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(657, 444);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 72);
            this.btn_cancel.TabIndex = 27;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // gb_Valid
            // 
            this.gb_Valid.Controls.Add(this.cb_cccd);
            this.gb_Valid.Controls.Add(this.cb_hb);
            this.gb_Valid.Controls.Add(this.cb_Anh);
            this.gb_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Valid.ForeColor = System.Drawing.Color.Black;
            this.gb_Valid.Location = new System.Drawing.Point(517, 191);
            this.gb_Valid.Name = "gb_Valid";
            this.gb_Valid.Size = new System.Drawing.Size(286, 212);
            this.gb_Valid.TabIndex = 26;
            this.gb_Valid.TabStop = false;
            this.gb_Valid.Text = "Xác thực";
            // 
            // cb_cccd
            // 
            this.cb_cccd.AutoSize = true;
            this.cb_cccd.Location = new System.Drawing.Point(8, 164);
            this.cb_cccd.Name = "cb_cccd";
            this.cb_cccd.Size = new System.Drawing.Size(94, 33);
            this.cb_cccd.TabIndex = 2;
            this.cb_cccd.Text = "Cccd";
            this.cb_cccd.UseVisualStyleBackColor = true;
            // 
            // cb_hb
            // 
            this.cb_hb.AutoSize = true;
            this.cb_hb.Location = new System.Drawing.Point(8, 106);
            this.cb_hb.Name = "cb_hb";
            this.cb_hb.Size = new System.Drawing.Size(68, 33);
            this.cb_hb.TabIndex = 1;
            this.cb_hb.Text = "Hb";
            this.cb_hb.UseVisualStyleBackColor = true;
            // 
            // cb_Anh
            // 
            this.cb_Anh.AutoSize = true;
            this.cb_Anh.Location = new System.Drawing.Point(8, 47);
            this.cb_Anh.Name = "cb_Anh";
            this.cb_Anh.Size = new System.Drawing.Size(117, 33);
            this.cb_Anh.TabIndex = 0;
            this.cb_Anh.Text = "Picture";
            this.cb_Anh.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rb_female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.ForeColor = System.Drawing.Color.Black;
            this.gb_Gender.Location = new System.Drawing.Point(517, 16);
            this.gb_Gender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_Gender.Size = new System.Drawing.Size(285, 169);
            this.gb_Gender.TabIndex = 25;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(8, 112);
            this.rb_female.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(122, 33);
            this.rb_female.TabIndex = 1;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(8, 52);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(91, 33);
            this.rb_Male.TabIndex = 0;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // txb_Dtb
            // 
            this.txb_Dtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Dtb.Location = new System.Drawing.Point(256, 346);
            this.txb_Dtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_Dtb.Name = "txb_Dtb";
            this.txb_Dtb.Size = new System.Drawing.Size(214, 34);
            this.txb_Dtb.TabIndex = 24;
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Name.Location = new System.Drawing.Point(256, 104);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(214, 34);
            this.txb_Name.TabIndex = 23;
            // 
            // txb_Id
            // 
            this.txb_Id.Enabled = false;
            this.txb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Id.Location = new System.Drawing.Point(256, 19);
            this.txb_Id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_Id.Name = "txb_Id";
            this.txb_Id.ReadOnly = true;
            this.txb_Id.Size = new System.Drawing.Size(214, 34);
            this.txb_Id.TabIndex = 22;
            // 
            // lb_dtb
            // 
            this.lb_dtb.AutoSize = true;
            this.lb_dtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dtb.ForeColor = System.Drawing.Color.Black;
            this.lb_dtb.Location = new System.Drawing.Point(147, 349);
            this.lb_dtb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_dtb.Name = "lb_dtb";
            this.lb_dtb.Size = new System.Drawing.Size(53, 29);
            this.lb_dtb.TabIndex = 21;
            this.lb_dtb.Text = "Dtb";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.ForeColor = System.Drawing.Color.Black;
            this.lb_Date.Location = new System.Drawing.Point(145, 271);
            this.lb_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(67, 29);
            this.lb_Date.TabIndex = 20;
            this.lb_Date.Text = "Date";
            // 
            // lb_CLassName
            // 
            this.lb_CLassName.AutoSize = true;
            this.lb_CLassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CLassName.ForeColor = System.Drawing.Color.Black;
            this.lb_CLassName.Location = new System.Drawing.Point(145, 188);
            this.lb_CLassName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CLassName.Name = "lb_CLassName";
            this.lb_CLassName.Size = new System.Drawing.Size(78, 29);
            this.lb_CLassName.TabIndex = 19;
            this.lb_CLassName.Text = "Class";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Location = new System.Drawing.Point(145, 109);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(82, 29);
            this.lb_Name.TabIndex = 18;
            this.lb_Name.Text = "Name";
            // 
            // lb_MSSV
            // 
            this.lb_MSSV.AutoSize = true;
            this.lb_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MSSV.ForeColor = System.Drawing.Color.Black;
            this.lb_MSSV.Location = new System.Drawing.Point(145, 22);
            this.lb_MSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MSSV.Name = "lb_MSSV";
            this.lb_MSSV.Size = new System.Drawing.Size(84, 29);
            this.lb_MSSV.TabIndex = 17;
            this.lb_MSSV.Text = "MSSV";
            // 
            // AddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 533);
            this.Controls.Add(this.dtpker_Date);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.gb_Valid);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.txb_Dtb);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.txb_Id);
            this.Controls.Add(this.lb_dtb);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.lb_CLassName);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_MSSV);
            this.Name = "AddOrEditForm";
            this.Text = "Sinh Viên";
            this.gb_Valid.ResumeLayout(false);
            this.gb_Valid.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpker_Date;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gb_Valid;
        private System.Windows.Forms.CheckBox cb_cccd;
        private System.Windows.Forms.CheckBox cb_hb;
        private System.Windows.Forms.CheckBox cb_Anh;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.TextBox txb_Dtb;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Id;
        private System.Windows.Forms.Label lb_dtb;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_CLassName;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_MSSV;
    }
}