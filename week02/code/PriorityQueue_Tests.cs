using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities (Low, High, Medium) and dequeue them.
    // Expected Result: Items should be dequeued strictly in order of highest priority first (e.g., Priority 5 before Priority 3 and 1).
    // Defect(s) Found: None.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 3);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items that share the exact same high priority level.
    // Expected Result: FIFO (First In, First Out) rule should apply when priorities are identical.
    // Defect(s) Found: None.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("FirstInLine", 10);
        priorityQueue.Enqueue("SecondInLine", 10);
        priorityQueue.Enqueue("Low", 1);

        Assert.AreEqual("FirstInLine", priorityQueue.Dequeue());
        Assert.AreEqual("SecondInLine", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }
}