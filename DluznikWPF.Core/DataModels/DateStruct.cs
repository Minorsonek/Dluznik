namespace DluznikWPF.Core
{
    /// <summary>
    /// A struct to form a date from day and month
    /// </summary>
    public struct Date
    {
        #region Public Members

        public int Day;

        public int Month;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Date(int d, int m)
        {
            Day = d;
            Month = m;
        }

        #endregion
    }
}
