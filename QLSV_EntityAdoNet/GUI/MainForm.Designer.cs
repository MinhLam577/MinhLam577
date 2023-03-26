namespace QLSV_EntityAdoNet.GUI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_sort = new System.Windows.Forms.ComboBox();
            this.cb_ClassName = new System.Windows.Forms.ComboBox();
            this.dgv_sv = new System.Windows.Forms.DataGridView();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_delelte = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_class = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sv)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_sort
            // 
            this.cb_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sort.FormattingEnabled = true;
            this.cb_sort.Items.AddRange(new object[] {
            "Class",
            "ID",
            "Name",
            "Dtb",
            "NS",
            "Gender"});
            this.cb_sort.Location = new System.Drawing.Point(1059, 424);
            this.cb_sort.Name = "cb_sort";
            this.cb_sort.Size = new System.Drawing.Size(265, 37);
            this.cb_sort.TabIndex = 21;
            // 
            // cb_ClassName
            // 
            this.cb_ClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ClassName.FormattingEnabled = true;
            this.cb_ClassName.Items.AddRange(new object[] {
            "21TCLC_DT4",
            "21TCLC_DT3",
            "21TCLC_DT2",
            "21TCLC_KHDL",
            "22TCLC_KHDL",
            "ALL"});
            this.cb_ClassName.Location = new System.Drawing.Point(211, 73);
            this.cb_ClassName.Name = "cb_ClassName";
            this.cb_ClassName.Size = new System.Drawing.Size(279, 37);
            this.cb_ClassName.TabIndex = 20;
            // 
            // dgv_sv
            // 
            this.dgv_sv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            this.dgv_sv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_sv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_sv.ColumnHeadersHeight = 29;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sv.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgv_sv.Location = new System.Drawing.Point(48, 116);
            this.dgv_sv.Name = "dgv_sv";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sv.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgv_sv.RowHeadersWidth = 51;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_sv.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgv_sv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_sv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_sv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_sv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_sv.RowTemplate.Height = 24;
            this.dgv_sv.RowTemplate.ReadOnly = true;
            this.dgv_sv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sv.Size = new System.Drawing.Size(1276, 274);
            this.dgv_sv.TabIndex = 19;
            // 
            // txb_search
            // 
            this.txb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.Location = new System.Drawing.Point(1059, 68);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(265, 34);
            this.txb_search.TabIndex = 18;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(886, 65);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(131, 40);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort.Location = new System.Drawing.Point(886, 421);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(131, 40);
            this.btn_sort.TabIndex = 16;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_delelte
            // 
            this.btn_delelte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delelte.Location = new System.Drawing.Point(540, 421);
            this.btn_delelte.Name = "btn_delelte";
            this.btn_delelte.Size = new System.Drawing.Size(131, 40);
            this.btn_delelte.TabIndex = 15;
            this.btn_delelte.Text = "Del";
            this.btn_delelte.UseVisualStyleBackColor = true;
            this.btn_delelte.Click += new System.EventHandler(this.btn_delelte_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(293, 421);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(131, 40);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(48, 421);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(131, 40);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_class.Location = new System.Drawing.Point(43, 76);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(78, 29);
            this.lb_class.TabIndex = 12;
            this.lb_class.Text = "Class";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 527);
            this.Controls.Add(this.cb_sort);
            this.Controls.Add(this.cb_ClassName);
            this.Controls.Add(this.dgv_sv);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_delelte);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_class);
            this.Name = "MainForm";
            this.Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_sort;
        private System.Windows.Forms.ComboBox cb_ClassName;
        private System.Windows.Forms.DataGridView dgv_sv;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_delelte;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_class;
    }
}