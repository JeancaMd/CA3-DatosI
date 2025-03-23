using Xunit;

public class DataStructureTests
{
    // Stack Tests
    [Fact]
    public void Stack_Push_AddsElementToStack()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        Assert.Equal(1, stack.Count);
    }

    [Fact]
    public void Stack_Pop_RemovesAndReturnsLastElement()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        var result = stack.Pop();
        Assert.Equal(2, result);
        Assert.Equal(1, stack.Count);
    }

    [Fact]
    public void Stack_Peek_ReturnsLastElementWithoutRemoving()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        var result = stack.Peek();
        Assert.Equal(2, result);
        Assert.Equal(2, stack.Count);
    }

    [Fact]
    public void Stack_IsEmpty_ReturnsTrueForEmptyStack()
    {
        var stack = new Stack<int>();
        Assert.True(stack.IsEmpty());
    }

    [Fact]
    public void Stack_IsEmpty_ReturnsFalseForNonEmptyStack()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        Assert.False(stack.IsEmpty());
    }

    [Fact]
    public void Stack_Pop_ThrowsExceptionForEmptyStack()
    {
        var stack = new Stack<int>();
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void Stack_Peek_ThrowsExceptionForEmptyStack()
    {
        var stack = new Stack<int>();
        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }

    // Queue Tests
    [Fact]
    public void Queue_Enqueue_AddsElementToQueue()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        Assert.Equal(1, queue.Count);
    }

    [Fact]
    public void Queue_Dequeue_RemovesAndReturnsFirstElement()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        var result = queue.Dequeue();
        Assert.Equal(1, result);
        Assert.Equal(1, queue.Count);
    }

    [Fact]
    public void Queue_Peek_ReturnsFirstElementWithoutRemoving()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        var result = queue.Peek();
        Assert.Equal(1, result);
        Assert.Equal(2, queue.Count);
    }

    [Fact]
    public void Queue_IsEmpty_ReturnsTrueForEmptyQueue()
    {
        var queue = new Queue<int>();
        Assert.True(queue.IsEmpty());
    }

    [Fact]
    public void Queue_IsEmpty_ReturnsFalseForNonEmptyQueue()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        Assert.False(queue.IsEmpty());
    }

    [Fact]
    public void Queue_Dequeue_ThrowsExceptionForEmptyQueue()
    {
        var queue = new Queue<int>();
        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }

    [Fact]
    public void Queue_Peek_ThrowsExceptionForEmptyQueue()
    {
        var queue = new Queue<int>();
        Assert.Throws<InvalidOperationException>(() => queue.Peek());
    }
}
