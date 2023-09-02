using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TopLearn.Core.DTOs;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.Users
{
    [PermissionChecker(3)]
    public class CreateUserModel : PageModel
    {
      
        private IUserService _userService;
        private IPermissionService _permissionSevice;

        public CreateUserModel(IPermissionService permissionSevice , IUserService userService)
        {
            _permissionSevice = permissionSevice;
            _userService = userService;
        }


        [BindProperty]
        public CreateUserViewModel CreateUserViewModel { get; set; }
        public void OnGet()
        {
            ViewData["Roles"]=_permissionSevice.GetRoles();
        }
        public IActionResult OnPost(List <int> SelctedRoles)
        {
           if(!ModelState.IsValid)
            {
                return Page();
            }
            int userId = _userService.AddUserFromAdmin(CreateUserViewModel);

            //Add Roles
            _permissionSevice.AddRolesToUser(SelctedRoles, userId);


            return Redirect("/Admin/Users");
        }
    }
}
