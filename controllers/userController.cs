//using System.ComponentModel.DataAnnotations;
using lumni.data;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results; 
using FluentValidation;



namespace user.controllers
{
    public class userController : Controller
    {
        [HttpPost ("/saveuser")]
        public static async Task<string> saveProduct ([FromBody]User user)
        {
            userValidator validator = new userValidator();
            ValidationResult result = validator.Validate(user);
            using (var dbpg = new pgsql())
            {
                dbpg.users.Add(user);
                await dbpg.SaveChangesAsync();
            }
            return "SUCCESS";
        }
    }
}