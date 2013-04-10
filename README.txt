C# CRASH REPORTER 0.0
=====================

Crash Reporter is a Free Form designed to be shown when catching Exceptions 
in your program.
In order to use this form, the best way is to implement a global 
try/catch at the root of your program: see CrashReporterTest\Program.cs

By doing so, you can still implement your try catches elsewhere in your program.

Example : 
=========

        static void Main()
        {
            try
            {
                // Your application code;

            }
	    // When Catching All Exceptions...
            catch (Exception p_Exception)
            {
                CrashReporter.CrashReporterForm crashrep = new CrashReporter.CrashReporterForm(p_Exception, false);
                crashrep.ShowDialog();
            }
        }


When Catching Exception, the exception catcher does:
====================================================

* Display Form
* Write an AppCrash_[DATETIME].txt file

Licenced under WTFPL, do whatever you f*cking want with this code!