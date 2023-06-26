
namespace BancaEinstein
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblfrutas = new System.Windows.Forms.Label();
            this.lblsalgados = new System.Windows.Forms.Label();
            this.Lst_Frutas = new System.Windows.Forms.ListBox();
            this.Lst_Salgados = new System.Windows.Forms.ListBox();
            this.txtfruta = new System.Windows.Forms.TextBox();
            this.txtsalgado = new System.Windows.Forms.TextBox();
            this.btnadfruta = new System.Windows.Forms.Button();
            this.btnremfruta = new System.Windows.Forms.Button();
            this.btnadcsalgado = new System.Windows.Forms.Button();
            this.btnremsalgado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Timertitulo = new System.Windows.Forms.Timer(this.components);
            this.Timer_Fruta = new System.Windows.Forms.Timer(this.components);
            this.Timer_Salgado = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.Location = new System.Drawing.Point(212, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(249, 40);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Sacolão Einstein";
            // 
            // lblfrutas
            // 
            this.lblfrutas.AutoSize = true;
            this.lblfrutas.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblfrutas.ForeColor = System.Drawing.Color.Blue;
            this.lblfrutas.Location = new System.Drawing.Point(24, 149);
            this.lblfrutas.Name = "lblfrutas";
            this.lblfrutas.Size = new System.Drawing.Size(188, 32);
            this.lblfrutas.TabIndex = 1;
            this.lblfrutas.Text = "Banca de Frutas";
            // 
            // lblsalgados
            // 
            this.lblsalgados.AutoSize = true;
            this.lblsalgados.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsalgados.ForeColor = System.Drawing.Color.Blue;
            this.lblsalgados.Location = new System.Drawing.Point(421, 61);
            this.lblsalgados.Name = "lblsalgados";
            this.lblsalgados.Size = new System.Drawing.Size(218, 32);
            this.lblsalgados.TabIndex = 2;
            this.lblsalgados.Text = "Banca de Salgados";
            // 
            // Lst_Frutas
            // 
            this.Lst_Frutas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lst_Frutas.ForeColor = System.Drawing.Color.BlueViolet;
            this.Lst_Frutas.FormattingEnabled = true;
            this.Lst_Frutas.ItemHeight = 21;
            this.Lst_Frutas.Location = new System.Drawing.Point(24, 201);
            this.Lst_Frutas.Name = "Lst_Frutas";
            this.Lst_Frutas.Size = new System.Drawing.Size(182, 193);
            this.Lst_Frutas.TabIndex = 3;
            // 
            // Lst_Salgados
            // 
            this.Lst_Salgados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lst_Salgados.ForeColor = System.Drawing.Color.BlueViolet;
            this.Lst_Salgados.FormattingEnabled = true;
            this.Lst_Salgados.ItemHeight = 21;
            this.Lst_Salgados.Location = new System.Drawing.Point(421, 118);
            this.Lst_Salgados.Name = "Lst_Salgados";
            this.Lst_Salgados.Size = new System.Drawing.Size(182, 193);
            this.Lst_Salgados.TabIndex = 4;
            // 
            // txtfruta
            // 
            this.txtfruta.Location = new System.Drawing.Point(212, 158);
            this.txtfruta.Name = "txtfruta";
            this.txtfruta.Size = new System.Drawing.Size(129, 23);
            this.txtfruta.TabIndex = 5;
            // 
            // txtsalgado
            // 
            this.txtsalgado.Location = new System.Drawing.Point(640, 70);
            this.txtsalgado.Name = "txtsalgado";
            this.txtsalgado.Size = new System.Drawing.Size(142, 23);
            this.txtsalgado.TabIndex = 6;
            // 
            // btnadfruta
            // 
            this.btnadfruta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadfruta.Location = new System.Drawing.Point(228, 212);
            this.btnadfruta.Name = "btnadfruta";
            this.btnadfruta.Size = new System.Drawing.Size(103, 41);
            this.btnadfruta.TabIndex = 7;
            this.btnadfruta.Text = "Adicionar";
            this.btnadfruta.UseVisualStyleBackColor = true;
            this.btnadfruta.Click += new System.EventHandler(this.btnadfruta_Click);
            // 
            // btnremfruta
            // 
            this.btnremfruta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnremfruta.Location = new System.Drawing.Point(228, 270);
            this.btnremfruta.Name = "btnremfruta";
            this.btnremfruta.Size = new System.Drawing.Size(103, 41);
            this.btnremfruta.TabIndex = 8;
            this.btnremfruta.Text = "Remover";
            this.btnremfruta.UseVisualStyleBackColor = true;
            this.btnremfruta.Click += new System.EventHandler(this.btnremfruta_Click);
            // 
            // btnadcsalgado
            // 
            this.btnadcsalgado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadcsalgado.Location = new System.Drawing.Point(662, 118);
            this.btnadcsalgado.Name = "btnadcsalgado";
            this.btnadcsalgado.Size = new System.Drawing.Size(103, 41);
            this.btnadcsalgado.TabIndex = 9;
            this.btnadcsalgado.Text = "Adicionar";
            this.btnadcsalgado.UseVisualStyleBackColor = true;
            this.btnadcsalgado.Click += new System.EventHandler(this.btnadcsalgado_Click);
            // 
            // btnremsalgado
            // 
            this.btnremsalgado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnremsalgado.Location = new System.Drawing.Point(662, 190);
            this.btnremsalgado.Name = "btnremsalgado";
            this.btnremsalgado.Size = new System.Drawing.Size(103, 41);
            this.btnremsalgado.TabIndex = 10;
            this.btnremsalgado.Text = "Remover";
            this.btnremsalgado.UseVisualStyleBackColor = true;
            this.btnremsalgado.Click += new System.EventHandler(this.btnremsalgado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancaEinstein.Properties.Resources.Frutas2;
            this.pictureBox1.Location = new System.Drawing.Point(24, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BancaEinstein.Properties.Resources.Salgados;
            this.pictureBox2.Location = new System.Drawing.Point(609, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Timertitulo
            // 
            this.Timertitulo.Interval = 195;
            this.Timertitulo.Tick += new System.EventHandler(this.Timertitulo_Tick);
            // 
            // Timer_Fruta
            // 
            this.Timer_Fruta.Tick += new System.EventHandler(this.timer_Fruta_Tick);
            // 
            // Timer_Salgado
            // 
            this.Timer_Salgado.Tick += new System.EventHandler(this.timer_Salgado_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnremsalgado);
            this.Controls.Add(this.btnadcsalgado);
            this.Controls.Add(this.btnremfruta);
            this.Controls.Add(this.btnadfruta);
            this.Controls.Add(this.txtsalgado);
            this.Controls.Add(this.txtfruta);
            this.Controls.Add(this.Lst_Salgados);
            this.Controls.Add(this.Lst_Frutas);
            this.Controls.Add(this.lblsalgados);
            this.Controls.Add(this.lblfrutas);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblfrutas;
        private System.Windows.Forms.Label lblsalgados;
        private System.Windows.Forms.ListBox Lst_Frutas;
        private System.Windows.Forms.ListBox Lst_Salgados;
        private System.Windows.Forms.TextBox txtfruta;
        private System.Windows.Forms.TextBox txtsalgado;
        private System.Windows.Forms.Button btnadfruta;
        private System.Windows.Forms.Button btnremfruta;
        private System.Windows.Forms.Button btnadcsalgado;
        private System.Windows.Forms.Button btnremsalgado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer Timertitulo;
        private System.Windows.Forms.Timer Timer_Fruta;
        private System.Windows.Forms.Timer Timer_Salgado;
    }
}

