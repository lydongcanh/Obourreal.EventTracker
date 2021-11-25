using API.Infrastructure.Requests;
using Microsoft.AspNetCore.Mvc;
using Segment;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SegmentController : ControllerBase
    {
        /// <summary>
        /// The Segment Identify call lets you tie a user to their actions and record traits about them.
        /// </summary>
        /// <remarks>
        /// It's recommended that you make an Identify call:<br/>
        /// - After a user first registers<br/>
        /// - After a user logs in<br/>
        /// - When a user updates their info (for example, they change or add a new address)<br/>
        /// - Upon loading any pages that are accessible by a logged in user (optional)
        /// </remarks>
        [HttpPost]
        [Route("identity")]
        public IActionResult Identify(SegmentIdentifyRequest request)
        {
            Analytics.Client.Identify(request.UserId, request.Traits);
            return Ok();
        }
        
        /// <summary>
        /// This is how you record any actions your users perform, along with any properties that describe the action.
        /// </summary>
        [HttpPost]
        [Route("track")]
        public IActionResult Track(SegmentTrackRequest request)
        {
            Analytics.Client.Track(request.UserId, request.Event, request.Properties);
            return Ok();
        }
        
        /// <summary>
        /// This call lets you record whenever a user sees a page of the website,
        /// along with any optional properties about the page.
        /// </summary>
        [HttpPost]
        [Route("page")]
        public IActionResult Page(SegmentPageRequest request)
        {
            Analytics.Client.Page(request.UserId, request.Name, request.Category, request.Properties, null);
            return Ok();
        }
        
        /// <summary>
        /// The screen call lets you record whenever a user sees a screen,
        /// the mobile equivalent of page, in the mobile app, along with any properties about the screen.
        /// </summary>
        [HttpPost]
        [Route("screen")]
        public IActionResult Screen(SegmentScreenRequest request)
        {
            Analytics.Client.Screen(request.UserId, request.Name, request.Category, request.Properties, null);
            return Ok();
        }
        
        /// <summary>
        /// This call is how you associate an individual user with a group.
        /// </summary>
        /// <remarks>
        /// A user can be in more than one group, however, not all platforms support multiple groups.<br/>
        /// It also lets you record custom traits about the group, like industry or number of employees.
        /// </remarks>
        [HttpPost]
        [Route("group")]
        public IActionResult Group(SegmentGroupRequest request)
        {
            Analytics.Client.Group(request.UserId, request.GroupId, request.Traits);
            return Ok();
        }
        
        /// <summary>
        /// This call is used to merge two user identities, effectively connecting two sets of user data as one.
        /// </summary>
        /// <remarks>
        /// This is an advanced method, but it is required to manage user identities successfully in some of our destinations.
        /// </remarks>
        [HttpPost]
        [Route("alias")]
        public IActionResult Alias(SegmentAliasRequest request)
        {
            Analytics.Client.Alias(request.PreviousId, request.UserId);
            return Ok();
        }
    }
}
