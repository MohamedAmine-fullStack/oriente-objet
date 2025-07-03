using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculAndChange
{
    public partial class Standard : Form
    {
        private double memory = 0; // Mémoire pour MC, MR, M+, M-, MS
        private bool isFirstInput = true; // Pour savoir si c'est le premier clic
        public Standard()
        {
            InitializeComponent();
        }
        // Fonction pour les boutons numériques (0 à 9)
        // Fonction pour les boutons numériques (0 à 9)
        private void zero_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "0"; // Réinitialiser à zéro
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "0"; // Ajouter 0
            }
        }

        private void one_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "1";
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void two_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "2";
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void three_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "3";
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void four_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "4";
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void five_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "5";
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void six_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "6";
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void seven_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "7";
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void eight_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "8";
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void nine_Button_Click(object sender, EventArgs e)
        {
            if (isFirstInput)
            {
                textBox.Text = "9";
                isFirstInput = false;
            }
            else
            {
                textBox.Text += "9";
            }
        }

        // Fonction pour les opérations (+, -, *, /)
        private void plus_Button_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
            isFirstInput = false; // Pour indiquer qu'une opération a été ajoutée
        }

        private void minus_Button_Click(object sender, EventArgs e)
        {
            // Si c'est le premier clic, on réinitialise la valeur du TextBox
            if (isFirstInput)
            {
                textBox.Text = "-";
                isFirstInput = false; // Après avoir ajouté l'opérateur, on permet d'entrer un nombre
            }
            else
            {
                textBox.Text += "-"; // Sinon, on ajoute le signe moins à l'expression
            }
        }


        private void mult_Button_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
            isFirstInput = false;
        }

        private void div_Button_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
            isFirstInput = false;
        }

        // Fonction pour le bouton "point" (.)
        private void dot_Button_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
            isFirstInput = false; // Le premier clic après un point est une valeur valide
        }

        // Fonction pour l'égal
        private void equal_Button_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = new DataTable().Compute(textBox.Text, null).ToString();
                isFirstInput = true; // Reset après un calcul
            }
            catch
            {
                textBox.Text = "Erreur";
                isFirstInput = true; // Reset après une erreur
            }
        }

        // Fonction pour le bouton "CE" (Clear Entry)
        private void Ce_Button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
        }

        // Fonction pour le bouton "C" (Clear)
        private void clear_Button_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            isFirstInput = true; // Reset pour un nouveau calcul
        }

        // Fonction pour le bouton "Delete" (supprimer le dernier caractère)
        private void delete_Button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
            isFirstInput = false; // Après une suppression, on peut ajouter des chiffres
        }

        // Fonction pour le bouton "1/x" (inverse)
        private void oneX_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(textBox.Text);
                if (value != 0)
                {
                    textBox.Text = (1 / value).ToString();
                }
                else
                {
                    textBox.Text = "Erreur";
                }
                isFirstInput = true;
            }
            catch
            {
                textBox.Text = "Erreur";
            }
        }

        // Fonction pour le bouton "Square" (Carré)
        private void square_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(textBox.Text);
                textBox.Text = (value * value).ToString();
                isFirstInput = true;
            }
            catch
            {
                textBox.Text = "Erreur";
            }
        }

        // Fonction pour la racine carrée
        private void racine_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(textBox.Text);
                if (value >= 0)
                {
                    textBox.Text = Math.Sqrt(value).ToString();
                    isFirstInput = true;
                }
                else
                {
                    textBox.Text = "Erreur";
                }
            }
            catch
            {
                textBox.Text = "Erreur";
            }
        }

        // Fonction pour le pourcentage
        private void modulo_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(textBox.Text);
                textBox.Text = (value / 100).ToString();
                isFirstInput = true;
            }
            catch
            {
                textBox.Text = "Erreur";
            }
        }

        // Fonction pour le bouton "+" et "-"
        private void plusMinus_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(textBox.Text);
                value = value * (-1); // Inverser le signe
                textBox.Text = value.ToString();
                isFirstInput = false;
            }
            catch
            {
                textBox.Text = "Erreur";
            }
        }

        // Fonction pour les boutons mémoire (MC, MR, M+, M-, MS)
        private void Mr_Button_Click(object sender, EventArgs e)
        {
            textBox.Text = memory.ToString();
        }

        private void Mc_Button_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void Mplus_Button_Click(object sender, EventArgs e)
        {
            try
            {
                memory += double.Parse(textBox.Text);
            }
            catch
            {
                textBox.Text = "Erreur";
            }
        }

        private void Mmoins_Button_Click(object sender, EventArgs e)
        {
            try
            {
                memory -= double.Parse(textBox.Text);
            }
            catch
            {
                textBox.Text = "Erreur";
            }
        }

        private void Ms_Button_Click(object sender, EventArgs e)
        {
            try
            {
                memory = double.Parse(textBox.Text);
            }
            catch
            {
                textBox.Text = "Erreur";
            }
        }

    }
}
