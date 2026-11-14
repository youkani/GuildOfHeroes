// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// yaroslav.Health = 75;

// Console.WriteLine(">>> Герой 1 <<<");
// Console.WriteLine($"Имя: {yaroslav.Name}");
// Console.WriteLine($"Здоровье: {yaroslav.Health}");
// Console.WriteLine($"Уровень: {yaroslav.Level}");
// Console.WriteLine($"Опыт: {yaroslav.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 2 <<<");
// Console.WriteLine($"Имя: {anastasia.Name}");
// Console.WriteLine($"Здоровье: {anastasia.Health}");
// Console.WriteLine($"Уровень: {anastasia.Level}");
// Console.WriteLine($"Опыт: {anastasia.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 3 <<<");
// Console.WriteLine($"Имя: {artem.Name}");
// Console.WriteLine($"Здоровье: {artem.Health}");
// Console.WriteLine($"Уровень: {artem.Level}");
// Console.WriteLine($"Опыт: {artem.Experience}");

Film interstellar = new Film("Интерстеллар", 2014, "Научная фантастика", 8.7);
Film shutterIsland = new Film("Остров проклятых", 2009, "Триллер", 8.6);
Film spiderMan = new Film("Человек-паук: Новый день", 2026, "Приключения", 7.9);

Console.WriteLine($"<<Фильм {interstellar.Name}>>");
Console.WriteLine($"{interstellar.Data} года создания");
Console.WriteLine($"Жанр: {interstellar.Genre}");
Console.WriteLine($"Оценка: {interstellar.Rating}./10");
Console.WriteLine($"доступность: {interstellar.Status}");

Console.WriteLine();

Console.WriteLine($"<<Фильм {shutterIsland.Name}>>");
Console.WriteLine($"{shutterIsland.Data} года создания");
Console.WriteLine($"Жанр: {shutterIsland.Genre}");
Console.WriteLine($"Оценка: {shutterIsland.Rating}./10");
Console.WriteLine($"доступность: {shutterIsland.Status}");

Console.WriteLine();

Console.WriteLine($"<<Фильм {spiderMan.Name}>>");
Console.WriteLine($"{spiderMan.Data} года создания");
Console.WriteLine($"Жанр: {spiderMan.Genre}");
Console.WriteLine($"Оценка: {spiderMan.Rating}./10");
Console.WriteLine($"доступность: {spiderMan.Status}");