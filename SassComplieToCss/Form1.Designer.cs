namespace SassComplieToCss
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sassDir = new System.Windows.Forms.TextBox();
            this.cssDir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RubyDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sass폴더경로 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PartnerData 폴더경로 : ";
            // 
            // sassDir
            // 
            this.sassDir.Location = new System.Drawing.Point(189, 66);
            this.sassDir.Name = "sassDir";
            this.sassDir.Size = new System.Drawing.Size(357, 21);
            this.sassDir.TabIndex = 2;
            this.sassDir.Text = "C:\\Dev\\v2Test\\TqoonV2\\TqoonV2\\Content\\1\\sass";
            // 
            // cssDir
            // 
            this.cssDir.Location = new System.Drawing.Point(189, 96);
            this.cssDir.Name = "cssDir";
            this.cssDir.Size = new System.Drawing.Size(357, 21);
            this.cssDir.TabIndex = 3;
            this.cssDir.Text = "D:\\DevVirtualDirectory\\PartnerData\\63\\Content\\Css";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "sass 컴파일";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(76, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ruby폴더경로 :";
            // 
            // RubyDir
            // 
            this.RubyDir.Location = new System.Drawing.Point(189, 33);
            this.RubyDir.Name = "RubyDir";
            this.RubyDir.Size = new System.Drawing.Size(357, 21);
            this.RubyDir.TabIndex = 6;
            this.RubyDir.Text = "C:\\Ruby23-x64\\bin\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 261);
            this.Controls.Add(this.RubyDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cssDir);
            this.Controls.Add(this.sassDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "sass컴파일러";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sassDir;
        private System.Windows.Forms.TextBox cssDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RubyDir;
    }
}

