using DeskoptStyle.Command.Commandbt;
using DeskoptStyle.Command;
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
using System.Windows.Shapes;

namespace DeskoptStyle.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public ICommand ShowCommand { get; set; }
        public ICommand ShowCommandbt { get; set; }
        public MainView()
        {
            InitializeComponent();
            DataContext = this;
            ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand);
            ShowCommandbt = new RelayCommandbt(ExecuteShowCommandbt, CanExecuteShowCommandbt);

        }
        void ExecuteShowCommand(object? parameter) => MessageBox.Show(txtbox.Text);
        bool CanExecuteShowCommand(object? parameter) => txtbox.Text.Length > 6;

        void ExecuteShowCommandbt(object? parameter) => txtbox.Text = o.Text;
        bool CanExecuteShowCommandbt(object? parameter) => true;
    }
}
