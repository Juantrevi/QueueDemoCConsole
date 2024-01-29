// This program demonstrates the use of a Queue<T> collection
Queue<int> callerIds = new Queue<int>();
List<int> list = new List<int>();

for (int i = 0; i < 10; i++)
{
    callerIds.Enqueue(i);
}

Console.WriteLine($"Queue has {callerIds.Count} items");

if (callerIds.Count>0)
{
    Console.WriteLine($"First item is {callerIds.Peek()}");
}

foreach(var id in callerIds)
{
    Console.WriteLine($"Inside the queue: {id}");
}

while(callerIds.Count > 0)
{
    var queueItem = callerIds.Dequeue();
    Console.WriteLine($"Dequeued (Removed) {queueItem}");
    if(callerIds.Contains(3))
    {
        Console.WriteLine($"The id 3 is still in the Q");
    }
}

Console.WriteLine($"Processed Q has {callerIds.Count} items");

try
{
    callerIds.Dequeue(); // Throws an exception
}
catch (Exception e)
{
    Console.WriteLine("Exception thrown when trying to dequeue an empty queue" + e.Message);
}
