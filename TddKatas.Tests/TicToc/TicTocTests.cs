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

        [Test]
        public void WhenPlayGameOn1And1_SpaceShouldBeWithPointOn1And1()
        {
            var x = new X(1);
            var y = new Y(1);
            var coordinate = new Coordinate(x, y);
            var spaceWithCross = new Space(new[] {coordinate});
            var game = new Game();

            game.PlayRound(x, y);

            game.GetSpace().Should().Be(spaceWithCross);
        }
    }
}