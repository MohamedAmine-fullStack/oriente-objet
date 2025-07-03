using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace calculAndChange
{
    public partial class adminChange : Form
    {
        private List<Pays> paysList = new List<Pays>();
        private const string filePath = "./Data/pays.txt";

        public adminChange()
        {
            InitializeComponent();
            VerifierOuCreerFichier();
            ChargerPays();
        }

        // Vérifie si le fichier existe, sinon le crée
        private void VerifierOuCreerFichier()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        // Charge les pays depuis le fichier texte
        private void ChargerPays()
        {
            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split(';');
                    if (parts.Length == 3 && decimal.TryParse(parts[2], out decimal valeur))
                    {
                        paysList.Add(new Pays
                        {
                            Nom = parts[0],
                            Devise = parts[1],
                            Valeur = valeur
                        });
                    }
                }
            }
            MettreAJourListBox();
        }

        // Met à jour la ListBox et le label avec le nombre total de pays
        private void MettreAJourListBox()
        {
            CountryList.DataSource = null; // Réinitialisation pour éviter les doublons
            CountryList.DataSource = paysList;
            CountryList.DisplayMember = "Nom"; // Affiche uniquement le nom du pays dans la ListBox
            MettreAJourNombrePays();
        }

        // Met à jour le label avec la position du pays sélectionné et le total des pays
        private void MettreAJourNombrePays()
        {
            int totalPays = paysList.Count;

            if (CountryList.SelectedIndex >= 0)
            {
                int position = CountryList.SelectedIndex + 1; // Les index commencent à 0
                NumberCoun.Text = $"Pays {position} sur un Total de {totalPays}";
            }
            else
            {
                NumberCoun.Text = $"Total de {totalPays} pays";
            }
        }

        // Événement déclenché lors de la sélection d’un pays dans la ListBox
        private void CountryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountryList.SelectedItem is Pays selectedPays)
            {
                CountryName.Text = selectedPays.Nom;
                Curren.Text = selectedPays.Devise;
                Val.Text = selectedPays.Valeur.ToString();
            }

            // Met à jour le label avec la position du pays
            MettreAJourNombrePays();
        }

        // Ajouter un nouveau pays
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CountryName.Text))
            {
                MessageBox.Show("Le nom du pays ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Curren.Text))
            {
                MessageBox.Show("La devise ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(Val.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valeur))
            {
                MessageBox.Show("Veuillez entrer une valeur numérique valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paysList.Any(p => p.Nom.Equals(CountryName.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Le pays existe déjà dans la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            paysList.Add(new Pays
            {
                Nom = CountryName.Text,
                Devise = Curren.Text,
                Valeur = valeur
            });

            MettreAJourListBox();
            EffacerChamps();
        }

        // Modifier un pays existant
        private void Edite_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(Val.Text, out decimal valeur))
            {
                MessageBox.Show("Entrée invalide. Veuillez entrer une valeur numérique correcte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CountryList.SelectedItem is Pays selectedPays)
            {
                selectedPays.Nom = CountryName.Text;
                selectedPays.Devise = Curren.Text;
                selectedPays.Valeur = valeur;

                MettreAJourListBox();
                EffacerChamps();
            }
        }

        // Supprimer un pays
        private void Delete_Click(object sender, EventArgs e)
        {
            if (CountryList.SelectedItem is Pays selectedPays)
            {
                paysList.Remove(selectedPays);
                MettreAJourListBox();
                EffacerChamps();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un pays à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sauvegarder les données dans le fichier texte
        private void Sauv_Click(object sender, EventArgs e)
        {
            var lignes = paysList.Select(p => $"{p.Nom};{p.Devise};{p.Valeur}");
            File.WriteAllLines(filePath, lignes);
            MessageBox.Show("Données sauvegardées avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Effacer les champs
        private void EffacerChamps()
        {
            CountryName.Clear();
            Curren.Clear();
            Val.Clear();
        }
        private void Ann_Click(object sender, EventArgs e) {
            EffacerChamps();
        }
    }

    // Classe représentant un pays
    public class Pays
    {
        public string Nom { get; set; }
        public string Devise { get; set; }
        public decimal Valeur { get; set; }
    }
}
