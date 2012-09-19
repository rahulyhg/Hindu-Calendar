﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Calender2
{
    public sealed partial class PersonalEventItem : UserControl
    {
        ItemDetailPage _page;

        public PersonalEventItem(String text, ItemDetailPage page)
        {
            this.InitializeComponent();
            EventText.Text = text;
            _page = page;
        }

        private void EventText_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
        }
    }
}
