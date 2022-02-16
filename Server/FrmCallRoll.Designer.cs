
namespace Server
{
    partial class FrmCallRoll
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstStudentInfo = new System.Windows.Forms.ListView();
            this.columnHeader_StudentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.lblPresentStudent = new System.Windows.Forms.Label();
            this.lblAbsentStudent = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstStudentInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 481);
            this.groupBox2.TabIndex = 2;
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
            this.columnHeader_ClassName,
            this.columnHeader_Status});
            this.lstStudentInfo.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.lstStudentInfo.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lstStudentInfo.HideSelection = false;
            this.lstStudentInfo.Location = new System.Drawing.Point(12, 21);
            this.lstStudentInfo.Name = "lstStudentInfo";
            this.lstStudentInfo.Size = new System.Drawing.Size(537, 442);
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
            // columnHeader_Status
            // 
            this.columnHeader_Status.Text = "Trạng thái";
            this.columnHeader_Status.Width = 100;
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudent.Location = new System.Drawing.Point(12, 506);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(549, 23);
            this.lblTotalStudent.TabIndex = 3;
            this.lblTotalStudent.Text = "Tổng số sinh viên: ";
            this.lblTotalStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPresentStudent
            // 
            this.lblPresentStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPresentStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentStudent.Location = new System.Drawing.Point(12, 531);
            this.lblPresentStudent.Name = "lblPresentStudent";
            this.lblPresentStudent.Size = new System.Drawing.Size(549, 23);
            this.lblPresentStudent.TabIndex = 4;
            this.lblPresentStudent.Text = "Số sinh viên hiện tại: ";
            this.lblPresentStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAbsentStudent
            // 
            this.lblAbsentStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbsentStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsentStudent.Location = new System.Drawing.Point(12, 557);
            this.lblAbsentStudent.Name = "lblAbsentStudent";
            this.lblAbsentStudent.Size = new System.Drawing.Size(549, 23);
            this.lblAbsentStudent.TabIndex = 5;
            this.lblAbsentStudent.Text = "Số sinh viên vắng mặt: ";
            this.lblAbsentStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCallRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 589);
            this.Controls.Add(this.lblAbsentStudent);
            this.Controls.Add(this.lblPresentStudent);
            this.Controls.Add(this.lblTotalStudent);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(602, 636);
            this.Name = "FrmCallRoll";
            this.Text = "Điểm danh sinh viên";
            this.Load += new System.EventHandler(this.FrmCallRoll_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstStudentInfo;
        private System.Windows.Forms.ColumnHeader columnHeader_StudentId;
        private System.Windows.Forms.ColumnHeader columnHeader_StudentName;
        private System.Windows.Forms.ColumnHeader columnHeader_ClassName;
        private System.Windows.Forms.ColumnHeader columnHeader_Status;
        private System.Windows.Forms.Label lblTotalStudent;
        private System.Windows.Forms.Label lblPresentStudent;
        private System.Windows.Forms.Label lblAbsentStudent;
    }
}