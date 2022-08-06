using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;

namespace avaloniax.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            var panels = Enumerable
                .Range(0, 10)
                .Select(o =>
                {
                    var stackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal
                    };

                    stackPanel.Children.AddRange(Enumerable.Range(0, 10).Select(oo => new Label() { Content = "Test" + o + oo }));
                    return stackPanel;
                });
            
            var container = new StackPanel()
            {
                Orientation = Orientation.Vertical,
            };
            
            container.Children.AddRange(panels);

            Presenter.Content = container;
        }
    }
}