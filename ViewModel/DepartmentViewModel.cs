using ManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace ManagementApp.ViewModel
{
    public class DepartmentViewModel
    {
        private IList<Department> _departmentsList;
        public DepartmentViewModel()
        {
            _departmentsList = new List<Department>
            {
                new Department {NomDepartment="Tech" ,IdDept =1, IdManager=10,DateModificationManager= new DateTime(2015,12,31) },
                new Department { NomDepartment="Geologia", IdDept=2,IdManager=11, DateModificationManager = new DateTime(2017,05,12) }
            };
        }

        public IList<Department> Departments
        {
            get { return _departmentsList; }
            set { _departmentsList = value; }
        }

        //private ICommand mUpdater;
        //public ICommand UpdateCommand
        //{
        //    get
        //    {
        //        if (mUpdater == null)
        //        {
        //            mUpdater = new Updater();
        //        }

        //        return mUpdater;
        //    }
        //    set
        //    {
        //        mUpdater = value;
        //    }
        //}

        //private class Updater : ICommand
        //{
        //    #region Icommand Members

        //    public bool CanExecute(object parameter)
        //    {
        //        return true;
        //    }

        //    public event EventHandler CanExecuteChanged;

        //    public void Execute(object parameter)
        //    {
        //    }

        //    #endregion
        //}
    }
}
