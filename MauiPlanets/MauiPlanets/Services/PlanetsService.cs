using MauiPlanets.Models;
namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the " +
                "smallest in the Solar System. It is a rocky planet with a trace atmosphere " +
                "and a surface gravity slightly higher than that of Mars. The surface of " +
                "Mercury is similar to Earth's Moon, being heavily cratered, with an " +
                "expansive rupes system generated from thrust faults, and bright ray " +
                "systems, formed by ejecta. Its largest crater, Caloris Planitia, " +
                "has a diameter of 1,550 km (960 mi), which is about one-third the " +
                "diameter of the planet (4,880 km or 3,030 mi).",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
            .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2).
                ToList();
        }

        public static List<Planet> GetAllPlanets()
         => planets;
    }
}
