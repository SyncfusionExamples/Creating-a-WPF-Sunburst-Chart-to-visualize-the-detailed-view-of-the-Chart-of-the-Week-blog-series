using Syncfusion.UI.Xaml.SunburstChart;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;

namespace ChartOfTheWeekData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var hyperlink = (Hyperlink)sender;
            var url = hyperlink.NavigateUri.AbsoluteUri;
            System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private bool isSegmentSelected = false;

        private void SfSunburstChart_SelectionChanged(object sender, SunburstSelectionChangedEventArgs e)
        {
            var selectedSegment = e.SelectedSegment;
            string? segmentName = "";

            if (selectedSegment != null && !isSegmentSelected)
            {
                isSegmentSelected = true;
                segmentName = (selectedSegment.Parent?.Category ?? e.SelectedSegment.Category)?.ToString();
                viewModel.SelectedBlogs.Clear();
                var blogsToAdd = viewModel.Blogs.Where(b => b.Platform == segmentName).ToList();

                foreach (var blog in blogsToAdd)
                {
                    viewModel.SelectedBlogs.Add(blog);
                }

                listView.Items.Refresh();
            }
            else if (isSegmentSelected)
            {
                viewModel.SelectedBlogs.Clear();
                foreach (var blog in viewModel.Blogs)
                {
                    viewModel.SelectedBlogs.Add(blog);
                }

                listView.Items.Refresh();
                isSegmentSelected = false;
            }
        }
    }
}