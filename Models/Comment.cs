using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using TheBlogProject.Enums;

namespace TheBlogProject.Models
{
    public class Comment
    {
        public Comment()
        {
        }

        public int Id { get; set; }

        public int PostId { get; set; }

        public string AuthorId { get; set; }

        public string ModeratorId { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The {0} must b at least {2} and at most {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Comment")]
        public string Body { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime? Updated { get; set; }

        public DateTime? Moderated { get; set; }

        public DateTime? Deleted { get; set; }

        [StringLength(500, ErrorMessage = "The {0} must b at least {2} and at most {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Moderated Comment")]
        public string ModeratedBody { get; set; }

        public ModerationType ModerationType { get; set; }

        // Navigation properties
        public virtual Post Post { get; set; }
        public virtual BlogUser Author { get; set; }
        public virtual BlogUser Moderator { get; set; }
    }
}
