namespace FileToFolder
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fromPathTextBox = new System.Windows.Forms.TextBox();
            this.fromPathButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toPathButton = new System.Windows.Forms.Button();
            this.toPathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.accessedRadioButton = new System.Windows.Forms.RadioButton();
            this.modifiedRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.copyRadioButton = new System.Windows.Forms.RadioButton();
            this.moveRadioButton = new System.Windows.Forms.RadioButton();
            this.subFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.goButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 286);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(480, 23);
            this.progressBar.TabIndex = 0;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endDatePicker.Location = new System.Drawing.Point(58, 63);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(164, 27);
            this.endDatePicker.TabIndex = 1;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startDatePicker.Location = new System.Drawing.Point(58, 30);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(164, 27);
            this.startDatePicker.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.startDatePicker);
            this.groupBox1.Controls.Add(this.endDatePicker);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(257, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "時間範圍起迄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "迄(<=)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "起(>=)";
            // 
            // fromPathTextBox
            // 
            this.fromPathTextBox.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fromPathTextBox.Location = new System.Drawing.Point(50, 26);
            this.fromPathTextBox.Name = "fromPathTextBox";
            this.fromPathTextBox.Size = new System.Drawing.Size(339, 23);
            this.fromPathTextBox.TabIndex = 5;
            // 
            // fromPathButton
            // 
            this.fromPathButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fromPathButton.Location = new System.Drawing.Point(398, 24);
            this.fromPathButton.Name = "fromPathButton";
            this.fromPathButton.Size = new System.Drawing.Size(75, 23);
            this.fromPathButton.TabIndex = 6;
            this.fromPathButton.Text = "瀏覽";
            this.fromPathButton.UseVisualStyleBackColor = true;
            this.fromPathButton.Click += new System.EventHandler(this.fromPathButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.toPathButton);
            this.groupBox2.Controls.Add(this.fromPathTextBox);
            this.groupBox2.Controls.Add(this.toPathTextBox);
            this.groupBox2.Controls.Add(this.fromPathButton);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "來源&&目的路徑";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "目的";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "來源";
            // 
            // toPathButton
            // 
            this.toPathButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toPathButton.Location = new System.Drawing.Point(398, 60);
            this.toPathButton.Name = "toPathButton";
            this.toPathButton.Size = new System.Drawing.Size(75, 23);
            this.toPathButton.TabIndex = 9;
            this.toPathButton.Text = "瀏覽";
            this.toPathButton.UseVisualStyleBackColor = true;
            this.toPathButton.Click += new System.EventHandler(this.toPathButton_Click);
            // 
            // toPathTextBox
            // 
            this.toPathTextBox.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toPathTextBox.Location = new System.Drawing.Point(50, 62);
            this.toPathTextBox.Name = "toPathTextBox";
            this.toPathTextBox.Size = new System.Drawing.Size(339, 23);
            this.toPathTextBox.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.accessedRadioButton);
            this.groupBox3.Controls.Add(this.modifiedRadioButton);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 56);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "判斷依據";
            // 
            // accessedRadioButton
            // 
            this.accessedRadioButton.AutoSize = true;
            this.accessedRadioButton.Location = new System.Drawing.Point(132, 27);
            this.accessedRadioButton.Name = "accessedRadioButton";
            this.accessedRadioButton.Size = new System.Drawing.Size(90, 20);
            this.accessedRadioButton.TabIndex = 1;
            this.accessedRadioButton.Text = "存取時間";
            this.accessedRadioButton.UseVisualStyleBackColor = true;
            // 
            // modifiedRadioButton
            // 
            this.modifiedRadioButton.AutoSize = true;
            this.modifiedRadioButton.Checked = true;
            this.modifiedRadioButton.Location = new System.Drawing.Point(9, 27);
            this.modifiedRadioButton.Name = "modifiedRadioButton";
            this.modifiedRadioButton.Size = new System.Drawing.Size(90, 20);
            this.modifiedRadioButton.TabIndex = 0;
            this.modifiedRadioButton.TabStop = true;
            this.modifiedRadioButton.Text = "修改時間";
            this.modifiedRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.copyRadioButton);
            this.groupBox4.Controls.Add(this.moveRadioButton);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(12, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 56);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "移動或複製";
            // 
            // copyRadioButton
            // 
            this.copyRadioButton.AutoSize = true;
            this.copyRadioButton.Location = new System.Drawing.Point(84, 30);
            this.copyRadioButton.Name = "copyRadioButton";
            this.copyRadioButton.Size = new System.Drawing.Size(180, 20);
            this.copyRadioButton.TabIndex = 1;
            this.copyRadioButton.Text = "複製(同檔名自動覆蓋)";
            this.copyRadioButton.UseVisualStyleBackColor = true;
            // 
            // moveRadioButton
            // 
            this.moveRadioButton.AutoSize = true;
            this.moveRadioButton.Checked = true;
            this.moveRadioButton.Location = new System.Drawing.Point(9, 30);
            this.moveRadioButton.Name = "moveRadioButton";
            this.moveRadioButton.Size = new System.Drawing.Size(58, 20);
            this.moveRadioButton.TabIndex = 0;
            this.moveRadioButton.TabStop = true;
            this.moveRadioButton.Text = "移動";
            this.moveRadioButton.UseVisualStyleBackColor = true;
            // 
            // subFolderCheckBox
            // 
            this.subFolderCheckBox.AutoSize = true;
            this.subFolderCheckBox.Checked = true;
            this.subFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subFolderCheckBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subFolderCheckBox.Location = new System.Drawing.Point(12, 188);
            this.subFolderCheckBox.Name = "subFolderCheckBox";
            this.subFolderCheckBox.Size = new System.Drawing.Size(239, 20);
            this.subFolderCheckBox.TabIndex = 10;
            this.subFolderCheckBox.Text = "依月份產生子資料夾(yyyyMM)";
            this.subFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.goButton.Location = new System.Drawing.Point(367, 224);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(125, 52);
            this.goButton.TabIndex = 11;
            this.goButton.Text = "執行";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 315);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.subFolderCheckBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.FolderBrowserDialog fromFolderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog toFolderBrowserDialog;
        private System.Windows.Forms.TextBox fromPathTextBox;
        private System.Windows.Forms.Button fromPathButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toPathButton;
        private System.Windows.Forms.TextBox toPathTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton modifiedRadioButton;
        private System.Windows.Forms.RadioButton accessedRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton copyRadioButton;
        private System.Windows.Forms.RadioButton moveRadioButton;
        private System.Windows.Forms.CheckBox subFolderCheckBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

