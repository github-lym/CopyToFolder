namespace MoveToFolder
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
            this.from_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.from_label = new System.Windows.Forms.Label();
            this.to_label = new System.Windows.Forms.Label();
            this.from_btn = new System.Windows.Forms.Button();
            this.from_textBox = new System.Windows.Forms.TextBox();
            this.to_btn = new System.Windows.Forms.Button();
            this.to_textBox = new System.Windows.Forms.TextBox();
            this.to_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.exe_btn = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.rb_move = new System.Windows.Forms.RadioButton();
            this.rb_copy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime_before = new System.Windows.Forms.DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_after = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_access = new System.Windows.Forms.RadioButton();
            this.rb_modified = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.subFolder_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // from_label
            // 
            this.from_label.AutoSize = true;
            this.from_label.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.from_label.Location = new System.Drawing.Point(17, 24);
            this.from_label.Name = "from_label";
            this.from_label.Size = new System.Drawing.Size(53, 21);
            this.from_label.TabIndex = 0;
            this.from_label.Text = "From";
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.to_label.Location = new System.Drawing.Point(38, 88);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(32, 21);
            this.to_label.TabIndex = 1;
            this.to_label.Text = "To";
            // 
            // from_btn
            // 
            this.from_btn.Location = new System.Drawing.Point(386, 22);
            this.from_btn.Name = "from_btn";
            this.from_btn.Size = new System.Drawing.Size(75, 23);
            this.from_btn.TabIndex = 2;
            this.from_btn.Text = "browse";
            this.from_btn.UseVisualStyleBackColor = true;
            this.from_btn.Click += new System.EventHandler(this.from_btn_Click);
            // 
            // from_textBox
            // 
            this.from_textBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.from_textBox.Location = new System.Drawing.Point(85, 22);
            this.from_textBox.Name = "from_textBox";
            this.from_textBox.Size = new System.Drawing.Size(295, 27);
            this.from_textBox.TabIndex = 3;
            this.from_textBox.Text = "D:\\Upload\\Upload";
            // 
            // to_btn
            // 
            this.to_btn.Location = new System.Drawing.Point(386, 88);
            this.to_btn.Name = "to_btn";
            this.to_btn.Size = new System.Drawing.Size(75, 23);
            this.to_btn.TabIndex = 4;
            this.to_btn.Text = "browse";
            this.to_btn.UseVisualStyleBackColor = true;
            this.to_btn.Click += new System.EventHandler(this.to_btn_Click);
            // 
            // to_textBox
            // 
            this.to_textBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.to_textBox.Location = new System.Drawing.Point(85, 87);
            this.to_textBox.Name = "to_textBox";
            this.to_textBox.Size = new System.Drawing.Size(295, 27);
            this.to_textBox.TabIndex = 5;
            // 
            // exe_btn
            // 
            this.exe_btn.Location = new System.Drawing.Point(343, 390);
            this.exe_btn.Name = "exe_btn";
            this.exe_btn.Size = new System.Drawing.Size(75, 67);
            this.exe_btn.TabIndex = 8;
            this.exe_btn.Text = "RUN";
            this.exe_btn.UseVisualStyleBackColor = true;
            this.exe_btn.Click += new System.EventHandler(this.exe_btn_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 463);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(449, 23);
            this.pBar.TabIndex = 10;
            // 
            // rb_move
            // 
            this.rb_move.AutoSize = true;
            this.rb_move.Checked = true;
            this.rb_move.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_move.Location = new System.Drawing.Point(23, 33);
            this.rb_move.Name = "rb_move";
            this.rb_move.Size = new System.Drawing.Size(67, 23);
            this.rb_move.TabIndex = 11;
            this.rb_move.TabStop = true;
            this.rb_move.Text = "move";
            this.rb_move.UseVisualStyleBackColor = true;
            // 
            // rb_copy
            // 
            this.rb_copy.AutoSize = true;
            this.rb_copy.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_copy.Location = new System.Drawing.Point(191, 33);
            this.rb_copy.Name = "rb_copy";
            this.rb_copy.Size = new System.Drawing.Size(62, 23);
            this.rb_copy.TabIndex = 12;
            this.rb_copy.Text = "copy";
            this.rb_copy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_move);
            this.groupBox1.Controls.Add(this.rb_copy);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(85, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 75);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // dateTime_before
            // 
            this.dateTime_before.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTime_before.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTime_before.Location = new System.Drawing.Point(154, 429);
            this.dateTime_before.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTime_before.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTime_before.Name = "dateTime_before";
            this.dateTime_before.Size = new System.Drawing.Size(169, 27);
            this.dateTime_before.TabIndex = 6;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date_label.Location = new System.Drawing.Point(38, 431);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(108, 21);
            this.date_label.TabIndex = 7;
            this.date_label.Text = "Time before";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(38, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Time after";
            // 
            // dateTime_after
            // 
            this.dateTime_after.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTime_after.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTime_after.Location = new System.Drawing.Point(155, 390);
            this.dateTime_after.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTime_after.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTime_after.Name = "dateTime_after";
            this.dateTime_after.Size = new System.Drawing.Size(169, 27);
            this.dateTime_after.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_access);
            this.groupBox2.Controls.Add(this.rb_modified);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(85, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 75);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // rb_access
            // 
            this.rb_access.AutoSize = true;
            this.rb_access.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_access.Location = new System.Drawing.Point(191, 29);
            this.rb_access.Name = "rb_access";
            this.rb_access.Size = new System.Drawing.Size(73, 23);
            this.rb_access.TabIndex = 11;
            this.rb_access.Text = "access";
            this.rb_access.UseVisualStyleBackColor = true;
            // 
            // rb_modified
            // 
            this.rb_modified.AutoSize = true;
            this.rb_modified.Checked = true;
            this.rb_modified.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_modified.Location = new System.Drawing.Point(23, 29);
            this.rb_modified.Name = "rb_modified";
            this.rb_modified.Size = new System.Drawing.Size(92, 23);
            this.rb_modified.TabIndex = 12;
            this.rb_modified.TabStop = true;
            this.rb_modified.Text = "modified";
            this.rb_modified.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.subFolder_checkBox);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(85, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 75);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option";
            // 
            // subFolder_checkBox
            // 
            this.subFolder_checkBox.AutoSize = true;
            this.subFolder_checkBox.Checked = true;
            this.subFolder_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subFolder_checkBox.Location = new System.Drawing.Point(24, 34);
            this.subFolder_checkBox.Name = "subFolder_checkBox";
            this.subFolder_checkBox.Size = new System.Drawing.Size(183, 23);
            this.subFolder_checkBox.TabIndex = 0;
            this.subFolder_checkBox.Text = "SubFolder(yyyyMM)";
            this.subFolder_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 492);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime_after);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.exe_btn);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.dateTime_before);
            this.Controls.Add(this.to_textBox);
            this.Controls.Add(this.to_btn);
            this.Controls.Add(this.from_textBox);
            this.Controls.Add(this.from_btn);
            this.Controls.Add(this.to_label);
            this.Controls.Add(this.from_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ToFolder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog from_folderBrowserDialog;
        private System.Windows.Forms.Label from_label;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.Button from_btn;
        private System.Windows.Forms.TextBox from_textBox;
        private System.Windows.Forms.Button to_btn;
        private System.Windows.Forms.TextBox to_textBox;
        private System.Windows.Forms.FolderBrowserDialog to_folderBrowserDialog;
        private System.Windows.Forms.Button exe_btn;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.RadioButton rb_move;
        private System.Windows.Forms.RadioButton rb_copy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime_before;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_after;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_access;
        private System.Windows.Forms.RadioButton rb_modified;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox subFolder_checkBox;
    }
}

