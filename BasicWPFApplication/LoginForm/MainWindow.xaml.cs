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

namespace LoginForm
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
      SolidColorBrush brush = new SolidColorBrush();
      #region delete
      //if (e.NewValue == 25)
      //{
      //  brush.Color = Colors.Green;
      //  grid1.Background = brush;
      //}
      //else if (e.NewValue == 50)
      //{
      //  brush.Color = Colors.LightYellow;
      //  grid1.Background = brush;
      //}
      //else if (e.NewValue == 75)
      //{
      //  brush.Color = Colors.White;
      //  grid1.Background = brush;
      //}
      //else if (e.NewValue == 100)
      //{
      //  brush.Color = Colors.Aqua;
      //  grid1.Background = brush;
      //}
      #endregion

      brush.Color =
      Color.FromArgb(
          255, Convert.ToByte(e.NewValue), Convert.ToByte(e.OldValue), Convert.ToByte(e.NewValue));
      grid1.Background = brush;
    }

  }
}
