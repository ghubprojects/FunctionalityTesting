using FunctionalityTesting.Application;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Chương trình tính diện tích hình tròn");
Console.Write("Nhập bán kính: ");

if (double.TryParse(Console.ReadLine(), out double radius))
{
    double area = CircleAreaCalculator.Calculate(radius);
    Console.WriteLine($"Diện tích của hình tròn có bán kính {radius} là: {area}");
}
else
{
    Console.WriteLine("Bán kính không hợp lệ. Vui lòng nhập một số thực.");
}