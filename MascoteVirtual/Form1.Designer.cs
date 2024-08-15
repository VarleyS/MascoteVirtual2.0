namespace MascoteVirtual
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(761, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "GetPokemon";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.EventHandler);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(87, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "UP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(87, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "DOWN";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(2, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "LEFT";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(181, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "RIGTH";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(273, 476);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 35);
            this.button6.TabIndex = 7;
            this.button6.Text = "SELECT";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.Location = new System.Drawing.Point(457, 476);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 35);
            this.button7.TabIndex = 8;
            this.button7.Text = "START";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.EventHandler);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.Location = new System.Drawing.Point(610, 385);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 35);
            this.button8.TabIndex = 9;
            this.button8.Text = "B";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button9.Location = new System.Drawing.Point(723, 385);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 35);
            this.button9.TabIndex = 10;
            this.button9.Text = "A";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, -25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2800, 2255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(36, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 284);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 575);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

