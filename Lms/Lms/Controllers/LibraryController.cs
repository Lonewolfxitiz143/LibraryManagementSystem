using Lms.ModelEntities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;


namespace Lms.Controllers
{
    public class LibraryController : Controller
    {


        private string Url = "https://localhost:7047/api/Student/";
        private HttpClient Client =new HttpClient();//A class used to request and Response http form source url
      
        [HttpGet]
        public async Task <IActionResult> Dashboard()
        {
            List<Library> data = new List<Library>();
          HttpResponseMessage response = await Client.GetAsync(Url);//Get data in form of JSON
            if (response.IsSuccessStatusCode) { 
                string result = await response.Content.ReadAsStringAsync();//Store JSON to string variables
                var List =JsonConvert.DeserializeObject<List<Library>>(result);//Convert JSON to list
                if (List!=null)
                {
                    data = List;
                }
            }
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Create(Library obj)
        {
            string _data =  JsonConvert.SerializeObject(obj);//CONVERT DATA INTO JSON
            StringContent _content = new StringContent(_data,Encoding.UTF8,"application/json");//Convert json into formated text
            HttpResponseMessage _message = await Client.PostAsync(Url, _content);
            if (_message.IsSuccessStatusCode) {

                return RedirectToAction("Dashboard");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            HttpResponseMessage _response = await Client.DeleteAsync(Url+id);
            if (_response.IsSuccessStatusCode) {
                return RedirectToAction("Dashboard");
            
            }
            return View();
        }

    }
}  
