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
using System.Collections.ObjectModel;  // Add this line

namespace Solenoidtest4
{
    public partial class MainWindow : Window
    {
        // Define a data class for the rows
        public class MyDataRow
        {
            public int Step { get; set; }
            public string Command { get; set; }
            public string Address { get; set; }
            public int Value { get; set; }
            public string Description { get; set; }
        }

        // ObservableCollection to hold the data
        public ObservableCollection<MyDataRow> MyData { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the ObservableCollection
            MyData = new ObservableCollection<MyDataRow>();

            // Set the DataGrid's ItemsSource to the ObservableCollection
            myDataGrid.ItemsSource = MyData;

            // Example: Adding rows
            MyData.Add(new MyDataRow { Step = 1, Command = "CMD1", Address = "0x123", Value = 42, Description = "First row" });
            MyData.Add(new MyDataRow { Step = 2, Command = "CMD2", Address = "0x456", Value = 78, Description = "Second row" });
            MyData.Add(new MyDataRow { Step = 2, Command = "CMD2", Address = "0x456", Value = 78, Description = "Second row" });
            MyData.Add(new MyDataRow { Step = 2, Command = "CMD2", Address = "0x456", Value = 78, Description = "Second row" });
            
            // Add more rows as needed
        }
    }
}
