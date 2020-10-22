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

        BindingSource bindingSourceDrivers = new BindingSource();

        public FormRaceCarDriver()
        {
            InitializeComponent();
        }

        private void FormRaceCarDriver_Load(object sender, EventArgs e)
        {
            Binding nameBinding = new Binding("Text", bindingSourceDrivers, "Name");
            Binding winsBinding = new Binding("Text", bindingSourceDrivers, "Wins");

            bindingSourceDrivers.DataSource = drivers;
            dataGridViewDrivers.DataSource = bindingSourceDrivers;
            textBoxName.DataBindings.Add(nameBinding);
            textBoxWins.DataBindings.Add(winsBinding);
            labelCount.Text = $"{BindingContext[bindingSourceDrivers].Position + 1}/{BindingContext[bindingSourceDrivers].Count}";
        }

        private void ButtonAddWin_Click(object sender, EventArgs e)
        {
            if (bindingSourceDrivers.Count != 0)
            {
                (BindingContext[bindingSourceDrivers].Current as RaceCarDriver).Wins++;
            }
        }

        private void buttonMovePrev_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[bindingSourceDrivers];

            if (bindingManager.Position > 0)
            {
                bindingManager.Position--;
                labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
            }
        }

        private void buttonMoveNext_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[bindingSourceDrivers];

            if (bindingManager.Position < bindingManager.Count - 1)
            {
                bindingManager.Position++;
                labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
            }
        }

        private void buttonMoveFirst_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[bindingSourceDrivers];

            bindingManager.Position = 0;
            labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
        }

        private void buttonMoveLast_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[bindingSourceDrivers];

            bindingManager.Position = bindingManager.Count - 1;
            labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            BindingManagerBase bindingManager = BindingContext[bindingSourceDrivers];

            bindingSourceDrivers.Add(new RaceCarDriver { Name = "new name", Wins = 100 } );
            labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
        }

        private void buttonDeleteDriver_Click(object sender, EventArgs e)
        {
            if (bindingSourceDrivers.Count != 0)
            {
                BindingManagerBase bindingManager = BindingContext[bindingSourceDrivers];

                bindingSourceDrivers.RemoveAt(BindingContext[bindingSourceDrivers].Position);
                labelCount.Text = $"{bindingManager.Position + 1}/{bindingManager.Count}";
            }
        }

        private void TextBoxWins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
