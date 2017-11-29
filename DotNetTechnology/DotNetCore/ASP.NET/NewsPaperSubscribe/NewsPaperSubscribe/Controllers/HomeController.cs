using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPaperSubscribe.Models;
using NewsPaperSubscribe.Repository.NewsPaperSubscribe;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewsPaperSubscribe.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsPaperSubscribeRepository _NewsPaperSubscribeRepository;

        public HomeController(INewsPaperSubscribeRepository newsPaperSubscribeRepository)
        {
            _NewsPaperSubscribeRepository = newsPaperSubscribeRepository;
        }
        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _NewsPaperSubscribeRepository.GetAllClientsDetailAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create( ClientDetails clientDetails)
        {
            if (ModelState.IsValid)
            {
                await _NewsPaperSubscribeRepository.AddClientAsync(clientDetails);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update([FromBody] ClientDetails updateDetails, [FromRoute] int id)
        {
            if (ModelState.IsValid)
            {
                if (await _NewsPaperSubscribeRepository.IsClientExistsAsync(id))
                {
                    await _NewsPaperSubscribeRepository.EditClientAsync(updateDetails);
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Something went wrong,please try again!");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (ModelState.IsValid)
            {
                ClientDetails removeClient =await _NewsPaperSubscribeRepository.GetClientByIdAsync(id);
                if (removeClient != null)
                {
                    await _NewsPaperSubscribeRepository.DeleteClientAsync(removeClient);
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("", "Something went Wrong, please try again!");
            return View();
        }
    }
}
