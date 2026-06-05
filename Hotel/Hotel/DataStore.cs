using System.Collections.Generic;

namespace Hotel
{
    static class DataStore
    {
        public static string[] Categories = new string[]
        {
            "1-местный",
            "2-местный",
            "Семейный",
            "1-местный люкс",
            "2-местный люкс",
            "Семейный люкс"
        };

        public static Dictionary<string, List<HotelInfo>> Directions = new Dictionary<string, List<HotelInfo>>();

        static DataStore()
        {
            var sochi = new List<HotelInfo>();
            sochi.Add(MakeHotel("Жемчужина", "sochi_zhemchuzhina", 3000,
                "Отель в центре Сочи, 5 минут до моря. Рядом дендрарий и набережная. " +
                "Бесплатная парковка, Wi-Fi на всей территории, завтрак включён в стоимость."));
            sochi.Add(MakeHotel("Морская волна", "sochi_morskaya", 2500,
                "Уютная гостиница недалеко от Олимпийского парка. Рядом торговый центр и кафе. " +
                "Платная парковка, бесплатный Wi-Fi, завтрак за отдельную плату."));
            Directions.Add("Сочи", sochi);

            var kazan = new List<HotelInfo>();
            kazan.Add(MakeHotel("Казанские купола", "kazan_kupola", 2800,
                "В шаге от Кремля и улицы Баумана. Рядом сувенирные лавки и рестораны татарской кухни. " +
                "Бесплатная парковка, Wi-Fi, завтрак включён."));
            kazan.Add(MakeHotel("Волга", "kazan_volga", 2300,
                "Гостиница на берегу Волги, красивый вид из окон. Рядом аквапарк и парк. " +
                "Парковка бесплатная, Wi-Fi есть, завтрак не включён."));
            Directions.Add("Казань", kazan);

            var spb = new List<HotelInfo>();
            spb.Add(MakeHotel("Северная столица", "spb_stolica", 3900,
                "Исторический центр, рядом Эрмитаж и Дворцовая площадь. Множество музеев в пешей доступности. " +
                "Платная парковка, бесплатный Wi-Fi, завтрак включён в стоимость."));
            spb.Add(MakeHotel("Нева", "spb_neva", 3300,
                "Вид на Неву, недалеко от Невского проспекта. Рядом театры и кафе. " +
                "Парковка платная, Wi-Fi бесплатный, завтрак за дополнительную плату."));
            Directions.Add("Санкт-Петербург", spb);

            var krym = new List<HotelInfo>();
            krym.Add(MakeHotel("Ласточкино гнездо", "krym_lastochka", 3800,
                "Ялта, первая линия у моря. Рядом набережная и канатная дорога. " +
                "Бесплатная парковка, Wi-Fi, завтрак включён, собственный пляж."));
            krym.Add(MakeHotel("Южный берег", "krym_yuzhny", 2900,
                "Тихий район Алушты, в окружении гор. Рядом дельфинарий и рынок. " +
                "Парковка бесплатная, Wi-Fi есть, завтрак включён в стоимость номера."));
            Directions.Add("Крым", krym);
        }

        static HotelInfo MakeHotel(string name, string imageKey, int basePrice, string desc)
        {
            var h = new HotelInfo();
            h.Name = name;
            h.ImageKey = imageKey;
            h.Description = desc;

            h.Prices[Categories[0]] = basePrice;
            h.Prices[Categories[1]] = basePrice + 1200;
            h.Prices[Categories[2]] = basePrice + 2000;
            h.Prices[Categories[3]] = basePrice + 3000;
            h.Prices[Categories[4]] = basePrice + 4500;
            h.Prices[Categories[5]] = basePrice + 6000;

            return h;
        }
    }
}
