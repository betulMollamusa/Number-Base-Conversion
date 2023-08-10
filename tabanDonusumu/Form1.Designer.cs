namespace tabanDonusumu
{
    partial class Form1
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
            this.numberLabel = new System.Windows.Forms.Label();
            this.baseNumLabel = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.inputComboBox = new System.Windows.Forms.ComboBox();
            this.BaseConvertLabel = new System.Windows.Forms.Label();
            this.convertComboBox = new System.Windows.Forms.ComboBox();
            this.NewNumLabel = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.lblResultFromBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberLabel.Location = new System.Drawing.Point(72, 65);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(213, 27);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Dönüştürülecek Sayı :";
            // 
            // baseNumLabel
            // 
            this.baseNumLabel.AutoSize = true;
            this.baseNumLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baseNumLabel.Location = new System.Drawing.Point(72, 111);
            this.baseNumLabel.Name = "baseNumLabel";
            this.baseNumLabel.Size = new System.Drawing.Size(158, 27);
            this.baseNumLabel.TabIndex = 1;
            this.baseNumLabel.Text = "Sayının Tabanı :";
            // 
            // txtDecimal
            // 
            this.txtDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDecimal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDecimal.Location = new System.Drawing.Point(363, 62);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(219, 34);
            this.txtDecimal.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConvert.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConvert.Location = new System.Drawing.Point(321, 243);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(158, 41);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Hesapla";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResultLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResultLabel.Location = new System.Drawing.Point(358, 250);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 27);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Visible = false;
            // 
            // inputComboBox
            // 
            this.inputComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputComboBox.FormattingEnabled = true;
            this.inputComboBox.Location = new System.Drawing.Point(363, 108);
            this.inputComboBox.Name = "inputComboBox";
            this.inputComboBox.Size = new System.Drawing.Size(219, 35);
            this.inputComboBox.TabIndex = 7;
            // 
            // BaseConvertLabel
            // 
            this.BaseConvertLabel.AutoSize = true;
            this.BaseConvertLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaseConvertLabel.Location = new System.Drawing.Point(72, 166);
            this.BaseConvertLabel.Name = "BaseConvertLabel";
            this.BaseConvertLabel.Size = new System.Drawing.Size(230, 27);
            this.BaseConvertLabel.TabIndex = 8;
            this.BaseConvertLabel.Text = "Dönüştürülecek Taban :";
            // 
            // convertComboBox
            // 
            this.convertComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.convertComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.convertComboBox.FormattingEnabled = true;
            this.convertComboBox.Location = new System.Drawing.Point(363, 158);
            this.convertComboBox.Name = "convertComboBox";
            this.convertComboBox.Size = new System.Drawing.Size(219, 35);
            this.convertComboBox.TabIndex = 9;
            // 
            // NewNumLabel
            // 
            this.NewNumLabel.AutoSize = true;
            this.NewNumLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewNumLabel.Location = new System.Drawing.Point(72, 250);
            this.NewNumLabel.Name = "NewNumLabel";
            this.NewNumLabel.Size = new System.Drawing.Size(174, 27);
            this.NewNumLabel.TabIndex = 10;
            this.NewNumLabel.Text = "Hesaplanan Sayı :";
            this.NewNumLabel.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClear.Location = new System.Drawing.Point(634, 382);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(154, 41);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Temizle";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // lblResultFromBase
            // 
            this.lblResultFromBase.AutoSize = true;
            this.lblResultFromBase.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResultFromBase.Location = new System.Drawing.Point(321, 299);
            this.lblResultFromBase.Name = "lblResultFromBase";
            this.lblResultFromBase.Size = new System.Drawing.Size(0, 23);
            this.lblResultFromBase.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultFromBase);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.NewNumLabel);
            this.Controls.Add(this.convertComboBox);
            this.Controls.Add(this.BaseConvertLabel);
            this.Controls.Add(this.inputComboBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.baseNumLabel);
            this.Controls.Add(this.numberLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label baseNumLabel;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.ComboBox inputComboBox;
        private System.Windows.Forms.Label BaseConvertLabel;
        private System.Windows.Forms.ComboBox convertComboBox;
        private System.Windows.Forms.Label NewNumLabel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label lblResultFromBase;
    }
}

