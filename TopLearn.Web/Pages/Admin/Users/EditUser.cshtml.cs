using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TopLearn.Core.DTOs;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.Users
{
    [PermissionChecker(4)]
    public class EditUserModel : PageModel
    {
        private IUserService _userServise;
        private IPermissionService _permissionSevice;
        public EditUserModel(IUserService userService ,IPermissionService permissionSevice)
        {
            _userServise = userService;
            _permissionSevice = permissionSevice;
        }

        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }
        public void OnGet(int id)
        {
            EditUserViewModel=_userServise.GetUserForShowInEditMode(id);
            ViewData["Roles"]=_permissionSevice.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _userServise.EditUserFromAdmin(EditUserViewModel);

            //Edit Roles
            _permissionSevice.EditRolesUser(EditUserViewModel.UserId, SelectedRoles);
            return RedirectToPage("Index");
        }
    }
}
