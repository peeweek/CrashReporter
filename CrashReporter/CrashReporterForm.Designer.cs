namespace CrashReporter
{
    partial class CrashReporterForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashReporterForm));
            this.labelException = new System.Windows.Forms.Label();
            this.buttonToggleDetails = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.textBoxCrashText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelException
            // 
            this.labelException.AutoSize = true;
            this.labelException.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelException.Location = new System.Drawing.Point(72, 13);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(333, 13);
            this.labelException.TabIndex = 0;
            this.labelException.Text = "Application Crash Label Title - ApplicationCrashException";
            // 
            // buttonToggleDetails
            // 
            this.buttonToggleDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToggleDetails.Location = new System.Drawing.Point(340, 348);
            this.buttonToggleDetails.Name = "buttonToggleDetails";
            this.buttonToggleDetails.Size = new System.Drawing.Size(88, 23);
            this.buttonToggleDetails.TabIndex = 1;
            this.buttonToggleDetails.Text = "Details";
            this.buttonToggleDetails.UseVisualStyleBackColor = true;
            this.buttonToggleDetails.Click += new System.EventHandler(this.buttonToggleDetails_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(434, 348);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDetails.Controls.Add(this.textBoxCrashText);
            this.groupBoxDetails.Location = new System.Drawing.Point(13, 104);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(509, 231);
            this.groupBoxDetails.TabIndex = 5;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Crash Details";
            // 
            // textBoxCrashText
            // 
            this.textBoxCrashText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCrashText.Location = new System.Drawing.Point(6, 20);
            this.textBoxCrashText.Multiline = true;
            this.textBoxCrashText.Name = "textBoxCrashText";
            this.textBoxCrashText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCrashText.Size = new System.Drawing.Size(497, 205);
            this.textBoxCrashText.TabIndex = 0;
            // 
            // CrashReporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 383);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.buttonToggleDetails);
            this.Controls.Add(this.labelException);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CrashReporterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Crash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelException;
        private System.Windows.Forms.Button buttonToggleDetails;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TextBox textBoxCrashText;
    }
}