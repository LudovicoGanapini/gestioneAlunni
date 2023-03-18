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

namespace gestioneAlunni
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //commento fatto da github
        
        alunno a;
        scuola sc;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnAlunnoCrea_Click(object sender, RoutedEventArgs e)
        {
            a = new alunno();
            a.nome = txtAlunnoNome.Text;
            a.cognome = txtAlunnoCognome.Text;
            a.età = int.Parse(txtAlunnoAnni.Text);
            a.città = txtAlunnoCittà.Text;

            MessageBox.Show("Creato alunno!");
        }

        private void btnScuolaCrea_Click(object sender, RoutedEventArgs e)
        {
            sc = new scuola();
            sc.nome = txtScuolaNome.Text;
            sc.indirizzo = txtScuolaIndirizzo.Text;
            sc.apertura = DateTime.Parse(txtScuolaApertura.Text);
            sc.chiusura = DateTime.Parse(txtScuolaChiusura.Text);

            MessageBox.Show("Creata scuola!");
        }

        private void btnAlunnoToString_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(a.toString(a));
        }

        private void btnAlunnoAnno_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(a.classi(a));
        }

        private void btnScuolaToString_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sc.toString(sc));
        }
    }
}
