using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TDD_Practice.User_Class;

namespace TDD_Tests
{
    public class nullFields_Tests
    {
        [Fact]
        public void Check_Properties_shoudl_not_be_null_or_empty()
        {
            
            var user = new User("", "khan", DateTime.Now, "brown", "zk@audacia.com", 172);
           
            user.FirstName.Should().NotBeEmpty();
            user.LastName.Should().NotBeEmpty();
            user.Email.Should().NotBeEmpty();
            user.EyeColour.Should().NotBeEmpty();
            
        }
    }
}
