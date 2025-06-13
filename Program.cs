const string Sair = "tchau";

Console.WriteLine("Conversa com seu amigo Groot#");

string pergunta;
do
{
 Console.Write("Pergunta: ");
 pergunta = Console.ReadLine()!;

 string resposta = ObtemRespostaGroot(pergunta);

 ExibeResposta(ObtemRespostaGroot(pergunta));

} while (pergunta.Trim().ToLower() != Sair);


void ExibeResposta(string resposta)
{
 Console.WriteLine($" Resposta: {resposta}");
}

string ObtemRespostaGroot(string pergunta)
{
    return pergunta.Trim().ToLower() == Sair ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}
