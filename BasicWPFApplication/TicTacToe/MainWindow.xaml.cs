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

namespace TicTacToe
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    string player1Sign = string.Empty;
    string player2Sign = string.Empty;
    public MainWindow()
    {
      InitializeComponent();
    }

    private void txt_TextChanged(object sender, TextChangedEventArgs e)
    {
      bool result = false;
      if ((sender as TextBox).Name == "txt00")
      {
        if (Function1() || Function2() || Function3())
        {
          result = true;
        }
      }

      if (result)
      {
        media.Source = new Uri(@"D:\WPF Training\BasicWPFApplication\TicTacToe\tenor.gif");
        
        grid1.IsEnabled = false;
      }

      //   if (result)
      //call winning function


    }

    private bool Function4()
    {
      if (txt00.Text == txt10.Text && txt00.Text == txt20.Text && txt10.Text == txt20.Text)
      {
        return true;
      }
      else
      {
        return false;
      }
    }


    private bool Function1()
    {
      if (txt00.Text == txt01.Text && txt00.Text == txt02.Text && txt01.Text == txt02.Text)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    private bool Function2()
    {
      if (txt10.Text == txt11.Text && txt10.Text == txt12.Text && txt11.Text == txt12.Text)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    private bool Function3()
    {
      if (txt20.Text == txt21.Text && txt20.Text == txt22.Text && txt21.Text == txt22.Text)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private bool Function5()
    {
      if (txt01.Text == txt11.Text && txt01.Text == txt21.Text && txt11.Text == txt21.Text)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    private bool Function6()
    {
      if (txt02.Text == txt12.Text && txt02.Text == txt22.Text && txt12.Text == txt22.Text)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private bool Function7()
    {
      if (txt00.Text == txt11.Text && txt00.Text == txt22.Text && txt11.Text == txt22.Text)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private bool Function8()
    {
      if (txt02.Text == txt11.Text && txt02.Text == txt20.Text && txt11.Text == txt20.Text)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    private void btnStart_Click(object sender, RoutedEventArgs e)
    {
      grid1.IsEnabled = true;
      btnStart.IsEnabled = false;
      player1Sign = txtPlayer1.Text.ToString();
      player2Sign = txtPlayer2.Text.ToString();
    }
  }
}
