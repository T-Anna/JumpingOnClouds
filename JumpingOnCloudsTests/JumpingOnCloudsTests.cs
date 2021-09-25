using System;
using Xunit;
using JumpingOnClouds;
using System.Collections.Generic;

namespace JumpingOnCloudsTests
{
    public class JumpingOnCloudsTests
    {
        [Fact]
        public void JumpingOnCloudsCalculatesMinimumNumberOfJumpsToWinForExampleData1()
        {
            List<int> input = new List<int> { 0, 0, 1, 0, 0, 1, 0 };
            int result = Program.JumpingOnClouds(input);
            Assert.Equal(4, result);
        }

        [Fact]
        public void JumpingOnCloudsCalculatesMinimumNumberOfJumpsToWinForExampleData2()
        {
            List<int> input = new List<int> { 0, 0, 0, 0, 1, 0 };
            int result = Program.JumpingOnClouds(input);
            Assert.Equal(3, result);
        }

        [Fact]
        public void JumpingOnCloudsCalculatesMinimumNumberOfJumpsToWinForExampleData3()
        {
            List<int> input = new List<int> { 0, 0};
            int result = Program.JumpingOnClouds(input);
            Assert.Equal(1, result);
        }

        [Fact]
        public void JumpingOnCloudsCalculatesMinimumNumberOfJumpsToWinForEmptyInput()
        {
            List<int> input = new List<int> {};
            int result = Program.JumpingOnClouds(input);
            Assert.Equal(0, result);
        }

    }
}
