using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Moq;
using Xunit;

namespace TestCI.Tests
{
    public class Tests
    {
        [Fact(DisplayName = "Can_Succeed")]
        public void Can_Succeed()
        {
            Assert.True(true);
        }

        [Fact(DisplayName = "Can_Fail")]
        public void Can_Fail()
        {
            Assert.True(true);
        }
    }
}
