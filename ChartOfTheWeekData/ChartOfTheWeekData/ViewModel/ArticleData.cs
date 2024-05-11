using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace ChartOfTheWeekData
{
    public class ArticleData
    {
        public ObservableCollection<ArticleModel> Data { get; set; }
        public List<ArticleModel> Blogs { get; set; }
        public List<ArticleModel> SelectedBlogs { get; set; }

        public ArticleData()
        {
            // Platform, icon, title and URL of published blogs for list view
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            using (var stream = executingAssembly.GetManifestResourceStream("ChartOfTheWeekData.Resources.data.json"))
            using (TextReader textStream = new StreamReader(stream))
            {
                var data = textStream.ReadToEnd();
                data = data.Trim();
                Blogs = JsonConvert.DeserializeObject<List<ArticleModel>>(data);
            }

            // Platform, blog count and its category of published blogs for sunburst chart
            Data = new ObservableCollection<ArticleModel>
            {
                new ArticleModel(".NET MAUI",13, "Business Analysis"),
                new ArticleModel(".NET MAUI",1, "Stock Analysis"),
                new ArticleModel(".NET MAUI",3, "Sales Analysis"),
                new ArticleModel(".NET MAUI",5, "Environmental & Climate"),
                new ArticleModel(".NET MAUI",11, "Miscellaneous"),

                new ArticleModel("WPF",4, "Business Analysis"),
                new ArticleModel("WPF",1, "Stock Analysis"),
                new ArticleModel("WPF",2, "Environmental & Climate"),
                new ArticleModel("WPF",7, "Miscellaneous"),

                new ArticleModel("WINUI",2, "Business Analysis"),
                new ArticleModel("WINUI",1, "Environmental & Climate"),
            };

            SelectedBlogs = Blogs.ToList();
        }
    }
}