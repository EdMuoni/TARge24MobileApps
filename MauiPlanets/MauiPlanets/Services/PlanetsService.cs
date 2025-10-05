using MauiPlanets.Models;
namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Venus",
                Subtitle = "The smallest planet",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. " +
                "It is often called Earth's ' 'twin' or 'sister among the planets' of the" +
                "Solar System for its orbit being the closest to Earth's, " +
                "both being rocky planets, and having the most similar and nearly equal size, mass, and surface gravity. " +
                "Venus, though, is significantly different, especially as it has no liquid water, " +
                "and its atmosphere is far thicker and denser than that of any other rocky body in the Solar System. ",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },

            new()
            {
                Name = "Earth",
                Subtitle = "The only planet with life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life. " +
                "About 29.2% of Earth's surface is land consisting of continents and islands. The remaining 70.8% is covered with water, " +
                "mostly by oceans, seas, gulfs, and other salt-water bodies, but also by lakes, rivers, and other freshwater, which together " +
                "constitute the hydrosphere. Much of Earth's polar regions are covered in ice. Earth's outer layer is divided into several rigid tectonic plates that migrate across the surface over many millions of years.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

            new()
            {
                Name = "Mars",
                Subtitle = "The red planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, being larger than only Mercury. " +
                "In English, Mars carries the name of the Roman god of war and is often referred to as the 'Red Planet' because the iron oxide prevalent on its surface gives it a reddish appearance. " +
                "Mars is a terrestrial planet with a thin atmosphere, with surface features reminiscent both of the impact craters of the Moon and the valleys, deserts, and polar ice caps of Earth.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = "The largest planet",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
                "It is a giant planet with a mass one-thousandth that of the Sun, but two-and-a-half times that of all the other planets in the Solar System combined. " +
                "Jupiter is classified as a gas giant along with Saturn, with the two planets being primarily composed of hydrogen with a quarter of their mass being helium, " +
                "though helium comprises only about a tenth of the number of molecules. It may also have a rocky core of heavier elements, but like the other giant planets, Jupiter lacks a well-defined solid surface.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                },
            },

            new()
            {
                Name = "Saturn",
                Subtitle = "The ringed planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. " +
                "It is a gas giant with an average radius about nine times that of Earth. It has only one-eighth the average density of Earth; " +
                "however, with its larger volume, Saturn is over 95 times more massive. Saturn is named after the Roman god of wealth and agriculture; " +
                "its astronomical symbol (♄) represents the god's sickle. Saturn's interior is probably composed of a core of iron–nickel and rock (silicon and oxygen compounds).",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle = "The ringed planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                "It is a gaseous cyan-coloured ice giant. Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, " +
                "which astronomy calls ice or volatiles. The planets atmosphere has a complex " +
                "layered cloud structure and has the lowest minimum temperature (49 K (−224 °C; −371 °F)) " +
                "of all the Solar System's planets. It has a marked axial tilt of 82.23° with a retrograde rotation period of 17 hours and 14 minutes. " +
                "This means that in an 84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, followed by 42 years of continuous darkness.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                },
            },

            new()
            {
                Name = "Neptune",
                Subtitle = "The windy planet",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest-known Solar planet from the Sun. " +
                "In the Solar System, it is the fourth-largest planet by diameter, the third-most-massive planet, and the densest giant planet. " +
                "Neptune is 17 times the mass of Earth and is slightly more massive than its near-twin Uranus. " +
                "Neptune orbits the Sun once every 164.8 years at an average distance of 30.1 astronomical units (4.5 billion km; 2.8 billion mi). " +
                "It is named after the Roman god of the sea and has the astronomical symbol ♆, a stylised version of the god Neptune's trident.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

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
            },

            new()
            {
                Name = "Pluto",
                Subtitle = "The dwarf planet",
                HeroImage = "pluto.png",
                Description = "Pluto is a dwarf planet in the Kuiper belt, a ring of bodies beyond Neptune. " +
                "It was the first Kuiper belt object to be discovered and is the largest known plutoid (or ice dwarf). " +
                "Pluto was discovered by Clyde Tombaugh in 1930 and was originally considered to be the ninth planet from the Sun. " +
                "After 1992, its status as a planet was questioned following the discovery of several objects of similar size in the Kuiper belt. " +
                "In 2005, Eris, a dwarf planet in the scattered disc which is 27% more massive than Pluto, was discovered. " +
                "This led the International Astronomical Union (IAU) to define the term 'planet' formally in 2006, " +
                "resulting in Pluto's reclassification as a dwarf planet.",
                AccentColorStart = Color.FromArgb("#4e4e4e"),
                AccentColorEnd = Color.FromArgb("#9b9b9b"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2024/03/pluto-new-horizons-pia20291-16x9-1.jpg?resize=768,432",
                    "https://cdn.mos.cms.futurecdn.net/UM8PoLTcrhTqR7zpmVwnDh-970-80.jpg.webp",
                    "https://cdn.mos.cms.futurecdn.net/q7KPZNXUgmsgQXarz5suL6-970-80.jpg.webp"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "The dwarf planet in the asteroid belt",
                HeroImage = "ceres.png",
                Description = "Ceres is a dwarf planet in the asteroid belt between the orbits of Mars and Jupiter. " +
                "It is the largest object in the asteroid belt and the only dwarf planet located in the inner Solar System. " +
                "Ceres was discovered on January 1, 1801, by Giuseppe Piazzi and was the first asteroid to be discovered. " +
                "It is named after the Roman goddess of agriculture and fertility. " +
                "Ceres is composed of a mixture of water ice and various hydrated minerals such as carbonates and clay. " +
                "It is estimated to contain about one-third of the mass of the entire asteroid belt.",
                AccentColorStart = Color.FromArgb("#7a7a7a"),
                AccentColorEnd = Color.FromArgb("#b1b1b1"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/astro/exo-explore/internal_resources/598/Ceres.jpeg?w=1041&h=1041&fit=clip&crop=faces%2Cfocalpoint",
                    "https://cdn.mos.cms.futurecdn.net/qnft8kRfeGWWLgaygo4fb9-650-80.jpg.webp",
                    "https://static.wikia.nocookie.net/expanse/images/7/7f/Cereslevels_s.png/revision/latest/scale-to-width-down/228?cb=20160207102600",
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "The fast spinning dwarf planet",
                HeroImage = "haumea.png",
                Description = "Dwarf planet Haumea was originally designated 2003 EL61 (and nicknamed Santa by one discovery team). " +
                "Haumea is located in the Kuiper Belts, a doughnut-shaped region of icy bodies beyond the orbit of Neptune. " +
                "It is one of the largest objects in the Kuiper Belt and is known for its rapid rotation, ",
                AccentColorStart = Color.FromArgb("#7a7a7a"),
                AccentColorEnd = Color.FromArgb("#b1b1b1"),
                Images = new()
                {
                    "https://www.ecured.cu/images/thumb/9/95/Haumea%2C_Celestia.jpg/260px-Haumea%2C_Celestia.jpg",
                    "https://cdn.britannica.com/66/137066-004-13F11781/rendering-Artist-moons-Haumea.jpg?w=300",
                }
            },

            new()
            {
                Name = "MakeMake",
                Subtitle = "The dwarf planet",
                HeroImage = "makemake.png",
                Description = "Dwarf planet Makemake – along with Pluto, " +
                "Haumea, and Eris – is located in the Kuiper Belt, " +
                "a donut-shaped region of icy bodies beyond the orbit of Neptune." +
                "Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto is the brightest. " +
                "It takes about 305 Earth years for this dwarf planet to make one trip around the Sun." +
                "Makemake holds an important place in the history of solar system studies because it was one of the objects – " +
                "along with Eris – whose discovery prompted the International Astronomical Union to " +
                "reconsider the definition of a planet, and to create the new group of dwarf planets.",
                AccentColorStart = Color.FromArgb("#7a7a7a"),
                AccentColorEnd = Color.FromArgb("#b1b1b1"),
                Images = new()
                {
                    "https://apod.nasa.gov/apod/image/0807/makemake_nasa.jpg",
                    "https://nineplanets.org/wp-content/uploads/2019/09/makemake.png",
                    "https://myspacemuseum.com/wp-content/uploads/2023/11/What-Is-Makemake.jpg"
                }

            },

            new()
            {
                Name = "Eris",
                Subtitle = "The largest dwarf planet",
                HeroImage = "eris.png",
                Description = "Eris is one of largest the dwarf planets in our solar system. " +
                "It's about the same size as Pluto, but it's three times farther from the Sun." +
                "The discovery of Eris help trigger a debate in the scientific community that " +
                "led to the International Astronomical Union's decision in 2006 to clarify the " + 
                "definition of a planet. Pluto, Eris, and other similar objects are now classified as dwarf planets. " +
                "Eris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003, " + 
                "during a Palomar Observatory survey of the outer solar system by Mike Brown, " + 
                "a professor of planetary astronomy at the California Institute of Technology; " +
                "Chad Trujillo of the Gemini Observatory; and David Rabinowitz of Yale University. ",
                AccentColorStart = Color.FromArgb("#7a7a7a"),
                AccentColorEnd = Color.FromArgb("#b1b1b1"),
                Images = new()
                {
                    "https://nineplanets.org/wp-content/uploads/2019/09/eris-300x225.png",
                    "https://scx1.b-cdn.net/csz/news/800a/2023/dwarf-planet-eris-is-s.jpg",
                    "https://www.astronomytrek.com/wp-content/uploads/2018/02/Eris-678x381.png"
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
