namespace DluznikWPF.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ListItemViewModel"/>
    /// </summary>
    public class ListItemDesignModel : ListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ListItemDesignModel Instance => new ListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ListItemDesignModel()
        {
            Name = "Mama";
            Value = 50;
            Day = 6;
            Month = 7;
            Message = "Na chleb";
        }

        #endregion
    }
}
