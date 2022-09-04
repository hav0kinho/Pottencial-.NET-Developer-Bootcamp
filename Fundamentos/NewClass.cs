using System.IO;
using System.Linq;

class s{

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < qt; i++){
            
            string a = v[0];
            string b = v[1];
            
            if (int.Parse(a) % 10 != int.Parse(b) % 10){
              Console.WriteLine("nao encaixa");
            }
            
            else if (int.Parse(a) % 10 == int.Parse(b) % 10){
              Console.WriteLine("encaixa");
            }
            
            else{
              Console.WriteLine("nao encaixa");
            }
        }
    }

}