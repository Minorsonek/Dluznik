using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;
using System.Collections.Generic;

namespace DluznikWPF.Core
{
    /// <summary>
    /// The View Model for a main page
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The list (collection) of the borrowers
        /// </summary>
        public static ObservableCollection<ListItemViewModel> Items { get; set; }

        /// <summary>
        /// The flag to indicate if borrowers list is empty
        /// </summary>
        public bool IsItemsEmpty => Items.Count == 0;

        #endregion

        #region Commands

        /// <summary>
        /// The command to delete borrower from the list
        /// </summary>
        public ICommand DeleteCommand { get; set; }

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
            DeleteCommand = new RelayCommand(DeleteAsync);
            ToAddPageCommand = new RelayCommand(async () => await ChangeToAddPageAsync());

            // Load borrowers to the list
            LoadBorrowersFromFile();
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Deletes item from the list
        /// </summary>
        public void DeleteAsync()
        {
            // For each item...
            foreach(var item in Items)
            {
                // Delete item if selected
                if (item.IsSelected) DeleteBorrower(item.ID);
            }

            // Reload borrowers
            LoadBorrowersFromFile();
        }

        /// <summary>
        /// Takes the user to the add page
        /// </summary>
        /// <returns></returns>
        public async Task ChangeToAddPageAsync()
        {
            // Go to add page
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Add);

            await Task.Delay(1);
        }

        #endregion

        #region Private Helpers

        private void LoadBorrowersFromFile()
        {
            // Reset borrowers list and counter
            Items = new ObservableCollection<ListItemViewModel>();
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
                            Items.Add(new ListItemViewModel
                            {
                                Name = name,
                                Value = float.Parse(value),
                                Day = Int32.Parse(day),
                                Month = Int32.Parse(month),
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

        private void DeleteBorrower(int index)
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
