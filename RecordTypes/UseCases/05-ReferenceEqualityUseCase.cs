namespace RecordTypes.UseCases.ReferenceEquality;

/// <summary>
/// Questo esempio mostra il comportamento di default della reference types quando vengono confrontati.
/// 
/// La reference equality si basa sul confronto degli indirizzi di memoria occupati dagli oggetti nello heap.
/// Due istanze, anche se apparentemente uguali, restituiranno false nelle operazioni di confronto perché istanziate in zone diverse della memoria.
/// </summary>
public class ReferenceEqualityUseCase {

    public static void ExecuteCase()
    {
        var golf = new Veicolo() {
            Marca = "Volkswagen",
            Modello = "Golf 6",
            Targa = "XX123XX"
        };

        var golf2 = new Veicolo() {
            Marca = "Volkswagen",
            Modello = "Golf 6",
            Targa = "XX123XX"
        };

        // Reference equality: il confronto è basato sull’indentità dell’istanza
        Console.WriteLine(golf == golf2); // False
        Console.WriteLine(ReferenceEquals(golf, golf2)); //False
    }

}


public class Veicolo {
    public string Marca { get; init; } = default!;
    public string Modello { get; init; } = default!;
    public string Targa { get; init; } = default!;
}