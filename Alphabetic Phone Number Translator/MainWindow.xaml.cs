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

/// Map numbers to letters:
    /// A, B, C = 2
    /// D, E, F = 3
    /// G, H, I = 4
    /// J, K, L = 5
    /// M, N, O = 6
    /// P, Q, R, S = 7
    /// T, U, V = 8
    /// W, X, Y, Z = 9

/// The focus should be on the individual letters.

///The format of the phone number should be:
    /// XXX-XXX-XXXX

///

namespace Alphabetic_Phone_Number_Translator
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
        
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            enterNumbersTextBox.Text = "";
            translatedTextBlock.Text = "";
        }


        private static char ConvertToNumber(ref char letter)
        {
            char iki = '2';
            char uc = '3';
            char dort = '4';
            char bes = '5';
            char alti = '6';
            char yedi = '7';
            char sekis = '8';
            char dokus = '9';

            char number = ' ';

            /// Must return the correct number
            if (char.IsLetter(letter) && !char.IsPunctuation(letter))
            {
                if (letter == 'A' || letter == 'B' || letter == 'C')
                {
                    number = iki;
                }

                else if (letter == 'D' || letter == 'E' || letter == 'F')
                {
                    number = uc;
                }

                else if (letter == 'G' || letter == 'H' || letter == 'I')
                {
                    number = dort;
                }

                else if (letter == 'J' || letter == 'K' || letter == 'L')
                {
                    number = bes;
                }

                else if (letter == 'M' || letter == 'N' || letter == 'O')
                {
                    number = alti;
                }

                else if (letter == 'P' || letter == 'Q' || letter == 'R' || letter == 'S')
                {
                    number = yedi;
                }

                else if (letter == 'T' || letter == 'U' || letter == 'V')
                {
                    number = sekis;
                }

                else if (letter == 'W' || letter == 'X' || letter == 'Y' || letter == 'Z')
                {
                    number = dokus;
                }

                return number;
            }

            return number;
        }

        private void translateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string TranslatedNumber = "";

                /// Get numbers from textbox
                string phone = enterNumbersTextBox.Text;
                /// Trim numbers
                string trimmed = phone.Trim();
                string trimAndUpper = trimmed.ToUpper();
                

                const int LENGTH = 12;
                char[] parts = new char[LENGTH]; 
                parts = trimAndUpper.ToCharArray();


                /// Use this method to translate char into printable string.
                /// string cats = new string(parts);
                /// MessageBox.Show(cats);
                if (phone.Length == LENGTH && char.IsPunctuation(parts[3])
                    && char.IsPunctuation(parts[7]))
                {
                    foreach (char digit in trimAndUpper)
                    {
                        if (char.IsLetter(digit))
                        {
                            char letter = digit;
                            TranslatedNumber += Convert.ToString(ConvertToNumber(ref letter));
                        }

                        else
                        {
                            char number = digit;
                            TranslatedNumber += Convert.ToString(number);
                        }
                        translatedTextBlock.Text = TranslatedNumber;                    }
                }

                else
                {
                    MessageBox.Show("Problem here");
                }
            }

            catch
            {
                MessageBox.Show("Try again!");
            }
        }
    }
}
