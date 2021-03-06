﻿using System;
using System.Windows.Input;

namespace DluznikWPF.Core
{
    /// <summary>
    /// A view model for each borrower (list item)
    /// </summary>
    public class ListItemViewModel : BaseViewModel
    {
        #region Private Members

        // Rough values of day and month
        private int mDay;
        private int mMonth;

        #endregion

        #region Public Properties

        /// <summary>
        /// The name of the new borrower
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The money that new borrower has borrowed
        /// </summary>
        public float Value { get; set; }

        /// <summary>
        /// The day transaction was done
        /// </summary>
        public string Day
        {
            get
            {
                if (mDay < 10) return "0" + mDay.ToString();
                else return mDay.ToString();
            }
            set
            {
                mDay = Int32.Parse(value);
            }
        }

        /// <summary>
        /// The month transaction was done
        /// </summary>
        public string Month
        {
            get
            {
                if (mMonth < 10) return "0" + mMonth.ToString();
                else return mMonth.ToString();
            }
            set
            {
                mMonth = Int32.Parse(value);
            }
        }

        /// <summary>
        /// The message (topic) from borrower to recognise what was that money for
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The flag to indicate if borrower is selected (for deleting)
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// Non-displayed unique ID for each borrower
        /// </summary>
        public int ID { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to select borrower in list
        /// </summary>
        public ICommand SelectCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ListItemViewModel()
        {
            // Create commands
            SelectCommand = new RelayCommand(Select);
        }

        #endregion

        #region Command Methods

        private void Select()
        {
            // If item is selected, unselect everything
            if (IsSelected)
            {
                // Unselect every other item
                foreach (var item in ListViewModel.Instance.Items)
                    item.IsSelected = false;

                return;
            }

            // Item isnt selected, unselect everything
            foreach (var item in ListViewModel.Instance.Items)
                item.IsSelected = false;

            // Select only this item
            IsSelected = true;
        }

        #endregion
    }
}
