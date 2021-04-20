using System;

namespace shooting_gallery
{
    public class ShootingGallery
    {
        private string[] warehouseGun;
        public ShootingGallery()
        {
            warehouseGun = new string []
            {
                "AK-47",
                "AWP",
                "USP",
                "P90",
                "M4A1"
            };
        }
        public void GetGun(object visitor)
        {
            if(visitor is Civilian)
            {
                var visitorCivilian = visitor as Civilian;
                Console.WriteLine($"гражданский {visitorCivilian.FIO} запросил оружие {visitorCivilian.Gun}");
                if (visitorCivilian.license == true)
                {
                    Console.WriteLine("поиск оружия на складе");
                    for(var i =0; i< warehouseGun.Length; i++)
                    {
                        if(warehouseGun[i].Equals(visitorCivilian.Gun))
                        {
                            Console.WriteLine($"{visitorCivilian.FIO} получил оружие {visitorCivilian.Gun}");
                            Console.WriteLine($"{visitorCivilian.FIO} стреляет из автомата {visitorCivilian.Gun}");
                        }
                        else
                        {
                            if (i == warehouseGun.Length-1) { Console.WriteLine("Оружие не найдено на складе"); }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Отказано в выдаче оружия из-за отсутствия лицензии");
                }
            }
            else
            {
                var visitorMilitary = visitor as Military;
                Console.WriteLine($"военный {visitorMilitary.FIO} запросил оружие {visitorMilitary.Gun}");
                Console.WriteLine($"{visitorMilitary.FIO} получил оружие {visitorMilitary.Gun}");
                Console.WriteLine($"{visitorMilitary.FIO} стреляет из автомата {visitorMilitary.Gun}");
            }
        }
    }
}
