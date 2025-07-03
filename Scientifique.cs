using System;
using System.Windows.Forms;

namespace calculAndChange
{
    public partial class Scientifique : Form
    {

        public Scientifique()
        {
            InitializeComponent();
        }
        // Variables globales pour gérer les calculs
        private double currentValue = 0;
        private double memoryValue = 0;
        private string currentOperator = "";
        private bool isOperatorClicked = false;
        private bool isResultDisplayed = false;

        // Fonction pour les chiffres
        private void zero_Button_Click(object sender, EventArgs e) { AppendToTextBox("0"); }
        private void one_Button_Click(object sender, EventArgs e) { AppendToTextBox("1"); }
        private void two_Button_Click(object sender, EventArgs e) { AppendToTextBox("2"); }
        private void three_Button_Click(object sender, EventArgs e) { AppendToTextBox("3"); }
        private void four_Button_Click(object sender, EventArgs e) { AppendToTextBox("4"); }
        private void five_Button_Click(object sender, EventArgs e) { AppendToTextBox("5"); }
        private void six_Button_Click(object sender, EventArgs e) { AppendToTextBox("6"); }
        private void seven_Button_Click(object sender, EventArgs e) { AppendToTextBox("7"); }
        private void eight_Button_Click(object sender, EventArgs e) { AppendToTextBox("8"); }
        private void nine_Button_Click(object sender, EventArgs e) { AppendToTextBox("9"); }

        // Fonction pour afficher les chiffres
        private void AppendToTextBox(string number)
        {
            if (isResultDisplayed)
            {
                textBox.Clear();
                isResultDisplayed = false;
            }

            textBox.Text += number;
        }

        // Fonction pour calculer le résultat
        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (currentOperator != "" && !isOperatorClicked)
            {
                double secondValue = double.Parse(textBox.Text);
                switch (currentOperator)
                {
                    case "+":
                        currentValue += secondValue;
                        break;
                    case "-":
                        currentValue -= secondValue;
                        break;
                    case "x":
                        currentValue *= secondValue;
                        break;
                    case "÷":
                        if (secondValue != 0)
                            currentValue /= secondValue;
                        else
                            textBox.Text = "Error"; // Division par zéro
                        break;
                }
                textBox.Text = currentValue.ToString();
                isResultDisplayed = true;
                currentOperator = "";
            }
        }

        // Fonction pour l'opération plus (+)
        private void PlusButton_Click(object sender, EventArgs e)
        {
            SetOperator("+");
        }

        // Fonction pour l'opération moins (-)
        private void MineButton_Click(object sender, EventArgs e)
        {
            SetOperator("-");
        }

        // Fonction pour l'opération multiplication (x)
        private void MultButton_Click(object sender, EventArgs e)
        {
            SetOperator("x");
        }

        // Fonction pour l'opération division (÷)
        private void DivButton_Click(object sender, EventArgs e)
        {
            SetOperator("÷");
        }

        // Fonction pour supprimer un caractère
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }

        // Fonction pour ajouter un point (.)
        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
        }

        // Fonction pour la racine carrée (√)
        private void RacineButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            textBox.Text = Math.Sqrt(value).ToString();
        }

        // Fonction pour réinitialiser la calculatrice
        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            currentValue = 0;
            currentOperator = "";
        }

        // Fonction pour calculer le carré (x^2)
        private void SquareButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            textBox.Text = (value * value).ToString();
        }

        // Fonction pour l'exponentiation (x^y)
        private void ExpoButton_Click(object sender, EventArgs e)
        {
            SetOperator("^");
        }

        // Fonction pour plus ou moins (+/-)
        private void PlusOmoinButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            textBox.Text = (-value).ToString();
        }

        // Fonction pour l'inverse (1/x)
        private void OneXButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            if (value != 0)
                textBox.Text = (1 / value).ToString();
            else
                textBox.Text = "Error"; // Division par zéro
        }

        // Fonction pour le Pi (π)
        private void PiButton_Click(object sender, EventArgs e)
        {
            textBox.Text = Math.PI.ToString();
        }

        // Fonctions pour la mémoire
        private void MsButton_Click(object sender, EventArgs e) { memoryValue = double.Parse(textBox.Text); }
        private void MmoinsButton_Click(object sender, EventArgs e) { memoryValue -= double.Parse(textBox.Text); }
        private void MplusButton_Click(object sender, EventArgs e) { memoryValue += double.Parse(textBox.Text); }
        private void MrButton_Click(object sender, EventArgs e) { textBox.Text = memoryValue.ToString(); }
        private void McButton_Click(object sender, EventArgs e) { memoryValue = 0; }

        // Fonction pour le logarithme naturel (ln)
        private void LnButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            textBox.Text = Math.Log(value).ToString();
        }

        // Fonction pour le logarithme en base 10 (log)
        private void LogButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            textBox.Text = Math.Log10(value).ToString();
        }

        // Fonction pour 10^x
        private void TenPuisXButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            textBox.Text = Math.Pow(10, value).ToString();
        }

        // Fonction pour x^y
        private void XPuisYButton_Click(object sender, EventArgs e)
        {
            SetOperator("^");
        }

        // Fonction pour les parenthèses
        private void ParenthesCloButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Contains("("))
                textBox.Text += ")";
            else
                textBox.Text = "(" + textBox.Text;
        }

        // Fonction pour 2^x
        private void DeuxPuiXButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            textBox.Text = Math.Pow(2, value).ToString();
        }

        // Fonction pour le factoriel
        private void FactorialButton_Click(object sender, EventArgs e)
        {
            // Vérification si l'entrée est un nombre
            if (int.TryParse(textBox.Text, out int number))
            {
                // Vérification si le nombre est positif ou nul
                if (number < 0)
                {
                    MessageBox.Show("Erreur : La factorielle n'est pas définie pour les nombres négatifs.");
                }
                else
                {
                    // Calcul de la factorielle
                    double result = Factorial(number);
                    textBox.Text = result.ToString(); // Afficher le résultat dans le textBox
                }
            }
            else
            {
                // Si l'entrée n'est pas un nombre valide
                MessageBox.Show("Erreur : Veuillez entrer un nombre valide.");
            }
        }

        // Méthode pour calculer la factorielle
        private double Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }


        // Fonction pour le modulo
        private void ModButton_Click(object sender, EventArgs e)
        {
            SetOperator("%");
        }

        // Fonction pour l'exponentiation (e^x)
        private void ExpButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            textBox.Text = Math.Exp(value).ToString();
        }

        // Fonction pour la valeur absolue
        private void AbsolutButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox.Text);
            textBox.Text = Math.Abs(value).ToString();
        }

        // Fonction pour la parenthèse ouvrante
        private void ParentheseOuButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "(" + textBox.Text;
        }

        // Fonction générique pour définir l'opérateur
        private void SetOperator(string operatorSymbol)
        {
            // Vérifier si la valeur de textBox est un nombre valide
            if (double.TryParse(textBox.Text, out double newValue))
            {
                // Si un opérateur précédent a déjà été sélectionné, on effectue le calcul
                if (currentOperator != "")
                {
                    PerformCalculation(newValue); // Effectuer le calcul avant d'appliquer un nouvel opérateur
                }
                else
                {
                    currentValue = newValue;  // Si aucun calcul précédent, stocker la première valeur
                }

                // Changer l'opérateur actuel
                currentOperator = operatorSymbol;

                // Effacer la zone de texte pour entrer un nouveau nombre
                textBox.Clear();
            }
            else
            {
                // Si la valeur dans textBox n'est pas valide, afficher une erreur
                MessageBox.Show("Veuillez entrer un nombre valide.");
            }
        }

        private void PerformCalculation(double newValue)
        {
            // Effectuer le calcul selon l'opérateur actuel
            switch (currentOperator)
            {
                case "+":
                    currentValue += newValue;
                    break;
                case "-":
                    currentValue -= newValue;
                    break;
                case "*":
                    currentValue *= newValue;
                    break;
                case "/":
                    if (newValue != 0)
                    {
                        currentValue /= newValue;
                    }
                    else
                    {
                        MessageBox.Show("Erreur : Division par zéro impossible.");
                        return;
                    }
                    break;
                default:
                    break;
            }

            // Afficher le résultat dans textBox
            textBox.Text = currentValue.ToString();
        }



    }
}
