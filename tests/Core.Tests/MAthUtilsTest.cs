using Core;
using Xunit;

namespace Core.Tests;

public class MathUtilsTests
{
    [Fact] public void Add_Works() => Assert.Equal(7, MathUtils.Add(3,4));

    [Theory]
    [InlineData(17,false)]
    [InlineData(18,true)]
    [InlineData(25,true)]
    public void IsAdult_Threshold(int age, bool expected)
        => Assert.Equal(expected, MathUtils.IsAdult(age));
}
