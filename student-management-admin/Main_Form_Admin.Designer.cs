﻿
namespace student_management_admin
{
    partial class Main_Form_Admin
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
            this.pnlToolBar = new System.Windows.Forms.Panel();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnActivity = new System.Windows.Forms.Panel();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbDateOfWeek = new System.Windows.Forms.ComboBox();
            this.lblTitleTeacher = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgrvData = new System.Windows.Forms.DataGridView();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.pnLocation = new System.Windows.Forms.Panel();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnAddBuild = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvClassroom = new System.Windows.Forms.DataGridView();
            this.dtgvBuilding = new System.Windows.Forms.DataGridView();
            this.pnlToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvData)).BeginInit();
            this.pnLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnLocation);
            this.pnlToolBar.Controls.Add(this.btnClass);
            this.pnlToolBar.Controls.Add(this.btnSchedule);
            this.pnlToolBar.Controls.Add(this.btnSubject);
            this.pnlToolBar.Controls.Add(this.btnTeacher);
            this.pnlToolBar.Controls.Add(this.btnStudent);
            this.pnlToolBar.Controls.Add(this.btnLogout);
            this.pnlToolBar.Controls.Add(this.panel1);
            this.pnlToolBar.Location = new System.Drawing.Point(14, 15);
            this.pnlToolBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(220, 599);
            this.pnlToolBar.TabIndex = 0;
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(24, 212);
            this.btnLocation.Margin = new System.Windows.Forms.Padding(6);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(163, 37);
            this.btnLocation.TabIndex = 6;
            this.btnLocation.Text = "Vị trí";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(24, 162);
            this.btnClass.Margin = new System.Windows.Forms.Padding(6);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(163, 37);
            this.btnClass.TabIndex = 3;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(24, 261);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(6);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(163, 37);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Lịch giảng";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Location = new System.Drawing.Point(24, 113);
            this.btnSubject.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(163, 37);
            this.btnSubject.TabIndex = 2;
            this.btnSubject.Text = "Môn học";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(24, 64);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(6);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(163, 37);
            this.btnTeacher.TabIndex = 1;
            this.btnTeacher.Text = "Giảng viên";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(24, 15);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(163, 37);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Sinh viên";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(64, 565);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 28);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(4, 511);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 47);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(96, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label2";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(616, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 24);
            this.lblTitle.TabIndex = 1;
            // 
            // pnActivity
            // 
            this.pnActivity.Controls.Add(this.cbYear);
            this.pnActivity.Controls.Add(this.cbDateOfWeek);
            this.pnActivity.Controls.Add(this.lblTitleTeacher);
            this.pnActivity.Controls.Add(this.btnSearch);
            this.pnActivity.Controls.Add(this.txtSearch);
            this.pnActivity.Controls.Add(this.btnAdd);
            this.pnActivity.Controls.Add(this.dtgrvData);
            this.pnActivity.Controls.Add(this.cbTeacher);
            this.pnActivity.Location = new System.Drawing.Point(241, 79);
            this.pnActivity.Margin = new System.Windows.Forms.Padding(4);
            this.pnActivity.Name = "pnActivity";
            this.pnActivity.Size = new System.Drawing.Size(901, 535);
            this.pnActivity.TabIndex = 2;
            this.pnActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.pnActivity_Paint);
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(106, 11);
            this.cbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(119, 24);
            this.cbYear.TabIndex = 16;
            this.cbYear.Visible = false;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cbDateOfWeek
            // 
            this.cbDateOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateOfWeek.FormattingEnabled = true;
            this.cbDateOfWeek.Location = new System.Drawing.Point(233, 11);
            this.cbDateOfWeek.Margin = new System.Windows.Forms.Padding(4);
            this.cbDateOfWeek.Name = "cbDateOfWeek";
            this.cbDateOfWeek.Size = new System.Drawing.Size(249, 24);
            this.cbDateOfWeek.TabIndex = 15;
            this.cbDateOfWeek.Visible = false;
            this.cbDateOfWeek.SelectedIndexChanged += new System.EventHandler(this.cbDateOfWeek_SelectedIndexChanged);
            // 
            // lblTitleTeacher
            // 
            this.lblTitleTeacher.AutoSize = true;
            this.lblTitleTeacher.Location = new System.Drawing.Point(542, 21);
            this.lblTitleTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleTeacher.Name = "lblTitleTeacher";
            this.lblTitleTeacher.Size = new System.Drawing.Size(67, 16);
            this.lblTitleTeacher.TabIndex = 14;
            this.lblTitleTeacher.Text = "Giảng viên";
            this.lblTitleTeacher.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(802, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(617, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 22);
            this.txtSearch.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgrvData
            // 
            this.dtgrvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvData.Location = new System.Drawing.Point(10, 46);
            this.dtgrvData.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrvData.Name = "dtgrvData";
            this.dtgrvData.RowHeadersWidth = 51;
            this.dtgrvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvData.Size = new System.Drawing.Size(880, 480);
            this.dtgrvData.TabIndex = 9;
            this.dtgrvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvData_CellContentClick);
            this.dtgrvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvData_CellDoubleClick);
            // 
            // cbTeacher
            // 
            this.cbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(617, 12);
            this.cbTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(271, 24);
            this.cbTeacher.TabIndex = 13;
            this.cbTeacher.Visible = false;
            this.cbTeacher.SelectedIndexChanged += new System.EventHandler(this.cbTeacher_SelectedIndexChanged);
            // 
            // pnLocation
            // 
            this.pnLocation.Controls.Add(this.btnAddClass);
            this.pnLocation.Controls.Add(this.btnAddBuild);
            this.pnLocation.Controls.Add(this.label4);
            this.pnLocation.Controls.Add(this.label3);
            this.pnLocation.Controls.Add(this.label2);
            this.pnLocation.Controls.Add(this.dtgvClassroom);
            this.pnLocation.Controls.Add(this.dtgvBuilding);
            this.pnLocation.Location = new System.Drawing.Point(241, 15);
            this.pnLocation.Margin = new System.Windows.Forms.Padding(4);
            this.pnLocation.Name = "pnLocation";
            this.pnLocation.Size = new System.Drawing.Size(901, 599);
            this.pnLocation.TabIndex = 3;
            this.pnLocation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLocation_Paint);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(504, 78);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(88, 28);
            this.btnAddClass.TabIndex = 8;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnAddBuild
            // 
            this.btnAddBuild.Location = new System.Drawing.Point(10, 78);
            this.btnAddBuild.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBuild.Name = "btnAddBuild";
            this.btnAddBuild.Size = new System.Drawing.Size(88, 28);
            this.btnAddBuild.TabIndex = 7;
            this.btnAddBuild.Text = "Thêm";
            this.btnAddBuild.UseVisualStyleBackColor = true;
            this.btnAddBuild.Click += new System.EventHandler(this.btnAddBuild_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = ">>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách phòng học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách toà nhà";
            // 
            // dtgvClassroom
            // 
            this.dtgvClassroom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvClassroom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvClassroom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClassroom.Location = new System.Drawing.Point(504, 113);
            this.dtgvClassroom.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvClassroom.Name = "dtgvClassroom";
            this.dtgvClassroom.RowHeadersWidth = 51;
            this.dtgvClassroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvClassroom.Size = new System.Drawing.Size(385, 476);
            this.dtgvClassroom.TabIndex = 1;
            this.dtgvClassroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClassroom_CellClick);
            this.dtgvClassroom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClassroom_CellDoubleClick);
            // 
            // dtgvBuilding
            // 
            this.dtgvBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvBuilding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBuilding.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBuilding.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvBuilding.Location = new System.Drawing.Point(10, 113);
            this.dtgvBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvBuilding.MultiSelect = false;
            this.dtgvBuilding.Name = "dtgvBuilding";
            this.dtgvBuilding.RowHeadersWidth = 51;
            this.dtgvBuilding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBuilding.Size = new System.Drawing.Size(385, 476);
            this.dtgvBuilding.TabIndex = 0;
            this.dtgvBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBuilding_CellClick);
            this.dtgvBuilding.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBuilding_CellDoubleClick);
            // 
            // Main_Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 629);
            this.Controls.Add(this.pnActivity);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlToolBar);
            this.Controls.Add(this.pnLocation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Form_Admin";
            this.Text = "Main_Form_Admin";
            this.Load += new System.EventHandler(this.Main_Form_Admin_Load);
            this.pnlToolBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnActivity.ResumeLayout(false);
            this.pnActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvData)).EndInit();
            this.pnLocation.ResumeLayout(false);
            this.pnLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Panel pnActivity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgrvData;
        private System.Windows.Forms.Panel pnLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvClassroom;
        private System.Windows.Forms.DataGridView dtgvBuilding;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnAddBuild;
        private System.Windows.Forms.Label lblTitleTeacher;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbDateOfWeek;
    }
}