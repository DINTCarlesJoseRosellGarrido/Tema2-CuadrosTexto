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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            boxName.Tag = mensajeName;
            boxSurname.Tag = mensajeSurname;
        }

        private void box_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox caja = (TextBox)sender;
            TextBlock ayuda = (TextBlock)caja.Tag;
            
            if(e.Key == Key.F1)
            {
                if(ayuda.Visibility == Visibility.Hidden)
                {
                    ayuda.Visibility = Visibility.Visible;
                }
                else
                {
                    ayuda.Visibility = Visibility.Hidden;
                }
            }
        }

        private void boxAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 && !int.TryParse(boxAge.Text, out _))
            {
                if (mensajeAge.Visibility == Visibility.Hidden)
                {
                    mensajeAge.Visibility = Visibility.Visible;
                }
                else
                {
                    mensajeAge.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}
