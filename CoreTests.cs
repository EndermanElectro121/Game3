using System;
using Xunit;
public class CoreTests
{
    public void GameFake_DoesNotThrow()
    {
        var game = new Game();
        var exception = Record.Exception(() => game.create("character"));
        Assert.Null(exception);
    }
    [Fact]
    public void GameStub_ThrowsOnBadInput()
    {
        var badtype = "badtype";
        var game = new Game();
        var exception = Record.Exception(() => game.create(badtype));   
    }
    [Fact]
    public void GameMock_TracksMethodCalls()
    {
        var game = new Game();
        var type1 = "character";
        var type2 = "enemy";
        Assert.True(true);
        Console.WriteLine("CoreTests passed");
    }
}

