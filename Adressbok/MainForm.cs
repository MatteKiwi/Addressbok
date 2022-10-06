using Adressbok.Classes;

namespace Adressbok
{
    public partial class MainForm : Form
    {
        List<Person> people = new List<Person> { };
        public MainForm()
        {
            InitializeComponent();
            UpdateGUI();
        }
        //Tömmer "MainForm" och gör den "fin"    
        private void UpdateGUI()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtZipCode.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

            txtSearch.Text = "";
            lstAddressBook.Items.Clear();
        }

        //lägga till den ny skapade "personen" i txt filen
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person(txtFirstName.Text, txtLastName.Text, txtAddress.Text,
                                            txtZipCode.Text, txtCity.Text, txtPhone.Text,
                                                txtEmail.Text);          
            if (CheckValues())
            {
                people.Add(person);
                person.AddPerson(people);
                MessageBox.Show("Kontakt tillagd");
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Fyll i alla fält med information");
            }           
        }

        //söka i txt filen efter "sökvillkoret" 
        //där efter visa resultat i listan under
        private void btnSearch_Click(object sender, EventArgs e)
        {         
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                MessageBox.Show("Fyll i sökord för att kunna göra en sökning");
            }
            else
            {
                FileManager fileManager = new FileManager(@"C:\temp\address.txt");
                fileManager.ReadFile(people, txtSearch.Text, lstAddressBook);
            }           
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = IsListItemSelected();

            if (index > -1)
            {
                string oldInput = lstAddressBook.SelectedItem.ToString();
                string newInput = txtFirstName.Text + ',' + txtLastName.Text + ',' + txtAddress.Text + ',' + txtZipCode.Text + ',' + txtCity.Text + ',' + txtPhone.Text + ',' + txtEmail.Text;
                string data = File.ReadAllText(@"C:\temp\address.txt");
                string value = data.Replace(oldInput, newInput);

                File.WriteAllText(@"C:\temp\address.txt", value);
                MessageBox.Show("Vald kontakt har blivit ändrat");

                UpdateGUI();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = IsListItemSelected();

            if (index > -1)
            {
                DialogResult dialogResult = MessageBox.Show("Bekräfta ifall du vill ta bort vald kontakt", "Ta bort kontakt", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string oldInput = lstAddressBook.SelectedItem.ToString();
                    string newInput = "";
                    string data = File.ReadAllText(@"C:\temp\address.txt");
                    string value = data.Replace(oldInput, newInput);

                    File.WriteAllText(@"C:\temp\address.txt", value);
                    MessageBox.Show("Vald kontakt har blivit raderad");

                    UpdateGUI();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
        private void lstAddressBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = IsListItemSelected();

            if (index > -1)
            {
                int pos = int.Parse(lstAddressBook.SelectedIndex.ToString());
                string text = lstAddressBook.Items[pos].ToString();
                if (text == null || text == "")
                {
                    MessageBox.Show("Välj en kontakt");
                }
                else if (index >= 0)
                {
                    List<string> list = new List<string>(text.Split(','));
                    txtFirstName.Text = list[0];
                    txtLastName.Text = list[1];
                    txtAddress.Text = list[2];
                    txtZipCode.Text = list[3];
                    txtCity.Text = list[4];
                    txtPhone.Text = list[5];
                    txtEmail.Text = list[6];
                }
                else
                {
                    MessageBox.Show("Välj en kontakt");
                }
            }
        }
        //Metod som returnerar en bool, om användaren har fyllt i alla fält blir den true annars false
        private bool CheckValues()
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtZipCode.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                return false;
            }
            return true;
        }
        //Metod som kollar ifall "användaren" har valt en kontakt ifrån listBoxen
        private int IsListItemSelected()
        {
            int index = lstAddressBook.SelectedIndex;

            if (lstAddressBook.SelectedIndex < 0)
            {
                MessageBox.Show("Välj en kontakt från listan");
                return -1;
            }
            return index;
        }
    }
}