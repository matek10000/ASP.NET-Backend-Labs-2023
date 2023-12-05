using Lab3___Aplikacja.Controllers;
using Lab3___Aplikacja.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Lab9___Test
{
    public class ContactControllerTest
    {

        private KontaktController _controller;
        private IContactService _service;

        public ContactControllerTest()
        {
            _service = new MemoryContactService();
            _service.Add(new Kontakt() { Id = 1 });
            _service.Add(new Kontakt() { Id = 2 });
            _controller = new KontaktController(_service);
        }

        [Fact]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as List<Kontakt>;
            Assert.Equal(2, model.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void DetailTest(int id)
        {
            var result = _controller.Details(id);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Kontakt;
            Assert.Equal(id, model.Id);
        }

        [Fact]
        public void DetailsTestForNonExistingContact()
        {
            var result = _controller.Details(3);
            Assert.IsType<ViewResult>(result);
        }

    }
}