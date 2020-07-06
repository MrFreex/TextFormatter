namespace TextFormatter
{
    partial class textFormatterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textFormatterForm));
            this.toformatinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputlines = new System.Windows.Forms.TextBox();
            this.format_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadprof = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.browseTxt = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.saveoutput = new System.Windows.Forms.CheckBox();
            this.savethesettings = new System.Windows.Forms.CheckBox();
            this.askbeforeclosing = new System.Windows.Forms.CheckBox();
            this.saveprofbutton = new System.Windows.Forms.Button();
            this.saveprofileas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.profilesel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toformatinput
            // 
            this.toformatinput.Location = new System.Drawing.Point(12, 168);
            this.toformatinput.Name = "toformatinput";
            this.toformatinput.Size = new System.Drawing.Size(620, 26);
            this.toformatinput.TabIndex = 0;
            this.toformatinput.TextChanged += new System.EventHandler(this.toformatinput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Write Here the text to format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1015, 87);
            this.label2.TabIndex = 2;
            this.label2.Text = "How to use:\r\n- Write in here the preset to format, where you\'d like to put the ot" +
    "her inputs add %1,%2,%3 ecc.\r\n- Write down here the text to insert in the first " +
    "text (one per line)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Write Here the text to insert in the preset";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inputlines
            // 
            this.inputlines.Location = new System.Drawing.Point(12, 277);
            this.inputlines.Multiline = true;
            this.inputlines.Name = "inputlines";
            this.inputlines.Size = new System.Drawing.Size(620, 261);
            this.inputlines.TabIndex = 3;
            this.inputlines.TextChanged += new System.EventHandler(this.inputlines_TextChanged);
            // 
            // format_button
            // 
            this.format_button.Location = new System.Drawing.Point(477, 567);
            this.format_button.Name = "format_button";
            this.format_button.Size = new System.Drawing.Size(155, 42);
            this.format_button.TabIndex = 5;
            this.format_button.Text = "Format";
            this.format_button.UseVisualStyleBackColor = true;
            this.format_button.Click += new System.EventHandler(this.format_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadprof);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.saveoutput);
            this.groupBox1.Controls.Add(this.savethesettings);
            this.groupBox1.Controls.Add(this.askbeforeclosing);
            this.groupBox1.Controls.Add(this.saveprofbutton);
            this.groupBox1.Controls.Add(this.saveprofileas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.profilesel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(708, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 473);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // loadprof
            // 
            this.loadprof.ForeColor = System.Drawing.Color.Black;
            this.loadprof.Location = new System.Drawing.Point(417, 41);
            this.loadprof.Name = "loadprof";
            this.loadprof.Size = new System.Drawing.Size(95, 35);
            this.loadprof.TabIndex = 16;
            this.loadprof.Text = "Load";
            this.loadprof.UseVisualStyleBackColor = true;
            this.loadprof.Click += new System.EventHandler(this.loadprof_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtfilename);
            this.groupBox2.Controls.Add(this.browseTxt);
            this.groupBox2.Controls.Add(this.txtpath);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(21, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 150);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TxtFile";
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(16, 99);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(349, 35);
            this.txtfilename.TabIndex = 2;
            this.txtfilename.Text = "Txt file name";
            this.txtfilename.TextChanged += new System.EventHandler(this.txtfilename_TextChanged);
            // 
            // browseTxt
            // 
            this.browseTxt.ForeColor = System.Drawing.Color.Black;
            this.browseTxt.Location = new System.Drawing.Point(381, 35);
            this.browseTxt.Name = "browseTxt";
            this.browseTxt.Size = new System.Drawing.Size(110, 34);
            this.browseTxt.TabIndex = 1;
            this.browseTxt.Text = "Browse Txt";
            this.browseTxt.UseVisualStyleBackColor = true;
            this.browseTxt.Click += new System.EventHandler(this.browseTxt_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(16, 35);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(349, 35);
            this.txtpath.TabIndex = 0;
            this.txtpath.Text = "Txt folder path";
            this.txtpath.TextChanged += new System.EventHandler(this.txtpath_TextChanged);
            // 
            // saveoutput
            // 
            this.saveoutput.AutoSize = true;
            this.saveoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveoutput.Location = new System.Drawing.Point(21, 247);
            this.saveoutput.Name = "saveoutput";
            this.saveoutput.Size = new System.Drawing.Size(315, 33);
            this.saveoutput.TabIndex = 14;
            this.saveoutput.Text = "Save the output in a txt file";
            this.saveoutput.UseVisualStyleBackColor = true;
            this.saveoutput.CheckedChanged += new System.EventHandler(this.saveoutput_CheckedChanged);
            // 
            // savethesettings
            // 
            this.savethesettings.AutoSize = true;
            this.savethesettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savethesettings.Location = new System.Drawing.Point(21, 196);
            this.savethesettings.Name = "savethesettings";
            this.savethesettings.Size = new System.Drawing.Size(221, 33);
            this.savethesettings.TabIndex = 13;
            this.savethesettings.Text = "Save the settings";
            this.savethesettings.UseVisualStyleBackColor = true;
            this.savethesettings.CheckedChanged += new System.EventHandler(this.savethesettings_CheckedChanged);
            // 
            // askbeforeclosing
            // 
            this.askbeforeclosing.AutoSize = true;
            this.askbeforeclosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askbeforeclosing.Location = new System.Drawing.Point(21, 144);
            this.askbeforeclosing.Name = "askbeforeclosing";
            this.askbeforeclosing.Size = new System.Drawing.Size(365, 33);
            this.askbeforeclosing.TabIndex = 12;
            this.askbeforeclosing.Text = "Ask before closing the window";
            this.askbeforeclosing.UseVisualStyleBackColor = true;
            this.askbeforeclosing.CheckedChanged += new System.EventHandler(this.askbeforeclosing_CheckedChanged);
            // 
            // saveprofbutton
            // 
            this.saveprofbutton.ForeColor = System.Drawing.Color.Black;
            this.saveprofbutton.Location = new System.Drawing.Point(439, 94);
            this.saveprofbutton.Name = "saveprofbutton";
            this.saveprofbutton.Size = new System.Drawing.Size(95, 33);
            this.saveprofbutton.TabIndex = 11;
            this.saveprofbutton.Text = "Save";
            this.saveprofbutton.UseVisualStyleBackColor = true;
            this.saveprofbutton.Click += new System.EventHandler(this.saveprofbutton_Click);
            // 
            // saveprofileas
            // 
            this.saveprofileas.Location = new System.Drawing.Point(216, 94);
            this.saveprofileas.Multiline = true;
            this.saveprofileas.Name = "saveprofileas";
            this.saveprofileas.Size = new System.Drawing.Size(200, 33);
            this.saveprofileas.TabIndex = 10;
            this.saveprofileas.TextChanged += new System.EventHandler(this.saveprofileas_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Save profile as";
            // 
            // profilesel
            // 
            this.profilesel.FormattingEnabled = true;
            this.profilesel.Location = new System.Drawing.Point(134, 41);
            this.profilesel.Name = "profilesel";
            this.profilesel.Size = new System.Drawing.Size(269, 28);
            this.profilesel.TabIndex = 8;
            this.profilesel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Profile";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 635);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(620, 47);
            this.output.TabIndex = 7;
            // 
            // textFormatterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1370, 729);
            this.Controls.Add(this.output);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.format_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputlines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toformatinput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "textFormatterForm";
            this.Text = "RC Text Formatter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.textFormatterForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toformatinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputlines;
        private System.Windows.Forms.Button format_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox profilesel;
        private System.Windows.Forms.Button saveprofbutton;
        private System.Windows.Forms.TextBox saveprofileas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button browseTxt;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.CheckBox saveoutput;
        private System.Windows.Forms.CheckBox savethesettings;
        private System.Windows.Forms.CheckBox askbeforeclosing;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button loadprof;
    }
}

