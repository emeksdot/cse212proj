using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        // Test to verify that the Dequeue method returns the item with the highest priority. 
        // Arrange
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Watch", 167);
        priorityQueue.Enqueue("Shoes", 150);
        priorityQueue.Enqueue("Bag", 120);
        priorityQueue.Enqueue("Hat", 160);


        // We will remove the node object with the highest priority so that we can continue to dequeue the List. Adjustments were made to the for loop in the PriorityQueue.cs file to loop to the end of the List.
        // Act
        string result = priorityQueue.Dequeue();

        // Assert
        Assert.AreEqual("Watch", result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        // Test to ensure that if there are multiple items with the same priority, the one that was added first is removed first.
        // Arrange
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Watch", 167);
        priorityQueue.Enqueue("Shoes", 150);
        priorityQueue.Enqueue("Bag", 120);
        priorityQueue.Enqueue("Hat", 160);
        priorityQueue.Enqueue("Suit", 167);

        // Act
        string result = priorityQueue.Dequeue();

        // Confirmation that the first item with the highest priority is removed first.
        // Assert
        Assert.AreEqual("Watch", result);
    }

    // Add more test cases as needed below.
}