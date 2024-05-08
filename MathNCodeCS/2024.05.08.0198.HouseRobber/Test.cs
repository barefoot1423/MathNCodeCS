using NUnit.Framework;

namespace MathNCodeCS._2024._05._08._0198.HouseRobber;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new int[] { }, 0)]
    [TestCase(new[] { 2 }, 2)]
    [TestCase(new[] { 1, 2 }, 2)]
    [TestCase(new[] { 3, 2 }, 3)]
    [TestCase(new[] { 1, 2, 3, 1 }, 4)]
    [TestCase(new[] { 2, 7, 9, 3, 1 }, 12)]
    [TestCase(new[] { 1, 2, 7, 9, 12, 1, 7, 54, 3, 2, 3, 29, 41 }, 118)]
    [TestCase(new[] { 1, 2, 3, 1, 7, 9, 12, 17, 54, 3, 2, 3, 29, 41 }, 121)]
    [TestCase(
        new[]
        {
            183, 219, 57, 193, 94, 233, 202, 154, 65, 240, 97, 234, 100, 249, 186, 66, 90, 238, 168,
            128, 177, 235, 50, 81, 185, 165, 217, 207, 88, 80, 112, 78, 135, 62, 228, 247, 211,
        },
        3365)]
    public void AssertThis(int[] input, int expected)
    {
        Assert.That(_solution.Rob(input), Is.EqualTo(expected));
    }
}
