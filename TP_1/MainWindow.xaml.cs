using Microsoft.Win32;
using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
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




namespace TP_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                ArrayList myAL = new ArrayList();
                int index;
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
            
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog  myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";
     
            if (myDialog.ShowDialog()==true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        { 
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int[] massk = new int[itemCount];
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Неотсортированный");
            for (index = 1; index < itemCount; index++)
            {
                number = 100 + rnd1.Next(200);
                massk[index] = number;
        
                lbMain.Items.Add(massk[index]);
               
       
            }
            lbMain.Items.Add("Элементы большие");
            for (index = 2; index < itemCount-1; index++)
            {

                if (massk[index] > massk[index + 1] && massk[index] > massk[index - 1])
                {
                    lbMain.Items.Add(massk[index]);
                }

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int[] massk = new int[itemCount];
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Неотсортированный");
            for (index = 1; index < itemCount; index++)
            {
                number =rnd1.Next(50);
                massk[index] = number;

                lbMain.Items.Add(massk[index]);


            }
            lbMain.Items.Add("Элементы большие");
            for (index = 1; index < itemCount; index++)
            {

                if (massk[index]>25)
                {

                    lbMain.Items.Add(index);
                    break;
                }

            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int S = 0;
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int[] massk = new int[itemCount];
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Неотсортированный");
            for (index = 1; index < itemCount; index++)
            {
                number = rnd1.Next(50);
                massk[index] = number;
                lbMain.Items.Add(massk[index]);
            }


            lbMain.Items.Add("Сумма");
            for (index = 1; index < itemCount; index++)
            {

                if (massk[index] > massk[2])
                {

                   S+=massk[index];
                   
                }
                
            }
            lbMain.Items.Add(S);
        }




    }
}
