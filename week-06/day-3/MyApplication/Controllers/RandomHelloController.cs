using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    [Route("randomhellos")]
    public class RandomHelloController : Controller
    {
        public IActionResult RandomHellos()
        {
            var hellos = new string[] {"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
                "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
                "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
                "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};
            var colors = new string[] { "#22223b", "#4a4e69", "#9a8c98", "#c9ada7", "#5f0f40"};

            var randomHello = hellos[new Random().Next(0, 50)];
            var randomColor = colors[new Random().Next(0, 5)];
            var randomFontSize = $"{new Random().Next(16, 50)}px";

            var hello = new GreetingNational(randomHello, randomColor, randomFontSize);
            return View(hello);
        }
    }
}
