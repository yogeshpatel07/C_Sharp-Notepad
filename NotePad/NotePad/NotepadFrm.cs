using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class NotepadFrm : Form
    {
        public static string Filename;// = "Unsaved";
        public NotepadFrm()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TxtArea_TextChanged(object sender, EventArgs e)
        {
            SaveStat.Text = "Unsaved";
            UpdateStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtArea.Text = "";
            UpdateStatus();
            Filename = "Unsaved.txt";
            SaveStat.Text = "Saved";
            FlnameSt.Text = "Unsaved.txt";

        }

        private void UpdateStatus()
        {
            string txt = TxtArea.Text;
            string[] sp = txt.Split('\n');
            int ln = sp.Length;
            int clm = sp[ln - 1].Length;
            ClmNo.Text = "Clm : " + clm;
            LnNo.Text = "Ln : " + ln;

            
          
        }

        private void nFileMenu_Click(object sender, EventArgs e)
        {
            if(SaveStat.Text=="Unsaved")
            {
                sFlDial1.Filter= "TXT Files (*.txt *) | *.txt";
                 sFlDial1.DefaultExt = ".txt";
                if(sFlDial1.ShowDialog()== DialogResult.OK)
                {
                    if(SaveFile())
                    {
                        MessageBox.Show("File Saved", "Information", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("File Not Saved", "Information", MessageBoxButtons.OK);
                    }
                }
            }
            

            TxtArea.Text = "";
            SaveStat.Text = "Saved";
            Filename = "Unsaved.txt";
        }

        private bool SaveFile()
        {
            try
            {
                StreamWriter outf = File.CreateText(sFlDial1.FileName);
                string[] sp = TxtArea.Text.Split('\n');
                foreach (string lin in sp)
                {
                    outf.WriteLine(lin);
                }

                if (outf != null)
                    outf.Close();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        private void OpnFile()
        {
            try
            {
                StreamReader outf = File.OpenText(opnFlDial1.FileName);
                string sp = "";
                while(!(outf.EndOfStream))
                {
                     sp = outf.ReadToEnd();
                }

                if (outf != null)
                    outf.Close();

                TxtArea.Text = sp;
                Filename = opnFlDial1.FileName;
                
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error during File open...\n"+e.Message, "Error", MessageBoxButtons.OK);
               
            }
        }
        private void exitMenu_Click(object sender, EventArgs e)
        {
            if (SaveStat.Text == "Unsaved")
            {
                if(FlnameSt.Text=="Unsaved.txt")
                {
                    sFlDial1.DefaultExt = ".txt";
                    if (sFlDial1.ShowDialog() == DialogResult.OK)
                    {
                        if (SaveFile())
                        {
                            MessageBox.Show("File Saved", "Information", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("File Not Saved", "Information", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    try
                    {
                        StreamWriter outf = File.CreateText(FlnameSt.Text);
                        string[] sp = TxtArea.Text.Split('\n');
                        foreach (string lin in sp)
                        {
                            outf.WriteLine(lin);

                        }

                        if (outf != null)
                            outf.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File Not Saved\n" + ex.Message, "Information", MessageBoxButtons.OK);
                    }

                }
                
            }

            this.Close();
        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            if (SaveStat.Text == "Unsaved")
            {
                if ((MessageBox.Show("Do you want to save file?", "Information", MessageBoxButtons.YesNo)==DialogResult.Yes))
                {
                    sFlDial1.DefaultExt = ".txt";
                    if (sFlDial1.ShowDialog() == DialogResult.OK)
                    {
                        if (SaveFile())
                        {
                            MessageBox.Show("File Saved", "Information", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("File Not Saved", "Information", MessageBoxButtons.OK);
                        }
                    }
                }
                TxtArea.Text = "";
                SaveStat.Text = "Saved";
                Filename = "Unsaved.txt";
            }
            if (opnFlDial1.ShowDialog() == DialogResult.OK)
            {
                OpnFile();
                
            }
            FlnameSt.Text = Filename;
            SaveStat.Text = "Saved";

        }

        private void saveFileMenu_Click(object sender, EventArgs e)
        {
            if (FlnameSt.Text == "Unsaved.txt")
            {
                if (SaveStat.Text == "Unsaved")
                {
                    sFlDial1.DefaultExt = ".txt";
                    if (sFlDial1.ShowDialog() == DialogResult.OK)
                    {
                        if (SaveFile())
                        {
                            MessageBox.Show("File Saved", "Information", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("File Not Saved", "Information", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    StreamWriter outf = File.CreateText(FlnameSt.Text);
                    string[] sp = TxtArea.Text.Split('\n');
                    foreach (string lin in sp)
                    {
                        outf.WriteLine(lin);

                    }

                    if (outf != null)
                        outf.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("File Not Saved\n" + ex.Message, "Information", MessageBoxButtons.OK);
                }
            }

            SaveStat.Text = "Saved";
        }

        private void saveAsFileMenu_Click(object sender, EventArgs e)
        {
            if (SaveStat.Text == "Unsaved")
            {
                
                sFlDial1.DefaultExt = ".txt";
                if (sFlDial1.ShowDialog() == DialogResult.OK)
                {
                    if (SaveFile())
                    {
                        MessageBox.Show("File Saved", "Information", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("File Not Saved", "Information", MessageBoxButtons.OK);
                    }
                }
            }

            SaveStat.Text = "Saved";
        }

        private void fontMenu_Click(object sender, EventArgs e)
        {
            if(fntDial1.ShowDialog()==DialogResult.OK)
                TxtArea.Font = fntDial1.Font;
        }

        private void foreColorMenu_Click(object sender, EventArgs e)
        {
            if(ClrDial1.ShowDialog() == DialogResult.OK)
                TxtArea.ForeColor = ClrDial1.Color;

        }

        private void backColorMenu_Click(object sender, EventArgs e)
        {
            if (ClrDial1.ShowDialog() == DialogResult.OK)
                TxtArea.BackColor = ClrDial1.Color;
        }

        private void selectAllMenu_Click(object sender, EventArgs e)
        {
            TxtArea.SelectAll();
        }

        private void cutMenu_Click(object sender, EventArgs e)
        {
            TxtArea.Cut();
        }

        private void copyMenu_Click(object sender, EventArgs e)
        {
            TxtArea.Copy();
        }

        private void pasteManu_Click(object sender, EventArgs e)
        {
            TxtArea.Paste();
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            TxtArea.SelectedText = "";
        }

        private void printFileMenu_Click(object sender, EventArgs e)
        {
            if(prtDial1.ShowDialog()==DialogResult.OK)
            {
                prtDial1.PrintToFile = true;
                sFlDial1.DefaultExt = ".pdf";
                if (sFlDial1.ShowDialog() == DialogResult.OK)
                {
                    if (PrintToFle())
                    {
                        MessageBox.Show("File Saved as PDF", "Information", MessageBoxButtons.OK);
                    }
                    else
                    {
                            MessageBox.Show("File Not Saved", "Information", MessageBoxButtons.OK);
                        
                    }
                }

            }
                
        }

        private bool PrintToFle()
        {
            if(sFlDial1.FileName.EndsWith(".pdf"))
            {
                try
                {
                    StreamWriter outf = File.CreateText(sFlDial1.FileName);
                    string[] sp = TxtArea.Text.Split('\n');
                    foreach (string lin in sp)
                    {
                        outf.WriteLine(lin);
                    }

                    if (outf != null)
                        outf.Close();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Make File Extension .pdf", "Information", MessageBoxButtons.OK);
                return false;

            }
        }

        private void TxtArea_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Tab")
                TxtArea.Paste("    ");
        }

        
    }
}
