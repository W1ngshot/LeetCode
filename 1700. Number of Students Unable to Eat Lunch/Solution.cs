namespace LeetCode._1700._Number_of_Students_Unable_to_Eat_Lunch;

public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        var stack = new Stack<int>();
        var queue = new Queue<int>();

        for (var i = 0; i < students.Length; i++)
        {
            queue.Enqueue(students[i]);
            stack.Push(sandwiches[^(i + 1)]);
        }

        var counter = 0;
        while (queue.Count > 0 && counter < queue.Count)
        {
            var student = queue.Dequeue();
            if (student == stack.Peek())
            {
                stack.Pop();
                counter = 0;
            }
            else
            {
                queue.Enqueue(student);
                counter++;
            }
        }

        return queue.Count;
    }
}