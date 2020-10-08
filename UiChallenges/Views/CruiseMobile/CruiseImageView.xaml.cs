using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace UiChallenges.Views.CruiseMobile
{
    public partial class CruiseImageView
    {
        public static readonly BindableProperty Image1Property =
            BindableProperty.Create("Image1", typeof(string), typeof(CruiseImageView), default(string));

        public static readonly BindableProperty Image2Property =
            BindableProperty.Create("Image2", typeof(string), typeof(CruiseImageView), default(string));

        public static readonly BindableProperty Image3Property =
            BindableProperty.Create("Image3", typeof(string), typeof(CruiseImageView), default(string));

        public string Image1
        {
            get { return (string)GetValue(Image1Property); }
            set { SetValue(Image1Property, value); }
        }

        public string Image2
        {
            get => (string)GetValue(Image2Property);
            set => SetValue(Image2Property, value);
        }

        public string Image3
        {
            get => (string)GetValue(Image3Property);
            set => SetValue(Image3Property, value);
        }

        public CruiseImageView()
        {
            InitializeComponent();
        }
    }
}
