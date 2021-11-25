using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Obourreal.EventTracker.API.Infrastructure.Requests
{
    public class SegmentPageRequest
    {
        /// <summary>
        /// The ID for this user.
        /// </summary>
        [Required]
        public string UserId { get; set; }
        
        /// <summary>
        /// The webpage name you’re tracking.
        /// Human-readable names like Song Played or Status Updated is recommended.
        /// </summary>
        [Required]
        public string Name { get; set; }
        
        /// <summary>
        /// The webpage category.
        /// If you’re making a news app, the category could be Sports.
        /// </summary>
        [Required]
        public string Category { get; set; }
        
        /// <summary>
        /// A dictionary of properties for the event.
        /// If the event was Product Added to cart, it might have properties like price or product.
        /// </summary>
        public IDictionary<string, object> Properties { get; set; }
    }
}
