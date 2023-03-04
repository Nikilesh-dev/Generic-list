using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Generic_List
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<String> listname = new List<String>();
        List<String> Age = new List<String>();
        List<String> Gender = new List<String>();
        List<String> listmail = new List<String>();
        List<String> phone = new List<String>();
        List<String> Designation = new List<String>();
        List<String> Country = new List<String>();
        int len;
        public Window2()
        {

        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtAge.Text != "" && txtFanme.Text != "" && txtMail.Text != "" && txtDes.Text != "" && txtCountry.Text != "" && txtnum.Text != "")
            {
                len = listname.Count;
                InitializeComponent();
                listname.Add(txtFanme.Text);
                Age.Add(txtAge.Text);
                listmail.Add(txtMail.Text);
                Designation.Add(txtDes.Text);
                phone.Add(txtnum.Text);
                Country.Add(txtCountry.Text);

                if(male.IsChecked== true)
                {
                    Gender.Add("Male");
                }else if(female.IsChecked== true)
                {
                    Gender.Add("Female");
                }


               
               MessageBoxResult result= MessageBox.Show("Sucessfully Register", "Registered", MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    txtFanme.Clear();
                    txtDes.Clear();

                 if(male.IsChecked == true)
                    {
                        male.IsChecked = false;
                    }else if(female.IsChecked == true)
                    {
                        female.IsChecked = false;
                    }
                    
                    txtAge.Clear();
                    txtCountry.Clear();
                    txtnum.Clear();
                    txtMail.Clear();
                    
                }
            }
            else
            {
                MessageBox.Show("Please Fill All the Details","ERROR",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
        int count = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtname.Text == listname[1].ToString())
            {
                txtname.Text = listname[0].ToString();
                txtmail.Text = listmail[0].ToString();
                txtphoneN.Text = phone[0].ToString();
                txtCountryN.Text = Country[0].ToString();
                txtGender.Text = Gender[0].ToString();
                txtDesN.Text = Designation[0].ToString();
                txtAgeN.Text = Age[0].ToString();
            }
            else if (txtname.Text == listname[0].ToString())
            {
                MessageBox.Show("You cant Backward", "Backward", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtname.Text == listname[2].ToString())
            {
                txtname.Text = listname[1].ToString();
                txtAgeN.Text = Age[1].ToString();
                txtGender.Text = Gender[1].ToString();
                txtmail.Text = listmail[1].ToString();
                txtphoneN.Text = phone[1].ToString();
                txtDesN.Text = Designation[1].ToString();
                txtCountryN.Text = Country[1].ToString();

            }
            else if (txtname.Text == listname[3].ToString())
            {
                txtname.Text = listname[2].ToString();
                txtAgeN.Text = Age[2].ToString();
                txtGender.Text = Gender[2].ToString();
                txtmail.Text = listmail[2].ToString();
                txtphoneN.Text = phone[2].ToString();
                txtDesN.Text = Designation[2].ToString();
                txtCountryN.Text = Country[2].ToString();
            }
            else if (txtname.Text == listname[4].ToString())
            {
                txtname.Text = listname[3].ToString();
                txtAgeN.Text = Age[3].ToString();
                txtGender.Text = Gender[3].ToString();
                txtmail.Text = listmail[3].ToString();
                txtphoneN.Text = phone[3].ToString();
                txtDesN.Text = Designation[3].ToString();
                txtCountryN.Text = Country[3].ToString();
            }
             }
       
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            count++;
           

           if(count<= len){
                if (count == 1)
                {
                    txtname.Text = listname[1].ToString();
                    txtAgeN.Text = Age[1].ToString();
                    txtGender.Text = Gender[1].ToString();
                    txtmail.Text = listmail[1].ToString();
                    txtphoneN.Text = phone[1].ToString();
                    txtDesN.Text = Designation[1].ToString();
                    txtCountryN.Text = Country[1].ToString();

                }
                else if (count == 2)
                {
                    txtname.Text = listname[2].ToString();
                    txtAgeN.Text = Age[2].ToString();
                    txtGender.Text = Gender[2].ToString();
                    txtmail.Text = listmail[2].ToString();
                    txtphoneN.Text = phone[2].ToString();
                    txtDesN.Text = Designation[2].ToString();
                    txtCountryN.Text = Country[2].ToString();
                }
                else if (count == 3)
                {
                    txtname.Text = listname[3].ToString();
                    txtAgeN.Text = Age[3].ToString();
                    txtGender.Text = Gender[3].ToString();
                    txtmail.Text = listmail[3].ToString();
                    txtphoneN.Text = phone[3].ToString();
                    txtDesN.Text = Designation[3].ToString();
                    txtCountryN.Text = Country[3].ToString();
                }
                else if (count == 4)
                {
                    txtname.Text = listname[4].ToString();
                    txtAgeN.Text = Age[4].ToString();
                    txtGender.Text = Gender[4].ToString();
                    txtmail.Text = listmail[4].ToString();
                    txtphoneN.Text = phone[4].ToString();
                    txtDesN.Text = Designation[4].ToString();
                    txtCountryN.Text = Country[4].ToString();
                }

            }
            else
            {
                MessageBox.Show("You cant Go forward", "Forward", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtname.Text = listname[0].ToString();
            txtmail.Text = listmail[0].ToString();
            txtphoneN.Text = phone[0].ToString();
            txtCountryN.Text = Country[0].ToString();
            txtGender.Text = Gender[0].ToString();
            txtDesN.Text = Designation[0].ToString();
            txtAgeN.Text = Age[0].ToString();
        }

        //private void rbmale_Checked(object sender, RoutedEventArgs e)
        //{
        //    RadioButton radio = (RadioButton)sender;
        //    if (radio.Content.ToString() == "Male")
        //    {
        //        Gender.Add("Male");
        //    }
        //    else if(radio.Content.ToString() =="Female")
        //    {
        //        Gender.Add("Female");
        //    }
        //}
    }
}

