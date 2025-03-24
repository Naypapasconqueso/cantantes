[ApiController]
[Route("artistas")]
public class Conexion : Controller 
{
    private IMongoCollection<Artistas> _artistas;
    [HttpGet("mongo")]
    public IActionResult ListarArtistasMongoDB()
    {
        var client = new MongoClient(CadenasConexion.MONGO_DB);
        var database = client.GetDatabase("Practica2_Nayeli_Frida");
        _artistas = database.GetCollection<Artistas>("cantantes");

        return Ok(_artistas);
    }
    [HttpGet]
    public ActionResult<List<Artistas>> Get()
    {
        return _artistas.Find(artista => true).ToList();
    }
}