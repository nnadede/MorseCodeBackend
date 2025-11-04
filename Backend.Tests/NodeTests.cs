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
}
