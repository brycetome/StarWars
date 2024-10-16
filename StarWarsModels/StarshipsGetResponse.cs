namespace StarWarsModels
{
    public class StarshipsGetResponse
    {
        public string count { get; set; } = "";
        public string next { get; set; } = "";
        public string previous { get; set; } = "";
        public StarshipAPI[] results { get; set; } = [];
    }
}
