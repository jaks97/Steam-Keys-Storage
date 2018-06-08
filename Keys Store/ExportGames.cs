using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Keys_Store
{
    public partial class ExportGames : Form
    {
        private List<Package> packages;

        public ExportGames(List<Package> packages)
        {
            InitializeComponent();
            this.packages = packages;
        }

        private void ExportGames_Load(object sender, EventArgs e)
        {
            this.UpdateResults();
        }

        private void UpdateResults()
        {
            string format = this.format.Text + (lineJump.Checked ? "\r\n" : "");
            results.Text = string.Empty;

            foreach (Package package in packages)
            {
                results.Text += format.ReplaceIgnoreCase("{SUBID}", package.SubId.ToString())
                    .ReplaceIgnoreCase("{NAME}", package.AppName)
                    .ReplaceIgnoreCase("{APPID}", package.AppId.ToString())
                    .ReplaceIgnoreCase("{DETAILS}", package.Details)
                    .ReplaceIgnoreCase("{CARDS}", package.HasCards ? "With Cards" : "No Cards")
                    .ReplaceIgnoreCase("{APPURL}", package.StorePage.ToString())
                    .ReplaceIgnoreCase("{PACKAGEURL}", package.SubPage.ToString())
                    .ReplaceIgnoreCase("{COUNT}", package.Quantity.ToString());
            }

        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(results.Text, false, 5, 200);
        }
    }
    public static class StringExtensions
    {
        public static string ReplaceIgnoreCase(this string str, string from, string to)
        {
            return Regex.Replace(str, Regex.Escape(from), to.Replace("$", "$$"), RegexOptions.IgnoreCase);
        }
    }
}
