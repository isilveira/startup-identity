using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using StartupIdentity.Core.Domain.Entities;
using StartupIdentity.Presentations.WebAPP.Models.Account;

namespace StartupIdentity.Presentations.WebAPP.Controllers
{
    public class AccountController : Controller
    {
        private ILogger<AccountController> Logger { get; set; }
        private SignInManager<User> SignInManager { get; set; }
        private UserManager<User> UserManager { get; set; }
        private IEmailSender EmailSender { get; set; }
        public AccountController(
            ILogger<AccountController> logger,
            IEmailSender emailSender,
            SignInManager<User> signInManager,
            UserManager<User> userManager
        )
        {
            Logger = logger;
            EmailSender = emailSender;
            SignInManager = signInManager;
            UserManager = userManager;
        }

        #region SignUp Methods
        public IActionResult SignUp()
        {
            return View(new AccountSignUpViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(AccountSignUpViewModel model)
        {
            string returnUrl = Url.Content("~/");
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User { UserName = model.Email, Email = model.Email };
            var result = await UserManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                Logger.LogInformation("User created a new account with password.");

                var code = await UserManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Action(
                    "ConfirmEmail", "Account",
                    values: new { area = "Identity", userId = user.Id, code = code },
                    protocol: Request.Scheme);

                await EmailSender.SendEmailAsync(model.Email, "Confirm your email",
                    $"Please confirm your account by <a href='{ HtmlEncoder.Default.Encode(callbackUrl) }'>clicking here</a>.");

                if (UserManager.Options.SignIn.RequireConfirmedAccount)
                {
                    return RedirectToAction("SignUpConfirmation", new { email = model.Email });
                }
                else
                {
                    await SignInManager.SignInAsync(user, isPersistent: false);
                    return Redirect(returnUrl);
                }
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }
        public async Task<IActionResult> SignUpConfirmation(string email)
        {
            AccountSignUpConfirmationViewModel model = new AccountSignUpConfirmationViewModel();

            if (email == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var user = await UserManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }

            model.Email = email;
            // Once you add a real email sender, you should remove this code that lets you confirm the account
            model.DisplayConfirmAccountLink = true;
            if (model.DisplayConfirmAccountLink)
            {
                var userId = await UserManager.GetUserIdAsync(user);
                var code = await UserManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                model.EmailConfirmationUrl = Url.Action(
                    "ConfirmEmail", "Account",
                    values: new { userId = userId, code = code },
                    protocol: Request.Scheme);
            }

            return View(model);
        }
        public async Task<IActionResult> SignUpConfirmEmail(string userId, string code)
        {
            AccountSignUpConfirmEmailViewModel model = new AccountSignUpConfirmEmailViewModel();
            if (userId == null || code == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var user = await UserManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await UserManager.ConfirmEmailAsync(user, code);
            model.StatusMessage = result.Succeeded ? "Thank you for confirming your email." : "Error confirming your email.";

            return View(model);
        } 
        #endregion

        #region SignIn Methods
        public IActionResult SignIn()
        {
            return View(new AccountSignInViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(AccountSignInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: true);
            if (result.Succeeded)
            {
                Logger.LogInformation("User signed in.");

                return RedirectToAction("Index", "Home");
            }
            //if (result.RequiresTwoFactor)
            //{
            //    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
            //}
            if (result.IsLockedOut)
            {
                Logger.LogWarning("User account locked out.");
                //return RedirectToPage("./Lockout");

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);
            }
        } 
        #endregion

        #region SignOut Methods
        public IActionResult SignOut()
        {
            return View(new AccountSignOutViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> SignOut(AccountSignOutViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await SignInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Manage Methods
        public async Task<IActionResult> Manage()
        {
            AccountManageViewModel model = new AccountManageViewModel();

            var user = await UserManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{ UserManager.GetUserId(User) }'.");
            }

            var userName = await UserManager.GetUserNameAsync(user);
            var phoneNumber = await UserManager.GetPhoneNumberAsync(user);

            model.UserName = userName;
            model.PhoneNumber = phoneNumber;

            return View(model);
        }
        #endregion
    }
}