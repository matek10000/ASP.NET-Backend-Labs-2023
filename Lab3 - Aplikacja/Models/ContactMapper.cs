using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Lab3___Aplikacja.Models
{
    public class ContactMapper
    {
        public static ContactEntity ToEntity(Kontakt model)
        {
            return new ContactEntity()
            {
                Name = model.Name,
                Email = model.Email,
                Birth = model.Birth,
                Phone = model.Phone,
                ContactId = model.Id,
                OrganizationId = (int)model.OrganizationId
            };
        }

        public static Kontakt FromEntity(ContactEntity entity)
        {
            return new Kontakt()
            {
                Name = entity.Name,
                Email = entity.Email,
                Birth = (DateTime)entity.Birth,
                Phone = entity.Phone,
                Id = entity.ContactId,
                OrganizationId = entity.OrganizationId

            };
        }
    }
}
