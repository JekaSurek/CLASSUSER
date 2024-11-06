using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CLASSUSER
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            User user = new User("Aoaoaoa", "SSSSSS", 18, "Aoaoaoaoaoa@gmail.com");

            // Вывод информации о пользователе в TextBlock
            TB1.Text = $"Имя: {user.GetFullName()}\n" +
                         $"Возраст: {user.Age}\n" +
                         $"Email: {user.Email}";
        
        }
    }
    /* •	Цель: Понять основы создания классов в C#, их свойства и методы.
•	Задание: 
o	Создать класс User с следующими свойствами: FirstName, LastName, Age, Email.
o	Добавить метод GetFullName(), который возвращает полное имя пользователя.
o	Создать экземпляр класса User в коде behind и вывести информацию о пользователе в элементе TextBlock на форме WPF.
*/

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public User(string firstName, string lastName, int age, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }

        // Метод для получения полного имени
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}