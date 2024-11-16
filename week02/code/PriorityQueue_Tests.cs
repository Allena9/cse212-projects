using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Input three new PriorityItems with different priorities and check to see if they appear in the queue. 
    // Expected Result: [Thing (Pri:3), Thang (Pri:2), Thingy (Pri:1)]
    // Defect(s) Found: Dequeue mehtod is not removing the item with the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        var item3 = new PriorityItem("Thang", 2);
        var item1 = new PriorityItem("Thing", 3);
        var item2 = new PriorityItem("Thingy", 1);
        
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);

        PriorityItem[] expectedResult = [item1, item3, item2];

        for(int i = 0; i < priorityQueue.Length; i++)
        {
            Assert.AreEqual(expectedResult[i].Value, priorityQueue.Dequeue());
        }
    }

    [TestMethod]
    // Scenario: Check to see if dequeue grabs the first item if there are two items with the same priority.
    // Expected Result: [Thing (Pri:3), Thang (Pri:2), Thingy (Pri:2)]
    // Defect(s) Found: Dequeue is not removing the items in order of first to last if the priorities are the same.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var item3 = new PriorityItem("Thang", 2);
        var item1 = new PriorityItem("Thing", 3);
        var item2 = new PriorityItem("Thingy", 2);
        
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);

        PriorityItem[] expectedResult = [item1, item3, item2];

        for(int i = 0; i < priorityQueue.Length; i++)
        {
            Assert.AreEqual(expectedResult[i].Value, priorityQueue.Dequeue());
        }
    }

    [TestMethod]
    // Scenario: Check to see if dequeue throws an error when the qeueue is empty.
    // Expected Result: "The queue is empty."
    // Defect(s) Found: None.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    // Add more test cases as needed below.
}