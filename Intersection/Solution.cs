namespace Intersection;

public class Solution
{
    public List<List<int>> Intersection(List<List<int>> user1, List<List<int>> user2)
    {
        List<List<int>> Answer = new();
        var iterA = 0;
        var iterB = 0;

        if (user1.Count == 0 || user2.Count == 0) return Answer;
        while (iterA < user1.Count || iterB < user2.Count)
        {
            if (user1[iterA][0] > user2[iterB][1])
            {
                if (iterB < user2.Count - 1)
                {
                    iterB++;
                    continue;
                }

                break;
            }

            if (user2[iterB][0] > user1[iterA][1])
            {
                if (iterA < user1.Count - 1)
                {
                    iterA++;
                    continue;
                }

                break;
            }

            List<int> inner = new();
            List<int> outer = new();

            List<int> answer = new();
            var isainner = false;
            if (user1[iterA][0] <= user2[iterB][1] && user1[iterA][0] >= user2[iterB][0])
            {
                inner = user1[iterA];
                outer = user2[iterB];
                isainner = true;
            }
            else
            {
                inner = user2[iterB];
                outer = user1[iterA];
            }

            answer.Add(inner[0]);
            if (inner[1] <= outer[1])
                answer.Add(inner[1]);
            else
                answer.Add(outer[1]);

            Answer.Add(answer);

            if (isainner && iterA != user1.Count - 1)
            {
                iterA++;
                continue;
            }

            if (!isainner && iterB != user2.Count - 1)
            {
                iterB++;
                continue;
            }

            if (iterA != user1.Count - 1)
            {
                iterA++;
                continue;
            }

            if (iterB != user2.Count - 1)
            {
                iterB++;
                continue;
            }

            break;
        }

        return Answer;
    }
}