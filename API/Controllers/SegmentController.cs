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
        /// It's recommended that you make an Identify call:
        /// <list type="bullet">
        /// <item><description>After a user first registers</description></item>
        /// <item><description>After a user logs in</description></item>
        /// <item><description>When a user updates their info (for example, they change or add a new address)</description></item>
        /// <item><description>Upon loading any pages that are accessible by a logged in user (optional)</description></item>
        /// </list>
        /// </summary>
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
        /// This call is how you associate an individual user with a group—
        /// be it a company, organization, account, project, team or whatever other crazy name you came up with for the same concept!
        /// A user can be in more than one group; however, not all platforms support multiple groups.
        /// It also lets you record custom traits about the group, like industry or number of employees.
        /// </summary>
        [HttpPost]
        [Route("group")]
        public IActionResult Group(SegmentGroupRequest request)
        {
            Analytics.Client.Group(request.UserId, request.GroupId, request.Traits);
            return Ok();
        }
        
        /// <summary>
        /// This call is used to merge two user identities, effectively connecting two sets of user data as one.
        /// This is an advanced method, but it is required to manage user identities successfully in some of our destinations.
        /// </summary>
        [HttpPost]
        [Route("alias")]
        public IActionResult Alias(SegmentAliasRequest request)
        {
            Analytics.Client.Alias(request.PreviousId, request.UserId);
            return Ok();
        }
    }
}
