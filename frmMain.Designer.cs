
namespace PluginNamer
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.pbrMain = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to plugin database:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(169, 13);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(603, 25);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.Text = "D:\\Users\\Christian\\Documents\\Image-Line\\FL Studio\\Presets\\Plugin database";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(778, 13);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(32, 26);
            this.btnBrowseFolder.TabIndex = 2;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(640, 101);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 39);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Convert thumbnails";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Font Size:";
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(169, 46);
            this.numFontSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(66, 25);
            this.numFontSize.TabIndex = 5;
            this.numFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFontSize.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // pbrMain
            // 
            this.pbrMain.Location = new System.Drawing.Point(16, 109);
            this.pbrMain.MarqueeAnimationSpeed = 10;
            this.pbrMain.Name = "pbrMain";
            this.pbrMain.Size = new System.Drawing.Size(219, 23);
            this.pbrMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbrMain.TabIndex = 6;
            this.pbrMain.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 152);
            this.Controls.Add(this.pbrMain);
            this.Controls.Add(this.numFontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "FLPluginLabeler";
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.ProgressBar pbrMain;
    }
}

