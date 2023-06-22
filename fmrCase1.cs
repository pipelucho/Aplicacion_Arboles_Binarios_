using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesBinarios
{
    public partial class fmrCase1 : Form
    {
        public fmrCase1()
        {
            InitializeComponent();
        }

        private void fmrCase1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrCase1_MouseMove(object sender, MouseEventArgs e)
        {
            txtEjeX.Text = e.X.ToString();
            txtEjeY.Text = e.Y.ToString();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Variable local de tipo Graphics
            Graphics nodo;
            //Metodo prediseñado que crea el Graphics para el control
            nodo=CreateGraphics(); //Dibuja el nodo Raiz
            //Dibuja una elipse rellena de color sobre las cordenadas
            nodo. FillEllipse (Brushes. Cyan, 320, 30, 35, 35); 
            //Dibuja la cadena de texto en las coordenadas con los objeos Brushes y font
            nodo.DrawString("13", Font, Brushes.Purple, 330, 40);
            //Define el objeto para dibujar lineas y curvas
            Pen myNodoRaiz = new Pen(Color.Orange, 3);
            //Dibuja la elipse a partir del objeto creado
            nodo.DrawEllipse(myNodoRaiz, 320, 30, 35, 35);

            //Lineas paar conectar los nodos
            Pen myLineal = new Pen(Color.Orange, 2); nodo.DrawLine(myLineal, 215, 100, 320, 55);
            Pen myLinea2 = new Pen(Color.Orange, 2); nodo.DrawLine(myLinea2, 355, 55, 440, 90);
            Pen myLinea3 = new Pen(Color.Orange, 2); nodo.DrawLine(myLinea3, 460, 100, 530, 150);
            Pen myLinea4 = new Pen(Color.Orange, 2); nodo.DrawLine(myLinea4, 220, 110, 280, 130);
            Pen myLinea5 = new Pen(Color.Orange, 2); nodo.DrawLine(myLinea5, 160, 130, 220, 100);
            Pen myLinea6 = new Pen(Color.Orange, 2); nodo.DrawLine(myLinea6, 400, 130, 445, 110);

            Pen myLinea7 = new Pen(Color.Orange, 2); nodo.DrawLine(myLinea7, 270, 155, 238, 191);
            Pen myLinea8 = new Pen(Color.Orange, 2); nodo.DrawLine(myLinea8, 226, 210, 187, 255);
            Pen myLinea9 = new Pen(Color.Orange, 2); nodo.DrawLine(myLinea9, 175, 270, 120, 315);
            Pen myLinea10 = new Pen(Color.Orange, 2); nodo.DrawLine(myLinea10, 195, 277, 220, 317);
            Pen myLinea11= new Pen(Color.Orange, 2); nodo.DrawLine(myLinea11, 528, 155, 580, 195);
            Pen myLinea12= new Pen(Color.Orange, 2); nodo.DrawLine(myLinea12, 508, 156, 477, 190);
            Pen myLinea13= new Pen(Color.Orange, 2); nodo.DrawLine(myLinea13, 480, 210, 530, 260);

            //Nodos del subarbol izquiedo
            nodo.FillEllipse(Brushes.Cyan, 200, 80, 35, 35); 
            nodo.DrawString("4", Font, Brushes.Purple, 210, 90); 
            Pen myNodo1 = new Pen(Color.Orange, 3); 
            nodo.DrawEllipse(myNodo1, 200, 80, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 140, 130, 35, 35); 
            nodo.DrawString("3", Font, Brushes.Purple, 150, 140); 
            Pen myNodo2 = new Pen(Color.Orange, 3);
            nodo.DrawEllipse(myNodo2, 140, 130, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 260, 130, 35, 35);
            nodo.DrawString("11", Font, Brushes.Purple, 270, 140); 
            Pen myNodo3 = new Pen(Color.Orange, 3);
            nodo.DrawEllipse(myNodo3, 260, 130, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 215, 185, 35, 35);
            nodo.DrawString("8", Font, Brushes.Purple, 225, 195);
            Pen myNodo8 = new Pen(Color.Orange, 3);
            nodo.DrawEllipse(myNodo8, 215, 185, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 170, 250, 35, 35);
            nodo.DrawString("6", Font, Brushes.Purple, 180, 260);
            Pen myNodo9 = new Pen(Color.Orange, 3);
            nodo.DrawEllipse(myNodo9, 170, 250, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 100, 310, 35, 35);
            nodo.DrawString("5", Font, Brushes.Purple, 110, 320);
            Pen myNodo10 = new Pen(Color.Orange, 3);
            nodo.DrawEllipse(myNodo10, 100, 310, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 210, 310, 35, 35);
            nodo.DrawString("7", Font, Brushes.Purple, 220, 320);
            Pen myNodo11 = new Pen(Color.Orange, 3);
            nodo.DrawEllipse(myNodo11, 210, 310, 35, 35);

            //Nodos del subarbol derecho
            nodo.FillEllipse (Brushes. Cyan, 440, 80, 35, 35); 
            nodo.DrawString("15", Font, Brushes. Purple, 450, 90); 
            Pen myNodo4= new Pen(Color.Orange, 3); 
            nodo.DrawEllipse (myNodo4, 440, 80, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 500, 130, 35, 35); 
            nodo.DrawString("18", Font, Brushes.Purple, 510, 140); 
            Pen myNodo5 = new Pen(Color.Orange, 3); 
            nodo.DrawEllipse(myNodo5, 500, 130, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 380, 130, 35, 35);
            nodo.DrawString("14", Font, Brushes.Purple, 390, 140);
            Pen myNodo6 = new Pen(Color.Orange, 3); 
            nodo.DrawEllipse(myNodo6, 380, 130, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 455, 185, 35, 35);
            nodo.DrawString("16", Font, Brushes.Purple, 465, 195);
            Pen myNodo12 = new Pen(Color.Orange, 3);
            nodo.DrawEllipse(myNodo12, 455, 185, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 570, 185, 35, 35);
            nodo.DrawString("20", Font, Brushes.Purple, 580, 195);
            Pen myNodo13 = new Pen(Color.Orange, 3);
            nodo.DrawEllipse(myNodo13, 570, 185, 35, 35);

            nodo.FillEllipse(Brushes.Cyan, 520, 250, 35, 35);
            nodo.DrawString("17", Font, Brushes.Purple, 530, 260);
            Pen myNodo14 = new Pen(Color.Orange, 3);
            nodo.DrawEllipse(myNodo14, 520, 250, 35, 35);
        }

        private void preOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics Preorden; 
            Preorden = CreateGraphics();
            Preorden.DrawString("Preorden", Font, Brushes.Red, 30, 400);
            Pen myNodo1 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo1, 90, 390, 35, 35); 
            Preorden.DrawString("13", Font, Brushes.Purple, 100, 400);
            Pen myNodo2 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 130, 390, 35, 35);
            Preorden.DrawString("4", Font, Brushes.Purple, 140, 400);
            Pen myNodo3 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 170, 390, 35, 35);
            Preorden.DrawString("3", Font, Brushes.Purple, 180, 400);
            Pen myNodo4 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 210, 390, 35, 35);
            Preorden.DrawString("11", Font, Brushes.Purple, 220, 400);
            Pen myNodo5 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 250, 390, 35, 35);
            Preorden.DrawString("8", Font, Brushes.Purple, 260, 400);
            Pen myNodo6 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 290, 390, 35, 35);
            Preorden.DrawString("6", Font, Brushes.Purple, 300, 400);
            Pen myNodo7 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 330, 390, 35, 35);
            Preorden.DrawString("5", Font, Brushes.Purple, 340, 400);
            Pen myNodo8 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo1, 370, 390, 35, 35);
            Preorden.DrawString("7", Font, Brushes.Purple, 380, 400);
            Pen myNodo9 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 410, 390, 35, 35);
            Preorden.DrawString("15", Font, Brushes.Purple, 420, 400);
            Pen myNodo10 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 450, 390, 35, 35);
            Preorden.DrawString("14", Font, Brushes.Purple, 460, 400);
            Pen myNodo11 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 490, 390, 35, 35);
            Preorden.DrawString("18", Font, Brushes.Purple, 500, 400);
            Pen myNodo12 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 530, 390, 35, 35);
            Preorden.DrawString("16", Font, Brushes.Purple, 540, 400);
            Pen myNodo13 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 570, 390, 35, 35);
            Preorden.DrawString("17", Font, Brushes.Purple, 580, 400);
            Pen myNodo14 = new Pen(Color.Green, 1);
            Preorden.DrawEllipse(myNodo2, 610, 390, 35, 35);
            Preorden.DrawString("20", Font, Brushes.Purple, 620, 400);
        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics Inorden;
            Inorden = CreateGraphics();
            Inorden.DrawString("Inorden", Font, Brushes.Red, 30, 460);
            Pen myNodo1 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo1, 90, 450, 35, 35);
            Inorden.DrawString("3", Font, Brushes.Purple, 100, 460);
            Pen myNodo2 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 130, 450, 35, 35);
            Inorden.DrawString("4", Font, Brushes.Purple, 140, 460);
            Pen myNodo3 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 170, 450, 35, 35);
            Inorden.DrawString("5", Font, Brushes.Purple, 180, 460);
            Pen myNodo4 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 210, 450, 35, 35);
            Inorden.DrawString("6", Font, Brushes.Purple, 220, 460);
            Pen myNodo5 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 250, 450, 35, 35);
            Inorden.DrawString("7", Font, Brushes.Purple, 260, 460);
            Pen myNodo6 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 290, 450, 35, 35);
            Inorden.DrawString("8", Font, Brushes.Purple, 300, 460);
            Pen myNodo7 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 330, 450, 35, 35);
            Inorden.DrawString("11", Font, Brushes.Purple, 340, 460);
            Pen myNodo8 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo1, 370, 450, 35, 35);
            Inorden.DrawString("13", Font, Brushes.Purple, 380, 460);
            Pen myNodo9 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 410, 450, 35, 35);
            Inorden.DrawString("14", Font, Brushes.Purple, 420, 460);
            Pen myNodo10 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 450, 450, 35, 35);
            Inorden.DrawString("15", Font, Brushes.Purple, 460, 460);
            Pen myNodo11 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 490, 450, 35, 35);
            Inorden.DrawString("16", Font, Brushes.Purple, 500, 460);
            Pen myNodo12 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 530, 450, 35, 35);
            Inorden.DrawString("17", Font, Brushes.Purple, 540, 460);
            Pen myNodo13 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 570, 450, 35, 35);
            Inorden.DrawString("18", Font, Brushes.Purple, 580, 460);
            Pen myNodo14 = new Pen(Color.Green, 1);
            Inorden.DrawEllipse(myNodo2, 610, 450, 35, 35);
            Inorden.DrawString("20", Font, Brushes.Purple, 620, 460);
        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics Postorden;
            Postorden = CreateGraphics();
            Postorden.DrawString("Postorden", Font, Brushes.Red, 30, 520);
            Pen myNodo1 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo1, 90, 510, 35, 35);
            Postorden.DrawString("3", Font, Brushes.Purple, 100, 520);
            Pen myNodo2 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 130, 510, 35, 35);
            Postorden.DrawString("5", Font, Brushes.Purple, 140, 520);
            Pen myNodo3 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 170, 510, 35, 35);
            Postorden.DrawString("7", Font, Brushes.Purple, 180, 520);
            Pen myNodo4 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 210, 510, 35, 35);
            Postorden.DrawString("6", Font, Brushes.Purple, 220, 520);
            Pen myNodo5 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 250, 510, 35, 35);
            Postorden.DrawString("8", Font, Brushes.Purple, 260, 520);
            Pen myNodo6 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 290, 510, 35, 35);
            Postorden.DrawString("11", Font, Brushes.Purple, 300, 520);
            Pen myNodo7 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 330, 510, 35, 35);
            Postorden.DrawString("4", Font, Brushes.Purple, 340, 520);
            Pen myNodo8 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo1, 370, 510, 35, 35);
            Postorden.DrawString("14", Font, Brushes.Purple, 380, 520);
            Pen myNodo9 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 410, 510, 35, 35);
            Postorden.DrawString("17", Font, Brushes.Purple, 420, 520);
            Pen myNodo10 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 450, 510, 35, 35);
            Postorden.DrawString("16", Font, Brushes.Purple, 460, 520);
            Pen myNodo11 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 490, 510, 35, 35);
            Postorden.DrawString("20", Font, Brushes.Purple, 500, 520);
            Pen myNodo12 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 530, 510, 35, 35);
            Postorden.DrawString("18", Font, Brushes.Purple, 540, 520);
            Pen myNodo13 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 570, 510, 35, 35);
            Postorden.DrawString("15", Font, Brushes.Purple, 580, 520);
            Pen myNodo14 = new Pen(Color.Green, 1);
            Postorden.DrawEllipse(myNodo2, 610, 510, 35, 35);
            Postorden.DrawString("13", Font, Brushes.Purple, 620, 520);
        }
    }
}
