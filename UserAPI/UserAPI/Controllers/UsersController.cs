using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UserAPI.Entity;
using UserAPI.Services;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    [EnableCors("_myAllowSpecificOrigins")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository ??
                throw new ArgumentNullException(nameof(userRepository));

        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            var usersFromRepo = _userRepository.GetUsers();

            return Ok(usersFromRepo);
        }

        [HttpGet]
        [Route("{userName}")]
        public IActionResult GetUser(string userName)
        {
            var userFromRepo = _userRepository.GetUser(userName);
            if (userFromRepo == null)
                return NotFound("User not found!");

            return Ok(userFromRepo);
        }

        [HttpPost]
        [Route("login")]
        public String LoginUser([FromBody] User user)
        {
            var userFromRepo = _userRepository.GetUser(user.Name);
            if (userFromRepo == null)
                return "User not found!";

            if (user.Password != userFromRepo.Password)
                return "Wrong password!";

            return userFromRepo.Name;
        }

        [HttpPost]
        public String CreateUser([FromBody] User user)
        {
            if (_userRepository.UserExists(user.Name))
                return "User already exists!";

            _userRepository.AddUser(user);
            _userRepository.Save();

            var httpWebRequest= (HttpWebRequest)WebRequest.Create("https://scoreapi20200520112737.azurewebsites.net/api/scores");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"UserName\":\"" + user.Name + "\"," +
                              "\"Points\":\"" + 0 + "\"}";

                streamWriter.Write(json);
            }

            string result;

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            if (Int32.Parse(result) != 0)
            {
                return  "Something went wrong!";
            }
            else
            {
                return user.Name;
            }
        }

        [HttpPut]
        [Route("{userName}")]
        public ActionResult UpdateUser(string userName, [FromBody] User user)
        {
            if (!_userRepository.UserExists(userName))
                return NotFound("User not found!");

            var userFromRepo = _userRepository.GetUser(userName);
            if (userFromRepo == null)
                return NotFound("User not found!");

            userFromRepo.Name = user.Name;
            userFromRepo.Password = user.Password;

            _userRepository.UpdateUser(userFromRepo);
            _userRepository.Save();

            return Ok("Update successfully!");
        }

        [HttpDelete]
        [Route("{userName}")]
        public string DeleteUser(string userName)
        {
            var userToDelete = _userRepository.GetUser(userName);

            if (userToDelete == null)
                return "User not found!";

            _userRepository.DeleteUser(userToDelete);
            _userRepository.Save();

            string sURL = "https://scoreapi20200520112737.azurewebsites.net/api/scores/" + userName;

            WebRequest request = WebRequest.Create(sURL);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string result;

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            if (result == "User not found!")
            {
                return "Something went wrong!";
            }
            else
            {
                return "User was deleted successfully!";
            }
        }

        [HttpDelete]
        public string DeleteUsers(string userName)
        {

            var usersFromRepo = _userRepository.GetUsers();


            foreach (var item in usersFromRepo) // Loop through List with foreach
            {
                this.DeleteUser(item.Name);
            }

            return "Good job!";

        }
    }
}
