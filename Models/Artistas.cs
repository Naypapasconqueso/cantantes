using MongoDB.Bson.Serialization.Attributes;
public class Artistas{
[BsonId]
[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
public string? ObjectId { get; set; }
public string Albumes { get; set; }
public int Edad { get; set; }
public string Genero { get; set; }
public string Nacionalidad { get; set; }
public string Nombre { get; set; }
public int Premios { get; set; }
public int ActivoDesde { get; set; }

}