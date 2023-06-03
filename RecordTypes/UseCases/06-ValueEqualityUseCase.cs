namespace RecordTypes.UseCases.ValueEquality;

/// <summary>
/// Questo esempio mostra le politiche di cronfronto basate sul valore dei record types.
/// Anche se reference type, il loro confronto avviene paragonando lo stato interno delle due istanze.
/// 
/// Di conseguenza, anche se due istanze uguali occupano zone diverse dello heap, le operazioni di confronto restituiranno true se le 
/// proprietà dei due record conterranno gli stessi valori.
/// </summary>
public class ValueEqualityUseCase {

    public static void ExecuteCase()
    {
        var tesla = new Veicolo("Tesla", "Model 3", "XX123XX");
        var tesla2 = new Veicolo("Tesla", "Model 3", "XX123XX");

        // Value equality: il confronto è basato sui valori delle proprietà, pur essendo istanze differenti
        Console.WriteLine(tesla == tesla2); // True
        Console.WriteLine(ReferenceEquals(tesla, tesla2)); //False
    }

}


public record Veicolo(string Marca, string Modello, string Targa);