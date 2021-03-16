using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerketteteListe1
{
    public partial class Form1 : Form
    {
        VerketteteListe<string> list = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    /*
        private void btnShowList_Click(object sender, EventArgs e)
        {
            try
            {
                string[] visualizer = { "", "|" };

                for (int i = 0; i < list.AnzElemente; i++)
                {
                    if (0 != i)
                    {
                        visualizer[1] += "-->|";
                        visualizer[0] = visualizer[0].PadRight(visualizer[1].Length - 1);
                    }
                    visualizer[0] += ("[" + i.ToString() + "]");
                    string content = list.GetElementData(i).ToString();
                    visualizer[1] += (content + "|");
                }
                tbxCompleteList.Lines = visualizer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    */
 
        private void UpdateListInfo()
        {
            tbxAnzElemente.Text = "n/a";
            tbxFirstElem.Text = "n/a";
            tbxLastElem.Text = "n/a";

        }

        private void btnNeueListe_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxNewContent.Text))
            {
                list = new VerketteteListe<string>(tbxNewContent.Text);
            }
            else
            {
                list = new VerketteteListe<string>();
            }
        }
    }
}
