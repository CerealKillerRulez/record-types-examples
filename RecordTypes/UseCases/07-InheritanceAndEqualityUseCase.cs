namespace RecordTypes.UseCases.InheritanceAndEquality;

/// <summary>
/// Questo esempio mostra come il tipo di record sia parte integrante dei meccanismi di confronto.
/// 
/// Anche se il controllo di uguaglianza avviene confrontando gli stati dei due oggetti, i tipi messi a confronto 
/// dovranno appartenere allo stesso tipo, anche se sottoclassi di un record base.
/// 
/// </summary>
public class InheritanceAndEqualityUseCase {

    public static void ExecuteCase()
    {
        var studente = new Studente("Rossi", "Mario", "XX123");
        var professore = new Professore("Rossi", "Mario", "XX123");

        // Il confronto restituirà False perché il tipo di studente è diverso dal tipo di professore
        Console.WriteLine(studente == professore); // False
    }

}



public record Persona(string Cognome, string Nome);
public record Studente(string Cognome, string Nome, string Matricola) : Persona(Cognome, Nome);
public record Professore(string Cognome, string Nome, string Matricola) : Persona(Cognome, Nome);