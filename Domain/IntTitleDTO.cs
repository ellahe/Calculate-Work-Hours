namespace WorkHourCalculator.Domain
{
    public class IntTitleDTO
    {
        public IntTitleDTO(int iD, string title)
        {
            ID = iD;
            Title = title;
        }

        public int ID { get; set; }
        public string Title { get; set; }
    }
}
