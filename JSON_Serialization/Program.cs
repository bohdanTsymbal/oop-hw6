using System.Text.Json;
using JSON_Serialization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.Unicode;

string path = @"./json_data.json";

using (FileStream fs = new(path, FileMode.Open, FileAccess.Read))
{
    var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs);

	if (books == null)
	{
		Console.WriteLine("Failed to read the JSON file!");
		return;
	}

	foreach (var book in books)
	{
		Console.WriteLine($"{book.Title} - {book.PublishingHouse.Id} - {book.PublishingHouse.Name} - {book.PublishingHouse.Address}");
	}
}
