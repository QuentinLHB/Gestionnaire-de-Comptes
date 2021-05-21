using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comptes.Constants
{
   public class Const
    {
        public const string BUDGET = "Budget";
        public const string ACCOUNT = "Account";
        public const string TOTAL = "Total";
        public const int DECEMBER = 11;

        public const String FILE_MONTHLYRECAP = "SauvegardesMensuelles";
        public const String FILE_DATA = "appData";

        public const int USER_A = 0; public const int USER_B = 1;
        public const string DEFAULT_NAME_USER_A = "Utilisateur A";
        public const string DEFAULT_NAME_USER_B = "Utilisateur B";
        public const int NAME_LENGTH_LIMIT = 10;

        public static Dictionary<string, double> initialDivision = new Dictionary<string, double>();

        public const string BALANCEDRESULT = "Résultat équilibré.";

        public const string MONTHLYEXPENSES_HEADER = "Dépenses de";

        public static string debtDisplay(string name, double result)
        {
            return ($"{name} doit {result}€.");

        }
        public const string MONTH_YEAR_FORMAT = "MMMM / yyyy";

        // Contenu des MessageBox :
        public const string ERROR = "Erreur";

        public const string MSG_TITLE_ERR_NOSAVE = "Action impossible";
        public const string MSG_ERR_NO_MONTHLYSAVE = "Aucune sauvegarde enregistrée.";

        public const string MSG_TITLE_VALIDATIONMONYLYSAVE = "Cloturer le mois";
        public const string MSG_VALIDATIONMONYLYSAVE = "Valider le mois ? Aucune modification ne pourra êttre apportée.";

        public const string MSG_TITLE_SAVEBEFOREQUIT = "Fermeture";
        public const string MSG_SAVEBEFOREQUIT = "Voulez-vous sauvegarder avant de quitter?";

        public const string MSG_TITLE_RESET = "Réinitialisation";
        public const string MSG_RESET = "Toutes les données seront effacées. Confirmer ?";
        public const string MSG_RESETOK = "L'application a été réinitialisée avec succès.";

        public const string MSG_TITRE_ERR_SAVE = "Sauvegarde";
        public const string MSG_ERR_SAVE = ERROR;

        public const string MSG_TITRE_ERR_WRONGINPUT = ERROR;
        public const string MSG_ERR_WRONGINPUT = "Ne saisir que des nombres ou des calculs.";

        public const string MSG_TITLE_DELETE = "Confirmation de suppression";
        public const string MSG_DELETEBUDGET = "Voulez-vous vraiment supprimer le budget et son contenu ?";
        public const string MSG_DELETEMONTLYSAVE = "Voulez-vous vraiment supprimer cette sauvegarde mensuelle de manière permanente ?";

        public const string MSG_ERR_ADDDIVISION = "La répartition n'a pas pu être ajoutée.";
        public const string MSG_ERR_ADDDIVISION2 = "Un minimum d'une répartition doit subsister.";

        public const string MSG_ERR_FINALIZE = "Ajouter au moins un budget.";

        public const string MSG_ERR_WRONGSELECTION = "Aucune sauvegarde n'a été trouvée pour le mois suivant :";

        public const string MSG_TITLE_REPLACE = "Ecrasement";
        public const string MSG_REPLACE = "Une sauvegarde existe déjà pour ce mois. L'écraser ?";
        public const string MSG_REPLACE_YES = "La sauvegarde mensuelle a été écrasée.";
        public const string MSG_REPLACE_NO = "La sauvgarde n'a pas été effectuée.";

        private Const()
        {
            initializeDivisions();
        }

        public static void initializeDivisions()
        {
            initialDivision.Add("50 / 50", 0.5);
            initialDivision.Add("60 / 40", 0.6);
            initialDivision.Add("70 / 30", 0.7);
        }

        public static string EXPENSES(string user)
        {
            return $"Dépenses de {user}";
        }
    }
}
