namespace Backend.Tests;

public class BinaryTreeTests
{
    [Fact]
    public void Constructor_ShouldInitializeRootAsNull()
    {
        // Act
        var tree = new BinaryTree();

        // Assert
        Assert.Null(tree.Root);
    }
}