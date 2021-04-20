
namespace shooting_gallery
{
    public class Visitor
    {
        public string FIO { get; set; }
        public string DateBirth { get; set; }
        public string Gender { get; set; }
        public string Gun { get; set; }

        public Visitor(string FIO, string dateBirth, string gender, string gun)
        {
            this.FIO = FIO;
            this.DateBirth = dateBirth;
            this.Gender = gender;
            this.Gun = gun;
        }
    }
}
