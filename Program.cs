using System;

namespace ListaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLista lista = new CircularLista();
            

            //lista.Add(new AgendaTelefonica("carlos", "uvv@gmail.com", "27 9973464922"));
            //lista.Add(new AgendaTelefonica("mashiho", "emescam@gmail.com", "29 9973464922"));
            //lista.Add(new AgendaTelefonica("ana", "ufes@gmail.com", "28 9973464922"));
            
            lista.Add();
            lista.PrintList();

            //lista.Remove("27 9973464922");
            //lista.OrdenarPorNome();

            //lista.Update(5, 3);
            //lista.Orderer(listafinal.data);


            //lista.PrintList();

            //retorna node se achar o numero e retorna nada se nao achar
            //Console.WriteLine(lista.Find("mashiho"));
            //imprime os dados do contato atraves do numero pesquisado
            //lista.Find("29 9973464922");

            //lista.Update("ana", "ana carolina", "carol@gmail.com", "30 9973464922");
            //lista.PrintList();

            
        }
    }
}
