namespace qualifworks
{
    partial class frmQualifWorks
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpSupervisors = new System.Windows.Forms.TabPage();
            this.tbpStudents = new System.Windows.Forms.TabPage();
            this.lblQualifWorksTopic = new System.Windows.Forms.Label();
            this.dgvQualifWorksTopics = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tbpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifWorksTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpSupervisors);
            this.tabControl1.Controls.Add(this.tbpStudents);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1285, 1018);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpSupervisors
            // 
            this.tbpSupervisors.Location = new System.Drawing.Point(10, 58);
            this.tbpSupervisors.Name = "tbpSupervisors";
            this.tbpSupervisors.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSupervisors.Size = new System.Drawing.Size(1265, 950);
            this.tbpSupervisors.TabIndex = 0;
            this.tbpSupervisors.Text = "Darbu vaditaji";
            this.tbpSupervisors.UseVisualStyleBackColor = true;
            // 
            // tbpStudents
            // 
            this.tbpStudents.Controls.Add(this.lblQualifWorksTopic);
            this.tbpStudents.Controls.Add(this.dgvQualifWorksTopics);
            this.tbpStudents.Controls.Add(this.dataGridView1);
            this.tbpStudents.Location = new System.Drawing.Point(10, 58);
            this.tbpStudents.Name = "tbpStudents";
            this.tbpStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStudents.Size = new System.Drawing.Size(1265, 950);
            this.tbpStudents.TabIndex = 1;
            this.tbpStudents.Text = "Studenti";
            this.tbpStudents.UseVisualStyleBackColor = true;
            // 
            // lblQualifWorksTopic
            // 
            this.lblQualifWorksTopic.AutoSize = true;
            this.lblQualifWorksTopic.Location = new System.Drawing.Point(6, 419);
            this.lblQualifWorksTopic.Name = "lblQualifWorksTopic";
            this.lblQualifWorksTopic.Size = new System.Drawing.Size(346, 41);
            this.lblQualifWorksTopic.TabIndex = 2;
            this.lblQualifWorksTopic.Text = "Noslegumu darbu temas";
            // 
            // dgvQualifWorksTopics
            // 
            this.dgvQualifWorksTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualifWorksTopics.Location = new System.Drawing.Point(-10, 492);
            this.dgvQualifWorksTopics.Name = "dgvQualifWorksTopics";
            this.dgvQualifWorksTopics.RowHeadersWidth = 102;
            this.dgvQualifWorksTopics.RowTemplate.Height = 49;
            this.dgvQualifWorksTopics.Size = new System.Drawing.Size(1253, 375);
            this.dgvQualifWorksTopics.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(1275, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmQualifWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 1033);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmQualifWorks";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbpStudents.ResumeLayout(false);
            this.tbpStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifWorksTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpSupervisors;
        private TabPage tbpStudents;
        private Label lblQualifWorksTopic;
        private DataGridView dgvQualifWorksTopics;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
    }
}