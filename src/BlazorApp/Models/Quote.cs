namespace BlazorApp.Models
{
    public enum TagType
    {
        MOVIE,
        SONG,
        TV_SERIES,
        PERSONALITY,
        STORY
    }

    public class Quote
    {
        public string ImageName { get; set; }
        public string Title { get; set; }
        public string QuoteString { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Tag {  get; set; }

        public string GetTagIconName()
        {
            TagType? tagType = null;
            try
            {
                tagType = Enum.Parse<TagType>(Tag.Replace(" ", "_"), true);
            }
            catch (Exception _) { }

            switch (tagType)
            {
                case TagType.MOVIE:
                    return "fa fa-film";
                case TagType.TV_SERIES:
                    return "fa fa-tv";
                case TagType.SONG:
                    return "fa fa-music";
                case TagType.PERSONALITY:
                    return "fa fa-user";
                case TagType.STORY:
                    return "fa fa-book";
                default:
                    return "";
            }
        }
    }
}
