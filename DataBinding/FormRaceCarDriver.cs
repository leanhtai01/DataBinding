using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class FormRaceCarDriver : Form
    {
        RaceCarDriver driver = new RaceCarDriver
        {
            Name = "M. Schumacher",
            Wins = 500
        };

        public FormRaceCarDriver()
        {
            InitializeComponent();
        }

        private void FormRaceCarDriver_Load(object sender, EventArgs e)
        {
            LoadDriver();
        }

        private void LoadDriver()
        {
            textBoxName.Text = driver.Name;
            textBoxWins.Text = driver.Wins.ToString();
        }

        private void ButtonAddWin_Click(object sender, EventArgs e)
        {
            driver.Wins++;
            textBoxWins.Text = driver.Wins.ToString();
        }
    }
}
