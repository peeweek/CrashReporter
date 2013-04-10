/*=============================================================================================
            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
                    Version 2, December 2004

 Copyright (C) 2004 Sam Hocevar <sam@hocevar.net>

 Everyone is permitted to copy and distribute verbatim or modified
 copies of this license document, and changing it is allowed as long
 as the name is changed.

            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION

  0. You just DO WHAT THE FUCK YOU WANT TO.

	NON-WARRANTY CLAUSE:
	This program is free software. It comes without any warranty, to
	the extent permitted by applicable law. You can redistribute it
	and/or modify it under the terms of the Do What The Fuck You Want
	To Public License, Version 2, as published by Sam Hocevar. See
	http://www.wtfpl.net/ for more details. 
 * =============================================================================================
 */
namespace CrashReporterTest
{
    partial class CrashReporterTestForm
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
            this.buttonCrashSimple = new System.Windows.Forms.Button();
            this.buttonDBZ = new System.Windows.Forms.Button();
            this.buttonDBZUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCrashSimple
            // 
            this.buttonCrashSimple.Location = new System.Drawing.Point(12, 12);
            this.buttonCrashSimple.Name = "buttonCrashSimple";
            this.buttonCrashSimple.Size = new System.Drawing.Size(93, 35);
            this.buttonCrashSimple.TabIndex = 0;
            this.buttonCrashSimple.Text = "CRASH!";
            this.buttonCrashSimple.UseVisualStyleBackColor = true;
            this.buttonCrashSimple.Click += new System.EventHandler(this.buttonCrashSimple_Click);
            // 
            // buttonDBZ
            // 
            this.buttonDBZ.Location = new System.Drawing.Point(111, 12);
            this.buttonDBZ.Name = "buttonDBZ";
            this.buttonDBZ.Size = new System.Drawing.Size(93, 35);
            this.buttonDBZ.TabIndex = 1;
            this.buttonDBZ.Text = "DIVIDE BY ZERO!";
            this.buttonDBZ.UseVisualStyleBackColor = true;
            this.buttonDBZ.Click += new System.EventHandler(this.buttonDBZ_Click);
            // 
            // buttonDBZUser
            // 
            this.buttonDBZUser.Location = new System.Drawing.Point(210, 12);
            this.buttonDBZUser.Name = "buttonDBZUser";
            this.buttonDBZUser.Size = new System.Drawing.Size(130, 35);
            this.buttonDBZUser.TabIndex = 2;
            this.buttonDBZUser.Text = "DIVIDE BY ZERO! (HANDLED BY USER)";
            this.buttonDBZUser.UseVisualStyleBackColor = true;
            this.buttonDBZUser.Click += new System.EventHandler(this.buttonDBZUser_Click);
            // 
            // CrashReporterTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 59);
            this.Controls.Add(this.buttonDBZUser);
            this.Controls.Add(this.buttonDBZ);
            this.Controls.Add(this.buttonCrashSimple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CrashReporterTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRASH TESTER!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCrashSimple;
        private System.Windows.Forms.Button buttonDBZ;
        private System.Windows.Forms.Button buttonDBZUser;
    }
}

