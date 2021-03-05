using System;
using System.ComponentModel;

namespace ManagementApp.Model
{
    public class Department : INotifyPropertyChanged
    {
        private int idDept { get; set; }
        private int? idManager { get; set; }
        private string nomDepartment { get; set; }
        private DateTime dateModificationManager { get; set; }

        public int IdDept
        {
            get
            {
                return idDept;
            }
            set
            {
                idDept = value;
                OnPropertyChanged("IdDept");
            }
        }

        public int IdManager
        {
            get
            {
                return (int)idManager;
            }
            set
            {
                idManager = value;
                OnPropertyChanged("IdManager");
            }
        }

        public string NomDepartment
        {
            get
            {
                return nomDepartment;
            }
            set
            {
                nomDepartment = value;
                OnPropertyChanged("NomDepartment");
            }
        }

        public DateTime DateModificationManager
        {
            get
            {
                return dateModificationManager;
            }
            set
            {
                dateModificationManager = value;
                OnPropertyChanged("DateModificationManager");
            }
        }




        #region INotifyPropertyChangedMembers 

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
