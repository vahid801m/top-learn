using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.User;


namespace TopLearn.Web.Pages.Admin.Roles
{
    [PermissionChecker(7)]
    public class CreateRoleModel : PageModel
    {
        private IPermissionService _permissionSevice;
        public CreateRoleModel(IPermissionService permissionSevice)
        {
            _permissionSevice = permissionSevice;
        }
        [BindProperty]
        public Role Role { get; set; }
        public void OnGet()
        {
           ViewData["Permission"]= _permissionSevice.GetAllPermission();
        }
        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Role.IsDelete = false;
            int roleId = _permissionSevice.AddRole(Role);

            _permissionSevice.AddPermissionsToRole(roleId,SelectedPermission);
            return RedirectToPage("Index");


        }
    }
}
