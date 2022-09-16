using EmployeeWpfMvvmApp.DataAccessObject;
using EmployeeWpfMvvmApp.Model;
using EmployeeWpfMvvmApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeeWpfMvvmApp
{
    /// <summary>
    /// Interaction logic for FrmEmployee.xaml
    /// </summary>
    public partial class FrmEmployee : Window
    {
        private EmployeeViewModel mdl;
        public FrmEmployee()
        {
            InitializeComponent();
            mdl = (EmployeeViewModel)MyLayout.DataContext;
        }
        bool isNew = true;
        public bool IsNew
        {
            get { return isNew; }
            set
            {
                isNew = value;
                LblFormStatus.Content = isNew ? "New Employee" : "Edit Employee";
                TxtID.IsReadOnly = !isNew;
            }
        }
        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            mdl.EmployeeForm = new EmployeeModel();
            IsNew = true;
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<EmployeeModel> employees = EmployeeDAO.ReadAll();
            mdl.EmployeesGrid = employees;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            mdl.EmployeeForm = (EmployeeModel)GrdEmployees.SelectedItem;
            IsNew = false;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
            {
                return;
            }
            EmployeeModel employee = (EmployeeModel)GrdEmployees.SelectedItem;
            EmployeeDAO.Delete(employee.Id);

            MessageBox.Show("Employee is deleted successfully.");
            //lblStatus.Content = "Employee is deleted successfully.";

            BtnLoad_Click(null, null);
            BtnNew_Click(null, null);
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure to save?", "Confirm", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
            {
                return;
            }

            
            if (IsNew)
            {
                EmployeeDAO.Create(mdl.EmployeeForm);
            }
            {
                EmployeeDAO.Update(mdl.EmployeeForm);
            }

            MessageBox.Show("Employee is saved successfully.");
            //lblStatus.Content = "Employee is saved successfully.";

            BtnLoad_Click(null, null);
            BtnNew_Click(null, null);
        }
    }
}
