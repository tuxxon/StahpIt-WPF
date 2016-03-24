﻿/*
* Copyright (c) 2016 Jesse Nicholson.
*
* This file is part of Stahp It.
*
* Stahp It is free software: you can redistribute it and/or
* modify it under the terms of the GNU General Public License as published
* by the Free Software Foundation, either version 3 of the License, or (at
* your option) any later version.
*
* In addition, as a special exception, the copyright holders give
* permission to link the code of portions of this program with the OpenSSL
* library.
*
* You must obey the GNU General Public License in all respects for all of
* the code used other than OpenSSL. If you modify file(s) with this
* exception, you may extend this exception to your version of the file(s),
* but you are not obligated to do so. If you do not wish to do so, delete
* this exception statement from your version. If you delete this exception
* statement from all source files in the program, then also delete it
* here.
*
* Stahp It is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General
* Public License for more details.
*
* You should have received a copy of the GNU General Public License along
* with Stahp It. If not, see <http://www.gnu.org/licenses/>.
*/

using System.Windows;
using Te.StahpIt.Controls;

namespace Te.StahpIt.Views
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : BaseView
    {
        private AddCategoryControl m_addCategoryControl;

        public Settings()
        {
            InitializeComponent();

            m_addCategoryControl = new AddCategoryControl();
            m_addCategoryControl.BtnAddCategory.Click += OnAddCategoryClicked;

            btnDeleteCategory.Click += OnDeleteCategoryClicked;
            btnShowAddCategory.Click += OnShowAddCategoryClicked;
        }

        private void OnShowAddCategoryClicked(object sender, RoutedEventArgs e)
        {
            /*
            var mainWindow = Window.GetWindow(this) as MetroWindow;
            if(mainWindow != null)
            {
                Flyout rightFlyout = mainWindow.FindName("rightFlyout") as Flyout;

                if(rightFlyout != null)
                {
                    rightFlyout.Header = "Add New Category";
                    rightFlyout.Content = m_addCategoryControl;
                    rightFlyout.IsOpen = !rightFlyout.IsOpen;
                }
            }
            */
        }

        private void OnDeleteCategoryClicked(object sender, RoutedEventArgs e)
        {
        }

        private void OnAddCategoryClicked(object sender, RoutedEventArgs e)
        {
        }
    }
}