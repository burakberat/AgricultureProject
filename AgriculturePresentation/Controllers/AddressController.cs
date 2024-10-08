using AgricultureBusinessLayer.Abstract;
using AgricultureBusinessLayer.ValidationRules;
using AgricultureEntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;
        private readonly AddressValidator _validationRules;

        public AddressController(IAddressService addressService, AddressValidator validationRules)
        {
            _addressService = addressService;
            _validationRules = validationRules;
        }

        public IActionResult Index()
        {
            var values = _addressService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var value = _addressService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditAddress(Address address)
        {
            ValidationResult result = _validationRules.Validate(address);
            if (result.IsValid)
            {
                _addressService.Update(address);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
