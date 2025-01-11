using Intersection;

namespace Test;

public class Test
{
    [Fact]
    public void TestCase1()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 3, 98 }, new() { 35, 67 } };
        var user2 = new List<List<int>> { new() { 17, 31 }, new() { 86, 98 }, new() { 69, 72 } };
        var expected = new List<List<int>> { new() { 17, 31 }, new() { 86, 98 }, new() { 69, 72 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestCase2()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 4, 8 }, new() { 11, 39 }, new() { 29, 94 }, new() { 77, 78 }, new() { 71, 78 } };
        var user2 = new List<List<int>> { new() { 28, 86 }, new() { 75, 84 }, new() { 0, 98 }, new() { 20, 75 }, new() { 43, 61 } };
        var expected = new List<List<int>> { new() { 28, 39 }, new() { 29, 86 }, new() { 75, 84 }, new() { 29, 94 }, new() { 77, 78 }, new() { 71, 78 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestCase3()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 27, 71 }, new() { 13, 25 }, new() { 48, 55 } };
        var user2 = new List<List<int>> { new() { 44, 83 }, new() { 33, 39 }, new() { 93, 97 }, new() { 68, 76 } };
        var expected = new List<List<int>> { new() { 44, 71 }, new() { 48, 55 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestCase4()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 10, 81 }, new() { 37, 91 }, new() { 80, 100 }, new() { 46, 83 }, new() { 24, 33 } };
        var user2 = new List<List<int>> { new() { 84, 92 }, new() { 98, 100 } };
        var expected = new List<List<int>> { new() { 84, 91 }, new() { 84, 92 }, new() { 98, 100 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestCase5()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 29, 42 }, new() { 48, 66 } };
        var user2 = new List<List<int>> { new() { 81, 93 }, new() { 20, 68 }, new() { 45, 59 }, new() { 85, 90 }, new() { 89, 100 } };
        var expected = new List<List<int>> {  };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestCase6()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 77, 98 }, new() { 21, 90 } };
        var user2 = new List<List<int>> { new() { 20, 80 }, new() { 48, 66 }, new() { 81, 99 } };
        var expected = new List<List<int>> { new() { 77, 80 }, new() { 81, 98 }, new() { 81, 90 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestCase7()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 87, 93 }, new() { 98, 99 }, new() { 29, 34 } };
        var user2 = new List<List<int>> { new() { 51, 69 }, new() { 8, 36 }, new() { 72, 95 }, new() { 40, 54 } };
        var expected = new List<List<int>> { new() { 87, 93 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestCase8()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 50, 92 }, new() { 58, 68 }, new() { 33, 51 }, new() { 31, 100 }, new() { 33, 88 } };
        var user2 = new List<List<int>> { new() { 46, 61 }, new() { 17, 83 }, new() { 63, 69 }, new() { 96, 97 }, new() { 14, 34 } };
        var expected = new List<List<int>> { new() { 50, 61 }, new() { 50, 83 }, new() { 63, 69 }, new() { 96, 97 }, new() { 31, 34 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestCase9()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 87, 94 }, new() { 76, 79 }, new() { 49, 74 } };
        var user2 = new List<List<int>> { new() { 67, 84 }, new() { 70, 98 }, new() { 1, 89 }, new() { 92, 94 }, new() { 87, 96 } };
        var expected = new List<List<int>> { new() { 87, 94 }, new() { 76, 79 }, new() { 70, 74 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

    [Fact]
    public void TestCase10()
    {
        var solution = new Solution();
        var user1 = new List<List<int>> { new() { 98, 100 }, new() { 14, 52 }, new() { 55, 66 }, new() { 58, 59 } };
        var user2 = new List<List<int>> { new() { 64, 76 }, new() { 64, 71 }, new() { 80, 90 }, new() { 81, 98 } };
        var expected = new List<List<int>> { new() { 98, 98 } };

        Assert.Equal(expected, solution.Intersection(user1, user2));
    }

}
