
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.tboxQuery = new System.Windows.Forms.TextBox();
            this.btnExe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.tboxPath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가져오기";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(572, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 25);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "DB Load";
            this.btnLoad.UseVisualStyleBackColor = true;
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
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(582, 16);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(65, 28);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "예제3";
            this.btnEx3.UseVisualStyleBackColor = true;
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(511, 16);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(65, 28);
            this.btnEx2.TabIndex = 1;
            this.btnEx2.Text = "예제2";
            this.btnEx2.UseVisualStyleBackColor = true;
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(437, 16);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(65, 28);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "예제1";
            this.btnEx1.UseVisualStyleBackColor = true;
            // 
            // tboxQuery
            // 
            this.tboxQuery.Location = new System.Drawing.Point(7, 50);
            this.tboxQuery.Multiline = true;
            this.tboxQuery.Name = "tboxQuery";
            this.tboxQuery.Size = new System.Drawing.Size(640, 166);
            this.tboxQuery.TabIndex = 3;
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(595, 316);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(65, 28);
            this.btnExe.TabIndex = 4;
            this.btnExe.Text = "실행";
            this.btnExe.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 642);
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
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tboxPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.TextBox tboxQuery;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgData;
    }
}

