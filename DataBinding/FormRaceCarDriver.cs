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

        BindingList<RaceCarDriver> drivers = new BindingList<RaceCarDriver>
        {
            new RaceCarDriver
            {
                Name = "Le Anh Tai",
                Wins = 1000
            },

            new RaceCarDriver
            {
                Name = "ABC",
                Wins = 200
            },

            new RaceCarDriver
            {
                Name = "M. Schumacher",
                Wins = 500
            }
        };

        public FormRaceCarDriver()
        {
            InitializeComponent();
        }

        private void FormRaceCarDriver_Load(object sender, EventArgs e)
        {
            Binding nameBinding = new Binding("Text", drivers, "Name");
            Binding winsBinding = new Binding("Text", drivers, "Wins");

            dataGridViewDrivers.DataSource = drivers;
            textBoxName.DataBindings.Add(nameBinding);
            textBoxWins.DataBindings.Add(winsBinding);
            labelCount.Text = $"{BindingContext[drivers].Position + 1}/{BindingContext[drivers].Count}";
        }

        private void ButtonAddWin_Click(object sender, EventArgs e)
        {
            if (drivers.Count != 0)
            {
                (BindingContext[drivers].Current as RaceCarDriver).Wins++;
            }
        }

        private void buttonMovePrev_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[drivers];

            if (bindingManager.Position > 0)
            {
                bindingManager.Position--;
                labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
            }
        }

        private void buttonMoveNext_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[drivers];

            if (bindingManager.Position < bindingManager.Count - 1)
            {
                bindingManager.Position++;
                labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
            }
        }

        private void buttonMoveFirst_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[drivers];

            bindingManager.Position = 0;
            labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
        }

        private void buttonMoveLast_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[drivers];

            bindingManager.Position = bindingManager.Count - 1;
            labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[drivers];

            drivers.Add(new RaceCarDriver { Name = "new name", Wins = 100 } );
            labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
        }

        private void buttonDeleteDriver_Click(object sender, EventArgs e)
        {
            if (drivers.Count != 0)
            {
                BindingManagerBase bindingManager = BindingContext[drivers];

                drivers.RemoveAt(BindingContext[drivers].Position);
                labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
            }
        }
    }
}
