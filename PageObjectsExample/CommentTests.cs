﻿
using Xunit;

namespace PageObjectsExample
{
    public class CommentTests : BaseTest
    {
        [Fact]
        public void Can_add_new_comment_to_latest_note()
        {
            var startPage = MainPage.Open(GetBrowser());
            var notePage = startPage.NavigateToNewestNote();
            var exampleComment = new ExampleComment();
            var noteWithComment = notePage.AddComment(exampleComment);

            Assert.True(noteWithComment.Has(exampleComment));

        }
    }
}