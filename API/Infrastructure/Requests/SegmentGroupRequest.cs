using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Infrastructure.Requests
{
    public class SegmentGroupRequest
    {
        /// <summary>
        /// The ID for this user.
        /// </summary>
        [Required]
        public string UserId { get; set; }

        /// <summary>
        /// The ID for this group.
        /// </summary>
        [Required]
        public string GroupId { get; set; }
        
        /// <summary>
        /// A dictionary of traits you know about the group. Things like: ma,e or website.
        /// </summary>
        public IDictionary<string, object> Traits { get; set; }
    }
}
