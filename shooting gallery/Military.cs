
namespace shooting_gallery
{
    public class Military : Visitor
    {
        public Military(string FIO, string dateBirth, string gender, string gun)
            : base(FIO, dateBirth, gender, gun)
        {
            this.FIO = FIO;
            this.DateBirth = dateBirth;
            this.Gender = gender;
            this.Gun = gun;
        }
    }
}
