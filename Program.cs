

namespace DataBases;
using System;
class Program
{
    static void Main(string[] args)
    {/*
        var tipollave = new List<string>() { "ci" };
        var tipoattributo = new HashSet<string>() { "nombre" };
        var persona = new Entity("persona", tipollave, tipoattributo);
        var x = new Data<int>(1111);
        var nombre = new Data<string>("F");
        var ci = new AttributesSet("hola", new HashSet<IData>() { x });
        var nombreAtt = new AttributesSet("nombre", new HashSet<IData>() { nombre });
        var dict = new Dictionary<string, AttributesSet>();
        dict.Add("ci", ci);
        var keys = Lock.GenerateKey(dict, tipollave);
        var dict2 = new Dictionary<IEntity, KeyClass>();
        dict2.Add(persona, keys);
        var keysClass = new KeyClassWrapped(dict2);
        persona.AddInstance(keysClass, new List<AttributesSet>() { nombreAtt }, null);

        var nuevoatributos = new List<string> { "juego" };


        var personaJugadora = new SpecializedEntity(persona, "jugador", nuevoatributos);

        persona.CallToRemoveTheEntity("persona");
     */
    }
}