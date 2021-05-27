using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Comptes.Model;
using System.Globalization;
using Comptes.Constants;


namespace Comptes.Control
{
    public partial class Controler
    {

        public string createNewDivision(string txtDividend, string txtDivider)
        {
            string key = txtDividend + " / " + txtDivider;
            data.dctDivisions.Add(key, double.Parse(txtDividend) / 100);
            return key;
        }

        public string getDivider(string txtDividend)
        { 
            int dividend = 100 - int.Parse(txtDividend);
            if (dividend >= 0 && dividend <= 100)
            {
                return dividend.ToString();
            }

            else
            {
                return "";
            }
        }

        public void deleteDivision(string itemToRemove)
        {
            if (data.dctDivisions.Count != 1)
            {
                data.dctDivisions.Remove(itemToRemove);
                frmDivisions.refreshCboDivisions();
            }

            else
            {
                MessageBox.Show(Const.MSG_ERR_ADDDIVISION2, Const.ERROR, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Vérifie les données entrées par l'utilisateur.
        /// </summary>
        /// <param name="dividend">Le string de la valeur entrée.</param>
        /// <returns>True si :
        /// * Une valeur a bien été entrée.
        /// * La valeur est bien comprise entre 0 et 100 inclus.</returns>
        public bool validateDivisionData(string dividend)
        {
            if(dividend == null)
            {
                return false;
            }
            return (int.Parse(dividend) >= 0 && int.Parse(dividend) <= 100);        
        }
    }
}
