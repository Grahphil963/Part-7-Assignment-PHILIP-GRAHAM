using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_7_Assignment_PHILIP_GRAHAM
{
    public partial class UsingLists : Form
    {
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random generator = new Random();
        int removeTotal = 0;
        public UsingLists()

        {
            InitializeComponent();
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            heroes.Remove(txtRemoveHero.Text);
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Hero Removed ";





        }

        private void UsingLists_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;
            heroes.Add("Batman");
            heroes.Add("Superman");
            lstHeroes.DataSource = heroes;


        }

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Numbers Sorted";


        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Heroes Sorted";


        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "New list";


        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "New List of heroes ";


        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {


            numbers.RemoveAt((Int32)lstNumbers.SelectedIndex);
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Number Removed";



        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            heroes.Add(txtAddHero.Text);
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "New hero added";

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            {
                if (lstNumbers.SelectedIndex < 0)
                    lblStatus.Text = "No item selected";
                else
                    while (numbers.Remove((Int32)lstNumbers.SelectedItem))
                    {
                        removeTotal = removeTotal + 1;
                        lblStatus.Text = ($"Removed a total of{removeTotal}");
                    }
                removeTotal = 0;
                lstNumbers.DataSource = null;
                lstNumbers.DataSource = numbers;
                lblStatus.Text = "all removed ";
            }
        }
    }
}
