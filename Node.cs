using System;
using System.Collections.Generic;
using System.Text;

public class Node{
    
    public AgendaTelefonica data;
    public Node next;
    
    public Node(AgendaTelefonica a)
    {
        data = a;
        next = null;
    }

}