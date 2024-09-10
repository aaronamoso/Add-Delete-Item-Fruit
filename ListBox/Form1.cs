using System.Diagnostics.Eventing.Reader;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get list, append "abc" to the list item
            // lstFruit.Items.Add("abc");

            //array
            // string[] FruitItems = ["pear", "peach"];
            // lstFruit.Items.AddRange(FruitItems);

            //txtNewFruit.Text

            if (txtNewFruit.Text != "")
            {
                lstFruit.Items.Add(txtNewFruit.Text);
                txtNewFruit.Text = "";
            }
            else
            {
                MessageBox.Show("Please inpute a new fruit");
            }
        }

        private void txtNewFruit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstFruit.SelectedItem != null)
            {
                lstFruit.Items.Remove(lstFruit.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item!");
            }

        }

        private void txtNewFruit_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                lstFruit.Items.Add(txtNewFruit.Text);
                txtNewFruit.Text = "";
            }
        }
    }
}
