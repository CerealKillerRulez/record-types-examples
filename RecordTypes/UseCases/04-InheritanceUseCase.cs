namespace RecordTypes.UseCases.Inheritance;

/// <summary>
/// L'esempio mostra come si comporta l'ereditarietà per i record. 
/// Sarà possibile creare record derivati a partire da record base (anche astratti) e sfruttare la sintassi posizionale per creare strutture derivate complesse.
/// 
/// Il record derivato dovrà dichiarare nella sua firma anche le proprietà per idratare il record base.
/// Questo servirà a definire il suo stato interno e ad idratare le proprietà del record base.
/// 
/// L'ereditarietà è applicabile solamente ai tipi record [class], mentre non sarà possibile applicare l'ereditarietà 
/// tra due record struct o tra una classe ed un record
/// </summary>
public class InheritanceUseCase {

    public static void ExecuteCase()
    {

        var macchina = new Automobile("Volkswagen", "Golf", "XX123XX", 3);

        Console.WriteLine(macchina);
    }

}


public abstract record Veicolo(string Marca, string Targa);
public record Automobile(string Marca, string Modello, string Targa, int Porte) : Veicolo(Marca, Targa);


// Eliminate il commento per vedere come non è possibile applicare l'ereditarietà ai tipi record struct.
// Il compilatore genera un errore.
//
//public record struct Persona(string Cognome, string Nome);
//public record struct Professore(string Cognome, string Nome, string Matricola) : Persona(Cognome, Nome);