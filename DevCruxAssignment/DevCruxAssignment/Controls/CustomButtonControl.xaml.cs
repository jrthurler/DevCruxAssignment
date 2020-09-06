
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevCruxAssignment.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomButtonControl : ContentView
    {
        private Image ImageButton;
        public CustomButtonControl()
        {
            InitializeComponent();
            lbl.Text = Text;
            img.Source = ImageSource;
            customBtn.BackgroundColor = BackgroundColor;
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(CustomButtonControl),
            default(string),
            BindingMode.OneWay);

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(
            nameof(ImageSource),
            typeof(string),
            typeof(CustomButtonControl),
            default(string),
            BindingMode.OneWay);

        public static readonly BindableProperty ImageWidthProperty = BindableProperty.Create(
            nameof(ImageWidth),
            typeof(int),
            typeof(CustomButtonControl),
            default(int),
            BindingMode.OneWay);


        public static readonly BindableProperty ImageHeightProperty = BindableProperty.Create(
            nameof(ImageHeight),
            typeof(int),
            typeof(CustomButtonControl),
            default(int),
            BindingMode.OneWay);



        public static readonly BindableProperty BackgrondColorProperty = BindableProperty.Create(
            nameof(BackgroundColor),
            typeof(Color),
            typeof(CustomButtonControl),
            default(Color),
            BindingMode.OneWay);


        public string Text 
        { 
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public string ImageSource
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public int ImageWidth
        {
            get { return (int)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        public int ImageHeight
        {
            get { return (int)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }


        public Color BackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TextProperty.PropertyName)
            {
                lbl.Text = Text;
            }

            if (propertyName == ImageProperty.PropertyName)
            {
                img.Source = ImageSource;
            }

            if (propertyName == BackgroundColorProperty.PropertyName)
            {
                customBtn.BackgroundColor = BackgroundColor;
            }
        }
    }
}