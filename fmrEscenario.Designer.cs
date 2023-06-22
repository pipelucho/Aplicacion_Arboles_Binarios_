namespace ArbolesBinarios
{
    partial class fmrEscenario
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
            this.txtWelcome = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnCase1 = new System.Windows.Forms.Button();
            this.btnCase2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWelcome.Location = new System.Drawing.Point(41, 24);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(123, 40);
            this.txtWelcome.TabIndex = 0;
            this.txtWelcome.Text = "label1";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.DarkRed;
            this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnd.Location = new System.Drawing.Point(316, 283);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(166, 43);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Cerrar Sesion";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnCase1
            // 
            this.btnCase1.BackColor = System.Drawing.Color.Lime;
            this.btnCase1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCase1.FlatAppearance.BorderSize = 0;
            this.btnCase1.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCase1.Location = new System.Drawing.Point(104, 167);
            this.btnCase1.Name = "btnCase1";
            this.btnCase1.Size = new System.Drawing.Size(244, 43);
            this.btnCase1.TabIndex = 3;
            this.btnCase1.Text = "Escenario 1";
            this.btnCase1.UseVisualStyleBackColor = false;
            this.btnCase1.Click += new System.EventHandler(this.btnCase1_Click);
            // 
            // btnCase2
            // 
            this.btnCase2.BackColor = System.Drawing.Color.Lime;
            this.btnCase2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCase2.FlatAppearance.BorderSize = 0;
            this.btnCase2.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCase2.Location = new System.Drawing.Point(461, 167);
            this.btnCase2.Name = "btnCase2";
            this.btnCase2.Size = new System.Drawing.Size(260, 43);
            this.btnCase2.TabIndex = 5;
            this.btnCase2.Text = "Escenario 2";
            this.btnCase2.UseVisualStyleBackColor = false;
            this.btnCase2.Click += new System.EventHandler(this.btnCase2_Click);
            // 
            // fmrEscenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(822, 460);
            this.Controls.Add(this.btnCase2);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnCase1);
            this.Controls.Add(this.txtWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrEscenario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir Escenario";
            this.Load += new System.EventHandler(this.fmrEscenario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtWelcome;
        private Button btnEnd;
        private Button btnCase1;
        private Button btnCase2;
    }
}