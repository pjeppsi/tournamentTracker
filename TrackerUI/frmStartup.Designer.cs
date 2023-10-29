
namespace TrackerUI
{
    partial class frmStartup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNoviTurnir = new System.Windows.Forms.Button();
            this.btnUcitajPostojeci = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoviTurnir
            // 
            this.btnNoviTurnir.Location = new System.Drawing.Point(69, 219);
            this.btnNoviTurnir.Name = "btnNoviTurnir";
            this.btnNoviTurnir.Size = new System.Drawing.Size(143, 74);
            this.btnNoviTurnir.TabIndex = 0;
            this.btnNoviTurnir.Text = "Novi turnir";
            this.btnNoviTurnir.UseVisualStyleBackColor = true;
            // 
            // btnUcitajPostojeci
            // 
            this.btnUcitajPostojeci.Location = new System.Drawing.Point(339, 219);
            this.btnUcitajPostojeci.Name = "btnUcitajPostojeci";
            this.btnUcitajPostojeci.Size = new System.Drawing.Size(143, 74);
            this.btnUcitajPostojeci.TabIndex = 1;
            this.btnUcitajPostojeci.Text = "Ucitaj postojeci turnir";
            this.btnUcitajPostojeci.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Postojeci turnir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Novi turnir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmStartup
            // 
            this.ClientSize = new System.Drawing.Size(450, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmStartup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoviTurnir;
        private System.Windows.Forms.Button btnUcitajPostojeci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

