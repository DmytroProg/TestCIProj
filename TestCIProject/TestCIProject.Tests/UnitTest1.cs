namespace TestCIProject.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var service = GeometryService.SquareArea(10);
        
        Assert.Equal(100, service);
    }
    
    [Fact]
    public void Test2()
    {
        var service = GeometryService.RectangleArea(10, 20);
        
        Assert.Equal(200, service);
    }
    
    [Fact]
    public void Test3()
    {
        var service = GeometryService.TriangleArea(10, 20);
        
        Assert.Equal(100, service);
    }
}