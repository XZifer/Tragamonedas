using Tragamonedas.Aplicacion;

Console.WriteLine("Quieres jugar al Tragamonedas: S- Si  Otra- No");
string jugar = Console.ReadLine();
JuegoTragamonedas tragamonedas = new JuegoTragamonedas();

while (jugar.ToUpper() == "S")
{
    tragamonedas.JalarPalanca();
    Console.WriteLine("Volver a jugar?: S- Si Otro- No");
    jugar = Console.ReadLine();

}
