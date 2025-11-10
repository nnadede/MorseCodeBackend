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

    [Fact]
    public void InitTree_ShouldCreateCorrectStructureforLevel0()
    {
        // Arrange
        var tree = new BinaryTree();

        // Act
        tree.InitTree();

        // Assert
        Assert.NotNull(tree.Root);
    }

    [Fact]
    public void InitTree_ShouldCreateCorrectStructureforLevel1()
    {
        // Arrange
        var tree = new BinaryTree();

        // Act
        tree.InitTree();

        // Assert Level 1 as not null
        Assert.NotNull(tree.Root.Left);
        Assert.NotNull(tree.Root.Right);

        // Assert Level 1 values
        Assert.Equal('E', tree.Root.Left.Value);
        Assert.Equal('T', tree.Root.Right.Value);
    }

    [Fact]
    public void InitTree_ShouldCreateCorrectStructureforLevel2()
    {
        // Arrange
        var tree = new BinaryTree();

        // Act
        tree.InitTree();

        // Assert Level 2 as not null
        Assert.NotNull(tree.Root.Left.Left);
        Assert.NotNull(tree.Root.Left.Right);
        Assert.NotNull(tree.Root.Right.Left);
        Assert.NotNull(tree.Root.Right.Right);

        // Assert Level 2 values
        Assert.Equal('I', tree.Root.Left.Left.Value);
        Assert.Equal('A', tree.Root.Left.Right.Value);
        Assert.Equal('N', tree.Root.Right.Left.Value);
        Assert.Equal('M', tree.Root.Right.Right.Value);
    }

    [Fact]
    public void InitTree_ShouldCreateCorrectStructureforLevel3()
    {
        // Arrange
        var tree = new BinaryTree();

        // Act
        tree.InitTree();

        // Assert Level 3 as not null
        Assert.NotNull(tree.Root.Left.Left.Left);
        Assert.NotNull(tree.Root.Left.Left.Right);
        Assert.NotNull(tree.Root.Left.Right.Left);
        Assert.NotNull(tree.Root.Left.Right.Right);
        Assert.NotNull(tree.Root.Right.Left.Left);
        Assert.NotNull(tree.Root.Right.Left.Right);
        Assert.NotNull(tree.Root.Right.Right.Left);
        Assert.NotNull(tree.Root.Right.Right.Right);

        // Assert Level 3 values
        Assert.Equal('S', tree.Root.Left.Left.Left.Value);
        Assert.Equal('U', tree.Root.Left.Left.Right.Value);
        Assert.Equal('R', tree.Root.Left.Right.Left.Value);
        Assert.Equal('W', tree.Root.Left.Right.Right.Value);
        Assert.Equal('D', tree.Root.Right.Left.Left.Value);
        Assert.Equal('K', tree.Root.Right.Left.Right.Value);
        Assert.Equal('G', tree.Root.Right.Right.Left.Value);
        Assert.Equal('O', tree.Root.Right.Right.Right.Value);
    }

    [Fact]
    public void InitTree_ShouldCreateCorrectStructureforLevel4()
    {
        // Arrange
        var tree = new BinaryTree();

        // Act
        tree.InitTree();

        // Assert Level 4 as not null
        Assert.NotNull(tree.Root.Left.Left.Left.Left);
        Assert.NotNull(tree.Root.Left.Left.Left.Right);
        Assert.NotNull(tree.Root.Left.Left.Right.Left);
        Assert.NotNull(tree.Root.Left.Left.Right.Right);
        Assert.NotNull(tree.Root.Left.Right.Left.Left);
        Assert.NotNull(tree.Root.Left.Right.Left.Right);
        Assert.NotNull(tree.Root.Left.Right.Right.Left);
        Assert.NotNull(tree.Root.Left.Right.Right.Right);
        Assert.NotNull(tree.Root.Right.Left.Left.Left);
        Assert.NotNull(tree.Root.Right.Left.Left.Right);
        Assert.NotNull(tree.Root.Right.Left.Right.Left);
        Assert.NotNull(tree.Root.Right.Left.Right.Right);
        Assert.NotNull(tree.Root.Right.Right.Left.Left);
        Assert.NotNull(tree.Root.Right.Right.Left.Right);
        Assert.NotNull(tree.Root.Right.Right.Right.Left);
        Assert.NotNull(tree.Root.Right.Right.Right.Right);

        // Assert Level 4 values
        Assert.Equal('H', tree.Root.Left.Left.Left.Left.Value);
        Assert.Equal('V', tree.Root.Left.Left.Left.Right.Value);
        Assert.Equal('F', tree.Root.Left.Left.Right.Left.Value);
        Assert.Equal('L', tree.Root.Left.Right.Left.Left.Value);
        Assert.Equal('P', tree.Root.Left.Right.Right.Left.Value);
        Assert.Equal('J', tree.Root.Left.Right.Right.Right.Value);
        Assert.Equal('B', tree.Root.Right.Left.Left.Left.Value);
        Assert.Equal('X', tree.Root.Right.Left.Left.Right.Value);
        Assert.Equal('C', tree.Root.Right.Left.Right.Left.Value);
        Assert.Equal('Y', tree.Root.Right.Left.Right.Right.Value);
        Assert.Equal('Z', tree.Root.Right.Right.Left.Left.Value);
        Assert.Equal('Q', tree.Root.Right.Right.Left.Right.Value);
    }

    [Fact]
    public void InitTree_ShouldCreateCorrectStructureforLevel5()
    {
        // Arrange
        var tree = new BinaryTree();

        // Act
        tree.InitTree();

        // Assert Level 5 as not null
        Assert.NotNull(tree.Root.Left.Left.Left.Left.Left);
        Assert.NotNull(tree.Root.Left.Left.Left.Left.Right);
        Assert.NotNull(tree.Root.Left.Left.Left.Right.Right);
        Assert.NotNull(tree.Root.Left.Left.Right.Right.Left);
        Assert.NotNull(tree.Root.Left.Left.Right.Right.Right);
        Assert.NotNull(tree.Root.Left.Right.Left.Left.Left);
        Assert.NotNull(tree.Root.Left.Right.Left.Left.Right);
        Assert.NotNull(tree.Root.Left.Right.Left.Right.Left);
        Assert.NotNull(tree.Root.Left.Right.Right.Left.Right);
        Assert.NotNull(tree.Root.Left.Right.Right.Right.Right);
        Assert.NotNull(tree.Root.Right.Left.Left.Left.Left);
        Assert.NotNull(tree.Root.Right.Left.Left.Left.Right);
        Assert.NotNull(tree.Root.Right.Left.Left.Right.Left);
        Assert.NotNull(tree.Root.Right.Left.Right.Left.Right);
        Assert.NotNull(tree.Root.Right.Left.Right.Right.Left);
        Assert.NotNull(tree.Root.Right.Right.Left.Left.Left);
        Assert.NotNull(tree.Root.Right.Right.Left.Left.Right);
        Assert.NotNull(tree.Root.Right.Right.Right.Left.Left);
        Assert.NotNull(tree.Root.Right.Right.Right.Right.Left);
        Assert.NotNull(tree.Root.Right.Right.Right.Right.Right);

        // Assert Level 5 values
        Assert.Equal('5', tree.Root.Left.Left.Left.Left.Left.Value);
        Assert.Equal('4', tree.Root.Left.Left.Left.Left.Right.Value);
        Assert.Equal('3', tree.Root.Left.Left.Left.Right.Right.Value);
        Assert.Equal('2', tree.Root.Left.Left.Right.Right.Right.Value);
        Assert.Equal('&', tree.Root.Left.Right.Left.Left.Left.Value);
        Assert.Equal('+', tree.Root.Left.Right.Left.Right.Left.Value);
        Assert.Equal('1', tree.Root.Left.Right.Right.Right.Right.Value);
        Assert.Equal('6', tree.Root.Right.Left.Left.Left.Left.Value);
        Assert.Equal('=', tree.Root.Right.Left.Left.Left.Right.Value);
        Assert.Equal('/', tree.Root.Right.Left.Left.Right.Left.Value);
        Assert.Equal('(', tree.Root.Right.Left.Right.Right.Left.Value);
        Assert.Equal('7', tree.Root.Right.Right.Left.Left.Left.Value);
        Assert.Equal('8', tree.Root.Right.Right.Right.Left.Left.Value);
        Assert.Equal('9', tree.Root.Right.Right.Right.Right.Left.Value);
        Assert.Equal('0', tree.Root.Right.Right.Right.Right.Right.Value);
    }
    
    [Fact]
    public void InitTree_ShouldCreateCorrectStructureforLevel6()
    {
        // Arrange
        var tree = new BinaryTree();

        // Act
        tree.InitTree();

        // Assert Level 6 as not null
        Assert.NotNull(tree.Root.Left.Left.Right.Right.Left.Left);
        Assert.NotNull(tree.Root.Left.Left.Right.Right.Left.Right);
        Assert.NotNull(tree.Root.Left.Right.Left.Left.Right.Left);
        Assert.NotNull(tree.Root.Left.Right.Left.Right.Left.Right);
        Assert.NotNull(tree.Root.Left.Right.Right.Left.Right.Left);
        Assert.NotNull(tree.Root.Left.Right.Right.Right.Right.Left);
        Assert.NotNull(tree.Root.Right.Left.Left.Left.Left.Right);
        Assert.NotNull(tree.Root.Right.Left.Right.Left.Right.Left);
        Assert.NotNull(tree.Root.Right.Left.Right.Left.Right.Right);
        Assert.NotNull(tree.Root.Right.Left.Right.Right.Left.Right);
        Assert.NotNull(tree.Root.Right.Right.Left.Left.Right.Right);
        Assert.NotNull(tree.Root.Right.Right.Right.Left.Left.Left);

        // Assert Level 6 values
        Assert.Equal('?', tree.Root.Left.Left.Right.Right.Left.Left.Value);
        Assert.Equal('_', tree.Root.Left.Left.Right.Right.Left.Right.Value);
        Assert.Equal('"', tree.Root.Left.Right.Left.Left.Right.Left.Value);
        Assert.Equal('.', tree.Root.Left.Right.Left.Right.Left.Right.Value);
        Assert.Equal('@', tree.Root.Left.Right.Right.Left.Right.Left.Value);
        Assert.Equal('\'', tree.Root.Left.Right.Right.Right.Right.Left.Value);
        Assert.Equal('-', tree.Root.Right.Left.Left.Left.Left.Right.Value);
        Assert.Equal(';', tree.Root.Right.Left.Right.Left.Right.Left.Value);
        Assert.Equal('!', tree.Root.Right.Left.Right.Left.Right.Right.Value);
        Assert.Equal(')', tree.Root.Right.Left.Right.Right.Left.Right.Value);
        Assert.Equal(',', tree.Root.Right.Right.Left.Left.Right.Right.Value);
        Assert.Equal(':', tree.Root.Right.Right.Right.Left.Left.Left.Value);
    }
}