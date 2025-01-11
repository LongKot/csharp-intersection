using Intersection;

namespace Test;

public class Test
{
    [Fact]
    public void TestNormalCase()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 4, 7 }, new() { 10, 14 } };
        var user2 = new List<List<int>> { new() { 3, 6 }, new() { 8, 13 } };
        var expected = new List<List<int>> { new() { 4, 6 }, new() { 10, 13 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestNoIntersection()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 1, 2 }, new() { 5, 6 } };
        var user2 = new List<List<int>> { new() { 3, 4 }, new() { 7, 8 } };
        var expected = new List<List<int>>();

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestFullyContainedIntervals()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 2, 5 }, new() { 6, 10 } };
        var user2 = new List<List<int>> { new() { 1, 6 }, new() { 8, 12 } };
        var expected = new List<List<int>> { new() { 2, 5 }, new() { 6, 6 }, new() { 8, 10 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestIdenticalIntervals()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 1, 5 }, new() { 6, 10 } };
        var user2 = new List<List<int>> { new() { 1, 5 }, new() { 6, 10 } };
        var expected = new List<List<int>> { new() { 1, 5 }, new() { 6, 10 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestEdgeTouching()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 1, 3 }, new() { 5, 7 } };
        var user2 = new List<List<int>> { new() { 3, 4 }, new() { 7, 8 } };
        var expected = new List<List<int>> { new() { 3, 3 }, new() { 7, 7 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestEmptyArrays()
    {
        var solution = new Solution();
        var user1 = new List<List<int>>();
        var user2 = new List<List<int>> { new() { 1, 3 } };
        var expected = new List<List<int>>();

        Assert.Equal(expected, solution.Intersection(user1, user2));

        user1 = new List<List<int>> { new() { 1, 3 } };
        user2 = new List<List<int>>();
        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestLargeIntervals()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 1, 1000 } };
        var user2 = new List<List<int>> { new() { 500, 1500 } };
        var expected = new List<List<int>> { new() { 500, 1000 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestOverlappingIntervals()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 1, 5 }, new() { 10, 15 } };
        var user2 = new List<List<int>> { new() { 0, 2 }, new() { 13, 20 } };
        var expected = new List<List<int>> { new() { 1, 2 }, new() { 13, 15 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }
}