using System.Collections.ObjectModel;

namespace DluznikWPF.Core
{
    /// <summary>
    /// The View Model for the list of borrowers
    /// </summary>
    public class ListViewModel
    {
        #region Singleton

        /// <summary>
        /// Singleton instance of this view model
        /// </summary>
        public static ListViewModel Instance { get; set; } = new ListViewModel
        {
            Items = new ObservableCollection<ListItemViewModel>()
        };

        #endregion

        #region Public Properties

        /// <summary>
        /// The list (collection) of items in this control
        /// </summary>
        public ObservableCollection<ListItemViewModel> Items { get; set; }

        #endregion
    }
}
