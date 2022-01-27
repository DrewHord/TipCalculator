
namespace TipCalculator {
    partial class TipCalculatorForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCalculateTIp = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTipPercent = new System.Windows.Forms.TextBox();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateTIp
            // 
            this.btnCalculateTIp.Location = new System.Drawing.Point(130, 318);
            this.btnCalculateTIp.Name = "btnCalculateTIp";
            this.btnCalculateTIp.Size = new System.Drawing.Size(112, 34);
            this.btnCalculateTIp.TabIndex = 0;
            this.btnCalculateTIp.Text = "&Calculate Tip";
            this.btnCalculateTIp.UseVisualStyleBackColor = true;
            this.btnCalculateTIp.Click += new System.EventHandler(this.btnCalculateTIp_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(363, 69);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 31);
            this.txtTotal.TabIndex = 4;
            // 
            // txtTipPercent
            // 
            this.txtTipPercent.Location = new System.Drawing.Point(363, 137);
            this.txtTipPercent.Name = "txtTipPercent";
            this.txtTipPercent.ReadOnly = true;
            this.txtTipPercent.Size = new System.Drawing.Size(150, 31);
            this.txtTipPercent.TabIndex = 5;
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Location = new System.Drawing.Point(363, 203);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.ReadOnly = true;
            this.txtTipAmount.Size = new System.Drawing.Size(150, 31);
            this.txtTipAmount.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(401, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bill Total";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tip Percentage";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tip Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TipCalculatorForm
            // 
            this.AcceptButton = this.btnCalculateTIp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(646, 451);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.txtTipPercent);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalculateTIp);
            this.Name = "TipCalculatorForm";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateTIp;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTipPercent;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

