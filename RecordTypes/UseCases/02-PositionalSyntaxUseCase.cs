namespace RecordTypes.UseCases.PositionalSyntax;

/// <summary>
/// Questo esempio mostra come è possibile definire un record con la sintassi posizionale concisa.
/// 
/// Dichiarando i record con questa sintassi il compilatore sintetizzerà un costruttore parametrico 
/// da utilizzare per l'istanza dell'oggetto (non verrà sintetizzato il costruttore di default).
/// 
/// Una volta istanziato in memoria l'oggetto, immutabile di default, non potrà più variare il suo stato.
/// </summary>
public class PositionalSyntaxUseCase {

    public static void ExecuteCase() {
        var golf = new Veicolo("Volkswagen", "XX123XX", "Golf");

        // rimuovere il commento per notare l'errore sollevato dal compilatore se proviamo a modificare lo stato della proprietà Modello
        //golf.Modello = "Golf 6";


        //è possibile utilizzare  i named arguments per bypassre l'ordine posizionale dei parametri del costruttore e migliorare la leggibilità del codice 
        var golf2 = new Veicolo(
            Targa: "XX123XX",
            Marca: "Volkswagen", 
            Modello: "Golf"            
        );
    }

}



public record Veicolo(string Marca, string Modello, string Targa);
