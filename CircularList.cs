using System;
using System.Collections.Generic;
using System.Text;


class CircularLista{

    AgendaTelefonica agenda;
    public Node head;
    ///public Node tail;  poderia usar a logica do tail, pesquise sobre
    public int cont = 1;

    public CircularLista()
    {
        head = null;
    }

    public void Add()
    {
        Node aux = head;
        Node newNode = new Node(agenda);

        Console.WriteLine("Digite os dados do contato: ");
        Console.Write("Nome: ");
        newNode.data.nome = Console.ReadLine();
        //Console.Write("Email: ");
        //newNode.data.email = Console.ReadLine();
        //Console.Write("Telefone: ");
        //newNode.data.telefone = Console.ReadLine();               

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
    
    
    public void Remove(String telefone)
    {
        if(this.IsEmpty())
        {
            return;
        }

        Node aux = head;
        Node ant = null; //ant = anterior

        //remove usando o telefone
        while ((aux != null && (aux.data.telefone != telefone)))
        {
            ant = aux;
            aux = aux.next;
        }
        
        //remove o primeiro nó
        if(ant == null){ 
            head = aux.next;
        }else
        {
            ant.next = aux.next;
        }

        //nó é removido da MEM. by GC(garbage collection)
    }
    

    //Recuperar/Consultar(?)
    public void Find(String telefone)
    {
        Node aux = head;
        int contAux = 0;

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
        Console.WriteLine($" -> [{aux.data.nome}, {aux.data.email}, {aux.data.telefone}]");
            
    }
    

    public Node Update(String nome, String newNome, String newEmail, String newTel)
    {
        Node aux = head;
        int contAux = 0;

        while ((aux != null) && (aux.data.nome != nome))
        {
            if(contAux == cont)
            {
                Console.WriteLine("Número não encontrado.");
                return null;
            }

            aux = aux.next;
            contAux++;
        }
            aux.data.nome = newNome;
            aux.data.email = newEmail;
            aux.data.telefone = newTel;
            return aux;
    }

    public void OrdenarPorNome()
    {
        Node aux = head;
        Node ant = null; //ant = anterior
        Node newNode = new Node(aux.data);
        
        int contAux = 0;
        
        while (aux != null)
        {
            contAux++;
            if(contAux == cont)
            {
                Console.WriteLine("Ordenação finalizada.");
                ant.next = aux.next;
                
                return;
            }

            if (String.Compare(aux.data.nome, aux.next.data.nome) == 0)
            {
                Console.WriteLine($"Both strings have same value. NAO FAZ NADA"); 
            }  
                 
            else if (String.Compare(aux.data.nome, aux.next.data.nome) < 0)  
            {
                Console.WriteLine($"{aux.data.nome} precedes {aux.next.data.nome}.");  
                 //aux.next = head;
                 //head = aux;
                    
                 ant = aux;
                 aux = aux.next;
                 
                 
                 //newNode.next = null;

                 //if(aux.next == null)
                 //   return;
                 
            }
                
            else if (String.Compare(aux.data.nome, aux.next.data.nome) > 0){
                Console.WriteLine($"{aux.data.nome} follows {aux.next.data.nome}.");
                   // Console.WriteLine(newNode.data.nome);
                   ant.next = aux.next;
                   ant.next = aux;
                   //aux.next = ant.next;
                   
                   aux = ant.next;

                  Console.WriteLine(aux.data.nome);
                  Console.WriteLine(aux.next.data.nome);
                  Console.WriteLine(ant.data.nome);
                  Console.WriteLine(ant.next.data.nome);
                 //aux = aux.next;
                 //  Console.WriteLine(aux.data.nome);
                
                //ant = ant.next;
                // aux = aux.next;



                    //aux.next = ant;
                 //  head = ant;
                  // Console.WriteLine(head.data.nome);
                   // aux.next = head;
                    //Console.WriteLine(aux.next.data.nome);
                  //  aux = ant;


                   
                    
                   //aux = newNode;
                   //aux = aux.next;
                   //aux.next = newNode;
                   //newNode = null;
                   
        
                   //aux = aux.next;
                   //head = aux;
                   
                   //aux.next = head;
                 //aux.next = null;
                 //head= aux.next;
                 
            }   
            
            //ant.next = aux.next;
        }
        //newNode = ant;
        //newNode.next = newNode;
        
        

        //newNode = head;
    }

    /*
    public void Orderer(int valor)
    {
        var newNode = new Node(valor);
        Node aux = head;

        //Trata a lista vazia e insere o menor valor na lista
        if(head == null || valor < head.data)
        {
            newNode.next = head;
            head = newNode;
            return;
        }

        while((aux.next != null) && (valor > aux.next.data))
        {
            aux = aux.next;
        }

        newNode.next = aux.next;
        aux.next = newNode;
        
    }
    */

}