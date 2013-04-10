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

namespace CrashReporterTest
{
    public partial class CrashReporterTestForm : Form
    {
        public CrashReporterTestForm()
        {
            this.Icon = System.Drawing.SystemIcons.Error;
            InitializeComponent();
        }

        private void buttonCrashSimple_Click(object sender, EventArgs e)
        {
            throw new Exception("As requested, I crashed.");
        }

        private void buttonDBZ_Click(object sender, EventArgs e)
        {
            int X = 10;
            int Y = -X;
            MessageBox.Show(div(X, X + Y).ToString());
        }

        private int div(int X, int Y)
        {
            return X / Y;
        }

        private void buttonDBZUser_Click(object sender, EventArgs e)
        {
            try
            {
                int X = 10;
                int Y = -X;
                MessageBox.Show(div(X, X + Y).ToString());
            }
            catch (Exception pe)
            {
                MessageBox.Show("Caught Manally Exception : " + pe.Message);
            }
        }


    }
}
