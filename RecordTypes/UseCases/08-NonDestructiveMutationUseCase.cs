namespace RecordTypes.UseCases.NonDestructiveMutation;

/// <summary>
/// Questo esempio mostra come usare la non-destructive mutation per creare nuove istanze di record, andando a modificare
/// solamente i valori delle proprietà che intendiamo modificare e lasciando inalterato il resto.
/// 
/// è anche possibile usare l'operatore with per creare una nuova istanza senza andare a modificare alcuna proprietà della nuova istanza.
/// In questo caso, l'immutabilità dei due record messi a confronto, garantirà l'uguaglianza delle istanze, poiché conterranno gli stessi
/// valori di proprietà.
/// </summary>
public class NonDestructiveMutationUseCase {

    public static void ExecuteCase()
    {
        var golf = new Veicolo("Volkswagen", "Golf", "XX123XX");
        var polo = golf with { Modello = "Polo" };

        // Il confronto value-based restituirà False perché le due istanze hanno proprietà con valori differenti
        Console.WriteLine(golf == polo); // False
        Console.WriteLine(ReferenceEquals(golf, polo)); // False

        // Eseguiamo una non destructive mutation dell'oggetto 'golf' senza modificare valori delle proprietà originali
        var golf2 = golf with { };

        // Dopo la copia, il confronto value-based continuerà a restituire true anche se la reference dei due oggetti è differente
        Console.WriteLine(golf == golf2); // True
        Console.WriteLine(ReferenceEquals(golf, golf2)); // False
    }

}


public record Veicolo(string Modello, string Marca, string Targa);