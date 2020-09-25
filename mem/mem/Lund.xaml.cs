using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lund : ContentPage
    {
        public Lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            pea = new BoxView { Color = Color.LightBlue, CornerRadius = 50 };
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.All);
            abs.Children.Add(pea);
            Content = abs;
        }
    }
}