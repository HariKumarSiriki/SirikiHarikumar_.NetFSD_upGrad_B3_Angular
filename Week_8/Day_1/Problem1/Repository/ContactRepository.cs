using Dapper;
using WebApplication4.Models;
using WebApplication4.Repository;

namespace WebApplication4.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly DapperContext _context;

        public ContactRepository(DapperContext context)
        {
            _context = context;
        }

    
        public List<ContactInfo> GetAllContacts()
        {
            var db = _context.CreateConnection();

            string sqlQuery = @"
                SELECT c.*, comp.CompanyName, d.DepartmentName
                FROM ContactInfo c
              INNER JOIN Company comp ON c.CompanyId = comp.CompanyId
               INNER JOIN Department d ON c.DepartmentId = d.DepartmentId";

            return db.Query<ContactInfo>(sqlQuery).ToList();
        }

        
        public ContactInfo GetContactById(int id)
        {
            var db = _context.CreateConnection();

            string sqlQuery = @"
                SELECT c.*, comp.CompanyName, d.DepartmentName
                FROM ContactInfo c
                INNER JOIN Company comp ON c.CompanyId = comp.CompanyId
                INNER JOIN Department d ON c.DepartmentId = d.DepartmentId
                WHERE c.ContactId = @Id";

            return db.QueryFirstOrDefault<ContactInfo>(sqlQuery, new { Id = id });
        }

     
        public void AddContact(ContactInfo contact)
        {
            var db = _context.CreateConnection();

            string sqlQuery = @"
                INSERT INTO ContactInfo
                (FirstName, LastName, EmailId, MobileNo, Designation, CompanyId, DepartmentId)
                VALUES (@FirstName, @LastName, @EmailId, @MobileNo, @Designation, @CompanyId, @DepartmentId)";

            db.Execute(sqlQuery, contact);
        }

    
        public void UpdateContact(ContactInfo contact)
        {
            var db = _context.CreateConnection();

            string sqlQuery = @"
                UPDATE ContactInfo
                SET FirstName=@FirstName,
                    LastName=@LastName,
                    EmailId=@EmailId,
                    MobileNo=@MobileNo,
                    Designation=@Designation,
                    CompanyId=@CompanyId,
                    DepartmentId=@DepartmentId
                WHERE ContactId=@ContactId";

            db.Execute(sqlQuery, contact);
        }

     
        public void DeleteContact(int id)
        {
            var db = _context.CreateConnection();

            string sqlQuery = "DELETE FROM ContactInfo WHERE ContactId=@Id";

            db.Execute(sqlQuery, new { Id = id });
        }

       
        public List<Company> GetCompanies()
        {
            var db = _context.CreateConnection();

            return db.Query<Company>("SELECT * FROM Company").ToList();
        }

       
        public List<Department> GetDepartments()
        {
            var db = _context.CreateConnection();

            return db.Query<Department>("SELECT * FROM Department").ToList();
        }
    }
}