using System;
using System.Collections.Generic;
using System.Text;


class CircularLista{

    AgendaTelefonica agenda = new AgendaTelefonica();
    public Node head;
    ///public Node tail;  poderia usar a logica do tail, pesquise sobre
    public int cont = 1;

    public CircularLista()
    {
        head = null;
    }

    public void Add()
    {
        agenda = new AgendaTelefonica();
        Node aux = head;
        var newNode = new Node(agenda);

        Console.WriteLine("Digite os dados do contato: ");
        Console.Write("Nome: ");
        newNode.data.nome = Console.ReadLine();
        Console.Write("Email: ");
        newNode.data.email = Console.ReadLine();
        Console.Write("Telefone: ");
        newNode.data.telefone = Console.ReadLine();               

        if( head != null ){
            while(aux.next != head)
            {
                aux = aux.next;
            }
        }else{
            aux = newNode;
        }

        newNode.next = head;
        head = newNode;
        aux.next = head;
        cont++; //conta sempre que um item é adicionado
        
    }

    public void Navigation(){
        
        if(this.IsEmpty())
        {
            Console.WriteLine("Agenda vazia.");
            return;
        }

        bool checaTecla = true;
        Node aux = head;

            Console.Write("Use a tecla > para navegar entre os contatos(tecle qualquer coisa para parar): ");

        do
        {
            var ch = Console.ReadKey().Key;

                switch (ch)
                {
                    case ConsoleKey.RightArrow:
                        Console.Write($" -> [{aux.data.nome}, {aux.data.email}, {aux.data.telefone}]");
                        aux = aux.next;
                        break; 
                    
                    default:
                        checaTecla = false;
                        break;
                }

        }while(checaTecla);
        
    }

    public void PrintList()
    {
        if(head == null){
            Console.Write("Lista Vazia");
        }

        Console.Write("[HEAD]");
        var aux = head;

        do{
            Console.Write($" -> [{aux.data.nome}, {aux.data.email}, {aux.data.telefone}]");
            aux = aux.next;
        }while(aux != head);
        

        Console.WriteLine(" -> [NULL]");

    }

    
    public bool IsEmpty()
    {
        //lista vazia= true  lista preenchida=false
        return (head == null);
    }
    
    
    public void Remove()
    {
        Node aux = head;
        Node ant = null; //ant = anterior

        Console.Write("Digite o TELEFONE do contato que deseja excluir: ");
        String telefone = Console.ReadLine();

        if(this.IsEmpty())
        {
            Console.WriteLine("Agenda vazia.");
            return;
        }

        //remove usando o telefone
        while ((aux != null && (aux.data.telefone != telefone)))
        {
            ant = aux;
            aux = aux.next;
        }
        
        //remove o primeiro nó, quando há apenas um nó
        if(ant == null){ 
            head = aux.next;
            Console.WriteLine("Contato excluido.");
        }else
        {
            ant.next = aux.next;
            Console.WriteLine("Contato excluido.");
        }

        //nó é removido da MEM. by GC(garbage collection)
    }
    

    //Recuperar/Consultar(?)
    public void Find()
    {
        Node aux = head;
        int contAux = 0;

        Console.Write("Digite o TELEFONE do contato que você deseja procurar: ");
        String telefone = Console.ReadLine();

        while ((aux != null) && (aux.data.telefone != telefone))
        {
            if(contAux == cont)
            {
                Console.WriteLine("Contato nao encontrado");
                return;
            }

            aux = aux.next;
            contAux++;
  
        }
        Console.Write("Contato encontrado: ");
        Console.WriteLine($" -> [{aux.data.nome}, {aux.data.email}, {aux.data.telefone}]");
            
    }
    

    public Node Update()
    {
        Node aux = head;
        int contAux = 0;

        Console.WriteLine("Digite o TELEFONE do contato que deseja atualizar: ");
        String tel = Console.ReadLine();

        while ((aux != null) && (aux.data.telefone != tel))
        {
            if(contAux == cont)
            {
                Console.WriteLine("Número não encontrado.");
                return null;
            }

            aux = aux.next;
            contAux++;
        }

        Console.WriteLine("Digite o novo NOME do contato: ");
        String newNome = Console.ReadLine();
        Console.WriteLine("Digite o novo EMAIL do contato: ");
        String newEmail = Console.ReadLine();
        Console.WriteLine("Digite o novo TELEFONE do contato: ");
        String newTel = Console.ReadLine();

            aux.data.nome = newNome;
            aux.data.email = newEmail;
            aux.data.telefone = newTel;
            return aux;
    }


    public void OrdenarPorNome()
    {
        Node aux = head;
        
        int contAux = 0;

        do
        {
            contAux++;
            if(contAux == cont)
            {
                Console.WriteLine("Ordenação finalizada.");      
                return;
            }
            

            if (String.Compare(aux.data.nome, aux.next.data.nome) == 0)
            {
                Console.WriteLine($"Both strings have same value. NAO FAZ NADA"); 
            }  
               
            else if (String.Compare(aux.data.nome, aux.next.data.nome) < 0)  
            {
                Console.WriteLine($"{aux.data.nome} precedes {aux.next.data.nome}.");  
                 
                 aux = aux.next;
                 
            }

            else if (String.Compare(aux.data.nome, aux.next.data.nome) > 0){
                Console.WriteLine($"{aux.data.nome} follows {aux.next.data.nome}.");
                   AgendaTelefonica c = aux.data;
                        aux.data = aux.next.data;
                        aux.next.data = c;
            }           
        }
        while(aux != null);
        
    }

    public void OrdenarPorEmail()
    {
        Node aux = head;
        
        int contAux = 0;

        do
        {
            contAux++;
            if(contAux == cont)
            {
                Console.WriteLine("Ordenação finalizada.");
                return;
            }
            

            if (String.Compare(aux.data.email, aux.next.data.email) == 0)
            {
                Console.WriteLine($"Both strings have same value. NAO FAZ NADA"); 
            }  
               
            else if (String.Compare(aux.data.email, aux.next.data.email) < 0)  
            {
                Console.WriteLine($"{aux.data.email} precedes {aux.next.data.email}.");  
                 
                 aux = aux.next;
                 
            }

            else if (String.Compare(aux.data.email, aux.next.data.email) > 0){
                Console.WriteLine($"{aux.data.email} follows {aux.next.data.email}.");
                   AgendaTelefonica c = aux.data;
                        aux.data = aux.next.data;
                        aux.next.data = c;
            }           
        }
        while(aux != null);
        
    }


    public void SalvarAgenda(){

        Console.WriteLine("Fechando aplicação.");
        if(!this.IsEmpty())
        {
            Node no = head;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\carlo\Desktop\ESTRUTURA DE DADOS I\ListaTelefonica\agenda.txt", false);

            do
            {
                file.WriteLine($"{no.data.nome}, {no.data.email}, {no.data.telefone}");
                no = no.next;

            }while(no != head);

            file.Close();
            Console.WriteLine("Arquivo salvo.");

        }else{
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\carlo\Desktop\ESTRUTURA DE DADOS I\ListaTelefonica\agenda.txt", false);
            file.Close();
            Console.WriteLine("Arquivo salvo.");
        }

    }

}