using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class frmCreateTournament : frmBase
    {
        public frmCreateTournament()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ako se vratite promjene se odbacuju", "Upozorenje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                frmStartup f = new frmStartup();
                f.Show();
                this.Hide();
            }
            if(dialogResult== DialogResult.Cancel)
            {
                this.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateFormText(textBox1.Text))
            {
                if (ValidateFormNumber(textBox2.Text))
                {
                    frmStartup f = new frmStartup();//neka vodi na iducu formu, ovo za pocetnu je samo test
                    f.Show();
                    this.Hide();
                }
            }
        }
    }
}
