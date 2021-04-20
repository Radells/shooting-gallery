
namespace shooting_gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            Civilian visitor1 = new Civilian("Антон Бурмистров", "05.06.2000", "М", "M4A1",true);
            Military visitor2 = new Military("Максим Пентешихин", "15.05.1995", "М", "AK-47");
            Civilian visitor3 = new Civilian("Анна Шеховцова", "24.02.1988", "Ж", "USP", false);
            ShootingGallery shootingGallery = new ShootingGallery();
            shootingGallery.GetGun(visitor1);
            shootingGallery.GetGun(visitor2);
            shootingGallery.GetGun(visitor3);
        }
    }
}
