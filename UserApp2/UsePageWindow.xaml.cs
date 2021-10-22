﻿using System;
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
using System.Windows.Shapes;

namespace UserApp2
{
    /// <summary>
    /// Interaction logic for UsePageWindow.xaml
    /// </summary>
    public partial class UsePageWindow : Window
    {
        public UsePageWindow()
        {
            InitializeComponent();

            AppContext db = new AppContext();
            List<User> users = db.Users.ToList();

            ListOfUsers.ItemsSource = users;
        }
    }
}
