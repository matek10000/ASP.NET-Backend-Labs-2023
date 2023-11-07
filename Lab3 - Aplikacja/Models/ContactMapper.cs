using Data.Entities;

namespace Lab3___Aplikacja.Models
{
    public class ContactMapper
    {
        public static ContactEntity ToEntity(Kontakt model)
        {
            return new ContactEntity()
            {
                Name = model.Nazwa,
                Email = model.Email,
                Birth = model.Dataur,
                Phone = model.Telefon,
                ContactId = model.Id
            };
        }

        public static Kontakt FromEntity(ContactEntity entity)
        {
            return new Kontakt()
            {
                Nazwa = entity.Name,
                Email = entity.Email,
                Dataur = (DateTime)entity.Birth,
                Telefon = entity.Phone,
                Id = entity.ContactId

            };
        }
    }
}
