
using EmployeesRegister.AppMovil.Views;

namespace EmployeesRegister.AppMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EmployeesList();
        }
    }
}
