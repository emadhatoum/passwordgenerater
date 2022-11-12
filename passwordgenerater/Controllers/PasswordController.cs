using Microsoft.AspNetCore.Mvc;
using passwordgenerater.Models;

namespace passwordgenerater.Controllers
{
    public class PasswordController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            PasswordViewModel generatePassword = new PasswordViewModel();
            return View(generatePassword);
        }

        [HttpPost]
        public IActionResult GeneratePassword(int passwordLength)
        {
           PasswordViewModel generatePassword = new PasswordViewModel();
            string results = "";
            // ceart string with all the charchetrs(@#$%ghytes) loop through the string  and the loop will be the password length
            // inside the loop we will add each charchter to the string 
            int starterChar = 33;
            int enderChar = 126;
            Random random = new Random();
            for(int i = 0; i < passwordLength; i++)
            {
                int charIntValue = random.Next(starterChar, enderChar);
                char letter = Convert.ToChar(charIntValue);
                results += letter; 
            }
            string Password = results;
            generatePassword.PasswordResults = Password;
     
            return View("Index", generatePassword);
        }


    }
}
