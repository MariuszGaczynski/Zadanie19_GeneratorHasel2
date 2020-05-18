namespace Zadanie19_GeneratorHasel2
{
    partial class MainForm
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
            this.numUpDownPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.numUpDownHowManyPasswords = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ResetSettings = new System.Windows.Forms.Button();
            this.btn_PasswordGenerator = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_complexity4 = new System.Windows.Forms.RadioButton();
            this.rbtn_complexity3 = new System.Windows.Forms.RadioButton();
            this.rbtn_complexity2 = new System.Windows.Forms.RadioButton();
            this.rbtn_complexity1 = new System.Windows.Forms.RadioButton();
            this.listBox_ListOfPasswords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPasswordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHowManyPasswords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numUpDownPasswordLength
            // 
            this.numUpDownPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUpDownPasswordLength.Location = new System.Drawing.Point(66, 45);
            this.numUpDownPasswordLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDownPasswordLength.Name = "numUpDownPasswordLength";
            this.numUpDownPasswordLength.Size = new System.Drawing.Size(84, 26);
            this.numUpDownPasswordLength.TabIndex = 0;
            this.numUpDownPasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDownPasswordLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numUpDownHowManyPasswords
            // 
            this.numUpDownHowManyPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUpDownHowManyPasswords.Location = new System.Drawing.Point(295, 45);
            this.numUpDownHowManyPasswords.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDownHowManyPasswords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownHowManyPasswords.Name = "numUpDownHowManyPasswords";
            this.numUpDownHowManyPasswords.Size = new System.Drawing.Size(72, 26);
            this.numUpDownHowManyPasswords.TabIndex = 1;
            this.numUpDownHowManyPasswords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDownHowManyPasswords.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(25, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(180, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Characters in Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many Passwords:";
            // 
            // btn_ResetSettings
            // 
            this.btn_ResetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ResetSettings.Location = new System.Drawing.Point(291, 88);
            this.btn_ResetSettings.Name = "btn_ResetSettings";
            this.btn_ResetSettings.Size = new System.Drawing.Size(136, 31);
            this.btn_ResetSettings.TabIndex = 4;
            this.btn_ResetSettings.Text = "Reset all settings";
            this.btn_ResetSettings.UseVisualStyleBackColor = true;
            this.btn_ResetSettings.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_PasswordGenerator
            // 
            this.btn_PasswordGenerator.Enabled = false;
            this.btn_PasswordGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_PasswordGenerator.Location = new System.Drawing.Point(297, 174);
            this.btn_PasswordGenerator.Name = "btn_PasswordGenerator";
            this.btn_PasswordGenerator.Size = new System.Drawing.Size(122, 110);
            this.btn_PasswordGenerator.TabIndex = 5;
            this.btn_PasswordGenerator.Text = "Generate Passwords";
            this.btn_PasswordGenerator.UseVisualStyleBackColor = true;
            this.btn_PasswordGenerator.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_complexity4);
            this.groupBox1.Controls.Add(this.rbtn_complexity3);
            this.groupBox1.Controls.Add(this.rbtn_complexity2);
            this.groupBox1.Controls.Add(this.rbtn_complexity1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(13, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 198);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_complexity4
            // 
            this.rbtn_complexity4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtn_complexity4.Location = new System.Drawing.Point(14, 137);
            this.rbtn_complexity4.Name = "rbtn_complexity4";
            this.rbtn_complexity4.Size = new System.Drawing.Size(220, 63);
            this.rbtn_complexity4.TabIndex = 3;
            this.rbtn_complexity4.TabStop = true;
            this.rbtn_complexity4.Text = "numbers, lowercase letters, uppercase letters and special characters";
            this.rbtn_complexity4.UseVisualStyleBackColor = true;
            this.rbtn_complexity4.Click += new System.EventHandler(this.rbtn_complexity_Click);
            // 
            // rbtn_complexity3
            // 
            this.rbtn_complexity3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtn_complexity3.Location = new System.Drawing.Point(14, 85);
            this.rbtn_complexity3.Name = "rbtn_complexity3";
            this.rbtn_complexity3.Size = new System.Drawing.Size(228, 49);
            this.rbtn_complexity3.TabIndex = 2;
            this.rbtn_complexity3.TabStop = true;
            this.rbtn_complexity3.Text = "numbers, lowercase letters and uppercase letters";
            this.rbtn_complexity3.UseVisualStyleBackColor = true;
            this.rbtn_complexity3.Click += new System.EventHandler(this.rbtn_complexity_Click);
            // 
            // rbtn_complexity2
            // 
            this.rbtn_complexity2.AutoSize = true;
            this.rbtn_complexity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtn_complexity2.Location = new System.Drawing.Point(14, 57);
            this.rbtn_complexity2.Name = "rbtn_complexity2";
            this.rbtn_complexity2.Size = new System.Drawing.Size(228, 22);
            this.rbtn_complexity2.TabIndex = 1;
            this.rbtn_complexity2.TabStop = true;
            this.rbtn_complexity2.Text = "numbers and lowercase letters";
            this.rbtn_complexity2.UseVisualStyleBackColor = true;
            this.rbtn_complexity2.Click += new System.EventHandler(this.rbtn_complexity_Click);
            // 
            // rbtn_complexity1
            // 
            this.rbtn_complexity1.AutoSize = true;
            this.rbtn_complexity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtn_complexity1.Location = new System.Drawing.Point(14, 25);
            this.rbtn_complexity1.Name = "rbtn_complexity1";
            this.rbtn_complexity1.Size = new System.Drawing.Size(84, 22);
            this.rbtn_complexity1.TabIndex = 0;
            this.rbtn_complexity1.TabStop = true;
            this.rbtn_complexity1.Text = "numbers";
            this.rbtn_complexity1.UseVisualStyleBackColor = true;
            this.rbtn_complexity1.CheckedChanged += new System.EventHandler(this.rbtn_complexity_Click);
            // 
            // listBox_ListOfPasswords
            // 
            this.listBox_ListOfPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_ListOfPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_ListOfPasswords.FormattingEnabled = true;
            this.listBox_ListOfPasswords.ItemHeight = 20;
            this.listBox_ListOfPasswords.Location = new System.Drawing.Point(12, 332);
            this.listBox_ListOfPasswords.Name = "listBox_ListOfPasswords";
            this.listBox_ListOfPasswords.Size = new System.Drawing.Size(415, 204);
            this.listBox_ListOfPasswords.TabIndex = 7;
            this.listBox_ListOfPasswords.SelectedIndexChanged += new System.EventHandler(this.listBox_ListOfPasswords_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password Complexity Level:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_ListOfPasswords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_PasswordGenerator);
            this.Controls.Add(this.btn_ResetSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.numUpDownHowManyPasswords);
            this.Controls.Add(this.numUpDownPasswordLength);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 606);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwords Generator 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPasswordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHowManyPasswords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDownPasswordLength;
        private System.Windows.Forms.NumericUpDown numUpDownHowManyPasswords;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ResetSettings;
        private System.Windows.Forms.Button btn_PasswordGenerator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_complexity1;
        private System.Windows.Forms.ListBox listBox_ListOfPasswords;
        private System.Windows.Forms.RadioButton rbtn_complexity4;
        private System.Windows.Forms.RadioButton rbtn_complexity3;
        private System.Windows.Forms.RadioButton rbtn_complexity2;
        private System.Windows.Forms.Label label1;
    }
}

