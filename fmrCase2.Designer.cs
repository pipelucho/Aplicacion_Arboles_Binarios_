namespace ArbolesBinarios
{
    partial class fmrCase2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEjeY = new System.Windows.Forms.TextBox();
            this.txtEjeX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficaToolStripMenuItem,
            this.recorridosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graficaToolStripMenuItem
            // 
            this.graficaToolStripMenuItem.Name = "graficaToolStripMenuItem";
            this.graficaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.graficaToolStripMenuItem.Text = "Grafica";
            this.graficaToolStripMenuItem.Click += new System.EventHandler(this.graficaToolStripMenuItem_Click);
            // 
            // recorridosToolStripMenuItem
            // 
            this.recorridosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preOrdenToolStripMenuItem,
            this.inOrdenToolStripMenuItem,
            this.postOrdenToolStripMenuItem});
            this.recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            this.recorridosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // preOrdenToolStripMenuItem
            // 
            this.preOrdenToolStripMenuItem.Name = "preOrdenToolStripMenuItem";
            this.preOrdenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preOrdenToolStripMenuItem.Text = "PreOrden";
            this.preOrdenToolStripMenuItem.Click += new System.EventHandler(this.preOrdenToolStripMenuItem_Click);
            // 
            // inOrdenToolStripMenuItem
            // 
            this.inOrdenToolStripMenuItem.Name = "inOrdenToolStripMenuItem";
            this.inOrdenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inOrdenToolStripMenuItem.Text = "InOrden";
            this.inOrdenToolStripMenuItem.Click += new System.EventHandler(this.inOrdenToolStripMenuItem_Click);
            // 
            // postOrdenToolStripMenuItem
            // 
            this.postOrdenToolStripMenuItem.Name = "postOrdenToolStripMenuItem";
            this.postOrdenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.postOrdenToolStripMenuItem.Text = "PostOrden";
            this.postOrdenToolStripMenuItem.Click += new System.EventHandler(this.postOrdenToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // txtEjeY
            // 
            this.txtEjeY.Location = new System.Drawing.Point(943, 76);
            this.txtEjeY.Name = "txtEjeY";
            this.txtEjeY.Size = new System.Drawing.Size(67, 23);
            this.txtEjeY.TabIndex = 8;
            // 
            // txtEjeX
            // 
            this.txtEjeX.Location = new System.Drawing.Point(943, 38);
            this.txtEjeX.Name = "txtEjeX";
            this.txtEjeX.Size = new System.Drawing.Size(67, 23);
            this.txtEjeX.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eje Y : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(890, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eje X : ";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.DarkRed;
            this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnd.Location = new System.Drawing.Point(854, 559);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(166, 43);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "Cerrar Sesion";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // fmrCase2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1032, 614);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtEjeY);
            this.Controls.Add(this.txtEjeX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrCase2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrCase2";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fmrCase2_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem graficaToolStripMenuItem;
        private ToolStripMenuItem recorridosToolStripMenuItem;
        private ToolStripMenuItem preOrdenToolStripMenuItem;
        private ToolStripMenuItem inOrdenToolStripMenuItem;
        private ToolStripMenuItem postOrdenToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private TextBox txtEjeY;
        private TextBox txtEjeX;
        private Label label2;
        private Label label1;
        private Button btnEnd;
    }
}