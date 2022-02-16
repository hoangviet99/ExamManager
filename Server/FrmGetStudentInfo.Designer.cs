
namespace Server
{
    partial class FrmGetStudentInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstClassInfo = new System.Windows.Forms.ListView();
            this.columnHeaderClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstStudentInfo = new System.Windows.Forms.ListView();
            this.columnHeader_StudentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lstClassInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // lstClassInfo
            // 
            this.lstClassInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstClassInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderClassName});
            this.lstClassInfo.FullRowSelect = true;
            this.lstClassInfo.HideSelection = false;
            this.lstClassInfo.Location = new System.Drawing.Point(14, 21);
            this.lstClassInfo.Name = "lstClassInfo";
            this.lstClassInfo.Size = new System.Drawing.Size(280, 483);
            this.lstClassInfo.TabIndex = 0;
            this.lstClassInfo.UseCompatibleStateImageBehavior = false;
            this.lstClassInfo.View = System.Windows.Forms.View.Details;
            this.lstClassInfo.SelectedIndexChanged += new System.EventHandler(this.lstClassInfo_SelectedIndexChanged);
            // 
            // columnHeaderClassName
            // 
            this.columnHeaderClassName.Text = "Lớp";
            this.columnHeaderClassName.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstStudentInfo);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 522);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // lstStudentInfo
            // 
            this.lstStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStudentInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_StudentId,
            this.columnHeader_StudentName,
            this.columnHeader_ClassName});
            this.lstStudentInfo.FullRowSelect = true;
            this.lstStudentInfo.HideSelection = false;
            this.lstStudentInfo.Location = new System.Drawing.Point(12, 21);
            this.lstStudentInfo.Name = "lstStudentInfo";
            this.lstStudentInfo.Size = new System.Drawing.Size(419, 483);
            this.lstStudentInfo.TabIndex = 1;
            this.lstStudentInfo.UseCompatibleStateImageBehavior = false;
            this.lstStudentInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_StudentId
            // 
            this.columnHeader_StudentId.Text = "MSSV";
            // 
            // columnHeader_StudentName
            // 
            this.columnHeader_StudentName.Text = "Tên Sinh Viên";
            this.columnHeader_StudentName.Width = 150;
            // 
            // columnHeader_ClassName
            // 
            this.columnHeader_ClassName.Text = "Lớp";
            this.columnHeader_ClassName.Width = 100;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(206, 540);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(361, 40);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FrmGetStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 592);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(795, 639);
            this.Name = "FrmGetStudentInfo";
            this.Text = "Chọn danh sách sinh viên dự thi";
            this.Load += new System.EventHandler(this.FrmGetStudentInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstClassInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstStudentInfo;
        private System.Windows.Forms.ColumnHeader columnHeader_StudentId;
        private System.Windows.Forms.ColumnHeader columnHeader_StudentName;
        private System.Windows.Forms.ColumnHeader columnHeader_ClassName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader columnHeaderClassName;
    }
}