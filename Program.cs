using Netrunner.Signasl.Services;

#region Señales de abitraje triangular

Console.WriteLine("¡Hola Netrunner!");
Console.WriteLine("¡Vamos a consultar las ultimas señales de arbitraje!");
//Vamos a configurar acá la llamada al endpoint de la api Agentrunner.
var _apiUri = "https://api.agentrunner.netrunbot.com/";
var _endpoint = "dna180/signals";
var _token = "";
var _netrunner = "netrunbot.com";
var _triangleService = new TriangleService(_apiUri, _endpoint, _token, _netrunner);

var signals = await _triangleService.GetSignalsAsync();

Console.WriteLine("_________________________________________________________________________________________________________________________");
Console.WriteLine("|     Fecha       |  Par 1   |  Precio 1   |  Par 2     | Precio 2   |  Par 3   |  Precio 3   |      Profit Max       |");
foreach (var signal in signals)
{
    Console.WriteLine($"|{signal.Date.ToString("dd/MM/yyyy hh:mm")} | {signal.Pair1}| {signal.Price1} | {signal.Pair2}| {signal.Price2} | {signal.Pair3}| {signal.Price3} | {signal.MaxProfit} |");
}
Console.WriteLine("___________________________________________________________________________________________________________________________");
#endregion
