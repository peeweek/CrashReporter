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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrashReporter
{
    /// <summary>
    /// A form that gets an exception and formats output Callstack & error. Also Creates a text file of the crash at the end.
    /// </summary>
    public partial class CrashReporterForm : Form
    {
        private Exception e;
        private bool m_bDetailsVisible;

        public event CrashReporterEventHandler CrashReporterClose;

        public CrashReporterForm(Exception e, bool p_DetailsVisible)
        {
            InitializeComponent();
            this.Icon = System.Drawing.SystemIcons.Error;
            this.pictureBoxIcon.Image = System.Drawing.SystemIcons.Error.ToBitmap();
            this.labelException.Text = e.Message;


            string[] v_Text = new string[3];

            v_Text[0] = e.Message;
            v_Text[1] = "";
            v_Text[2] = e.StackTrace;

            this.textBoxCrashText.Lines = v_Text;
            this.textBoxCrashText.ReadOnly = true;

            this.ToggleVisibility(p_DetailsVisible);
        }

        private void buttonToggleDetails_Click(object sender, EventArgs e)
        {
            ToggleVisibility(!this.m_bDetailsVisible);
        }

        private void ToggleVisibility(bool p_DetailsVisible)
        {
            if (p_DetailsVisible)
            {
                this.Height = 400;
                this.groupBoxDetails.Show();
                this.buttonToggleDetails.Text = "Hide Details";

            }
            else
            {
                this.Height = 164;
                this.groupBoxDetails.Hide();
                this.buttonToggleDetails.Text = "Show Details";
            }
            this.m_bDetailsVisible = p_DetailsVisible;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            string v_out = this.textBoxCrashText.Text;
            char[] lineseparators = { '\n' };
            string filename = Application.StartupPath + "\\Appcrash_" + DateTime.Now.ToShortDateString().Replace('/', '-') + "_" + DateTime.Now.ToShortTimeString().Replace(':', '-') + ".txt";
            System.IO.StreamWriter v_Writer = new System.IO.StreamWriter(filename);
            string[] v_lines = v_out.Split(lineseparators);
            foreach (string i_line in v_lines)
            {
                v_Writer.WriteLine(i_line);
            }
            v_Writer.Close();
            if (this.CrashReporterClose != null) CrashReporterClose(this.textBoxCrashText.Lines);
            this.Close();
        }


    }
}
