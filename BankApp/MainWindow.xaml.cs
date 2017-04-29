using BankApp.BusinessLogic;
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

namespace BankApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bank bank = new Bank();
        private List<Client> listContent;

        public MainWindow()
        {
            InitializeComponent();

            bank.CreateEmployee("John", "123", OperationsTypes.None);
            bank.CreateEmployee("Max", "456", OperationsTypes.None);

            var client1 = bank.CreateClient("John");
            var client2 = bank.CreateClient("Max");
            var client3 = bank.CreateClient("John");
            var client4 = bank.CreateClient("Matilda");

            listContent = bank.Clients;

            bank.CreateAccount(client1);
            bank.CreateAccount(client1);
            bank.CreateAccount(client1);

            bank.CreateAccount(client2);
            bank.CreateAccount(client2);

            bank.CreateAccount(client3);
            bank.CreateAccount(client3);
            bank.CreateAccount(client3);
        }

        private void btnEmploeeLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Login();

            lbClients.ItemsSource = bank.Clients;
        }

        private void Login()
        {
            LoginWindow logMindow = new LoginWindow();
            bool? logResult = logMindow.ShowDialog();
            if (logResult == null || logResult == false)
            {
                MessageBox.Show("Вы не можете войти!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
                return;
            }

            if  (!bank.LoginEmployee(logMindow.Name, logMindow.Password))
            {
                MessageBox.Show($"Сотрдуник с логином {logMindow.Name} не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Login();
            }
        }

        private void tbFilterClientName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilterClientName.Text))
            {
                listContent = bank.Clients;
                return;
            }
            listContent = bank.Clients.Where(client => client.Name.Contains(tbFilterClientName.Text)).ToList();
        }

        private void lbClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshAccountsList();
        }

        private void RefreshAccountsList()
        {
            var selectedClient = lbClients.SelectedItem as Client;
            if (selectedClient == null)
                return;

            lbAccounts.ItemsSource = bank.Accounts.Where(item => item.OwnerClient == selectedClient);
        }

        private void btnPushMoney_Click(object sender, RoutedEventArgs e)
        {
            DoMoneyOp(bank.PushMoney);
        }

        private void btnPullMoney_Click(object sender, RoutedEventArgs e)
        {
            DoMoneyOp(bank.PullMoney);
        }

        private void DoMoneyOp(Action<Account, decimal> opMethod)
        {
            var selAcc = lbAccounts.SelectedItem as Account;
            if (selAcc == null)
            {
                MessageBox.Show("Выбран не счет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var dltMoney = 0m;
            if (!decimal.TryParse(tbDeltaMoney.Text, out dltMoney))
            {
                MessageBox.Show("Введена неверная сумма!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                opMethod(selAcc, dltMoney);
                RefreshAccountsList();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void DoMoneyOp<TOperation>(Func<Account, Employee, decimal, TOperation> creator)
            where TOperation : MoneyOperation, new()
        {
            var selAcc = lbAccounts.SelectedItem as Account;
            if (selAcc == null)
            {
                MessageBox.Show("Выбран не счет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var dltMoney = 0m;
            if (!decimal.TryParse(tbDeltaMoney.Text, out dltMoney))
            {
                MessageBox.Show("Введена неверная сумма!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //TOperation pullOp = new TOperation(selAcc, bank.CurrentEmployee, dltMoney);
            creator(selAcc, bank.CurrentEmployee, dltMoney).Apply();
            RefreshAccountsList();
        }

        private void btnAddAccount_Click(object sender, RoutedEventArgs e)
        {
            var selClnt = lbClients.SelectedItem as Client;
            if (selClnt == null)
            {
                MessageBox.Show("Не выбран клиент!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            bank.AddAccount(selClnt);
            RefreshAccountsList();
        }

        private void btnRemoveAccount_Click(object sender, RoutedEventArgs e)
        {
            var selAccount = lbAccounts.SelectedItem as Account;
            if (selAccount == null)
            {
                MessageBox.Show("Не выбран клиент!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            bank.RemoveAccount(selAccount);
            RefreshAccountsList();
        }
    }
}
