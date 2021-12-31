
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNajave = new System.Windows.Forms.Button();
            this.btnUpis = new System.Windows.Forms.Button();
            this.btnKalendar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxNaslov = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNajave);
            this.flowLayoutPanel1.Controls.Add(this.btnUpis);
            this.flowLayoutPanel1.Controls.Add(this.btnKalendar);
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
            // btnUpis
            // 
            this.btnUpis.BackColor = System.Drawing.Color.Silver;
            this.btnUpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpis.Location = new System.Drawing.Point(3, 147);
            this.btnUpis.Name = "btnUpis";
            this.btnUpis.Size = new System.Drawing.Size(1094, 141);
            this.btnUpis.TabIndex = 4;
            this.btnUpis.Text = "KALENDAR BRODOVA";
            this.btnUpis.UseVisualStyleBackColor = false;
            this.btnUpis.Click += new System.EventHandler(this.btnUpis_Click);
            // 
            // btnKalendar
            // 
            this.btnKalendar.BackColor = System.Drawing.Color.Silver;
            this.btnKalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKalendar.Location = new System.Drawing.Point(3, 294);
            this.btnKalendar.Name = "btnKalendar";
            this.btnKalendar.Size = new System.Drawing.Size(1094, 134);
            this.btnKalendar.TabIndex = 3;
            this.btnKalendar.Text = "UPIS BRODOVA";
            this.btnKalendar.UseVisualStyleBackColor = false;
            this.btnKalendar.Click += new System.EventHandler(this.btnKalendar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.richTextBoxNaslov);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(445, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 779);
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
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Button btnKalendar;
        private System.Windows.Forms.Button btnUpis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxNaslov;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

