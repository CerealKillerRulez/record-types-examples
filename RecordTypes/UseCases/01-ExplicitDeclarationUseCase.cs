namespace RecordTypes.UseCases.ExplicitDeclaration;

/// <summary>
/// Questo esempio mostra come è possibile definire un record con la sintassi tradizionale che utilizziamo per la dichiarazione di una classe.
/// In questi casi la gestione dell'immutabilità è totalmente manuale ed è ottenuta marcando le proprietà con l'init-only setter.
/// 
/// Notate come è possibile definire contesti ibridi marcando, se necessario, alcune proprietà come read-write (come per la proprietà Modello).
/// Queste proprietà possono essere modificate tramite il setter anche dopo l'istanza del record.
/// 
/// Con questa sintassi il compilatore andrà a sintetizzare il costruttore di default, che utilizzeremo per l'istanza in memoria, idratando 
/// le proprietà tramite object initializer.
/// </summary>
public class ExplicitDeclarationUseCase {

    public static void ExecuteCase()
    {
        var golf = new Veicolo {
            Marca = "Volkswagen",
            Targa = "XX123XX",
            Modello = "Golf"
        };

        golf.Modello = "Golf 6";
    }

}


public record Veicolo {
    public string Marca { get; init; } = default!;
    public string Modello { get; set; } = default!;
    public string Targa { get; init; } = default!;
}

