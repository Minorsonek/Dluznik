using System.Windows.Input;
using System.IO;
using System.Collections.Generic;

namespace DluznikWPF.Core
{
    /// <summary>
    /// The View Model for a confirm-delete page
    /// </summary>
    public class ConfirmDeleteViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The name of selected borrower
        /// </summary>
        public string SelectedBorrowerName { get; set; }

        /// <summary>
        /// The ID of selected borrower
        /// </summary>
        public int SelectedBorrowerID { get; set; }

        /// <summary>
        /// True if any borrower was selected in the list
        /// </summary>
        public bool IsAnyBorrowerSelected { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to delete selected borrower
        /// </summary>
        public ICommand DeleteCommand { get; set; }

        /// <summary>
        /// The command to return to main page
        /// </summary>
        public ICommand ToMainPageCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ConfirmDeleteViewModel()
        {
            // Create commands
            DeleteCommand = new RelayCommand(DeleteBorrower);
            ToMainPageCommand = new RelayCommand(ChangeToMainPage);

            // Check which borrower was selected (if any)
            CheckBorrowerSelection();
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Deletes item from the list
        /// </summary>
        public void DeleteBorrower()
        {
            // Delete selected borrower
            DeleteBorrowerInFile(SelectedBorrowerID);

            // Return to main page
            ChangeToMainPage();
        }

        /// <summary>
        /// Takes the user to the main page
        /// </summary>
        public void ChangeToMainPage()
        {
            // Go to main page
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Main);
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Checks which borrower was selected (if any)
        /// </summary>
        private void CheckBorrowerSelection()
        {
            // For each borrower, check selection
            foreach (var item in ListViewModel.Instance.Items)
            {
                if (item.IsSelected)
                {
                    // Selected borrower found, remember his name and ID
                    SelectedBorrowerName = item.Name;
                    SelectedBorrowerID = item.ID;

                    // Set the flag that we have found selected borrower
                    IsAnyBorrowerSelected = true;

                    return;
                }
            }

            // No one found, set the flag to indicate that
            IsAnyBorrowerSelected = false;
        }

        /// <summary>
        /// Deletes borrower in file by index
        /// </summary>
        /// <param name="index">Indicates which borrower should be deleted</param>
        private void DeleteBorrowerInFile(int index)
        {
            // Check if method was called properly
            if (index <= 0) return;

            // Read lines in file
            var file = new List<string>(File.ReadAllLines("dluznicy.txt"));

            // Delete specific borrower
            for(int i = 0; i < 5; i++) file.RemoveAt((index-1)*5);

            // Write remaining lines
            File.WriteAllLines("dluznicy.txt", file.ToArray());
        }

        #endregion
    }
}
