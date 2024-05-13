namespace ChartOfTheWeekData
{
    public class ArticleModel
    {
        public string? Platform { get; set; }
        public double Count { get; set; }
        public string? Icon { get; set; }
        public string? Category { get; set; }
        public string? Name { get; set; }
        public string? URL { get; set; }

        // ListView ItemSource
        public ArticleModel()
        {

        }

        // Chart ItemSource
        public ArticleModel(string platform, double count , string category)
        {
            Platform = platform;
            Count = count;
            Category = category;
        }
    }
}