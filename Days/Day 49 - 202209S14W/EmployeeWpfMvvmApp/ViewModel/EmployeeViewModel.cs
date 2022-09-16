using EmployeeWpfMvvmApp.Model;
using EmployeeWpfMvvmApp.MVVMBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWpfMvvmApp.ViewModel
{
    public class EmployeeViewModel: ViewModelBase
    {
        private EmployeeModel employeeForm;
        private ObservableCollection<EmployeeModel> employeesGrid;

        public EmployeeModel EmployeeForm
        {
            get { return employeeForm; }
            set { employeeForm = value; NotifyPropertyChanged("EmployeeForm"); }
        }
        public ObservableCollection<EmployeeModel> EmployeesGrid
        {
            get { return employeesGrid; }
            set { employeesGrid = value; NotifyPropertyChanged("EmployeesGrid");  }
        }

        public EmployeeViewModel()
        {
            this.EmployeeForm = new EmployeeModel();
            this.EmployeesGrid = new ObservableCollection<EmployeeModel>();
            this.EmployeesGrid.CollectionChanged += EmployeesGrid_CollectionChanged;
        }

        void EmployeesGrid_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("EmployeesGrid");
        }

    }
}
