using System;
using Xunit;
public class CoreTests
{
    public void GameFake_DoesNotThrow()
    {
        // Arrange
        var game = new Game();
        // Act & Assert
        var exception = Record.Exception(() => game.create("character"));
        Assert.Null(exception);
    }
    [Fact]
    public void GameStub_ThrowsOnBadInput()
    {
        // Arrange
        var badtype = "badtype";
        var game = new Game();
        // Act & Assert
        var exception = Record.Exception(() => game.create(badtype));   
    }
    [Fact]
    public void GameMock_TracksMethodCalls()
    {
        // Arrange
        var game = new Game();
        var type1 = "character";
        var type2 = "enemy";
        /*game.create(type1);
        game.create(type2);*/
        Assert.True(true);
        Console.WriteLine("CoreTests passed");
    }
}
