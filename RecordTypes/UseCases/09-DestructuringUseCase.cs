namespace RecordTypes.UseCases.Destructuring;

/// <summary>
/// Questo esempio mostra le moadlità di estrazione dei valori delle proprietà in variabili separate:
/// 
/// Con il destructuring possiamo dichiarare variabili in modo implicito che verranno riempite dei valori delle proprietà, presi dall'istanza del record.
/// 
/// Il metodo Deconstruct() è un'alternativa al destructuring.
/// </summary>
public class DestructuringUseCase {

    public static void ExecuteCase()
    {
        var golf = new Veicolo("Volkswagen", "Golf", "XX123XX");
        var (marca, modello, targa) = golf;

        // Le variabili sono riempite in modo posizionale con i valori presi dalle proprietà del record
        Console.Write($"{marca} {modello} - {targa}");


        // è possibile omettere il destructuring di una o più proprietà mettendo _ alla posizione della proprietà che vogliamo scartare
        var (marca2, _, targa2) = golf;

        Console.Write($"{marca2} - {targa2}");

        
        // è possibile ottenere un risultato analogo al destructuring utilizzando il metodo Deconstruct() sintetizzato dal compilatore
        string marca3, modello3, targa3;
        golf.Deconstruct(out marca3, out modello3, out targa3);

        Console.Write($"{marca3} {modello3} - {targa3}");
    }

}



public record Veicolo(string Marca, string Modello, string Targa);