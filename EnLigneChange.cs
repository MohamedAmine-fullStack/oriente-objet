using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace calculAndChange
{
    public partial class EnLigneChange : Form
    {
        private List<Pays> paysList = new List<Pays>();
        private const string filePath = "./Data/pays.txt";

        // Variables publiques pour stocker les informations du pays sélectionné
        public string selectedCountry { get; private set; }
        public string selectedCurrency { get; private set; }
        public float selectedMontant { get; private set; }
        public bool normal = true;

        public EnLigneChange()
        {
            InitializeComponent();
            LirePaysEtMonnaies();
            RemplirComboBox();

            // Lier l'événement SelectedIndexChanged pour le ComboBox
            countryList.SelectedIndexChanged += new EventHandler(countryList_SelectedIndexChanged);

            // Lier les événements CheckedChanged pour les RadioButtons
            radioCurrencyN.CheckedChanged += new EventHandler(RadioCurrency_CheckedChanged);
            radioCurrencyI.CheckedChanged += new EventHandler(RadioCurrency_CheckedChanged);
        }

        public class Pays
        {
            public string Nom { get; set; }
            public string Monnaie { get; set; }
            public float Valeur { get; set; }

            public Pays(string nom, string monnaie, float valeur)
            {
                Nom = nom;
                Monnaie = monnaie;
                Valeur = valeur;
            }

            public override string ToString()
            {
                return $"{Nom} - {Monnaie}";
            }
        }

        // Lire le fichier pays.txt et remplir la liste
        private void LirePaysEtMonnaies()
        {
            try
            {
                string[] lignes = File.ReadAllLines(filePath);

                foreach (var ligne in lignes)
                {
                    string[] elements = ligne.Split(';');

                    if (elements.Length == 3)
                    {
                        string pays = elements[0].Trim();
                        string monnaie = elements[1].Trim();
                        float valeur;

                        if (float.TryParse(elements[2].Trim(), out valeur))
                        {
                            paysList.Add(new Pays(pays, monnaie, valeur));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture du fichier : " + ex.Message);
            }
            DateTime currentDate = DateTime.Now;

            // Formater la date comme "jour de la semaine, jour mois année"
            string formattedDate = currentDate.ToString("dddd dd MMMM yyyy");

            // Afficher la date formatée
            EditionMode.Text = $"Montreal, Aujourd'hui {formattedDate}";
        }

        // Remplir le ComboBox avec la liste des pays
        private void RemplirComboBox()
        {
            countryList.Items.Clear();
            currencyName.Text = "CAN.Dollar";

            foreach (var pays in paysList)
            {
                countryList.Items.Add(pays);
            }
        }

        // Récupérer les informations du pays sélectionné
        private void countryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pays paysSelectionne = (Pays)countryList.SelectedItem;

            if (paysSelectionne != null)
            {
                selectedCountry = paysSelectionne.Nom;
                selectedCurrency = paysSelectionne.Monnaie;
                selectedMontant = paysSelectionne.Valeur;
                CalculerConversion(paysSelectionne);
            }
        }

        // Calculer la conversion en fonction de la monnaie du pays sélectionné
        private void CalculerConversion(Pays paysSelectionne)
        {
            float montantCAD = 1 / selectedMontant;

            currencyMN.Text = $"1 CAN.Dollar = {paysSelectionne.Valeur} {paysSelectionne.Monnaie}";
            currencyMI.Text = $"1 {paysSelectionne.Monnaie} = {montantCAD:F2} CAN.Dollar";

            radioCurrencyN.Text = $"CAN.Dollar vers {selectedCurrency}";
            radioCurrencyI.Text = $"{selectedCurrency} vers CAN.Dollar";
        }

        // Calculer la conversion appliquée lorsque le bouton Appliquer est cliqué
        public void ApplyCalc_Click(Object sender, EventArgs e)
        {
            string num = montantInput.Text;
            float valeurConvertie;

            if (float.TryParse(num, out valeurConvertie))
            {
                if (normal)
                {
                    // Conversion de CAD à la monnaie sélectionnée
                    displayOutput.Text = $"{valeurConvertie * selectedMontant} {selectedCurrency}";
                }
                else
                {
                    // Conversion de la monnaie sélectionnée à CAD
                    displayOutput.Text = $"{valeurConvertie / selectedMontant} CAN.Dollar";
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un montant valide.");
            }
        }

        // Gérer les changements d'état des boutons radio
        private void RadioCurrency_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCurrencyN.Checked)
            {
                normal = true;
                currencyName.Text = "CAN.Dollar";
            }
            else if (radioCurrencyI.Checked)
            {
                normal = false;
                currencyName.Text = selectedCurrency;
            }
        }

        // Fonction de fermeture du modèle (fenêtre)
        public void CloseModel_click(Object sender, EventArgs e)
        {
            this.Close();
        }

        // Fonction de "replay" (si besoin d'une réinitialisation)
        public void replayModel_click(object sender, EventArgs e)
        {
            currencyMI.Text = "";
            currencyMN.Text = "";
            radioCurrencyI.Checked = false;
            radioCurrencyN.Checked = false;
            radioCurrencyI.Text = "";
            radioCurrencyN.Text = "";
            montantInput.Text ="";
            currencyName.Text = "";
            displayOutput.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
