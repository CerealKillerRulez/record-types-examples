namespace RecordTypes.UseCases.CustomProperties;

/// <summary>
/// Questo esempio mostra come è possibile arricchire i nostri record con proprietà custom o campi calcolati.
/// 
/// Queste proprietà non saranno incluse nel costruttore parametrico sintetizzato dal compilatore e dovranno essere 
/// idratate manualmente tramite object initializer.
/// </summary>
public class CustomPropertiesUseCase {

    public static void ExecuteCase() {

        var golf = new Veicolo("Volksvagen", "XX123XX") { Modello = "Golf" };

        // La proprietà Modello sarà modificabile, in quanto custom property definita come read-write
        golf.Modello = "Golf 6";
    }

}


public record Veicolo(string Marca, string Targa) {
    public string Modello { get; set; } = default!;
}