/*
 * MainForm.cs
 * QGame main form
 * Revision History
 * Chan Shong, Ridoy Mubarak Hussain, 2024.10.23: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_Chan_Ridoy_QGame
{
    public partial class Group1_Chan_Ridoy_QGame : Form
    {
        public Group1_Chan_Ridoy_QGame()
        {
            InitializeComponent();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            QGameDesignForm qGameDesignForm = new QGameDesignForm();
            qGameDesignForm.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            QGamePlayForm qGamePlayForm = new QGamePlayForm();
            qGamePlayForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
