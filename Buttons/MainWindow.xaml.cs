using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Buttons
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }

    public class ColorInfo
    {
        public string Name { get; set; }
        public SolidColorBrush ForegroundBrush { get; set; }
        public SolidColorBrush BackgroundBrush { get; set; }
    }

    public class ViewModel
    {
        public List<ColorInfo> Colors { get; set; }

        public ViewModel()
        {
            Colors = new List<ColorInfo>
            {
                new ColorInfo { Name = "Navy", ForegroundBrush = Brushes.Navy, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Blue", ForegroundBrush = Brushes.Blue, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Aqua", ForegroundBrush = Brushes.Aqua, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Teal", ForegroundBrush = Brushes.Teal, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Olive", ForegroundBrush = Brushes.Olive, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Green", ForegroundBrush = Brushes.Green, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Lime", ForegroundBrush = Brushes.Lime, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Yellow", ForegroundBrush = Brushes.Yellow, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Orange", ForegroundBrush = Brushes.Orange, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Red", ForegroundBrush = Brushes.Red, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Maroon", ForegroundBrush = Brushes.Maroon, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Fuchsia", ForegroundBrush = Brushes.Fuchsia, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Purple", ForegroundBrush = Brushes.Purple, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Black", ForegroundBrush = Brushes.Black, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Silver", ForegroundBrush = Brushes.Silver, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "Gray", ForegroundBrush = Brushes.Gray, BackgroundBrush = Brushes.Gray },
                new ColorInfo { Name = "White", ForegroundBrush = Brushes.White, BackgroundBrush = Brushes.Gray },
            };
        }
    }
}
