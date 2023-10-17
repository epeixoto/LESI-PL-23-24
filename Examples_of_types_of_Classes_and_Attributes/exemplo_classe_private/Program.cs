using aminhaapp_Internal;

namespace exemplo_classe_private
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Maria", 28);
            
            pessoa.MostraNome();  
            pessoa.MostraIdade();


        }
    }
}