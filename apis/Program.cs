
using Newtonsoft.Json;

class todo
{
    public int userId { get; set; }



    public string title { get; set; }

    public bool validated { get; set; }
}
class apis
{
    HttpClient client = new HttpClient();
    public static async Task Main()
    {
        apis apis = new apis();
        await apis.Getitemsfromapi();
    }
    public async Task Getitemsfromapi()
    {
        string response = await client.GetStringAsync("" +
            "https://localhost:7264/api/Todo/getdata");
        // Console.WriteLine(response);
        List<todo> todoitems = JsonConvert.DeserializeObject<List<todo>>(response);
        foreach (var item in todoitems)
        {
            Console.WriteLine("id:{0} title: {1}", item.userId, item.title);
        }
    }
}
