using System;
using System.Collections.Generic;


public class Item
{
    public string Nome;
    public int Id;
    public int Preco;
    public string Desc;
}



public class Player
{
    public string nome;
    public int xp;
    public int gold;
    public List<Item> Itens = new List<Item>();
}



public class LP2_Trabalho
{

 
 
    static List<Player> Jogadores = new List<Player>();




    public static void Main(string[] args)
    {
       
        
        bool MostrarMenu = true;
        while (MostrarMenu)
        {
            MostrarMenu = MenuPrincipal();
        }

    }




    private static void CriarJogador(){

                Console.Clear();            
                Console.Write("Escreva um Apelido : ");
                var NomeJogador = Console.ReadLine();
                NomeJogador = NomeJogador.ToLower();


                Console.Write("Coloque uma quantidade de experiência: ");
                var Exp = Console.ReadLine();
               
                Random GetEXP = new Random();
                var ouro = GetEXP.Next(50, 350);


                Jogadores.Add(new Player { nome = NomeJogador, xp = Convert.ToInt32(Exp), gold = ouro});
                Console.Clear();
                Console.WriteLine("Jogador criado com sucesso");
                Console.WriteLine("");
                Console.WriteLine("Adicionamos " + ouro  + " de ouro na sua conta");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.Read();

    }


   

    private static void VisualizarJogadores(){

                Console.Clear();
                for (int i = 0; i < Jogadores.Count; i++)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Jogador:");            
                    Console.WriteLine("Apelido : " + Jogadores[i].nome);
                    Console.WriteLine("Exp : " + Jogadores[i].xp);
                    Console.WriteLine("Ouro : " + Jogadores[i].gold);                 
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.Write("Pressione qualquer tecla para sair...");
                Console.ReadKey();
    }




    private static void ChecarInv(){
            
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador para ver o iventário:");
            var NomeJogador = Console.ReadLine();
            NomeJogador = NomeJogador.ToLower();
            foreach(Player p in Jogadores)
            {
                if(p.nome == NomeJogador)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Itens:");
                    Console.WriteLine("");
                    for (int i = 0; i < p.Itens.Count; i++)
                    {
                        Console.WriteLine("Item: " + p.Itens[i].Nome);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.Read();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado... Retornando ao menu principal");
                    Console.Read();
                }
            }

    }




    private static void Store(
      
        Item Espada_De_Ferro_Store, 
        Item Espada_De_Ouro_Store,
        Item Machado_De_Aco_Store, 
        Item Armadura_De_Ferro_Store,  
        Item Cajado_Leviata_Store
        
        ){
            

            Console.Clear();
            Console.WriteLine("Digite o nome do jogador que irá acessar a loja: ");
            var NomeJogador = Console.ReadLine();
            NomeJogador = NomeJogador.ToLower();
      
      
               
            foreach(Player p in Jogadores)
            {
                if(p.nome == NomeJogador)
                {       
                    Console.WriteLine("- Insira o ID do item que você espera comprar:");
                    Console.WriteLine("");
                    Console.WriteLine(Espada_De_Ferro_Store.Id + " - " + Espada_De_Ferro_Store.Nome  + " " + Espada_De_Ferro_Store.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Espada_De_Ouro_Store.Id + " - " + Espada_De_Ouro_Store.Nome  + " " + Espada_De_Ouro_Store.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Machado_De_Aco_Store.Id + " - " + Machado_De_Aco_Store.Nome  + " " + Machado_De_Aco_Store.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Armadura_De_Ferro_Store.Id + " - " + Armadura_De_Ferro_Store.Nome  + " " + Armadura_De_Ferro_Store.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Cajado_Leviata_Store.Id + " - " + Cajado_Leviata_Store.Nome + " " + Cajado_Leviata_Store.Desc);       
                    Console.WriteLine("");
                    var itenconsult = Console.ReadLine();
                 
                 

                    if( itenconsult == Espada_De_Ferro_Store.Id.ToString() ){

                        Console.WriteLine("Você gostaria de comprar " + Espada_De_Ferro_Store.Nome + " por " + Espada_De_Ferro_Store.Preco + "de ouro? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.gold >= Espada_De_Ferro_Store.Preco)
                            {
                                p.gold = p.gold - Espada_De_Ferro_Store.Preco;
                                p.Itens.Add(Espada_De_Ferro_Store);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao seu iventário com sucesso!");
                               Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Ouro insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            } 
                    }


                    else if(itenconsult == Espada_De_Ouro_Store.Id.ToString())
                    {
                        Console.WriteLine("Você gostaria de comprar " + Espada_De_Ouro_Store.Nome + " por " + Espada_De_Ouro_Store.Preco + "de ouro? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);              
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.gold >= Espada_De_Ouro_Store.Preco)
                            {
                                p.gold = p.gold - Espada_De_Ouro_Store.Preco;
                                p.Itens.Add(Espada_De_Ouro_Store);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao seu iventário com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Ouro insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                              else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           } 
                    }

                    
                    else if(itenconsult == Machado_De_Aco_Store.Id.ToString())
                    {

                       Console.WriteLine("Você gostaria de comprar " + Machado_De_Aco_Store.Nome + " por " + Machado_De_Aco_Store.Preco + "de ouro? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                       resp = resp.ToLower();
                        if(resp == "s" )
                        {
                            if(p.gold >= Machado_De_Aco_Store.Preco)
                            {
                                p.gold = p.gold - Machado_De_Aco_Store.Preco;
                                p.Itens.Add(Machado_De_Aco_Store);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao seu iventário com sucesso!");
                                 Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Ouro insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                         else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           } 
                    }


                    else if(itenconsult == Armadura_De_Ferro_Store.Id.ToString())
                    {
                       Console.WriteLine("Você gostaria de comprar " + Armadura_De_Ferro_Store.Nome + " por " + Armadura_De_Ferro_Store.Preco + "de ouro? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.gold >= Armadura_De_Ferro_Store.Preco)
                            {
                                p.gold = p.gold - Armadura_De_Ferro_Store.Preco;
                                p.Itens.Add(Armadura_De_Ferro_Store);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao seu iventário com sucesso!");
                                 Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                           else
                            {
                                Console.WriteLine("Ouro insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                             else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           } 
                    }


                     else if(itenconsult == Cajado_Leviata_Store.Id.ToString())
                    {

                       Console.WriteLine("Você gostaria de comprar " + Cajado_Leviata_Store.Nome + " por " + Cajado_Leviata_Store.Preco + "de ouro? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.gold >= Cajado_Leviata_Store.Preco)
                            {
                                p.gold = p.gold - Cajado_Leviata_Store.Preco;
                                p.Itens.Add(Cajado_Leviata_Store);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao seu iventário com sucesso!");    
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                            else
                            {

                                Console.WriteLine("Ouro insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }
                        }
                        else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           } 
                    }

                    else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado...");
                    Console.WriteLine("Insira qualquer tecla para retornar ao menu principal...");
                    Console.ReadLine();
                    }
              
                 }
            }

    }



























    private static bool MenuPrincipal()
    {

            Item Espada_De_Ferro = new Item();
            Espada_De_Ferro.Id = 1;
            Espada_De_Ferro.Nome = "Espada de Ferro";
            Espada_De_Ferro.Preco = 40;
            Espada_De_Ferro.Desc = "(+12% DESTREZA)";

            Item Espada_De_Ouro = new Item();
            Espada_De_Ouro.Id = 2;
            Espada_De_Ouro.Nome = "Espada de ouro";
            Espada_De_Ouro.Preco = 100;
            Espada_De_Ouro.Desc = "(+20% DANO DE ATAQUE)";

            Item Machado_De_Aco = new Item();
            Machado_De_Aco.Id = 3;
            Machado_De_Aco.Nome = "machado de aço";
            Machado_De_Aco.Preco = 50;
            Machado_De_Aco.Desc = "(50% DANO DE ATAQUE)";

            Item Armadura_De_Ferro = new Item();
            Armadura_De_Ferro.Id = 4;
            Armadura_De_Ferro.Nome = "Armadura de ferro";
            Armadura_De_Ferro.Preco = 20;
            Armadura_De_Ferro.Desc = "(+20% PROTEÇÃO)";

            Item Cajado_Leviata = new Item();
            Cajado_Leviata.Id = 5;
            Cajado_Leviata.Nome = "Cajado leviata";
            Cajado_Leviata.Preco = 75;
            Cajado_Leviata.Desc = "(+90% CHANCE DE ACERTO CRÍTICO, DANO MÁGICO)";


       


        Console.Clear();
        Console.WriteLine("==================================================================");
        Console.WriteLine("Entre com '1' para criar um jogador (necessário para entrar na loja).");
        Console.WriteLine("Entre com '2' para ver os jogadores criados.");
        Console.WriteLine("Entre com '3' para ver o seu inventário.");
        Console.WriteLine("Entre com '4' para entrar na loja.");
        Console.WriteLine("Entre com '5' para encerrar o programa.");
        Console.WriteLine("==================================================================");
        switch (Console.ReadLine())
        {
            case "1":
            CriarJogador();
            return true;//END CASE (SWITCH)


            case "2":
            VisualizarJogadores();
            return true;//END CASE (SWITCH)
    

            case "3":
            ChecarInv();
            return true;//END CASE (SWITCH)


            case "4":
            Store(
                Espada_De_Ferro,
                Espada_De_Ouro,
                Machado_De_Aco,
                Armadura_De_Ferro,
                Cajado_Leviata,
            );
            return true;


            
            case "5":
                return false;


            
            default:
                return true;





        }
    
    }






}