namespace HomeWork7
{
    partial class fmMain
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbxActions = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grbxResult = new System.Windows.Forms.GroupBox();
            this.lbStep = new System.Windows.Forms.Label();
            this.lbFinish = new System.Windows.Forms.Label();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbxLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbxActions.SuspendLayout();
            this.grbxResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Enabled = false;
            this.btnPlus.Location = new System.Drawing.Point(6, 19);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+ 1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Enabled = false;
            this.btnMulti.Location = new System.Drawing.Point(6, 48);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "x 2";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(6, 77);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "1";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbxActions
            // 
            this.grbxActions.Controls.Add(this.btnBack);
            this.grbxActions.Controls.Add(this.btnPlus);
            this.grbxActions.Controls.Add(this.btnReset);
            this.grbxActions.Controls.Add(this.btnMulti);
            this.grbxActions.Location = new System.Drawing.Point(13, 27);
            this.grbxActions.Name = "grbxActions";
            this.grbxActions.Size = new System.Drawing.Size(88, 134);
            this.grbxActions.TabIndex = 3;
            this.grbxActions.TabStop = false;
            this.grbxActions.Text = "Действия";
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(6, 105);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grbxResult
            // 
            this.grbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxResult.Controls.Add(this.lbStep);
            this.grbxResult.Controls.Add(this.lbFinish);
            this.grbxResult.Controls.Add(this.lbCurrent);
            this.grbxResult.Location = new System.Drawing.Point(108, 27);
            this.grbxResult.Name = "grbxResult";
            this.grbxResult.Size = new System.Drawing.Size(134, 134);
            this.grbxResult.TabIndex = 4;
            this.grbxResult.TabStop = false;
            this.grbxResult.Text = "Результат";
            // 
            // lbStep
            // 
            this.lbStep.AutoSize = true;
            this.lbStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStep.Location = new System.Drawing.Point(6, 77);
            this.lbStep.Name = "lbStep";
            this.lbStep.Size = new System.Drawing.Size(55, 20);
            this.lbStep.TabIndex = 2;
            this.lbStep.Text = "Шаг: 1";
            // 
            // lbFinish
            // 
            this.lbFinish.AutoSize = true;
            this.lbFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFinish.Location = new System.Drawing.Point(6, 19);
            this.lbFinish.Name = "lbFinish";
            this.lbFinish.Size = new System.Drawing.Size(103, 24);
            this.lbFinish.TabIndex = 1;
            this.lbFinish.Text = "Цель: 100";
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrent.Location = new System.Drawing.Point(6, 51);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(90, 20);
            this.lbCurrent.TabIndex = 0;
            this.lbCurrent.Text = "Текущее: 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txbxLog);
            this.groupBox1.Location = new System.Drawing.Point(13, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 153);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лог игры";
            // 
            // txbxLog
            // 
            this.txbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxLog.Location = new System.Drawing.Point(6, 19);
            this.txbxLog.Multiline = true;
            this.txbxLog.Name = "txbxLog";
            this.txbxLog.ReadOnly = true;
            this.txbxLog.Size = new System.Drawing.Size(217, 127);
            this.txbxLog.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(254, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "Игра";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "Новая";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbxResult);
            this.Controls.Add(this.grbxActions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.grbxActions.ResumeLayout(false);
            this.grbxResult.ResumeLayout(false);
            this.grbxResult.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbxActions;
        private System.Windows.Forms.GroupBox grbxResult;
        private System.Windows.Forms.Label lbStep;
        private System.Windows.Forms.Label lbFinish;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbxLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
    }
}

