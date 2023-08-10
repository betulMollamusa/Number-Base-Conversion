using System;
using System.Windows.Forms;

namespace tabanDonusumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes(); //ComboBoxları başlat
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void InitializeComboBoxes()
        {
            // ComboBox'lara taban değerleri eklenir
            for (int i = 2; i <= 36; i++)
            {
                inputComboBox.Items.Add(i);
                convertComboBox.Items.Add(i);
            }
            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                Control control = new Control();
                
                ResultLabel.Visible = true; 
                NewNumLabel.Visible = true;
                btnConvert.Visible = false;

                int number = int.Parse(txtDecimal.Text); // Metin kutusundaki ondalık sayıyı al
                string numberBaseX = txtDecimal.Text; // Ondalık sayının metin hali
                int sourceBase = (int)inputComboBox.SelectedItem; // Kaynak taban seçimi
                int targetBase = (int)convertComboBox.SelectedItem; // Hedef taban seçimi

                int convertedFromBase = control.ConvertFromBase(numberBaseX, sourceBase); // Kaynak tabandan ondalık tabana çevirme
                string convertedToBase = control.ConvertToBase(convertedFromBase, targetBase); // Ondalık tabandan hedef tabana çevirme
                ResultLabel.Text = $"{convertedToBase}"; //sonucu göster

            }
            catch (Exception ex)
            {
                lblResultFromBase.Text = "Hata: " + ex.Message;
                
            }
        }

        //farklı hesaplama yapılacaksa eski girilen bilgileri siler
        private void buttonClear_Click(object sender, EventArgs e)
        {
            btnConvert.Visible = true;
            NewNumLabel.Visible = false;
            txtDecimal.Text = "";
            ResultLabel.Text = "";
            lblResultFromBase.Text = "";
            inputComboBox.SelectedItem = null;
            convertComboBox.SelectedItem = null;
        }

    }
}
