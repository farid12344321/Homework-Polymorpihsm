
using Homework_Polymorphism;


ShapeManager shapeManager  = new ShapeManager();
string opt;
do
{
	Console.WriteLine("1 Circle add");
	Console.WriteLine("2 Rectangle add");
	Console.WriteLine("3 Circle sayi");
	Console.WriteLine("4 Circle yeni array");
	Console.WriteLine("5 Circle sahelerinin cemi");
	Console.WriteLine("6 Rectangle width height braber olan");
    Console.WriteLine("0 bitir");
    opt = Console.ReadLine();

	switch (opt)
	{
		case "1":
			string radiusStr;
			double radius;
			do
			{
				Console.WriteLine("Radius");
				radiusStr = Console.ReadLine();
			} while (!double.TryParse(radiusStr, out radius));
			Circle circle2 = new Circle()
			{
				Radius = radius,
			};
            shapeManager.AddShape(circle2);
			break;
		case "2":
			string widhtStr;
			double widht;
			do
			{
                Console.WriteLine("Width");
				widhtStr = Console.ReadLine();
            } while (!double.TryParse(widhtStr,out widht));
            string heightStr;
            double height;
			do
			{
                Console.WriteLine("Height");
				heightStr = Console.ReadLine();
            } while (!double.TryParse(heightStr,out height));
            Rectangle rectangle = new Rectangle()
			{
				Width = widht,
				Height = height
			};
			shapeManager.AddShape(rectangle);
			break;
	    case "3":
			Console.WriteLine($"Sayi : {shapeManager.GetCircleCount()}");
		    break;  
	    case "4":
			for (int i = 0; i < shapeManager.GetCircles().Length; i++)
			{
				Console.WriteLine($"{i+1}.{shapeManager.GetCircles()[i]}");
            }
            break;
	    case "5":
            Console.WriteLine($"Sahelerin cemi : {shapeManager.GetTotalCircleAreas()}");
            break;
		case "6":
            Console.WriteLine($"Beraber olanlarin sayi : {shapeManager.GetSquareCount()}");
            break;
		default:
			if (opt != "0")
			{
                Console.WriteLine("duzgun operator daxil edin");
            }
			break;
	}
} while (opt != "0");