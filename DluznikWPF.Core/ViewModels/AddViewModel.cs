using System.Threading.Tasks;
using System.Windows.Input;
using System;
using System.IO;

namespace DluznikWPF.Core
{
    /// <summary>
    /// The View Model for an add page
    /// </summary>
    public class AddViewModel : BaseViewModel
    {
        #region Public Properties

        #region Error Messages

        /// <summary>
        /// A flag indicating if error message should be shown
        /// </summary>
        public bool ErrorFlag { get; set; }

        /// <summary>
        /// The message to show if error occured
        /// </summary>
        public string ErrorMessage { get; set; } = "";

        #endregion

        /// <summary>
        /// The name of the new borrower
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The money that new borrower has borrowed
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The day transaction was done
        /// </summary>
        public string Day { get; set; }

        /// <summary>
        /// The month transaction was done
        /// </summary>
        public string Month { get; set; }

        /// <summary>
        /// The message (topic) from borrower to recognise what was that money for
        /// </summary>
        public string Message { get; set; } = "";

        #endregion

        #region Commands

        /// <summary>
        /// The command to add new borrower
        /// </summary>
        public ICommand AddCommand { get; set; }

        /// <summary>
        /// The command to return to main page
        /// </summary>
        public ICommand ToMainPageCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddViewModel()
        {
            // Create commands
            AddCommand = new RelayCommand(AddBorrower);
            ToMainPageCommand = new RelayCommand(async () => await ChangeToMainPageAsync());
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Adds new borrower to the list
        /// </summary>
        /// <returns></returns>
        private void AddBorrower()
        {
            // Disable any previous errors
            ErrorFlag = false;

            // Prepare local variables to catch results from checker methods
            float localValue = 0;
            Date localDate = new Date(1, 1);

            // Try to parse/check every input value
            try
            {
                if (this.Name.Length > 20 || this.Name.Length < 3) throw new Exception("Zła wartość w polu imię");
                localValue = CheckValue(this.Value);
                localDate = CheckAndBuildDate(this.Day, this.Month);
                if (this.Message.Length > 30) throw new Exception("Zła wartość w polu wiadomości");
            }

            // If something went wrong...
            catch (Exception ex)
            {
                // Error should be shown
                ErrorFlag = true;

                // Show message from exception
                ErrorMessage = ex.Message;
            }

            // If something went wrong return here
            if (ErrorFlag)
                return;

            // Otherwise add new borrower to the file
            AddBorrowerToFile(this.Name, localValue, localDate.Day, localDate.Month, this.Message);

            // Back to Main page
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Main);
        }

        /// <summary>
        /// Takes the user to the main page
        /// </summary>
        /// <returns></returns>
        public async Task ChangeToMainPageAsync()
        {
            // Go to main page
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Main);

            await Task.Delay(1);
        }

        #endregion

        #region Add Command Helpers

        /// <summary>
        /// A helper to check if input value is valid
        /// </summary>
        /// <param name="value">The value to check</param>
        private float CheckValue(string value)
        {
            // Try to parse from string, if not possible throw exception with error message
            if (!float.TryParse(value, out float result))
                throw new Exception("Zła wartość w polu ilości pieniędzy");

            // Everything works, return the result
            return result;
        }

        /// <summary>
        /// A helper to build and check input date
        /// </summary>
        /// <param name="day">The input day</param>
        /// <param name="month">The input month</param>
        private Date CheckAndBuildDate(string day, string month)
        {
            // Try to parse from string, if not possible throw exception with error message
            if (!Int32.TryParse(day, out int resultDay))
                throw new Exception("Zła wartość w polu dnia pożyczki");

            // Try to parse from string, if not possible throw exception with error message
            if (!Int32.TryParse(month, out int resultMonth))
                throw new Exception("Zła wartość w polu miesiąca pożyczki");

            // Check if month is valid
            if (resultMonth > 12 || resultMonth < 1) throw new Exception("Zła wartość w polu miesiąca pożyczki");

            // Check if day is valid
            if (!CheckDay(resultDay, resultMonth)) throw new Exception("Zła wartość w polu dnia pożyczki");

            // Everything works, return the result
            return new Date(resultDay, resultMonth);
        }

        /// <summary>
        /// A helper to check day based on month
        /// </summary>
        private bool CheckDay(int d, int m)
        {
            // Check the month to calculate maximum day possible for that month
            // TODO: Year checking for 29th day February
            int maxDayPossible = 31;
            if (m == 2) maxDayPossible = 28;
            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    maxDayPossible = 30;
                    break;
            }
            
            // Check if day is valid and return fail if not
            if (d < 0 || d > maxDayPossible)
                return false;

            // Day is valid
            return true;
        }

        /// <summary>
        /// A helper to add new borrower to the file to let main page read from it
        /// </summary>
        private void AddBorrowerToFile(string name, float localValue, int day, int month, string message)
        {
            // Open the file
            using (StreamWriter sw = File.AppendText("dluznicy.txt"))
            {
                // Write every line to it
                sw.WriteLine(name);
                sw.WriteLine(localValue.ToString());
                sw.WriteLine(day.ToString());
                sw.WriteLine(month.ToString());
                sw.WriteLine(message);
            }
        }

        #endregion
    }
}
