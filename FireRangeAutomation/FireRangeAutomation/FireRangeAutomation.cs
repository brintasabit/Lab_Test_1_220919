using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireRangeAutomation
{
    public partial class FireRangeAutomation : Form
    {
        List<int> soldierNos=new List<int>();
        List<string> soldierNames=new List<string>();
        List<int> targetScores1=new List<int>();
        List<int> targetScores2 = new List<int>();
        List<int> targetScores3 = new List<int>();
        List<int> targetScores4 = new List<int>();
        List<int>total=new List<int>();
        public FireRangeAutomation()
        {
            InitializeComponent();
        }

        private void Save(int sNo)
        {
            soldierNos.Add(sNo);
            soldierNames.Add(soldierNameTextBox.Text);
            targetScores1.Add(Convert.ToInt32(taget1TextBox.Text));
            targetScores2.Add(Convert.ToInt32(taget2TextBox.Text));
            targetScores3.Add(Convert.ToInt32(taget3TextBox.Text));
            targetScores4.Add(Convert.ToInt32(taget4TextBox.Text));
            string see = "";
            for (int i = soldierNos.Count() - 1; i < soldierNos.Count(); i++)
            {

                see += "\nSoldier No. " + soldierNos[i] + "\n";
                see += "Soldier Name: " + soldierNames[i]+"\n";

            }
            

            soldierRichTextBox.Text += (see);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (soldierNos.Contains(Convert.ToInt32(soldierNoTextBox.Text)) == true)
                {
                    MessageBox.Show("Soldier Already Exists");
                }
                else
                {
                    Save(Convert.ToInt32(soldierNoTextBox.Text));
                }
            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message);
                
            }
           
            



        }

        private void FireRangeAutomation_Load(object sender, EventArgs e)
        {

        }

        private void taget2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowInfo()
        {
            string see = "";
            for (int i = soldierNos.Count() - 1; i < soldierNos.Count(); i++)
            {

                see += "\nSoldier No. " + soldierNos[i] + "\n";
                see += "Soldier Name: " + soldierNames[i] + "\n";

            }


            soldierRichTextBox.Text += (see);
        }
        private void showAllButton_Click(object sender, EventArgs e)
        {
           ShowInfo();
        }

        private void SearchInfo()
        {
            if (soldierNoRadioButton.Checked)
            {
                try
                {
                    if(soldierNos.Contains(Convert.ToInt32(searchTextBox.Text)))
                    {
                        int i = soldierNos.IndexOf(Convert.ToInt32(searchTextBox.Text));
                        string see = "";
                        
                            see += soldierNos[i]+"\n";
                            see += soldierNames[i] + "\n";
                        

                        soldierRichTextBox.Text += see;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (soldierNameRadioButton.Checked)
            {
                try
                {
                    if (soldierNames.Contains(searchTextBox.Text))
                    {
                        string see = "";
                        int i = soldierNames.IndexOf(searchTextBox.Text);
                        
                            see += soldierNos[i] + "\n";
                            see += soldierNames[i] + "\n";
                        
                        soldierRichTextBox.Text += see;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }
    }
}
