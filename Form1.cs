﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace TextFormatter
{
    public partial class textFormatterForm : Form
    {
        private static string XMLFileDIR = @"C:\ProgramData\textFormatter\Settings_file.xml";
        private static string XMLDIR = XMLFileDIR.Replace(@"\Settings_file.xml", "");

        private void loadMLConfig()
        {


            // Check if the config exists
            // Set Public Variables 
            string updatetxtDir = "";

        // Goto label
        Recheck:

            if (!File.Exists(XMLFileDIR))
            {
                //Creata a New XDocument
                string currentVer = Assembly.GetEntryAssembly().GetName().Version.ToString();
                XDocument MLConfig = new XDocument(
                    new XDeclaration("1.0", "utf8", "yes"),
                    new XComment("XML Config auto generated by TextFormatter"),
                    new XComment("Authors: MrFreex"),
                    
                    new XElement("TextFormatter",
                        new XElement("XMLVersion", currentVer),
                        new XElement("SelectedProfile", "Default"),
                        new XElement("Settings",
                            new XElement("txtDir", updatetxtDir),
                            new XElement("txtName", "passwordgen.txt"),
                            new XElement("toformat", ""),
                            new XElement("profiles", "Default"),
                            new XElement("linesInput", ""),
                            new XElement("askbeforeclosing","True"),
                            new XElement("savesettings", "True"),
                            new XElement("saveoutput", "False"),
                            new XElement("SelectedProfile","Default")
                        )

                       )
                    );
                //Creata the Directory and Config
                Directory.CreateDirectory(XMLDIR);
                MLConfig.Save(XMLFileDIR);
                goto Recheck;

            }
            else
            {
                //Load the config
                XDocument _config = XDocument.Load(XMLFileDIR);
                string currentVer = Assembly.GetEntryAssembly().GetName().Version.ToString();
                string xmlVer = _config.Root.Element("XMLVersion").Value.ToString().Replace("<XMLVersion>", "").Replace("</XMLVersion", "");
                updatetxtDir = _config.Root.Element("Settings").Element("txtDir").Value.ToString().Replace("<txtDir>", "").Replace("</txtDir>", "");
                txtfilename.Text = _config.Root.Element("Settings").Element("txtName").Value.ToString().Replace("<txtName>", "").Replace("</txtName>", "");
                toformatinput.Text = _config.Root.Element("Settings").Element("toformat").Value.ToString().Replace("<toformat>", "").Replace("</toformat>", "");
                string[] Profiles = _config.Root.Element("Settings").Element("profiles").Value.ToString().Replace("<profiles>", "").Replace("</profiles>", "").Split(',');
                string ToSplitText = _config.Root.Element("Settings").Element("linesInput").Value.ToString().Replace("<linesInput>", "").Replace("</linesInput>", "");
                inputlines.Lines = ToSplitText.Split(',');
                profilesel.Items.Clear();
                string readProfile = _config.Root.Element("Settings").Element("SelectedProfile").Value.Replace("<SelectedProfile>", "").Replace("</SelectedProfile>", "");
                foreach (string element in Profiles)
                {
                    profilesel.Items.Add(element);
                }
                int index = 0;
                for (int i = 0; i < profilesel.Items.Count; i++)
                {
                    if (Convert.ToString(profilesel.Items[i]) == readProfile)
                    {
                        index = i;
                    }
                }
                profilesel.SelectedIndex = index;
                if (xmlVer == currentVer)
                {
                    //set Arma 3 Dir
                    txtpath.Text = updatetxtDir;

                    //set Checkboxes
                    askbeforeclosing.Checked = Convert.ToBoolean(_config.Root.Element("Settings").Element("askbeforeclosing").Value);
                    savethesettings.Checked = Convert.ToBoolean(_config.Root.Element("Settings").Element("savesettings").Value);
                    saveoutput.Checked = Convert.ToBoolean(_config.Root.Element("Settings").Element("saveoutput").Value);
                    if (readProfile != "Default")
                    {
                        loadProfile(readProfile);
                    }
                }
                else
                {
                    /*
                        If the XML Version is not the same as the program Version
                        Delete, after loop through and Recreate the XML and reset
                        the settings.
                    */
                    System.IO.File.Delete(XMLFileDIR);
                    goto Recheck;
                }

            }


        }

        private void saveCBValues()
        {
            if (!savethesettings.Checked)
            {
                return;
            }
            XDocument _config = XDocument.Load(XMLFileDIR);
            string[] items = new string[profilesel.Items.Count];

            for (int i = 0; i < profilesel.Items.Count; i++)
            {
                items[i] = profilesel.Items[i].ToString();
            }
            string toSave = string.Join(",", items);
            _config.Root.Element("Settings").Element("profiles").Value = toSave;
            _config.Root.Element("Settings").Element("SelectedProfile").Value = Convert.ToString(profilesel.SelectedItem);
            _config.Save(XMLFileDIR);
            if (Convert.ToString(profilesel.SelectedItem) != "Default" && Convert.ToString(profilesel.SelectedItem) != "")
            {
                //MessageBox.Show(Convert.ToString(profilesel.SelectedItem) + " now saving ");
                saveprofile(false);
                return;
            }
            
            string linestosave = "";
            foreach (var line in inputlines.Lines)
            {
                linestosave += string.Format("{0},",line);
            }
            _config.Root.Element("Settings").Element("txtDir").Value = txtpath.Text;
            _config.Root.Element("Settings").Element("txtName").Value = txtfilename.Text;
            _config.Root.Element("Settings").Element("toformat").Value = toformatinput.Text;
            _config.Root.Element("Settings").Element("linesInput").Value = linestosave;
            _config.Root.Element("Settings").Element("askbeforeclosing").Value = Convert.ToString(askbeforeclosing.Checked);
            _config.Root.Element("Settings").Element("savesettings").Value = Convert.ToString(savethesettings.Checked);
            _config.Root.Element("Settings").Element("saveoutput").Value = Convert.ToString(saveoutput.Checked);
            _config.Save(XMLFileDIR);

        }
        public textFormatterForm()
        {
            InitializeComponent();
            loadMLConfig();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(XMLFileDIR);
            doc.Root.Element("Settings").Element("SelectedProfile").Value = Convert.ToString(profilesel.SelectedItem);
            doc.Save(XMLFileDIR);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
                "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }

        private void saveprofbutton_Click(object sender, EventArgs e)
        {
            if (saveprofileas.Text != "")
            {
                if (profilesel.Items.Contains(saveprofileas.Text))
                {
                    MessageBox.Show("a profile with that name already exists");
                } else
                {
                    profilesel.Items.Add(saveprofileas.Text);
                }
            } else
            {
                MessageBox.Show("Profile name cannot be empty!");
            }
            
        }

        private void toformatinput_TextChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void saveprofileas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpath_TextChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void txtfilename_TextChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void askbeforeclosing_CheckedChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void savethesettings_CheckedChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void saveoutput_CheckedChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void format_button_Click(object sender, EventArgs e)
        {
            if (toformatinput.Text != "" || !(toformatinput.Text.Contains("%1")))
            {
                freex_conversionRequirements();
            } else
            {
                MessageBox.Show("Wrong Input");
            }
        }

        private void freex_conversionRequirements()
        {
            string[] Formatters = toformatinput.Text.Split('%');
            bool exception = false;
            if (Formatters.Length != (inputlines.Lines.Length + 1))
            {
                for (int i = 0; i < inputlines.Lines.Length; i++)
                {
                    if (inputlines.Lines[i] == "\r\n" && !exception)
                    {
                        exception = true;
                    }
                    //MessageBox.Show(inputlines.Lines[i]); // Debug
                }
                if (exception)
                {
                    MessageBox.Show("There are too much % operators");
                }
            }
            string outputText = toformatinput.Text;
            for (int i = 0; i < inputlines.Lines.Length; i++)
            {
                string operatorInUse = string.Format("%{0}", i + 1);
                //MessageBox.Show(operatorInUse); // Debug
                if (inputlines.Lines[i] != "\r\n")
                {
                    outputText = outputText.Replace(operatorInUse, inputlines.Lines[i]);
                }
            }
            output.Text = outputText;
            if (saveoutput.Checked)
            {
                if (txtpath.Text == "" || !(Directory.Exists(txtpath.Text)) || txtfilename.Text == "")
                {
                    MessageBox.Show("Path or file name not valid");
                }
                else
                {
                    string[] lines = output.Lines;
                    // WriteAllLines creates a file, writes a collection of strings to the file,
                    // and then closes the file.  You do NOT need to call Flush() or Close().
                    System.IO.File.WriteAllLines(txtpath.Text + "/" + txtfilename.Text, lines);
                }
            }
        }

        private void saveprofile(bool createNew)
        {
            string profileName;
           if (createNew)
            {
                profileName = saveprofileas.Text;
            } else
            {
                profileName = Convert.ToString(profilesel.SelectedItem);
            }
            string linestosave = "";
            foreach (var line in inputlines.Lines)
            {
                if (line != "\r\n")
                {
                    linestosave += string.Format("{0},", line);
                }
            }
            if (!System.IO.File.Exists(XMLDIR + @"\" + profileName + ".xml"))
            {
                XDocument Doc = new XDocument(
                     new XDeclaration("1.0", "utf8", "yes"),
                    new XComment("XML Config auto generated by Text Formatter"),
                    new XComment("Authors: MrFreex"),
                    new XElement(profileName,
                        new XElement("txtDir", txtpath.Text),
                        new XElement("txtName", txtfilename.Text),
                        new XElement("toformat", toformatinput.Text),
                        //new XElement("profiles", "Default"),
                        new XElement("linesInput", linestosave),
                        new XElement("askbeforeclosing", Convert.ToString(askbeforeclosing.Checked)),
                        new XElement("savesettings", Convert.ToString(savethesettings.Checked)),
                        new XElement("saveoutput", Convert.ToString(saveoutput.Checked))
                 )
                 
            );
                Doc.Save(XMLDIR + @"\" + profileName + ".xml");
            } else
            {
                XDocument Doc = XDocument.Load(XMLDIR + @"\" + profileName + ".xml");
                Doc.Root.Element("txtDir").Value = txtpath.Text;
                Doc.Root.Element("txtName").Value = txtfilename.Text;
                Doc.Root.Element("toformat").Value = toformatinput.Text;
                Doc.Root.Element("linesInput").Value = linestosave;
                Doc.Root.Element("askbeforeclosing").Value = Convert.ToString(askbeforeclosing.Checked);
                Doc.Root.Element("savesettings").Value = Convert.ToString(savethesettings.Checked);
                Doc.Root.Element("saveoutput").Value = Convert.ToString(saveoutput.Checked);
                Doc.Save(XMLDIR + @"\" + profileName + ".xml");

            }
            

            
        }

        private void loadProfile(string profileName)
        {
            if (profileName == "Default") {
                loadMLConfig();    
                return;
            }
            if (!System.IO.File.Exists(XMLDIR + @"\" + profileName + ".xml"))
            {
                saveprofile(true);
                return;
            }
            XDocument File = XDocument.Load(XMLDIR + @"\" + profileName + ".xml");
            txtpath.Text = File.Root.Element("txtDir").Value;
            txtfilename.Text = File.Root.Element("txtName").Value;
            toformatinput.Text = File.Root.Element("toformat").Value;
            string[] linestosave = File.Root.Element("linesInput").Value.Split(',');
            inputlines.Lines = linestosave;
            askbeforeclosing.Checked = Convert.ToBoolean(File.Root.Element("askbeforeclosing").Value);
            savethesettings.Checked = Convert.ToBoolean(File.Root.Element("savesettings").Value);
            saveoutput.Checked = Convert.ToBoolean(File.Root.Element("saveoutput").Value);
        }

        private void loadprof_Click(object sender, EventArgs e)
        { 
            loadProfile(Convert.ToString(profilesel.SelectedItem));
        }

        private void browseTxt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtpath.Text = fbd.SelectedPath;
        }

        private void textFormatterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (askbeforeclosing.Checked)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    dynamic close = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo);
                    if (close == DialogResult.Yes)
                    {
                        e.Cancel = false;
                        Application.Exit();
                    }
                    else if (close == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void inputlines_TextChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }
    }
}
