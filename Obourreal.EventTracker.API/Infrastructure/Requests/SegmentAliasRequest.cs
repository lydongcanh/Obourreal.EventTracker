using System.ComponentModel.DataAnnotations;

namespace Obourreal.EventTracker.API.Infrastructure.Requests
{
    public class SegmentAliasRequest
    {
        /// <summary>
        /// The previous ID for this user.
        /// </summary>
        [Required]
        public string PreviousId { get; set; }
        
        /// <summary>
        /// The ID for this user.
        /// </summary>
        [Required]
        public string UserId { get; set; }
    }
}
