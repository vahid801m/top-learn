using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Web.Pages.Admin.Roles
{

    [PermissionChecker(9)]
    public class DeleteRoleModel : PageModel
    {      
        private IPermissionService _permissionSevice;
        public DeleteRoleModel(IPermissionService permissionSevice)
        {
          _permissionSevice = permissionSevice;
        }
        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
          Role=_permissionSevice.GetRoleById(id);
        }
        public IActionResult OnPost()
        {
            _permissionSevice.DeleteRole(Role);
            return RedirectToPage("Index");
        }
    }
}
