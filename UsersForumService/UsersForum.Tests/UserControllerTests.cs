using Xunit;
using Moq;
using UsersForum.Core.Posts;
using UsersForum.Core.Models;
using Microsoft.AspNetCore.Mvc;
using UsersForum.API.Controllers;
namespace UsersForum.Tests
{
    public class PostControllerTests
    {
        private readonly Mock<IPostService> _mockPostService;
        private readonly PostController _controller;

        public PostControllerTests()
        {
            _mockPostService = new Mock<IPostService>();
            _controller = new PostController((IPostService)_mockPostService.Object);
        }

        [Fact]
        public void TestGetAllPosts()
        {
            // Act
            var result = _controller.GetAllPosts();
            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void TestGetPostById()
        {
            // Act
            var result = _controller.GetPostById(1);
            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void TestAddNewPost()
        {
            // Act
            var result = _controller.AddNewPost(new Post());
            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
