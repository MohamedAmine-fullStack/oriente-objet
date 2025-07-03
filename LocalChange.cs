using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculAndChange
{
    public partial class LocalChange : Form
    {
        public LocalChange()
        {
            InitializeComponent();
        }


private void GetDirection_click(object sender, EventArgs e)
    {
        string url = "https://www.google.ca/maps/place/Institut+Teccart/@45.5404406,-73.5549403,16z/data=!4m6!3m5!1s0x4cc91b92de11a6b1:0xf00059d2f2ea0094!8m2!3d45.5404406!4d-73.5549403!16s%2Fg%2F1tfv04rx?entry=ttu&g_ep=EgoyMDI0MTIxMS4wIKXMDSoASAFQAw%3D%3D";

        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // Permet d'utiliser le navigateur par défaut
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur lors de l'ouverture de l'URL : {ex.Message}");
        }
    }

    private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
