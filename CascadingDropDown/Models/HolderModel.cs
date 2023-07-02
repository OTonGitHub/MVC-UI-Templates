using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CascadingDropDown.Models
{
    public class HolderModel
    {
        [Required]
        [Display(Name = "Parent")]
        public int ParentID { get; set; }


        [Display(Name = "Pure Javascript (ViewBag)")]
        public int ChildID { get; set; }


        [Display(Name = "JQUERY and Ajax (JSON)")]
        public int GrandChildID { get; set; }

        
        [Display(Name = "Pure Javascript + XHR/Fetch")]
        public int GreatGrandChildID { get; set; }

        public List<SelectListItem>? GrandChildren { get; set; }
    }
}
