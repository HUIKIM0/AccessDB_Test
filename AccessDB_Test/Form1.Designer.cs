
namespace AccessDB_Test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDBLoad = new System.Windows.Forms.Button();
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tboxQuery = new System.Windows.Forms.TextBox();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnExe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnExport = new System.Windows.Forms.Button();
            this.SFDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDBLoad);
            this.groupBox1.Controls.Add(this.tboxPath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가져오기";
            // 
            // btnDBLoad
            // 
            this.btnDBLoad.Location = new System.Drawing.Point(572, 25);
            this.btnDBLoad.Name = "btnDBLoad";
            this.btnDBLoad.Size = new System.Drawing.Size(75, 25);
            this.btnDBLoad.TabIndex = 1;
            this.btnDBLoad.Text = "DB Load";
            this.btnDBLoad.UseVisualStyleBackColor = true;
            this.btnDBLoad.Click += new System.EventHandler(this.btnDBLoad_Click);
            // 
            // tboxPath
            // 
            this.tboxPath.Location = new System.Drawing.Point(7, 25);
            this.tboxPath.Name = "tboxPath";
            this.tboxPath.Size = new System.Drawing.Size(559, 25);
            this.tboxPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tboxQuery);
            this.groupBox2.Controls.Add(this.btnEx3);
            this.groupBox2.Controls.Add(this.btnEx2);
            this.groupBox2.Controls.Add(this.btnEx1);
            this.groupBox2.Location = new System.Drawing.Point(13, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "조회";
            // 
            // tboxQuery
            // 
            this.tboxQuery.Location = new System.Drawing.Point(7, 50);
            this.tboxQuery.Multiline = true;
            this.tboxQuery.Name = "tboxQuery";
            this.tboxQuery.Size = new System.Drawing.Size(640, 166);
            this.tboxQuery.TabIndex = 3;
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(582, 16);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(65, 28);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "예제3";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(511, 16);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(65, 28);
            this.btnEx2.TabIndex = 1;
            this.btnEx2.Text = "예제2";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(437, 16);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(65, 28);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "예제1";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(595, 316);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(65, 28);
            this.btnExe.TabIndex = 4;
            this.btnExe.Text = "실행";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgData);
            this.groupBox3.Location = new System.Drawing.Point(13, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(653, 287);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "결과";
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(7, 25);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowTemplate.Height = 27;
            this.dgData.Size = new System.Drawing.Size(640, 256);
            this.dgData.TabIndex = 0;
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "openFileDialog1";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(486, 316);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 28);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Excel Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 642);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDBLoad;
        private System.Windows.Forms.TextBox tboxPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.TextBox tboxQuery;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.OpenFileDialog OFDialog;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog SFDialog;
    }
}

