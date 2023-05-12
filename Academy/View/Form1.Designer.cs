namespace Academy.View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegist = new System.Windows.Forms.Label();
            this.btnRegist = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbGuitar = new System.Windows.Forms.RadioButton();
            this.rbPiano = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPiano);
            this.panel1.Controls.Add(this.rbGuitar);
            this.panel1.Controls.Add(this.tbPhoneNumber);
            this.panel1.Controls.Add(this.lblRegist);
            this.panel1.Controls.Add(this.btnRegist);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(47, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 234);
            this.panel1.TabIndex = 3;
            // 
            // lblRegist
            // 
            this.lblRegist.AutoSize = true;
            this.lblRegist.Location = new System.Drawing.Point(70, 28);
            this.lblRegist.Name = "lblRegist";
            this.lblRegist.Size = new System.Drawing.Size(53, 12);
            this.lblRegist.TabIndex = 5;
            this.lblRegist.Text = "학원등록";
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(59, 194);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 24);
            this.btnRegist.TabIndex = 4;
            this.btnRegist.Text = "등록하기";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(46, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(432, 372);
            this.dataGridView1.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(46, 94);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.tbPhoneNumber.TabIndex = 6;
            // 
            // rbGuitar
            // 
            this.rbGuitar.AutoSize = true;
            this.rbGuitar.Location = new System.Drawing.Point(46, 141);
            this.rbGuitar.Name = "rbGuitar";
            this.rbGuitar.Size = new System.Drawing.Size(47, 16);
            this.rbGuitar.TabIndex = 7;
            this.rbGuitar.TabStop = true;
            this.rbGuitar.Text = "기타";
            this.rbGuitar.UseVisualStyleBackColor = true;
            // 
            // rbPiano
            // 
            this.rbPiano.AutoSize = true;
            this.rbPiano.Location = new System.Drawing.Point(46, 163);
            this.rbPiano.Name = "rbPiano";
            this.rbPiano.Size = new System.Drawing.Size(59, 16);
            this.rbPiano.TabIndex = 8;
            this.rbPiano.TabStop = true;
            this.rbPiano.Text = "피아노";
            this.rbPiano.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegist;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbPiano;
        private System.Windows.Forms.RadioButton rbGuitar;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

