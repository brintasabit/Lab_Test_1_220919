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
        List<double> totalScores = new List<double>();
        List<double> averageScores = new List<double>();
        List<double> topAverageScores = new List<double>();
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
            totalScores.Add(Convert.ToInt32(taget1TextBox.Text)+ Convert.ToInt32(taget2TextBox.Text)+ Convert.ToInt32(taget3TextBox.Text)+ Convert.ToInt32(taget4TextBox.Text));
            
            for (int i = soldierNos.Count() - 1; i < soldierNos.Count(); i++)
            {
                double avr = totalScores[i] / 4;
                averageScores.Add(avr);
                soldierListBox.Items.Add("Soldier ID: " + soldierNos[i]);
                soldierListBox.Items.Add("Soldier Name: "+soldierNames[i] + "\n");
                soldierListBox.Items.Add("Target 1 Score: " + targetScores1[i] + "\n");
                soldierListBox.Items.Add("Target 2 Score: " + targetScores2[i] + "\n");
                soldierListBox.Items.Add("Target 3 Score: " + targetScores3[i] + "\n");
                soldierListBox.Items.Add("Target 4 Score: " + targetScores4[i] + "\n");
                soldierListBox.Items.Add("Total Score: " + totalScores[i] + "\n");
                soldierListBox.Items.Add("Average Score: " + averageScores[i] +"\n");
                
            }
            




        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            soldierListBox.Items.Clear();
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

        private void ShowInfo()
        {

            for (int i = 0; i < soldierNos.Count(); i++)
            {
                soldierListBox.Items.Add("Soldier ID: " + soldierNos[i]);
                soldierListBox.Items.Add("Soldier Name: " + soldierNames[i] + "\n");
                soldierListBox.Items.Add("Target 1 Score: " + targetScores1[i] + "\n");
                soldierListBox.Items.Add("Target 2 Score: " + targetScores2[i] + "\n");
                soldierListBox.Items.Add("Target 3 Score: " + targetScores3[i] + "\n");
                soldierListBox.Items.Add("Target 4 Score: " + targetScores4[i] + "\n");
                soldierListBox.Items.Add("Total Score: " + totalScores[i] + "\n");
                soldierListBox.Items.Add("Average Score: " + averageScores[i] + "\n");
            }

        }
        
        private void showAllButton_Click(object sender, EventArgs e)
        {
            soldierListBox.Items.Clear();
            ShowInfo();
            //TopCounter();
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
                        soldierListBox.Items.Add("Soldier ID: " + soldierNos[i]);
                        soldierListBox.Items.Add("Soldier Name: " + soldierNames[i] + "\n");
                        soldierListBox.Items.Add("Target 1 Score: " + targetScores1[i] + "\n");
                        soldierListBox.Items.Add("Target 2 Score: " + targetScores2[i] + "\n");
                        soldierListBox.Items.Add("Target 3 Score: " + targetScores3[i] + "\n");
                        soldierListBox.Items.Add("Target 4 Score: " + targetScores4[i] + "\n");
                        soldierListBox.Items.Add("Total Score: " + totalScores[i] + "\n");
                        soldierListBox.Items.Add("Average Score: " + averageScores[i] + "\n");
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
                        int i = soldierNos.IndexOf(Convert.ToInt32(searchTextBox.Text));
                        soldierListBox.Items.Add("Soldier ID: " + soldierNos[i]);
                        soldierListBox.Items.Add("Soldier Name: " + soldierNames[i] + "\n");
                        soldierListBox.Items.Add("Target 1 Score: " + targetScores1[i] + "\n");
                        soldierListBox.Items.Add("Target 2 Score: " + targetScores2[i] + "\n");
                        soldierListBox.Items.Add("Target 3 Score: " + targetScores3[i] + "\n");
                        soldierListBox.Items.Add("Target 4 Score: " + targetScores4[i] + "\n");
                        soldierListBox.Items.Add("Total Score: " + totalScores[i] + "\n");
                        soldierListBox.Items.Add("Average Score: " + averageScores[i] + "\n");
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
            soldierListBox.Items.Clear();
            SearchInfo();
        }
    }
}
