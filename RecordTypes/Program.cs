using RecordTypes.UseCases.CustomProperties;
using RecordTypes.UseCases.Destructuring;
using RecordTypes.UseCases.ExplicitDeclaration;
using RecordTypes.UseCases.Inheritance;
using RecordTypes.UseCases.InheritanceAndEquality;
using RecordTypes.UseCases.NonDestructiveMutation;
using RecordTypes.UseCases.PositionalSyntax;
using RecordTypes.UseCases.RecordAndLINQ;
using RecordTypes.UseCases.ReferenceEquality;
using RecordTypes.UseCases.ToStringOverride;
using RecordTypes.UseCases.ValueEquality;

namespace RecordTypesExamples;

public class MainClass {

    public static void Main() {
        ExplicitDeclarationUseCase.ExecuteCase();
        PositionalSyntaxUseCase.ExecuteCase();
        CustomPropertiesUseCase.ExecuteCase();
        InheritanceUseCase.ExecuteCase();
        ReferenceEqualityUseCase.ExecuteCase();
        ValueEqualityUseCase.ExecuteCase();
        InheritanceAndEqualityUseCase.ExecuteCase();
        NonDestructiveMutationUseCase.ExecuteCase();
        DestructuringUseCase.ExecuteCase();
        ToStringOverrideUseCase.ExecuteCase();
        RecordAndLINQUseCase.ExecuteCase();

        Console.ReadKey();
    }
}

public record Veicolo(string Marca, string Modello, string Targa);