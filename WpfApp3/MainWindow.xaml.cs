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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily= new FontFamily(fontName); //Установка выбранного в комбобоксе шрифта
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int fontSize = Convert.ToInt32(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
            {
                textBox.FontSize = fontSize; //Установка выбранного в комбобоксе размера шрифта
            }
        }

   
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontWeight == FontWeights.Normal)//Проверка какой сейчас параметр
                {
                    textBox.FontWeight = FontWeights.Bold; //Установка значения из списка предопределенных
                }
                else
                {
                    textBox.FontWeight = FontWeights.Normal;//Установка значения из списка предопределенных
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Italic) //Проверка какой сейчас параметр
            {
                textBox.FontStyle = FontStyles.Normal; //Установка параметра из списка предопределенных

            }
            else
            {
                textBox.FontStyle = FontStyles.Italic;//Установка параметра из списка предопределенных

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations == TextDecorations.Underline)//Проверка какой сейчас параметр
            {
                textBox.TextDecorations = null; //Скидываем параметр в нулл

            }
            else
            {
                textBox.TextDecorations = TextDecorations.Underline;//Установка параметра из списка предопределенных

            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.Foreground.ToString() != "Black")//Проверка какой сейчас параметр
                {
                    textBox.Foreground = Brushes.Black;//Установка параметра из списка предопределенных
                }
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.Foreground.ToString() != "Red")//Проверка какой сейчас параметр
                {
                    textBox.Foreground = Brushes.Red;//Установка параметра из списка предопределенных
                }
            }
        }
    }
}
