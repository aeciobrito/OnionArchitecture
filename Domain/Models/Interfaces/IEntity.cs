namespace Domain.Models.Interfaces
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public bool Validate();
        public void Deactivate();
    }
}
