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
                if(result == DialogResult.OK)
                {
                    return false;
                }
                return false;
            }

            return true;
        }
        public bool ValidateFormNumber(string iznos)
        {
            //if(iznos != null && iznos > 0)
            //{
            //    return true;
            //}
            //return false;
            return true;
        }
    }
}
