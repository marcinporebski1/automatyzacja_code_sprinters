using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PageObjectsExample
{
    public class NoteTests : BaseTest
    {
        [Fact]
        public void Can_add_new_note_by_administration_panel()
        {
            var startPage = AdminPage.Open(GetBrowser());
            //var addNote = startPage.NavigateToNewestNote();
            //var exampleNote = new ExampleNote();
        }
    }
}
