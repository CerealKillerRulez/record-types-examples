using System.Text;

namespace RecordTypes.UseCases.ToStringOverride;

/// <summary>
/// Questo esempio mostra il comportamento delle implementazioni di default del metodo ToString() per i reference types e per i record.
/// Spiega, inoltre, come è possibile fare overrides dei metodi di stampa sintetizzati dal compilatore come PrintMembers()
/// </summary>
public class ToStringOverrideUseCase {

    public static void ExecuteCase()
    {
        var golfClass = new VeicoloClass() {
            Marca = "Volkswagen",
            Modello = "Golf 6",
            Targa = "XX123XX"
        };

        // L'implementazione di default di ToString() di un reference type stampa a video il nome dell'oggetto
        Console.Write(golfClass);


        // L'implementazione di default di ToString() di un record stampa la struttura del record, inserendo l'elenco di proprietà e valori
        var golfRecord = new VeicoloRecord("Volkswagen", "Golf", "XX123XX");

        Console.Write(golfRecord);
    }

}


public class VeicoloClass {
    public string Marca { get; init; } = default!;
    public string Modello { get; init; } = default!;
    public string Targa { get; init; } = default!;
}


public record VeicoloRecord(string Marca, string Modello, string Targa) {

    // è possibile fare override del metodo PrintMembers per modificare la struttura della stringa da visualizzare a video per le coppie proprietà\valore
    protected virtual bool PrintMembers(StringBuilder builder) {
        builder.Append($" Marca: {Marca} - ");
        builder.Append($" Modello: {Modello} - ");
        builder.Append($" Targa: {Targa}");
        return true;
    }

}

