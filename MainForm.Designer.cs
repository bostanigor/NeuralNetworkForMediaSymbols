﻿namespace AForge.WindowsForms
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
            this.cmbVideoSource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.processedImgBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.marginTrackBar = new System.Windows.Forms.TrackBar();
            this.borderTrackBar = new System.Windows.Forms.TrackBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ticksLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.resolutionsBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.originalImageBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.processedImgBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.tresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.marginTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.borderTrackBar)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            this.cmbVideoSource.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.cmbVideoSource.FormattingEnabled = true;
            this.cmbVideoSource.Location = new System.Drawing.Point(13, 578);
            this.cmbVideoSource.Name = "cmbVideoSource";
            this.cmbVideoSource.Size = new System.Drawing.Size(219, 21);
            this.cmbVideoSource.TabIndex = 1;
            this.cmbVideoSource.SelectionChangeCommitted +=
                new System.EventHandler(this.cmbVideoSource_SelectionChangeCommitted);
            this.label1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор камеры";
            this.StartButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.StartButton.Location = new System.Drawing.Point(238, 596);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(125, 30);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.btnStart_Click);
            this.groupBox1.Controls.Add(this.originalImageBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 519);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Камера";
            this.originalImageBox.Location = new System.Drawing.Point(6, 13);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(500, 500);
            this.originalImageBox.TabIndex = 1;
            this.originalImageBox.TabStop = false;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.processedImgBox);
            this.panel1.Location = new System.Drawing.Point(519, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 12;
            this.processedImgBox.Location = new System.Drawing.Point(-1, -2);
            this.processedImgBox.Name = "processedImgBox";
            this.processedImgBox.Size = new System.Drawing.Size(500, 500);
            this.processedImgBox.TabIndex = 0;
            this.processedImgBox.TabStop = false;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tresholdTrackBar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.marginTrackBar);
            this.panel2.Controls.Add(this.borderTrackBar);
            this.panel2.Location = new System.Drawing.Point(519, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 137);
            this.panel2.TabIndex = 18;
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(164, 652);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(43, 13);
            this.resultLabel.TabIndex = 28;
            this.resultLabel.Text = "Ничего";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Нейросеть думает, что это:";
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(164, 672);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(33, 13);
            this.percentLabel.TabIndex = 26;
            this.percentLabel.Text = "146%";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 672);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Точность распознавания:";
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(174, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Обработать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Порог";
            this.tresholdTrackBar.LargeChange = 1;
            this.tresholdTrackBar.Location = new System.Drawing.Point(7, 91);
            this.tresholdTrackBar.Maximum = 255;
            this.tresholdTrackBar.Name = "tresholdTrackBar";
            this.tresholdTrackBar.Size = new System.Drawing.Size(140, 45);
            this.tresholdTrackBar.TabIndex = 22;
            this.tresholdTrackBar.TickFrequency = 25;
            this.tresholdTrackBar.Value = 120;
            this.tresholdTrackBar.ValueChanged += new System.EventHandler(this.tresholdTrackBar_ValueChanged);
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Зазор";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Поля";
            this.marginTrackBar.LargeChange = 10;
            this.marginTrackBar.Location = new System.Drawing.Point(162, 31);
            this.marginTrackBar.Maximum = 40;
            this.marginTrackBar.Name = "marginTrackBar";
            this.marginTrackBar.Size = new System.Drawing.Size(140, 45);
            this.marginTrackBar.TabIndex = 19;
            this.marginTrackBar.TickFrequency = 4;
            this.marginTrackBar.Value = 10;
            this.marginTrackBar.ValueChanged += new System.EventHandler(this.marginTrackBar_ValueChanged);
            this.borderTrackBar.LargeChange = 60;
            this.borderTrackBar.Location = new System.Drawing.Point(7, 31);
            this.borderTrackBar.Maximum = 160;
            this.borderTrackBar.Name = "borderTrackBar";
            this.borderTrackBar.Size = new System.Drawing.Size(140, 45);
            this.borderTrackBar.TabIndex = 18;
            this.borderTrackBar.TickFrequency = 10;
            this.borderTrackBar.Value = 40;
            this.borderTrackBar.ValueChanged += new System.EventHandler(this.borderTrackBar_ValueChanged);
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.statusLabel.Location = new System.Drawing.Point(10, 528);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(77, 24);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "Статус:";
            this.ticksLabel.AutoSize = true;
            this.ticksLabel.Location = new System.Drawing.Point(376, 582);
            this.ticksLabel.Name = "ticksLabel";
            this.ticksLabel.Size = new System.Drawing.Size(131, 13);
            this.ticksLabel.TabIndex = 30;
            this.ticksLabel.Text = "Ticks for frame processing";
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.ProcessButton);
            this.controlPanel.Controls.Add(this.PlayButton);
            this.controlPanel.Enabled = false;
            this.controlPanel.Location = new System.Drawing.Point(520, 672);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(441, 59);
            this.controlPanel.TabIndex = 33;
            this.ProcessButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ProcessButton.Location = new System.Drawing.Point(166, 13);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(125, 30);
            this.ProcessButton.TabIndex = 26;
            this.ProcessButton.Text = "Распознать";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            this.PlayButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.PlayButton.Location = new System.Drawing.Point(297, 13);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(125, 30);
            this.PlayButton.TabIndex = 25;
            this.PlayButton.Text = "Обучить";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            this.resolutionsBox.AllowDrop = true;
            this.resolutionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionsBox.FormattingEnabled = true;
            this.resolutionsBox.Location = new System.Drawing.Point(14, 605);
            this.resolutionsBox.Name = "resolutionsBox";
            this.resolutionsBox.Size = new System.Drawing.Size(218, 21);
            this.resolutionsBox.TabIndex = 34;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 742);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resolutionsBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.ticksLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVideoSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Распознавалка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.originalImageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.processedImgBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.tresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.marginTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.borderTrackBar)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVideoSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar marginTrackBar;
        private System.Windows.Forms.TrackBar borderTrackBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label ticksLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tresholdTrackBar;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox processedImgBox;
        private System.Windows.Forms.ComboBox resolutionsBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label label5;
    }
}

