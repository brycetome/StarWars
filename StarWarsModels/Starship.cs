namespace StarWarsModels
{
    public class Starship
    {
        public int Id { get; set; }
        public string MGLT { get; set; } = "";
        public string CargoCapacity { get; set; } = "";
        public string Consumables { get; set; } = "";
        public string CostInCredits { get; set; } = "";
        public DateTime? Created { get;set; }
        public string Crew { get; set; } = "";
        public DateTime? Edited { get;set; }
        public double HyperDriveRating { get; set; }
        public double Length { get; set; }
        public string Manufacturer { get; set; } = "";
        public string MaxAtomspheringSpeed { get; set; } = "";
        public string Model { get; set; } = "";
        public string Name { get; set; } = "";
        public int Passengers { get; set; }
        public string[] Films { get; set; } = [];
        public string[] Pilots { get; set; } = [];
        public string StarshipClass { get; set; } = "";
        public string URL { get; set; } = "";

        public Starship() { }

        public Starship(StarshipAPI api)
        {
            MGLT = api.MGLT;
            CargoCapacity = api.cargo_capacity;
            Consumables = api.consumables;

            CostInCredits = api.cost_in_credits;


            if(DateTime.TryParse(api.created, out DateTime dateTime))
                Created = dateTime.ToUniversalTime();

            Crew = api.crew;

            if (DateTime.TryParse(api.edited, out DateTime dateTime2))
                Edited = dateTime.ToUniversalTime();

            if (double.TryParse(api.hyperdrive_rating, out double val))
                HyperDriveRating = val;

            if(double.TryParse(api.length, out double val2))
                Length = val2;

            Manufacturer = api.manufacturer;
            MaxAtomspheringSpeed = api.max_atmosphering_speed;
            Model = api.model;
            Name = api.name;

            _ = int.TryParse(api.passengers, out int passengerNumber);
            Passengers = passengerNumber;

            Films = api.films;
            Pilots = api.pilots;
            StarshipClass = api.starship_class;
            URL = api.url;
        }
    }
}
