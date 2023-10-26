﻿namespace SpanishScraper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_download = new System.Windows.Forms.Button();
            this.lbl_mangoUrl = new System.Windows.Forms.Label();
            this.txtBox_mangoUrl = new System.Windows.Forms.TextBox();
            this.txtBox_setFolder = new System.Windows.Forms.TextBox();
            this.btn_setFolder = new System.Windows.Forms.Button();
            this.setFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_scan = new System.Windows.Forms.Button();
            this.listBox_Scannies = new System.Windows.Forms.CheckedListBox();
            this.checkBox_MangoSubfolder = new System.Windows.Forms.CheckBox();
            this.listbox_logger = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Delay = new System.Windows.Forms.TextBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageCmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(21, 249);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(119, 23);
            this.btn_download.TabIndex = 0;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.Btn_download_Click);
            // 
            // lbl_mangoUrl
            // 
            this.lbl_mangoUrl.AutoSize = true;
            this.lbl_mangoUrl.Location = new System.Drawing.Point(23, 39);
            this.lbl_mangoUrl.Name = "lbl_mangoUrl";
            this.lbl_mangoUrl.Size = new System.Drawing.Size(75, 15);
            this.lbl_mangoUrl.TabIndex = 1;
            this.lbl_mangoUrl.Text = "Mango URL :";
            // 
            // txtBox_mangoUrl
            // 
            this.txtBox_mangoUrl.Location = new System.Drawing.Point(104, 36);
            this.txtBox_mangoUrl.Name = "txtBox_mangoUrl";
            this.txtBox_mangoUrl.Size = new System.Drawing.Size(441, 23);
            this.txtBox_mangoUrl.TabIndex = 2;
            this.txtBox_mangoUrl.TextChanged += new System.EventHandler(this.txtBox_mangoUrl_TextChanged);
            // 
            // txtBox_setFolder
            // 
            this.txtBox_setFolder.Enabled = false;
            this.txtBox_setFolder.Location = new System.Drawing.Point(104, 65);
            this.txtBox_setFolder.Name = "txtBox_setFolder";
            this.txtBox_setFolder.Size = new System.Drawing.Size(441, 23);
            this.txtBox_setFolder.TabIndex = 4;
            // 
            // btn_setFolder
            // 
            this.btn_setFolder.Location = new System.Drawing.Point(22, 65);
            this.btn_setFolder.Name = "btn_setFolder";
            this.btn_setFolder.Size = new System.Drawing.Size(76, 23);
            this.btn_setFolder.TabIndex = 5;
            this.btn_setFolder.Text = "Set Folder";
            this.btn_setFolder.UseVisualStyleBackColor = true;
            this.btn_setFolder.Click += new System.EventHandler(this.Btn_setFolder_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(21, 153);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(121, 23);
            this.btn_scan.TabIndex = 6;
            this.btn_scan.Text = "Scan the scannies";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.Btn_scan_Click);
            // 
            // listBox_Scannies
            // 
            this.listBox_Scannies.FormattingEnabled = true;
            this.listBox_Scannies.Location = new System.Drawing.Point(148, 153);
            this.listBox_Scannies.Name = "listBox_Scannies";
            this.listBox_Scannies.Size = new System.Drawing.Size(397, 76);
            this.listBox_Scannies.TabIndex = 7;
            this.listBox_Scannies.Visible = false;
            // 
            // checkBox_MangoSubfolder
            // 
            this.checkBox_MangoSubfolder.AutoSize = true;
            this.checkBox_MangoSubfolder.Checked = true;
            this.checkBox_MangoSubfolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_MangoSubfolder.Location = new System.Drawing.Point(23, 123);
            this.checkBox_MangoSubfolder.Name = "checkBox_MangoSubfolder";
            this.checkBox_MangoSubfolder.Size = new System.Drawing.Size(154, 19);
            this.checkBox_MangoSubfolder.TabIndex = 9;
            this.checkBox_MangoSubfolder.Text = "Create mango subfolder";
            this.checkBox_MangoSubfolder.UseVisualStyleBackColor = true;
            // 
            // listbox_logger
            // 
            this.listbox_logger.FormattingEnabled = true;
            this.listbox_logger.HorizontalScrollbar = true;
            this.listbox_logger.ItemHeight = 15;
            this.listbox_logger.Location = new System.Drawing.Point(148, 249);
            this.listbox_logger.Name = "listbox_logger";
            this.listbox_logger.Size = new System.Drawing.Size(397, 139);
            this.listbox_logger.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Weird UI";
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(22, 289);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(118, 23);
            this.btn_stop.TabIndex = 12;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Delay :";
            // 
            // txtBox_Delay
            // 
            this.txtBox_Delay.Location = new System.Drawing.Point(71, 330);
            this.txtBox_Delay.Name = "txtBox_Delay";
            this.txtBox_Delay.Size = new System.Drawing.Size(62, 23);
            this.txtBox_Delay.TabIndex = 14;
            this.txtBox_Delay.Text = "1500";
            this.txtBox_Delay.TextChanged += new System.EventHandler(this.txtBox_Delay_TextChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(21, 97);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(65, 15);
            this.languageLabel.TabIndex = 15;
            this.languageLabel.Text = "Language :";
            // 
            // languageCmbBox
            // 
            this.languageCmbBox.FormattingEnabled = true;
            this.languageCmbBox.Location = new System.Drawing.Point(104, 94);
            this.languageCmbBox.Name = "languageCmbBox";
            this.languageCmbBox.Size = new System.Drawing.Size(121, 23);
            this.languageCmbBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 456);
            this.Controls.Add(this.languageCmbBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.txtBox_Delay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_logger);
            this.Controls.Add(this.checkBox_MangoSubfolder);
            this.Controls.Add(this.listBox_Scannies);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.btn_setFolder);
            this.Controls.Add(this.txtBox_setFolder);
            this.Controls.Add(this.txtBox_mangoUrl);
            this.Controls.Add(this.lbl_mangoUrl);
            this.Controls.Add(this.btn_download);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Spanish Scrapper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_download;
        private Label lbl_mangoUrl;
        private TextBox txtBox_mangoUrl;
        private TextBox txtBox_setFolder;
        private Button btn_setFolder;
        private FolderBrowserDialog setFolderDialog;
        private Button btn_scan;
        private CheckedListBox listBox_Scannies;
        private CheckBox checkBox_MangoSubfolder;
        private ListBox listbox_logger;
        private Label label1;
        private Button btn_stop;
        private Label label2;
        private TextBox txtBox_Delay;
        private Label languageLabel;
        private ComboBox languageCmbBox;
    }
}