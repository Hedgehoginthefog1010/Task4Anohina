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

namespace Task4Anohina.View.Page
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void R1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(Tex1.Text);
                double a = 0.2, b = 0.5, z = Math.Exp(a * x);
                double A = 0.15, B = 0.2, Z = Math.Exp(2 * A * x);
                double А = 0.15, В = 0.2, З = Math.Exp(2 * A * x);
                if (x < -Math.Log(a))
                {
                    MessageBox.Show($"1)y = {a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x)}\n" +
                       $"2)y = {A * Math.Pow(Math.Sin(x), 2) + B * Math.Cos(Z * x)}\n" +
                       $"3)y = {А * Math.Pow(Math.Sin(x), 2) + В * Math.Cos(З * x)}", " задание 4",
                           MessageBoxButton.OK,
                           MessageBoxImage.Information);
                    if (-Math.Log(a) <= x && x <= b)
                    {
                        MessageBox.Show($"1)y = {Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3)}\n" +
                            $"2)y = {Math.Pow(A, B) - Math.Pow(Math.Cos(A + Z * x), 3)}\n" +
                            $"3)y = {Math.Pow(А, В) - Math.Pow(Math.Cos(В + З * x), 3)}", " задание 4",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                    }
                    if (x > b)
                    {
                        MessageBox.Show($"1)y = {Math.Sqrt(2.5 * Math.Pow(a, 3) + Math.Pow(b - z * Math.Pow(x, 2), 6))}\n" +
                            $"2)y = {Math.Sqrt(2.5 * Math.Pow(A, 3) + Math.Pow(B - Z * Math.Pow(x, 2), 6))}\n" +
                            $"3)y = {Math.Sqrt(2.5 * Math.Pow(А, 3) + Math.Pow(В - З * Math.Pow(x, 2), 6))}", " задание 4",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);


                    }
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка","4",
                    MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
            

               

        }

        private void R2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(Tex1.Text);
                double a = 4.2, b = 5.3, c = 1.5;
                double A = -0.35, B = 1.8, C = -1.8;
                double А = 2.8, В = 5, С = 2;
                if (Math.Exp(a + b) > Math.Exp(x))
                {
                    MessageBox.Show($"1)y = {Math.Sin(Math.Exp(a + b)) + Math.Pow(x, 2)}\n" +
                        $"2)y = {Math.Sin(Math.Exp(A + B)) + Math.Pow(x, 2)}\n" +
                        $"3)y = {Math.Sin(Math.Exp(А + В)) + Math.Pow(x, 2)}", " задание 5",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Exp(a + b) == Math.Exp(x))
                {
                    MessageBox.Show($"1)y = {Math.Atan(a * b * c) + Math.Pow(Math.Sqrt(x), 3)}\n" +
                        $"2)y = {Math.Atan(A * B * C) + Math.Pow(Math.Sqrt(x), 3)}\n" +
                        $"3)y = {Math.Atan(А * В * С) + Math.Pow(Math.Sqrt(x), 3)}", " задание 5",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Exp(a + b) < Math.Exp(x))
                {
                    MessageBox.Show($"1)y = {Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)))}\n" +
                        $"2)y = {Math.Cos(Math.Sqrt(Math.Abs(x + A * B * C)))}\n" +
                        $"3)y = {Math.Cos(Math.Sqrt(Math.Abs(x + А * В * С)))}", " задание 5",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                
            }
            catch
            {
                MessageBox.Show("Ошибка", "5",
                    MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

        }

        private void R3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(Tex1.Text);
                double a = -5, b = 5.3, z = Math.Log(b * Math.Pow(x, 3));
                double A = 3, B = 5, Z = Math.Log(b * x);
                double А = -10, В = 3, З = Math.Log(b * Math.Pow(x, 2));
                if (x < a)
                {
                    MessageBox.Show($"1)y = {2.8 * Math.Pow(Math.Sin(a * x), 2) - b * Math.Pow(x, 3) * z}\n" +
                        $"2)y = {2.8 * Math.Pow(Math.Sin(A * x), 2) - B * Math.Pow(x, 3) * Z}\n" +
                        $"3)y = {2.8 * Math.Pow(Math.Sin(А * x), 2) - В * Math.Pow(x, 3) * З}", " задание 6",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (a <= x && x <= Math.Pow(b, 2))
                {
                    MessageBox.Show($"1)y = {z * Math.Cos(Math.Pow(a * x + b, 2)) + Math.Log(z)}\n" +
                        $"2)y = {Z * Math.Cos(Math.Pow(A * x + B, 2)) + Math.Log(Z)}\n" +
                        $"3)y = {z * Math.Cos(Math.Pow(А * x + В, 2)) + Math.Log(З)}", " задание 6",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (x > Math.Pow(b, 2))
                {
                    MessageBox.Show($"1)y = {Math.Exp(2.5 * a * x) + z * a * b * x}\n" +
                        $"2)y = {Math.Exp(2.5 * A * x) + Z * A * B * x}\n" +
                        $"3)y = {Math.Exp(2.5 * А * x) + З * А * В * x}", " задание 6",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "6",
                    MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

        }

        private void R4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(Tex1.Text);
                
                    double a = 3.2, b = -0.7, c = 2.2;
                    double A = 10.5, B = -2.5, C = 5.6;
                    double А = 5.4, В = 3, С = 2.6;
                    if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
                    {
                        MessageBox.Show($"1)y = {x * Math.Exp(a) + Math.Exp(Math.Abs(b * c))}\n" +
                            $"2)y = {x * Math.Exp(A) + Math.Exp(Math.Abs(B * C))}\n" +
                            $"3)y = {x * Math.Exp(А) + Math.Exp(Math.Abs(В * С))}", " задание 7",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                    }
                    if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
                    {
                        MessageBox.Show($"1)y = {Math.Pow(Math.Sin(a * x), 2) + Math.Cos(b * c)}\n" +
                            $"2)y = {Math.Pow(Math.Sin(A * x), 2) + Math.Cos(B * C)}\n" +
                            $"3)y = {Math.Pow(Math.Sin(А * x), 2) + Math.Cos(В * С)}", " задание 7",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                    }
                    if (Math.Abs(1 - Math.Pow(x, 2)) < a + c)
                    {
                        MessageBox.Show($"1)y = {Math.Sqrt(a * Math.Pow(b, 4) + Math.Pow(Math.Sqrt(c * Math.Pow(x, 2)), 5))}\n" +
                            $"2)y = {Math.Cos(Math.Sqrt(Math.Abs(x + A * B * C)))}\n" +
                            $"3)y = {Math.Cos(Math.Sqrt(Math.Abs(x + А * В * С)))}", " задание 7",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                    }
                }

                catch
                {
                    MessageBox.Show("Ошибка", "7",
                        MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }

            }


        private void R5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(Tex1.Text);
                double k = 3.1, m = 5.15, n = -1.15;
                double K = 0.78, M = -2.4, N = 4.36;
                double К = 1.1, М = 0.8, Н = 0.41;
                if (Math.Pow(x, 2) > m + n)
                {
                    MessageBox.Show($"1)y = {Math.Log(Math.Abs(m * x + n))}\n" +
                        $"2)y = {Math.Log(Math.Abs(M * x + N))}\n" +
                        $"3)y = {Math.Log(Math.Abs(М * x + Н))}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(x, 2) == m + n)
                {
                    MessageBox.Show($"1)y = {Math.Exp(Math.Cos(Math.Abs(m * x - n)))}\n" +
                        $"2)y = {Math.Exp(Math.Cos(Math.Abs(M * x - N)))}\n" +
                        $"3)y = {Math.Exp(Math.Cos(Math.Abs(М * x - Н)))}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(x, 2) < m + n)
                {
                    MessageBox.Show($"1)y = {Math.Pow(Math.Sqrt(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2)), 3)}\n" +
                        $"2)y = {Math.Pow(Math.Sqrt(Math.Pow(K, 2) + Math.Pow(Math.Cos(x), 2)), 3)}\n" +
                        $"3)y = {Math.Pow(Math.Sqrt(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2)), 3)}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "8",
                    MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

        }

        private void R6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(Tex1.Text);
                double k = 3.1, m = 5.15, n = -1.15;
                double K = 0.78, M = -2.4, N = 4.36;
                double К = 1.1, М = 0.8, Н = 0.41;
                if (Math.Pow(x, 2) > m + n)
                {
                    MessageBox.Show($"1)y = {Math.Log(Math.Abs(m * x + n))}\n" +
                        $"2)y = {Math.Log(Math.Abs(M * x + N))}\n" +
                        $"3)y = {Math.Log(Math.Abs(М * x + Н))}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(x, 2) == m + n)
                {
                    MessageBox.Show($"1)y = {Math.Exp(Math.Cos(Math.Abs(m * x - n)))}\n" +
                        $"2)y = {Math.Exp(Math.Cos(Math.Abs(M * x - N)))}\n" +
                        $"3)y = {Math.Exp(Math.Cos(Math.Abs(М * x - Н)))}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(x, 2) < m + n)
                {
                    MessageBox.Show($"1)y = {Math.Pow(Math.Sqrt(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2)), 3)}\n" +
                        $"2)y = {Math.Pow(Math.Sqrt(Math.Pow(K, 2) + Math.Pow(Math.Cos(x), 2)), 3)}\n" +
                        $"3)y = {Math.Pow(Math.Sqrt(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2)), 3)}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "8",
                    MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }
    }
}
