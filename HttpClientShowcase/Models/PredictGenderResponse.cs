namespace HttpClientShowcase.Models
{
    public class PredictGenderResponse
    {
        public int Count { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public float Probability { get; set; }
    }

}
