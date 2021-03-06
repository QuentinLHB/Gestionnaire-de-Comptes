﻿using System;
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

        /// <summary>
        /// Sauvegarde les données affichées par sérialisation.
        /// </summary>
        public void saveData()
        {
            try
            {
                data.storeUserData();
                Serialise.Save(Const.FILE_DATA, data);
            }
            catch
            {
                MessageBox.Show(Const.MSG_ERR_SAVE, Const.MSG_TITLE_SAVE, MessageBoxButtons.OK);
            }
            setFlagChange(change: false);
        }



        /// <summary>
        /// Reinitialise le fichier data et les contrôles de l'application.
        /// </summary>
        public void resetView()
        {
            if (File.Exists(Const.FILE_DATA))
            {
                File.Delete(Const.FILE_DATA);
            }

            data.Clear();
            frmMain.resetView();        
            
        }

        /// <summary>
        /// Réinitialise l'application à son état d'origine (affichage et données).
        /// </summary>
        public void fullReset()
        {
            if (MessageBox.Show(Const.MSG_RESET, Const.MSG_TITLE_RESET, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(Const.FILE_MONTHLYRECAP))
                {
                    File.Delete(Const.FILE_MONTHLYRECAP);
                }
                resetView();
                frmMain.refreshTotals();

                MessageBox.Show(Const.MSG_RESETOK, Const.MSG_TITLE_RESET, MessageBoxButtons.OK);
                setFlagChange(change: true);
            }
        }

        /// <summary>
        /// Vérifie si une au moins une sauvegarde existe.
        /// </summary>
        /// <returns>True si une sauvegarde existe. False sinon.</returns>
        public bool saveNotNullOrEmpty()
        {
            List<MonthlySave> allSaves = getMonthlySaves();

            if (allSaves != null && allSaves.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
