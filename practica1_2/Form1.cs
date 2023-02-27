using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1_2
{
    
    public partial class Form1 : Form
    {
        string Num;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Num = textBox1.Text.PadLeft(3, '0');
            label1.Text = Num;
            switch (Convert.ToString(Num[0]))
            {
                case "0":
                    A3.BackColor = Color.Red;
                    B3.BackColor = Color.Red;
                    C3.BackColor = Color.Red;
                    D3.BackColor = Color.Red;
                    E3.BackColor = Color.Red;
                    F3.BackColor = Color.Red;
                    G3.BackColor = Color.Gainsboro;
                    break;


                case "1":
                    A3.BackColor = Color.Gainsboro;
                    B3.BackColor = Color.Red;
                    C3.BackColor = Color.Red;
                    D3.BackColor = Color.Gainsboro;
                    E3.BackColor = Color.Gainsboro;
                    F3.BackColor = Color.Gainsboro;
                    G3.BackColor = Color.Gainsboro;
                    break;

                case "2":
                    A3.BackColor = Color.Red;
                    B3.BackColor = Color.Red;
                    C3.BackColor = Color.Gainsboro;
                    D3.BackColor = Color.Red;
                    E3.BackColor = Color.Red;
                    F3.BackColor = Color.Gainsboro;
                    G3.BackColor = Color.Red;
                    break;

                case "3":
                    A3.BackColor = Color.Red;
                    B3.BackColor = Color.Red;
                    C3.BackColor = Color.Red;
                    D3.BackColor = Color.Red;
                    E3.BackColor = Color.Gainsboro;
                    F3.BackColor = Color.Gainsboro;
                    G3.BackColor = Color.Red;
                    break;

                case "4":
                    A3.BackColor = Color.Gainsboro;
                    B3.BackColor = Color.Red;
                    C3.BackColor = Color.Red;
                    D3.BackColor = Color.Gainsboro;
                    E3.BackColor = Color.Gainsboro;
                    F3.BackColor = Color.Red;
                    G3.BackColor = Color.Red;
                    break;

                case "5":
                    A3.BackColor = Color.Red;
                    B3.BackColor = Color.Gainsboro;
                    C3.BackColor = Color.Red;
                    D3.BackColor = Color.Red;
                    E3.BackColor = Color.Gainsboro;
                    F3.BackColor = Color.Red;
                    G3.BackColor = Color.Red;
                    break;

                case "6":
                    A3.BackColor = Color.Red;
                    B3.BackColor = Color.Gainsboro;
                    C3.BackColor = Color.Red;
                    D3.BackColor = Color.Red;
                    E3.BackColor = Color.Red;
                    F3.BackColor = Color.Red;
                    G3.BackColor = Color.Red;
                    break;

                case "7":
                    A3.BackColor = Color.Red;
                    B3.BackColor = Color.Red;
                    C3.BackColor = Color.Red;
                    D3.BackColor = Color.Gainsboro;
                    E3.BackColor = Color.Gainsboro;
                    F3.BackColor = Color.Gainsboro;
                    G3.BackColor = Color.Gainsboro;
                    break;

                case "8":
                    A3.BackColor = Color.Red;
                    B3.BackColor = Color.Red;
                    C3.BackColor = Color.Red;
                    D3.BackColor = Color.Red;
                    E3.BackColor = Color.Red;
                    F3.BackColor = Color.Red;
                    G3.BackColor = Color.Red;
                    break;

                case "9":
                    A3.BackColor = Color.Red;
                    B3.BackColor = Color.Red;
                    C3.BackColor = Color.Red;
                    D3.BackColor = Color.Red;
                    E3.BackColor = Color.Gainsboro;
                    F3.BackColor = Color.Red;
                    G3.BackColor = Color.Red;
                    break;
            }


            switch (Convert.ToString(Num[1]))
            {
                case "0":
                    A2.BackColor = Color.Red;
                    B2.BackColor = Color.Red;
                    C2.BackColor = Color.Red;
                    D2.BackColor = Color.Red;
                    E2.BackColor = Color.Red;
                    F2.BackColor = Color.Red;
                    G2.BackColor = Color.Gainsboro;
                    break;


                case "1":
                    A2.BackColor = Color.Gainsboro;
                    B2.BackColor = Color.Red;
                    C2.BackColor = Color.Red;
                    D2.BackColor = Color.Gainsboro;
                    E2.BackColor = Color.Gainsboro;
                    F2.BackColor = Color.Gainsboro;
                    G2.BackColor = Color.Gainsboro;
                    break;

                case "2":
                    A2.BackColor = Color.Red;
                    B2.BackColor = Color.Red;
                    C2.BackColor = Color.Gainsboro;
                    D2.BackColor = Color.Red;
                    E2.BackColor = Color.Red;
                    F2.BackColor = Color.Gainsboro;
                    G2.BackColor = Color.Red;
                    break;

                case "3":
                    A2.BackColor = Color.Red;
                    B2.BackColor = Color.Red;
                    C2.BackColor = Color.Red;
                    D2.BackColor = Color.Red;
                    E2.BackColor = Color.Gainsboro;
                    F2.BackColor = Color.Gainsboro;
                    G2.BackColor = Color.Red;
                    break;

                case "4":
                    A2.BackColor = Color.Gainsboro;
                    B2.BackColor = Color.Red;
                    C2.BackColor = Color.Red;
                    D2.BackColor = Color.Gainsboro;
                    E2.BackColor = Color.Gainsboro;
                    F2.BackColor = Color.Red;
                    G2.BackColor = Color.Red;
                    break;

                case "5":
                    A2.BackColor = Color.Red;
                    B2.BackColor = Color.Gainsboro;
                    C2.BackColor = Color.Red;
                    D2.BackColor = Color.Red;
                    E2.BackColor = Color.Gainsboro;
                    F2.BackColor = Color.Red;
                    G2.BackColor = Color.Red;
                    break;

                case "6":
                    A2.BackColor = Color.Red;
                    B2.BackColor = Color.Gainsboro;
                    C2.BackColor = Color.Red;
                    D2.BackColor = Color.Red;
                    E2.BackColor = Color.Red;
                    F2.BackColor = Color.Red;
                    G2.BackColor = Color.Red;
                    break;

                case "7":
                    A2.BackColor = Color.Red;
                    B2.BackColor = Color.Red;
                    C2.BackColor = Color.Red;
                    D2.BackColor = Color.Gainsboro;
                    E2.BackColor = Color.Gainsboro;
                    F2.BackColor = Color.Gainsboro;
                    G2.BackColor = Color.Gainsboro;
                    break;

                case "8":
                    A2.BackColor = Color.Red;
                    B2.BackColor = Color.Red;
                    C2.BackColor = Color.Red;
                    D2.BackColor = Color.Red;
                    E2.BackColor = Color.Red;
                    F2.BackColor = Color.Red;
                    G2.BackColor = Color.Red;
                    break;

                case "9":
                    A2.BackColor = Color.Red;
                    B2.BackColor = Color.Red;
                    C2.BackColor = Color.Red;
                    D2.BackColor = Color.Red;
                    E2.BackColor = Color.Gainsboro;
                    F2.BackColor = Color.Red;
                    G2.BackColor = Color.Red;
                    break;
            }

            switch (Convert.ToString(Num[2]))
            {
                case "0":
                    A1.BackColor = Color.Red;
                    B1.BackColor = Color.Red;
                    C1.BackColor = Color.Red;
                    D1.BackColor = Color.Red;
                    E1.BackColor = Color.Red;
                    F1.BackColor = Color.Red;
                    G1.BackColor = Color.Gainsboro;
                    break;


                case "1":
                    A1.BackColor = Color.Gainsboro;
                    B1.BackColor = Color.Red;
                    C1.BackColor = Color.Red;
                    D1.BackColor = Color.Gainsboro;
                    E1.BackColor = Color.Gainsboro;
                    F1.BackColor = Color.Gainsboro;
                    G1.BackColor = Color.Gainsboro;
                    break;

                case "2":
                    A1.BackColor = Color.Red;
                    B1.BackColor = Color.Red;
                    C1.BackColor = Color.Gainsboro;
                    D1.BackColor = Color.Red;
                    E1.BackColor = Color.Red;
                    F1.BackColor = Color.Gainsboro;
                    G1.BackColor = Color.Red;
                    break;

                case "3":
                    A1.BackColor = Color.Red;
                    B1.BackColor = Color.Red;
                    C1.BackColor = Color.Red;
                    D1.BackColor = Color.Red;
                    E1.BackColor = Color.Gainsboro;
                    F1.BackColor = Color.Gainsboro;
                    G1.BackColor = Color.Red;
                    break;

                case "4":
                    A1.BackColor = Color.Gainsboro;
                    B1.BackColor = Color.Red;
                    C1.BackColor = Color.Red;
                    D1.BackColor = Color.Gainsboro;
                    E1.BackColor = Color.Gainsboro;
                    F1.BackColor = Color.Red;
                    G1.BackColor = Color.Red;
                    break;

                case "5":
                    A1.BackColor = Color.Red;
                    B1.BackColor = Color.Gainsboro;
                    C1.BackColor = Color.Red;
                    D1.BackColor = Color.Red;
                    E1.BackColor = Color.Gainsboro;
                    F1.BackColor = Color.Red;
                    G1.BackColor = Color.Red;
                    break;

                case "6":
                    A1.BackColor = Color.Red;
                    B1.BackColor = Color.Gainsboro;
                    C1.BackColor = Color.Red;
                    D1.BackColor = Color.Red;
                    E1.BackColor = Color.Red;
                    F1.BackColor = Color.Red;
                    G1.BackColor = Color.Red;
                    break;

                case "7":
                    A1.BackColor = Color.Red;
                    B1.BackColor = Color.Red;
                    C1.BackColor = Color.Red;
                    D1.BackColor = Color.Gainsboro;
                    E1.BackColor = Color.Gainsboro;
                    F1.BackColor = Color.Gainsboro;
                    G1.BackColor = Color.Gainsboro;
                    break;

                case "8":
                    A1.BackColor = Color.Red;
                    B1.BackColor = Color.Red;
                    C1.BackColor = Color.Red;
                    D1.BackColor = Color.Red;
                    E1.BackColor = Color.Red;
                    F1.BackColor = Color.Red;
                    G1.BackColor = Color.Red;
                    break;

                case "9":
                    A1.BackColor = Color.Red;
                    B1.BackColor = Color.Red;
                    C1.BackColor = Color.Red;
                    D1.BackColor = Color.Red;
                    E1.BackColor = Color.Gainsboro;
                    F1.BackColor = Color.Red;
                    G1.BackColor = Color.Red;
                    break;
            }
        }
    }
}
