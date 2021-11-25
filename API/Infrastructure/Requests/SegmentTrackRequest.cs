using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Infrastructure.Requests
{
    public class SegmentTrackRequest
    {
        /// <summary>
        /// The ID for this user.
        /// </summary>
        [Required]
        public string UserId { get; set; }
        
        /// <summary>
        /// The name of the event you’re tracking.
        /// Human-readable names like Song Played or Status Updated is recommended.
        /// </summary>
        [Required]
        public string Event { get; set; }
        
        /// <summary>
        /// A dictionary of properties for the event.
        /// If the event was Product Added to cart, it might have properties like price or product.
        /// </summary>
        public IDictionary<string, object> Properties { get; set; }
    }
}
