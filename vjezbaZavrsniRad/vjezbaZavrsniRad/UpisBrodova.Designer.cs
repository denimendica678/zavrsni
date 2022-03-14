
namespace vjezbaZavrsniRad
{
    partial class UpisBrodova
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtUpisaniBrodovi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpisNovogBrodaDrugaForma = new System.Windows.Forms.Button();
            this.btnNatragUBP = new System.Windows.Forms.Button();
            this.richTextBoxNaslov = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUpisaniBrodovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtUpisaniBrodovi);
            this.groupBox2.Controls.Add(this.btnUpisNovogBrodaDrugaForma);
            this.groupBox2.Controls.Add(this.btnNatragUBP);
            this.groupBox2.Controls.Add(this.richTextBoxNaslov);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(452, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1107, 779);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // dtUpisaniBrodovi
            // 
            this.dtUpisaniBrodovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUpisaniBrodovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtUpisaniBrodovi.Location = new System.Drawing.Point(50, 333);
            this.dtUpisaniBrodovi.Name = "dtUpisaniBrodovi";
            this.dtUpisaniBrodovi.RowHeadersVisible = false;
            this.dtUpisaniBrodovi.RowHeadersWidth = 51;
            this.dtUpisaniBrodovi.RowTemplate.Height = 24;
            this.dtUpisaniBrodovi.Size = new System.Drawing.Size(1004, 329);
            this.dtUpisaniBrodovi.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BROD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DUŽINA";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ŠIRINA";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GAZ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "VRSTA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ZASTAVA";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // btnUpisNovogBrodaDrugaForma
            // 
            this.btnUpisNovogBrodaDrugaForma.BackColor = System.Drawing.Color.Silver;
            this.btnUpisNovogBrodaDrugaForma.Location = new System.Drawing.Point(406, 681);
            this.btnUpisNovogBrodaDrugaForma.Name = "btnUpisNovogBrodaDrugaForma";
            this.btnUpisNovogBrodaDrugaForma.Size = new System.Drawing.Size(312, 79);
            this.btnUpisNovogBrodaDrugaForma.TabIndex = 15;
            this.btnUpisNovogBrodaDrugaForma.Text = "UPIS BRODA";
            this.btnUpisNovogBrodaDrugaForma.UseVisualStyleBackColor = false;
            this.btnUpisNovogBrodaDrugaForma.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNatragUBP
            // 
            this.btnNatragUBP.BackColor = System.Drawing.Color.Silver;
            this.btnNatragUBP.Location = new System.Drawing.Point(50, 42);
            this.btnNatragUBP.Name = "btnNatragUBP";
            this.btnNatragUBP.Size = new System.Drawing.Size(187, 89);
            this.btnNatragUBP.TabIndex = 0;
            this.btnNatragUBP.Text = "NATRAG";
            this.btnNatragUBP.UseVisualStyleBackColor = false;
            this.btnNatragUBP.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxNaslov
            // 
            this.richTextBoxNaslov.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxNaslov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxNaslov.ForeColor = System.Drawing.Color.Navy;
            this.richTextBoxNaslov.Location = new System.Drawing.Point(328, 32);
            this.richTextBoxNaslov.Name = "richTextBoxNaslov";
            this.richTextBoxNaslov.Size = new System.Drawing.Size(643, 77);
            this.richTextBoxNaslov.TabIndex = 7;
            this.richTextBoxNaslov.Text = "UPISANI BRODOVI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::vjezbaZavrsniRad.Properties.Resources.naslovna_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(328, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 246);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UpisBrodova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox2);
            this.Name = "UpisBrodova";
            this.Text = "Upis i pregled brodova";
            this.Load += new System.EventHandler(this.UpisBrodova_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtUpisaniBrodovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpisNovogBrodaDrugaForma;
        private System.Windows.Forms.Button btnNatragUBP;
        private System.Windows.Forms.RichTextBox richTextBoxNaslov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtUpisaniBrodovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}