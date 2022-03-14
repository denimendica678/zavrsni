
namespace vjezbaZavrsniRad
{
    partial class Pocetna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNajave = new System.Windows.Forms.Button();
            this.btnKalendar = new System.Windows.Forms.Button();
            this.btnUpisBroda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxNaslov = new System.Windows.Forms.RichTextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpisAgencije = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNajave);
            this.flowLayoutPanel1.Controls.Add(this.btnKalendar);
            this.flowLayoutPanel1.Controls.Add(this.btnUpisBroda);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 332);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1097, 431);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNajave
            // 
            this.btnNajave.BackColor = System.Drawing.Color.Silver;
            this.btnNajave.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNajave.Location = new System.Drawing.Point(3, 3);
            this.btnNajave.Name = "btnNajave";
            this.btnNajave.Size = new System.Drawing.Size(1094, 138);
            this.btnNajave.TabIndex = 0;
            this.btnNajave.Text = "TRENUTNE NAJAVE";
            this.btnNajave.UseVisualStyleBackColor = false;
            this.btnNajave.Click += new System.EventHandler(this.btnNajave_Click);
            // 
            // btnKalendar
            // 
            this.btnKalendar.BackColor = System.Drawing.Color.Silver;
            this.btnKalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKalendar.Location = new System.Drawing.Point(3, 147);
            this.btnKalendar.Name = "btnKalendar";
            this.btnKalendar.Size = new System.Drawing.Size(1094, 141);
            this.btnKalendar.TabIndex = 4;
            this.btnKalendar.Text = "KALENDAR BRODOVA";
            this.btnKalendar.UseVisualStyleBackColor = false;
            this.btnKalendar.Click += new System.EventHandler(this.btnUpis_Click);
            // 
            // btnUpisBroda
            // 
            this.btnUpisBroda.BackColor = System.Drawing.Color.Silver;
            this.btnUpisBroda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpisBroda.Location = new System.Drawing.Point(3, 294);
            this.btnUpisBroda.Name = "btnUpisBroda";
            this.btnUpisBroda.Size = new System.Drawing.Size(1094, 134);
            this.btnUpisBroda.TabIndex = 3;
            this.btnUpisBroda.Text = "UPIS BRODOVA";
            this.btnUpisBroda.UseVisualStyleBackColor = false;
            this.btnUpisBroda.Click += new System.EventHandler(this.btnKalendar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.btnUpisAgencije);
            this.groupBox1.Controls.Add(this.richTextBoxNaslov);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(445, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 924);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // richTextBoxNaslov
            // 
            this.richTextBoxNaslov.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxNaslov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxNaslov.ForeColor = System.Drawing.Color.Navy;
            this.richTextBoxNaslov.Location = new System.Drawing.Point(212, 64);
            this.richTextBoxNaslov.Name = "richTextBoxNaslov";
            this.richTextBoxNaslov.Size = new System.Drawing.Size(746, 77);
            this.richTextBoxNaslov.TabIndex = 2;
            this.richTextBoxNaslov.Text = "EVIDENCIJA BRODOVA";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Red;
            this.btnIzlaz.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.ForeColor = System.Drawing.Color.White;
            this.btnIzlaz.Location = new System.Drawing.Point(953, 12);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(119, 56);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.Text = "X";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::vjezbaZavrsniRad.Properties.Resources.naslovna_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(259, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 246);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpisAgencije
            // 
            this.btnUpisAgencije.BackColor = System.Drawing.Color.Silver;
            this.btnUpisAgencije.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpisAgencije.Location = new System.Drawing.Point(21, 766);
            this.btnUpisAgencije.Name = "btnUpisAgencije";
            this.btnUpisAgencije.Size = new System.Drawing.Size(1094, 134);
            this.btnUpisAgencije.TabIndex = 4;
            this.btnUpisAgencije.Text = "UPIS AGENCIJE";
            this.btnUpisAgencije.UseVisualStyleBackColor = false;
            this.btnUpisAgencije.Click += new System.EventHandler(this.btnUpisAgencije_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pocetna";
            this.Text = "Evidencija brodova";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNajave;
        private System.Windows.Forms.Button btnUpisBroda;
        private System.Windows.Forms.Button btnKalendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxNaslov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnUpisAgencije;
    }
}

