using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
public class Artistas
{
[BsonId]
[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
public string? ObjectId { get; set; }
public List<string> Albumes { get; set; }
public int Edad { get; set; }
public required string Genero { get; set; }
public required string Nacionalidad { get; set; }
public required string Nombre { get; set; }
public int Premios { get; set; }
public DateTime ActivoDesde { get; set; }
public RedesSociales RedesSociales { get; set; }
}