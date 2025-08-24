using Microsoft.AspNetCore.Mvc;
using UnknownAgency.Models;

namespace UnknownAgency.Components
{
    public class ContactViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("~/Views/Partials/Forms/ContactForm.cshtml", new ContactFormViewModel());
        }
    }
}
