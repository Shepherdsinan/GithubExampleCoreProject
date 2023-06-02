using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using GithubExampleCoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;

    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IToastNotification _toastNotification;

        public CityController(IDestinationService destinationService, IToastNotification toastNotification)
        {
            _destinationService = destinationService;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            var values = String.Empty;
            try
            {
                destination.Status = true;
                _destinationService.TAdd(destination);
                values = JsonConvert.SerializeObject(destination);
            }
            catch (Exception e)
            {
                _toastNotification.AddWarningToastMessage("Hata:"+e.Message);
            }
            return Json(values);
        }

        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.TGetByID(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            _toastNotification.AddInfoToastMessage("Silme Başarılı");
            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            _toastNotification.AddSuccessToastMessage("Güncelleme Başarılı");
            return Json(v);
        }

        //public static List<CityClass> cities = new List<CityClass>
        //{
        //    new CityClass
        //    {
        //        CityID=1,
        //        CityName="Üsküp",
        //        CityCountry="Makedonya"
        //    },
        //    new CityClass
        //    {
        //        CityID=2,
        //        CityName="Roma",
        //        CityCountry="İtalya"
        //    },
        //    new CityClass
        //    {
        //        CityID=3,
        //        CityName="Londra",
        //        CityCountry="İngiltere"
        //    }
        //};


    }