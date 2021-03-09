using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
                if(( String.Equals(String.Concat(v1,v2),"tesourapapel"))  || ( String.Equals(String.Concat(v1,v2),"papelpedra"   )) //complete a solução
                    || ( String.Equals(String.Concat(v1,v2),"pedralagarto"    )) || ( String.Equals(String.Concat(v1,v2),"lagartoSpock"    ))
                    || ( String.Equals(String.Concat(v1,v2),"Spocktesoura"   )) || ( String.Equals(String.Concat(v1,v2),"tesouralagarto"   ))
                    || ( String.Equals(String.Concat(v1,v2),"lagartopapel"    )) || ( String.Equals(String.Concat(v1,v2),"papelSpock"   ))
                    || ( String.Equals(String.Concat(v1,v2),"Spockpedra"    )) || ( String.Equals(String.Concat(v1,v2),"pedratesoura"  )))
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!", i);       
                    }
                             
                else if ( String.Equals(v1, v2)    )   //complete a solucao
                {
                    Console.WriteLine("Caso #{0}: De novo!", i);
                }      
                else
                {
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
                }
            }

    }

}