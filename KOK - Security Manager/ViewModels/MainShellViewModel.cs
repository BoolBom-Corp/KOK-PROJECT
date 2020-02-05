using KOK___Security_Manager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOK___Security_Manager.ViewModels
{
    public class MainShellViewModel : ObservableObjects
    {
        #region fileds <---------------------------------------------------------------------------------------------------
        private Employee _selectedEmployee;
        private ObservableCollection<Employee> _employees = new ObservableCollection<Employee>();
        #endregion

        public MainShellViewModel()
        {
            //Test Case
            Employees.Add(new Employee { Id = 1, FirstName = "Tom", LastName = "Johanson", Contract = ContractType.ThreeQuartersTimeContract, HireDate = DateTime.Today, WeaponUse = false, IsKR = true });
        }

        #region props <---------------------------------------------------------------------------------------------------

        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged<Employee>(() => SelectedEmployee);
            }
        }

        #endregion

        #region methods <---------------------------------------------------------------------------------------------------

        public void LoadEditEmployeeFrame()
        {
            throw new NotImplementedException();
        }

        public void LoadAddEmployeeFrame()
        {
            throw new NotImplementedException();
        }

        public void DeleteEmploy()
        {
            throw new NotImplementedException();
        }

        public void AttachL4()
        {
            throw new NotImplementedException();
        }

        public void AttachHolliday()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
