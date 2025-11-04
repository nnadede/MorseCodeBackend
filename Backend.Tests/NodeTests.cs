namespace Backend.Tests;

public class NodeTests
{
    [Fact]
    public void Constructor_ShouldInitializeValueAndNullChildren()
    {
        // Arrange
        char expected = 'A';

        // Act
        var node = new Node(expected);

        // Assert
        Assert.Equal(expected, node.Value);
        Assert.Null(node.Left);
        Assert.Null(node.Right);
    }

    [Fact]
    public void ShouldBeAbleToLinkLeftAndRightNodes()
    {
        // Arrange
        var parent = new Node('P');
        var left = new Node('L');
        var right = new Node('R');

        // Act
        parent.Left = left;
        parent.Right = right;

        // Assert
        Assert.Same(left, parent.Left);
        Assert.Same(right, parent.Right);
    }
}
