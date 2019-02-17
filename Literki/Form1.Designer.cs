namespace Literki
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gameRB = new System.Windows.Forms.RadioButton();
            this.trainingRB = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.correctLabel = new System.Windows.Forms.Label();
            this.missedLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.difficultyProgressBar = new System.Windows.Forms.ProgressBar();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 70;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 76;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(504, 80);
            this.listBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericInterval
            // 
            this.numericInterval.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericInterval.Location = new System.Drawing.Point(401, 199);
            this.numericInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(68, 20);
            this.numericInterval.TabIndex = 2;
            this.numericInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interwał";
            // 
            // gameRB
            // 
            this.gameRB.AutoSize = true;
            this.gameRB.Checked = true;
            this.gameRB.Location = new System.Drawing.Point(401, 119);
            this.gameRB.Name = "gameRB";
            this.gameRB.Size = new System.Drawing.Size(55, 17);
            this.gameRB.TabIndex = 4;
            this.gameRB.TabStop = true;
            this.gameRB.Text = "Zagraj";
            this.gameRB.UseVisualStyleBackColor = true;
            this.gameRB.CheckedChanged += new System.EventHandler(this.gameRB_CheckedChanged);
            // 
            // trainingRB
            // 
            this.trainingRB.AutoSize = true;
            this.trainingRB.Location = new System.Drawing.Point(401, 152);
            this.trainingRB.Name = "trainingRB";
            this.trainingRB.Size = new System.Drawing.Size(61, 17);
            this.trainingRB.TabIndex = 5;
            this.trainingRB.Text = "Trening";
            this.trainingRB.UseVisualStyleBackColor = true;
            this.trainingRB.CheckedChanged += new System.EventHandler(this.trainingRB_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(378, 237);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 44);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Location = new System.Drawing.Point(17, 23);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(86, 13);
            this.correctLabel.TabIndex = 8;
            this.correctLabel.Text = "Prawidłowych: 0";
            // 
            // missedLabel
            // 
            this.missedLabel.AutoSize = true;
            this.missedLabel.Location = new System.Drawing.Point(17, 56);
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(56, 13);
            this.missedLabel.TabIndex = 9;
            this.missedLabel.Text = "Błędów: 0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(17, 90);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(73, 13);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Wszystkich: 0";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Location = new System.Drawing.Point(17, 121);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(86, 13);
            this.accuracyLabel.TabIndex = 11;
            this.accuracyLabel.Text = "Dokładność: 0%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.difficultyProgressBar);
            this.groupBox1.Controls.Add(this.totalLabel);
            this.groupBox1.Controls.Add(this.accuracyLabel);
            this.groupBox1.Controls.Add(this.correctLabel);
            this.groupBox1.Controls.Add(this.missedLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 191);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // difficultyProgressBar
            // 
            this.difficultyProgressBar.Location = new System.Drawing.Point(6, 148);
            this.difficultyProgressBar.Name = "difficultyProgressBar";
            this.difficultyProgressBar.Size = new System.Drawing.Size(118, 23);
            this.difficultyProgressBar.Step = 0;
            this.difficultyProgressBar.TabIndex = 12;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(166, 115);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 30);
            this.infoLabel.TabIndex = 13;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 324);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.trainingRB);
            this.Controls.Add(this.gameRB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericInterval);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Literki";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton gameRB;
        private System.Windows.Forms.RadioButton trainingRB;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label missedLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar difficultyProgressBar;
        private System.Windows.Forms.Label infoLabel;
    }
}

