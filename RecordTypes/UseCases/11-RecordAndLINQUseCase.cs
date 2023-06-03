namespace RecordTypes.UseCases.RecordAndLINQ;

/// <summary>
/// L'esempio mostra tutte le potenzialità dei record utilizzati in operazioni LINQ.
/// I record possono essere usati come chiave in operazioni come GroupBy(), Distinct(), Union() o Join().
/// 
/// Non è invece possibile ordinare liste di tipi record poiché non implementa IComparable, quindi non è possibile usare il metodo OrderBy().
/// </summary>
public class RecordAndLINQUseCase {

    public static void ExecuteCase()
    {
        List<Veicolo> automobili = new() {
            new Veicolo("Volkswagen", "Golf", "XX123XX"),
            new Veicolo("Fiat", "Tipo", "YY999XX"),
            new Veicolo("Tesla", "Model 3", "XX666XX"),
            new Veicolo("Volkswagen", "Golf", "XX123XX"),
            new Veicolo("Citroen", "C1", "WW433XX"),
            new Veicolo("Volkswagen", "Golf", "XX123XX")
        };

        
        // La distinct influenza il conteggio degli elementi nella lista perché un record può essere utilizzato come chiave nelle operazioni LINQ
        Console.WriteLine($"La lista contiene {automobili.Count()} elementi");
        Console.WriteLine($"La lista senza duplicati contiene {automobili.Distinct().Count()} elementi");



        // Chiamando il metodo OrderBy solleveremo un'eccezione perché record non implementa IComparable 
        foreach (var auto in automobili.OrderBy(x => x))
            Console.WriteLine(auto);



        // Un record può anche essere utilizzato come chiave di raggruppamento nelle operazioni GroupBy di LINQ
        var autoGrouped = automobili.GroupBy(x => x).Select(x => (key: x.Key, count: x.Count()));

        foreach (var auto in autoGrouped)
            Console.WriteLine($"il record {auto.key} compare {auto.count} volte");
    }

}


public record Veicolo(string Marca, string Modello, string Targa);