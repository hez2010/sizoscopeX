using Avalonia.Controls;
using sizoscopeX.ViewModels;

namespace sizoscopeX
{
    public partial class RootView : UserControl
    {
        private readonly RootViewModel _viewModel;

        [Obsolete("Should not be called except by XAML designer.")]
        public RootView()
        {
            InitializeComponent();
            _viewModel = default!;
        }

        protected override void OnLoaded()
        {
            if (TopLevel.GetTopLevel(this) is Window window)
            {
                window.Title = "Root View - sizoscopeX";
            }
        }

        public RootView(MstatData.Node node)
        {
            InitializeComponent();
            _viewModel = new RootViewModel(node);
            DataContext = _viewModel;
        }
    }
}