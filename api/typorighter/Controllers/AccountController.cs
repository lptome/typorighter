using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using typorighter.Models;
using typorighter.ViewModels;

namespace typorighter.Controllers
{
  [Route("api/account")]
  [ApiController]
  public class AccountController : ControllerBase
  {

    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    {
      this._userManager = userManager;
      this._signInManager = signInManager;
    }



    //Create a Reader account on the blog
    //POST : api/account/register
    [HttpPost("Register")]
    public async Task<Object> RegisterNewReader(RegisterViewModel model)
    {
        var user = new BlogReader() {
          FullName = model.FullName,
          UserName = model.Email,
          Email = model.Email
        };

       try
        {
          var result = await _userManager.CreateAsync(user, model.Password);
          return Ok(result);
        }
        catch (Exception ex)
        {
          throw ex;
        }
    }

    //POST : api/account/login
    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
      var user = await _userManager.FindByEmailAsync(model.Email);
      if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
      {
        await _signInManager.SignInAsync(user, isPersistent: false);
        return Ok();
      }
      else
      {
        return BadRequest(new { message = "Sorry, those credentials don't match our records." });
      }
    }

    }
}
