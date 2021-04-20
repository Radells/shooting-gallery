
namespace shooting_gallery
{
    public class Civilian : Visitor
    {
        public bool License { get; private set;}
        public Civilian(string FIO, string dateBirth, string gender, string gun,bool license)
            :base(FIO, dateBirth, gender, gun)
        {
            this.FIO = FIO;
            this.DateBirth = dateBirth;
            this.Gender = gender;
            this.Gun = gun;
            this.License = license;
        }
    }
}
