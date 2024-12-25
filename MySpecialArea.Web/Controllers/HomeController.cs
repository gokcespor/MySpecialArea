using MediatR;
using Microsoft.AspNetCore.Mvc;
using MySpecialArea.Shared.Operation.Operations.BlogPost.Query.GetBlogPost;
using MySpecialArea.Shared.Operation.Operations.BlogPost.Query.GetBlogPosts;
using MySpecialArea.Shared.Operation.Operations.Category.Query.GetCategories;
using MySpecialArea.Shared.Operation.Operations.Message.Query.GetMessages;
using MySpecialArea.Shared.Operation.Operations.Tag.Query.GetTags;
using MySpecialArea.Shared.Operation.Operations.User.Query.GetUser;
using MySpecialArea.Shared.Operation.Operations.User.Query.GetUsers;
using MySpecialArea.Web.Models;
using System.Diagnostics;

namespace MySpecialArea.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IMediator _mediator;

		public HomeController(ILogger<HomeController> logger, IMediator mediator)
		{
			_logger = logger;
			_mediator = mediator;
		}

		public async Task<IActionResult> Index()
		{
			var user = await _mediator.Send(new GetUserRequest
			{
				UserName = "Gök"
			});
		
			return View(new UserViewModel 
			{ 
				UserName = user.UserName, 
				FirstName = user.FirstName,
				LastName = user.LastName,
				Email = user.Email
			});		
		}

		public async Task<IActionResult> UserList()
		{
			var userList = await _mediator.Send(new GetUsersRequest
			{
				
			});
			var userListViewModel = userList.Select(x => new UserViewModel
			{
				UserName= x.UserName,
				FirstName= x.FirstName,
				LastName= x.LastName,
				Email = x.Email
			}).ToList();
			return View(userListViewModel);
		}
		public async Task<IActionResult> TagList()
		{
			var tagList = await _mediator.Send(new GetTagsRequest
			{

			});
			var tagListViewModel = tagList.Select(x => new TagViewModel
			{
				Name = x.Name
			}).ToList();
			return View(tagListViewModel);
		}
		public async Task<IActionResult> MessageList()
		{
			var messageList = await _mediator.Send(new GetMessagesRequest
			{

			});
			var messageListViewModel = messageList.Select(x => new MessageViewModel 
			{
				Title = x.Title,
				Description = x.Description
			}).ToList();
			return View(messageListViewModel);
		}
		public async Task<IActionResult> CategoryList()
		{
			var categoryList = await _mediator.Send(new GetCategoriesRequest
			{

			});
			var categoryListViewModel = categoryList.Select(x => new CategoryViewModel
			{
				Name= x.Name
			}).ToList();
			return View(categoryListViewModel);
		}
		public async Task<IActionResult> BlogPostList()
		{
			var blogPostList = await _mediator.Send(new GetBlogPostsRequest
			{

			});
			var blogPostListViewModel = blogPostList.Select(x => new BlogPostViewModel
			{
				Title = x.Title,
				PictureUrl = x.PictureUrl
			}).ToList();
			return View(blogPostListViewModel);
		}
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
