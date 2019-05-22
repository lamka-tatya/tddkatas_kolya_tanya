using FluentAssertions;
using NUnit.Framework;
using TddKatas.TicToc;

namespace Tests.TicToc
{
    public class TicTocTests
    {
        [Test]
        public void WhenGameStarted_SpaceShouldBeEmpty()
        {
            var game = new Game();

            game.GetSpace().Should().Be(new Space());
        }
    }
}