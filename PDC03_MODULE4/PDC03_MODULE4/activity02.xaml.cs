using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;
using PDC03_MODULE4;

namespace PDC03_MODULE4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class activity02 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }

        public activity02()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President" });
            employees.Add(new Employee { DisplayName = "John Dee", Position = "Vice President" });
            employees.Add(new Employee { DisplayName = "Peter Cruz", Position = "Director" });
            employees.Add(new Employee { DisplayName = "Mark Dela Cruz", Position = "Supervisor" });
        }
        private void Add_item(object sender, EventArgs e)
        {

        }

        private void Edit_item(object sender, EventArgs e)
        {

        }

        private void Delete_item(object sender, EventArgs e)
        {

        }
    }
}