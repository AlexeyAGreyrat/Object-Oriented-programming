using Lesson4;

Building building1 = new Building(100, 20, 140, 4);
Console.WriteLine($" Номер{building1.Id}");
Console.WriteLine($" Квартиры{building1.Apartments}");
Console.WriteLine($" Подьезд{building1.Entrances}");
Console.WriteLine($" Этажи{building1.Floors}");
Console.WriteLine($" Высота{building1.Height}");
Console.WriteLine($" Высота одно этажа {building1.GetHeightFloor(building1.Height, building1.Floors)}");
Console.WriteLine($" Количестов квартир в подъезеде {building1.CountApartmentsInEntrance(building1.Entrances,building1.Apartments)}");
Console.WriteLine($" Количестов квартир на этаже {building1.CountApartmentsToFloor(building1.Apartments, building1.Floors)}");

Building building2 = new Building();
Console.WriteLine($" Номер{building2.Id}");

Building building3 = new Building();
Console.WriteLine($" Номер{building3.Id}");

Building building4 = new Building();
Console.WriteLine($" Номер{building4.Id}");


