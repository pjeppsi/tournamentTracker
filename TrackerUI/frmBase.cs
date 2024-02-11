using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLib;

namespace TrackerUI
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }
        public bool ValidateFormText(string text)
        {
            if(text == null || text.Length == 0 || text.Length > 20)
            {
                DialogResult result = MessageBox.Show("Provjeri duljinu teksta. Ne smije biti prazna i veca od 20 znakova", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return false;
                }
                return false;
            }

            return true;
        }
        public bool ValidateFormNumber(string iznos)
        {
            if(float.TryParse(iznos, out float iznosTemp))
            {
                if(iznosTemp > 0 && iznosTemp != null)
                {
                    return true;
                }
                DialogResult dialogResult = MessageBox.Show("Broj mora biti veci od 0!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    return false;
                }
            }
            DialogResult result = MessageBox.Show("Upisite ispravnu vrijednost za broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                return false;
            }
            return false;
        }
    }
}
