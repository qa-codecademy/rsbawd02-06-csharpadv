namespace Generics.Models
{
    public class Order : BaseEntity
    {
        public string Reciever { get; set; }
        public string Address { get; set; }

        public override string GetInfo()
        {
            return $"{Id} - {Reciever} {Address}";
        }
    }
}
