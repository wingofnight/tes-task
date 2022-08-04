using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace TestQuest2
{
    public partial class MainWindow : Window
    {

        private const string TXTBX_FIRST_APP = "Нажмите на кнопку или введите числа через запятую.";
        private const string TXTBX_SECOND_APP = "Нажмите на кнопку, или введите по одной цифре через запятую";
        private const string TXTBX_THIRD_APP = "Введите строку";

        public MainWindow()
        {
            InitializeComponent();
        }


        //очищает поле ввода, если в него кликнуть мышкой
        private void txtBx_Massive_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (txtBx_Massive.Text == TXTBX_FIRST_APP) txtBx_Massive.Text = "";
        }

        //генерирует список случайных чисел в поле ввода
        private void btn_massiveGeneration_Click(object sender, RoutedEventArgs e)
        {
            txtBx_Massive.Text = GeneratorNumbers.ShowLinkedList();
        }

        //функиця генериует массив(список) случайных чисел. 

        private void btn_result_1_Click(object sender, RoutedEventArgs e)
        {
            float[] array = Separator.SeparatorArray(txtBx_Massive.Text);
            //проверяем, были ли ошибки при вводе массива
            if (array != null) txtBl_result_1.Text = Convert.ToString(FirstApp.AdditionModule(array));
            else txtBl_result_1.Text = "Проверьте правильнность ввода";
        }


        //второе приложение

        private void txtBx_firstList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (txtBx_firstList.Text == TXTBX_SECOND_APP) txtBx_firstList.Text = "";
        }

        private void txtBx_SecondList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (txtBx_SecondList.Text == TXTBX_SECOND_APP) txtBx_SecondList.Text = "";
        }

        private void btn_firstListGenerate_Click(object sender, RoutedEventArgs e)
        {
            txtBx_firstList.Text = GeneratorNumbers.ShowLinkedList(GeneratorNumbers.GenerateLinkedList(3,10,1,10));
        }

        private void btn_secondListGenerate_Click(object sender, RoutedEventArgs e)
        {
            txtBx_SecondList.Text = GeneratorNumbers.ShowLinkedList(GeneratorNumbers.GenerateLinkedList(3, 10, 1, 10));
        }

        private void btn_result_2_Click(object sender, RoutedEventArgs e)
        {
            LinkedList<int> firstList = Converter.ConvertFloatToInt(Separator.SeparatorLinkedList(txtBx_firstList.Text));
            LinkedList<int> secondList = Converter.ConvertFloatToInt(Separator.SeparatorLinkedList(txtBx_SecondList.Text));
            //проверка на правильность списков
            if (firstList != null && secondList != null)
            {   //проверка на то, что в списке цифры, а не числа
                if (Checker.CheckSingleFigure(firstList) && Checker.CheckSingleFigure(secondList))
                {
                    txtBl_result_2.Text = Convert.ToString(GeneratorNumbers.ShowLinkedList(SecondApp.SumTwoLists(firstList, secondList)));
                }
                else
                {
                    txtBl_result_2.Text = "Проверьте правильнность ввода";
                }
            }
            else
            {
                txtBl_result_2.Text = "Проверьте правильнность ввода";
            }

        }


        //третье приложене

        private void txtBx_palindrome_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (txtBx_palindrome.Text == TXTBX_THIRD_APP) txtBx_palindrome.Text = "";
        }

        private void txtBx_palindrome_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtBx_palindrome.Text == "") txtBx_palindrome.Text = TXTBX_THIRD_APP;
        }

        private void btn_chek_palindrome_Click(object sender, RoutedEventArgs e)
        {
            if (ThirdApp.Chek_Palindrome(txtBx_palindrome.Text)) txtBl_palindrome.Text = "Палиндром";
            else  txtBl_palindrome.Text = "Не палиндром";
        }
    }
}

