namespace NorthwindWindowsStore.ViewModel
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public abstract class BaseVM<T> : INotifyPropertyChanged
        where T : class, new()
    {
        public BaseVM()
        {
            Member = new T();
        }

        protected T Member { get; set; }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion INotifyPropertyChanged
    }
}
