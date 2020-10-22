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
            Binding nameBinding = new Binding("Text", driver, "Name");
            Binding winsBinding = new Binding("Text", driver, "Wins");

            textBoxName.DataBindings.Add(nameBinding);
            textBoxWins.DataBindings.Add(winsBinding);
        }

        private void ButtonAddWin_Click(object sender, EventArgs e)
        {
            driver.Wins++;
        }
    }
}
