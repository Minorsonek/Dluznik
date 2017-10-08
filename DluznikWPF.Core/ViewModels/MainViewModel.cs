using System;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.IO;

namespace DluznikWPF.Core
{
    /// <summary>
    /// The View Model for a main page
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The flag to indicate if borrowers list is empty
        /// </summary>
        public bool IsItemsEmpty => ListViewModel.Instance.Items.Count == 0;

        #endregion

        #region Commands

        /// <summary>
        /// The command to change the current page to the "confirm-delete" page which deletes selected borrower
        /// </summary>
        public ICommand ToConfirmDeletePageCommand { get; set; }

        /// <summary>
        /// The command to change the current page to the "add" page
        /// </summary>
        public ICommand ToAddPageCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainViewModel()
        {
            // Create commands
            ToConfirmDeletePageCommand = new RelayCommand(ChangeToConfirmDeletePage);
            ToAddPageCommand = new RelayCommand(ChangeToAddPage);

            // Load borrowers to the list
            LoadBorrowersFromFile();
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Takes the user to the confirm-delete page
        /// </summary>
        public void ChangeToConfirmDeletePage()
        {
            // Go to add page
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.ConfirmDelete);
        }

        /// <summary>
        /// Takes the user to the add page
        /// </summary>
        public void ChangeToAddPage()
        {
            // Go to add page
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Add);
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Loads every borrower stored in file and adds them to the list
        /// </summary>
        private void LoadBorrowersFromFile()
        {
            // Reset borrowers list and counter
            ListViewModel.Instance.Items = new ObservableCollection<ListItemViewModel>();
            IoC.Application.BorrowersCounter = 0;

            // Read lines in file
            string[] readText = File.ReadAllLines("dluznicy.txt");

            // Check if there are any borrowers
            if (readText.Length < 5)
                return;

            // Prepare variables
            int i = 1;
            string name = "", value = "", day = "", month = "", message = "";

            // Loop though lines
            foreach (string line in readText)
            {
                switch (i)
                {
                    // Catch every line to separate variables
                    case 1:
                        name = line;
                        break;
                    case 2:
                        value = line;
                        break;
                    case 3:
                        day = line;
                        break;
                    case 4:
                        month = line;
                        break;
                    case 5:
                        {
                            message = line;

                            // We have everything we need, so count new borrower
                            IoC.Application.BorrowersCounter++;

                            // Then add new borrower to the list
                            ListViewModel.Instance.Items.Add(new ListItemViewModel
                            {
                                Name = name,
                                Value = float.Parse(value),
                                Day = day,
                                Month = month,
                                Message = message,
                                IsSelected = false,
                                ID = IoC.Application.BorrowersCounter
                            });

                            // Reset the iterator for next borrower
                            i = 0;
                        }
                        break;
                }
                i++;
            }
        }

        #endregion
    }
}
