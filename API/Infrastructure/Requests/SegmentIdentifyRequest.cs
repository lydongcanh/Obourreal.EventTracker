using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Infrastructure.Requests
{
    public class SegmentIdentifyRequest
    {
        /// <summary>
        /// The ID for this user.
        /// </summary>
        [Required]
        public string UserId { get; set; }

        /// <summary>
        /// A dictionary of traits you know about the user. Things like: email, name or friends.
        /// </summary>
        public IDictionary<string, object> Traits { get; set; }
    }
}
