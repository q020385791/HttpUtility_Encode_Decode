namespace Changeunicode
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChange = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnencode = new System.Windows.Forms.Button();
            this.txtenocde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(30, 101);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(124, 41);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "HE轉中文";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(30, 55);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(300, 29);
            this.txtinput.TabIndex = 1;
            // 
            // btnencode
            // 
            this.btnencode.Location = new System.Drawing.Point(608, 103);
            this.btnencode.Name = "btnencode";
            this.btnencode.Size = new System.Drawing.Size(146, 36);
            this.btnencode.TabIndex = 3;
            this.btnencode.Text = "中文轉HE";
            this.btnencode.UseVisualStyleBackColor = true;
            this.btnencode.Click += new System.EventHandler(this.Btnencode_Click);
            // 
            // txtenocde
            // 
            this.txtenocde.Location = new System.Drawing.Point(424, 55);
            this.txtenocde.Name = "txtenocde";
            this.txtenocde.Size = new System.Drawing.Size(330, 29);
            this.txtenocde.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "HTML ENTITY 輸入 轉成中文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "中文 輸入 轉成HTML ENTITY";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(195, 187);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(378, 145);
            this.result.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "結果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "說明：適用於&&#xxxxx的代碼轉換";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtenocde);
            this.Controls.Add(this.btnencode);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btnChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnencode;
        private System.Windows.Forms.TextBox txtenocde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

