using DemoMemento;
using System.Windows;
using static System.Diagnostics.Debug;

/// <summary>
/// This Memento patter will create a caretaker that contains the 
/// collection with all the Statements in it. It can add and
/// retrieve Statements from the collection
/// </summary>
namespace Memento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Create a caretaker that contains the collection
        Caretaker caretaker = new Caretaker();

        // The originator sets the value for the statement        
        Originator originator = new Originator();

        int saveFiles = 0, currentStatement = -1;

        // ---------------------------------------------

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string text = theStatement.Text;

            originator.Set(text);

            caretaker.AddMemento(originator.StoreInMemento());

            saveFiles++;
            currentStatement++;

            WriteLine("Saved files " + saveFiles + "\n");

            btnUndo.IsEnabled = true;
        }

        private void BtnUndo_Click(object sender, RoutedEventArgs e)
        {
            if (currentStatement >= 0)
            {
                currentStatement--;
                
                string textBoxString = originator.RestoreFromMemento(caretaker.GetMemento(currentStatement));

                theStatement.Text = textBoxString;

                btnRedo.IsEnabled = true;
            }
            else
            {
                btnUndo.IsEnabled = false;
            }
        }

        private void BtnRedo_Click(object sender, RoutedEventArgs e)
        {
            if ((saveFiles - 1) > currentStatement)
            {
                currentStatement++;

                string textBoxString = originator.RestoreFromMemento(caretaker.GetMemento(currentStatement));

                theStatement.Text = textBoxString;

                btnUndo.IsEnabled = false;
            }
            else
            {
                btnRedo.IsEnabled = false;
            }

            btnUndo.IsEnabled = true;
        }
    }
}
