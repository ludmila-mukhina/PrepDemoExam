using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personal
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
            
        }
        List<EmployeeTable> ET = Base.BaseConnect.EmployeeTable.ToList();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int c = Convert.ToInt32(TBCode.Text);
            int code=0;
            EmployeeTable Us = Base.BaseConnect.EmployeeTable.FirstOrDefault(x => x.id_employee == c);
            if (Us!=null)
            {
                code = Us.id_employee;
            }
            MessageBox.Show(code + "");
            User U = new User { id_employee = code, login = TBLogin.Text, password = PBPass.Password, id_role = 6 };
            Base.BaseConnect.User.Add(U);
            Base.BaseConnect.SaveChanges();
            MessageBox.Show("Сотрудник добавлен");
        }
    }
}
