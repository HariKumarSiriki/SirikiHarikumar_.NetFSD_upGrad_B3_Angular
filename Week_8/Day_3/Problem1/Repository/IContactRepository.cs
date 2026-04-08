using WebApplication6.Models;


namespace WebApplication6.Repositories
{
    public interface IContactRepository
    {
        List<ContactInfo> GetAll();
        ContactInfo GetById(int id);
        void Add(ContactInfo contact);
        void Update(int id, ContactInfo contact);
        void Delete(int id);
    }
}