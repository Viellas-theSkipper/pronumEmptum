using System;
using System.Threading;

public class Protagonista
{
    private string nome;
    private string desc;
    private double hp;
    private double xp;
    private double atk;
    private double def;
    private string classe;
    private int nivel;            

    public Protagonista()
    {
        nome = "???";
        desc = "";
        hp = 50;
        xp = 0;
        atk = 10;
        def = 5;
        classe = "";
        nivel = 1;               
    }

    public void SetClasse(string classe)
    {
        this.classe = classe;
    }

    public string GetClasse()
    {
        return classe;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetDesc(string desc)
    {
        this.desc = desc;
    }

    public string GetDesc()
    {
        return desc;
    }

    public void SetHp(double hp)
    {
        this.hp = hp;
    }

    public double GetHp()
    {
        return hp;
    }

    public void SetXp(double xp)
    {
        this.xp = xp;
    }

    public double GetXp()
    {
        return xp;
    }

    public void SetAtk(double atk)
    {
        this.atk = atk;
    }

    public double GetAtk()
    {
        return atk;
    }

    public void SetDef(double def)
    {
        this.def = def;
    }

    public double GetDef()
    {
        return def;
    }

    public void MostrarFicha()
    {
        Console.WriteLine("\n==== FICHA DO PERSONAGEM ====");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Descrição: {desc}");
        Console.WriteLine($"Classe: {classe}");
        Console.WriteLine($"HP: {hp}");
        Console.WriteLine($"ATK: {atk}");
        Console.WriteLine($"DEF: {def}");
        Console.WriteLine($"Nível: {nivel}  XP: {xp:F1}");
        Console.WriteLine("=============================\n");
    }
    
    public int GetNivel()       
    {
        return nivel;
    }

    
    public void AddXp(double quantidade)
    {
        xp += quantidade;
        Console.WriteLine($"\nVocê ganhou {quantidade} de XP! (XP atual: {xp:F1})");

        while (xp >= 1.0)
        {
            xp -= 1.0;
            nivel++;
            SetHp(GetHp() + 5);  
            SetAtk(GetAtk() + 3); 
            SetDef(GetDef() + 3); 
            Console.WriteLine($"\nParabéns! Você subiu para o nível {nivel}!");
        }
    }
}

public class Espadachin : Protagonista
{
    private const double atkExtra = 5;
    private const double hpMinus = -5;

    public void AplicarClasse()
    {
        SetAtk(GetAtk() + atkExtra);
        SetHp(GetHp() + hpMinus);
        SetClasse("Espadachin");
    }
}

public class Tank : Protagonista
{
    private const double defExtra = 5;
    private const double hpBonus = 10;
    private const double atkPenalty = -3;

    public void AplicarClasse()
    {
        SetHp(GetHp() + hpBonus);
        SetDef(GetDef() + defExtra);
        SetAtk(GetAtk() + atkPenalty);
        SetClasse("Tank");
    }
}

public class Principal
{
    private Protagonista jogador = new Protagonista();

    public void EsperarConfirmacao()
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
        Console.Clear();
    }

    public void MostrarFichaOpcional()
    {
        Console.Write("\nDeseja visualizar sua ficha? (s/n): ");
        if (Console.ReadLine().ToLower() == "s")
        {
            jogador.MostrarFicha();
            EsperarConfirmacao();
        }
    }

    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("Bem Vindo à Pronum Emptum");
        Console.WriteLine("================================================");
        Console.WriteLine("1. Jogar");
        Console.WriteLine("2. Informações");
        Console.WriteLine("3. Sair");
        Console.WriteLine("================================================");
        Console.Write("Digite a opção desejada: ");
    }

    public void CenaUm()
    {
        MostrarFichaOpcional();
        Console.Clear();
        Console.WriteLine($"{jogador.GetNome()}: Caraca, que saco! Minha memória RAM queimou.");
        Thread.Sleep(1600);
        Console.WriteLine("Agora tenho que ir lá no Rodo Shopping comprar uma nova.");
        Thread.Sleep(1600);
        Console.WriteLine("Depois de cinco longos minutos andando, você chega lá.");
        Thread.Sleep(1600);
        Console.WriteLine("Ao chegar, você vê uma nova loja.");
        Thread.Sleep(1600);
        Console.WriteLine("Lendo o letreiro, você percebe que está escrito: Pronum.");
        Thread.Sleep(1600);
        Console.WriteLine("Você resolve entrar na loja.");
        Thread.Sleep(1600);
        Console.WriteLine("Ao entrar, não vê ninguém.");
        Thread.Sleep(1600);
        Console.WriteLine("Chama por alguém no balcão, mas ninguém responde.");
        Thread.Sleep(1600);
        Console.WriteLine("Você tenta ir embora, mas não encontra mais a porta.");
        Thread.Sleep(1600);
        Console.WriteLine("Tenta procurar por algo, porém uma dor de cabeça estridente — como você nunca teve antes — começa a lhe afetar.");
        Thread.Sleep(1600);
        Console.WriteLine("Antes mesmo que consiga assimilar o que está acontecendo, seu corpo desliga.");
        Thread.Sleep(1600);
        Console.WriteLine("Você desmaia.");
        Thread.Sleep(1600);
        
        jogador.AddXp(0.5);
    }

    public void CenaDois()
    {
        Console.Clear();
        Console.WriteLine("Você acorda de repente.");
        Thread.Sleep(1600);
        Console.WriteLine("Sua cabeça lateja como se estivesse prestes a explodir.\nSeus olhos mal conseguem focar — a luz parece cortante, e a dor só aumenta.");
        Thread.Sleep(1600);
        Console.WriteLine("Quando finalmente recobra um pouco da visão, percebe onde está.");
        Thread.Sleep(1600);
        Console.WriteLine("O Rodo Shopping.");
        Thread.Sleep(1600);
        Console.WriteLine("Mas... algo está estranho. O lugar onde tantas vezes passou está agora irreconhecível.");
        Thread.Sleep(1600);
        Console.WriteLine("Paredes rachadas, vitrines estilhaçadas, tudo envolto em uma névoa escura e pesada.");
        Thread.Sleep(1600);
        Console.WriteLine("Um silêncio perturbador domina o ambiente.");
        Thread.Sleep(1600);
        Console.WriteLine("Você se levanta com dificuldade.");
        Thread.Sleep(1600);
        Console.WriteLine("Ao observar o canto de uma parede, seu coração dispara: um cadáver caído no chão.");
        Thread.Sleep(1600);
        Console.WriteLine("Uma mulher.");
        Thread.Sleep(1600);
        Console.WriteLine("Você se aproxima, engolindo seco.");
        Thread.Sleep(1600);
        Console.WriteLine("No chão, ao lado dela, há um crachá com o nome:");
        Thread.Sleep(1600);
        Console.WriteLine("Lívia — A ????.\n você não consegue ler o resto como se tivesse codificado.");
        Thread.Sleep(1600);
        Console.WriteLine("Sua expressão congelada parece carregar dor... e aviso.");
        Thread.Sleep(1600);
        Console.WriteLine("Em sua mão direita, uma lanterna. Você a retira sem fazer barulho.");
        Thread.Sleep(1600);
        Console.WriteLine("Na mão esquerda dela, uma carta. Você a retira com cuidado.\n");
        Thread.Sleep(1600);
        Console.WriteLine("Carta:\n");
        Console.WriteLine("Se você está lendo isso, significa que conseguiu atravessar a Ruptura.\nEste lugar já não pertence ao nosso mundo. Está preso entre o que foi e o que ainda pode surgir.");
        Thread.Sleep(1600);
        Console.WriteLine("A Ordem falhou... e agora cabe a você resistir.");
        Thread.Sleep(1600);
        Console.WriteLine("A carta termina de forma abrupta, rasgada na base.");
        Thread.Sleep(1600);
        
        jogador.AddXp(0.5);
    }

    public void CenaTres()
{
    Console.Clear();

    Console.WriteLine("Você sente um arrepio subir pela espinha.");
    Thread.Sleep(1600);
    Console.WriteLine("Você ainda segura a carta e a lanterna quando ouve um barulho estranho atrás de você.");
    Thread.Sleep(1600);
    Console.WriteLine("É como se algo estivesse arranhando o chão.");
    Thread.Sleep(1600);
    Console.WriteLine("Você se vira lentamente.");
    Thread.Sleep(1600);
    Console.WriteLine("Das sombras perto da escada rolante, uma criatura aparece.");
    Thread.Sleep(1600);
    Console.WriteLine("É humanoide, mas toda feita de fumaça escura e partes retorcidas.");
    Thread.Sleep(1600);
    Console.WriteLine("Seus olhos brilham em vermelho.");
    Thread.Sleep(1600);
    Console.WriteLine("Ela avança em sua direção.");
    Thread.Sleep(1600);

    if (jogador.GetClasse() == "Tank")
    {
        Console.WriteLine("Você percebe um escudo no cadáver.\nVocê o pega rapidamente.");
    }
    else
    {
        Console.WriteLine("Você percebe uma espada no cadáver.\nVocê a pega rapidamente.");
    }
    Thread.Sleep(1600);

    Console.WriteLine("A luta começa!");
    Thread.Sleep(800);

    // combate
    Random rnd = new Random();
    int criaturaHp = 45;

    while (criaturaHp > 0 && jogador.GetHp() > 0)
    {
        Console.WriteLine($"\nSeu HP: {jogador.GetHp()} | Vida da criatura: {criaturaHp}");
        Console.WriteLine("Escolha sua ação: 1. Ataque   2. Defesa");
        Console.Write("Opção: ");
        string acao = Console.ReadLine();

        if (acao == "1")
        {
            // Ataque do jogador
            Console.WriteLine($"\nVocê ataca e causa {jogador.GetAtk()} de dano!");
            criaturaHp -= (int)jogador.GetAtk();
        }
        else if (acao == "2")
        {
            // Defesa do jogador
            int rolagemDef = rnd.Next(1, 6);
            Console.WriteLine($"\nVocê tenta defender... Rolagem: {rolagemDef}");
            if (rolagemDef >= jogador.GetDef() / 2)
            {
                Console.WriteLine("Defesa bem sucedida! Nenhum dano recebido neste turno.");
                Thread.Sleep(1600);
                continue;  
            }
            else
            {
                Console.WriteLine("Defesa falhou!");
            }
        }
        else
        {
            Console.WriteLine("\nAção inválida. Você perde a vez.");
        }

        // Ataque da criatura
        int danoCriatura = rnd.Next(1, 6);  // até 5 de dano
        Console.WriteLine($"\nA criatura ataca e causa {danoCriatura} de dano!");
        jogador.SetHp(jogador.GetHp() - danoCriatura);

        Thread.Sleep(1600);
    }

    if (jogador.GetHp() <= 0)
    {
        Console.WriteLine("\nVocê foi derrotado pela criatura...");
    }
    else
    {
        Console.WriteLine("\nVocê derrotou a criatura!");
    }
    Thread.Sleep(1600);
    jogador.AddXp(0.5);
}

    public void CenaQuatro()
    {
        Console.Clear();
        Console.WriteLine("Após a batalha, você para, respira fundo e tenta se acalmar.\nO silêncio agora toma conta do local, mas é um silêncio estranho — pesado, como se algo ainda estivesse observando você.");
        Thread.Sleep(1600);
        Console.WriteLine("Você começa a andar pelo ambiente.");
        Thread.Sleep(1600);
        Console.WriteLine("Esse lugar já foi familiar.");
        Thread.Sleep(1600);
        Console.WriteLine("Agora, o Rodo Shopping está em ruínas:\nAs lojas estão destruídas, com vidros quebrados e manequins jogados no chão.\nO teto tem buracos por onde entra uma luz fraca e esverdeada.\n Há cheiro de mofo, ferrugem e algo... mais podre. ");
        Thread.Sleep(1600);
        Console.WriteLine("Enquanto explora, você vê uma placa enferrujada pendurada em um pilar rachado:");
        Thread.Sleep(1600);
        Console.WriteLine("\nPlaca:\nPara passar você deve encontrar os 4 números perdidos");
        Thread.Sleep(1600);
        Console.WriteLine("Ache os números e resolva o enigma!\n");
        Thread.Sleep(1600);
        Console.WriteLine($"{jogador.GetNome()}: Isto me lembra aquele jogo do fliperama, que eu costumava jogar aqui.");
        Thread.Sleep(1600);
        EsperarConfirmacao();

        int[] numeros = new int[4];
        int numerosEncontrados = 0;
        bool enigmaResolvido = false;

        while (!enigmaResolvido)
        {
            Console.Clear();
            Console.WriteLine($"=== Números encontrados: {numerosEncontrados}/4 ===");

            if (numerosEncontrados == 4)
            {
                Console.WriteLine("\nVocê encontrou todos os números! Deseja resolver o enigma agora? (s/n)");
                string resolverAgora = Console.ReadLine().ToLower();

                if (resolverAgora == "s")
                {
                    Console.WriteLine("\nVocê volta para a placa e lê a instrução novamente:");
                    Console.WriteLine("> Pegue o 1º número × 2º número. Depois - 3º número + 4º número.");
                    Console.Write("\nQual é o resultado? (Digite o número): ");

                    if (int.TryParse(Console.ReadLine(), out int respostaUsuario))
                    {
                        int calculoCorreto = (numeros[0] * numeros[1]) - numeros[2] + numeros[3];
                        if (respostaUsuario == calculoCorreto)
                        {
                            Console.WriteLine("\n*CLIQUE* Um mecanismo se abre, revelando uma passagem secreta!");
                            Thread.Sleep(1600);
                            jogador.AddXp(0.5);
                            Console.WriteLine("Você conseguiu!");
                            enigmaResolvido = true;
                            EsperarConfirmacao();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nNada Acontece.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNada Acontece.");
                    }
                }
            }

            Console.WriteLine("\nOnde você quer procurar?");
            Console.WriteLine("Dica: anote todos os números que você achar, e a ordem.");
            Console.WriteLine("1. Procurar no cadáver de Lívia.");
            Console.WriteLine("2. Olhar no espelho quebrado da loja de roupas.");
            Console.WriteLine("3. Revirar os escombros da praça de alimentação.");
            Console.WriteLine("4. Investigar a lan house abandonada");
            Console.WriteLine("5. Verificar o balcão de informações.");
            Console.WriteLine("6. Inspecionar fotos quebradas na parede.");
            Console.WriteLine("7. Tentar abrir um armário trancado.");
            Console.WriteLine("8. Tentar resolver o enigma.");
            Console.Write("\nEscolha uma opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    if (numeros[0] == 0)
                    {
                        Console.WriteLine("\nVocê revira os bolsos do cadáver...");
                        Thread.Sleep(1600);
                        Console.WriteLine("Encontra um pedaço de papel com o número 7 escrito!, 7 é o primeiro número.");
                        numeros[0] = 7;
                        numerosEncontrados++;
                    }
                    else
                    {
                        Console.WriteLine("\nVocê já revistou aqui. Não há mais nada.");
                    }
                    break;

                case "2":
                    if (numeros[1] == 0)
                    {
                        Console.WriteLine("\nVocê se aproxima do espelho rachado...");
                        Thread.Sleep(1600);
                        Console.WriteLine("Entre os cacos, há um 3 riscado no vidro!, 2 é o segundo número.");
                        numeros[1] = 3;
                        numerosEncontrados++;
                    }
                    else
                    {
                        Console.WriteLine("\nO espelho já está totalmente quebrado. Nada útil aqui.");
                    }
                    break;

                case "3":
                    if (numeros[2] == 0)
                    {
                        Console.WriteLine("\nVocê levanta uma mesa caída...");
                        Thread.Sleep(1600);
                        Console.WriteLine("Debaixo dela, está gravado o número 9!, 9 é o terceiro número.");
                        numeros[2] = 9;
                        numerosEncontrados++;
                    }
                    else
                    {
                        Console.WriteLine("\nSó restam migalhas e ratos aqui.");
                    }
                    break;

                case "4":
                    if (numeros[3] == 0)
                    {
                        Console.WriteLine("\nVocê empurra uma impressora caída...");
                        Thread.Sleep(1600);
                        Console.WriteLine("Atrás dela, um 2 está escrito na parede!, 2 é o quarto número.");
                        numeros[3] = 2;
                        numerosEncontrados++;
                    }
                    else
                    {
                        Console.WriteLine("\nSó há computadores quebrados e teclados sem teclas.");
                    }
                    break;

                case "5":
                    Console.WriteLine("\nVocê se aproxima do balcão de informações, coberto de poeira.");
                    Thread.Sleep(1600);
                    Console.WriteLine("Há folhetos espalhados, todos ilegíveis pelo tempo.");
                    Thread.Sleep(1600);
                    Console.WriteLine("Nada de útil aqui...");
                    break;

                case "6":
                    Console.WriteLine("\nVocê olha as fotos quebradas penduradas na parede.");
                    Thread.Sleep(1600);
                    Console.WriteLine("Parecem ser de uma família feliz, sorrindo em frente ao shopping.");
                    Thread.Sleep(1600);
                    Console.WriteLine("Você duvida que eles ainda estejam vivos...");
                    Thread.Sleep(1600);
                    Console.WriteLine("Volta a procurar em outro lugar.");
                    break;

                case "7":
                    Console.WriteLine("\nVocê tenta arrombar o armário trancado.");
                    Thread.Sleep(1600);
                    Console.WriteLine("Está emperrado. Nem mesmo um chute consegue abri-lo.");
                    Thread.Sleep(1600);
                    Console.WriteLine("Melhor não gastar energia à toa.");
                    break;

                case "8":
                    if (numerosEncontrados < 4)
                    {
                        Console.WriteLine("\nVocê ainda não encontrou todos os números!");
                    }
                    else
                    {
                        Console.WriteLine("\nVocê volta para a placa e lê a instrução novamente:");
                        Console.WriteLine("> Pegue o 1º número × 2º número. Depois - 3º número + 4º número.");
                        Console.Write("\nQual é o resultado? (Digite o número): ");
                        int respostaUsuario;
                        bool entradaValida = int.TryParse(Console.ReadLine(), out respostaUsuario);

                        if (entradaValida)
                        {
                            int calculoCorreto = (numeros[0] * numeros[1]) - numeros[2] + numeros[3];
                            if (respostaUsuario == calculoCorreto)
                            {
                                Console.WriteLine("\nClick. A passagem se abre!");
                                Thread.Sleep(1600);
                                Console.WriteLine("Você conseguiu!");
                                enigmaResolvido = true;
                            }
                            else
                            {
                                Console.WriteLine("\nNada Acontece.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNada Acontece.");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("\nNada Acontece.");
                    break;
            }
            EsperarConfirmacao();
        }
    }

    public void UltimaCena()
    {
        Console.Clear();
        MostrarFichaOpcional();
        Console.WriteLine("Você entra na passagem e se depara com um corredor escuro\nVocê ouve uma voz, algo sussura em seu ouvido, você subconscientemente anda em direção ao som.");
        Thread.Sleep(1600);

        if (jogador.GetClasse() == "Tank")
        {
            Console.WriteLine("Na localização do chamado você encontra.\nUm escudo antigo...\nEle exala uma energia sombria, encravado em meio ao concreto, seu corpo se estremece só de se aproximar.");
            Thread.Sleep(1600);
            Console.WriteLine("É possível perceber um nome gravado na borda.\nEric - o Protetor ???");
        }
        else
        {
            Console.WriteLine("Na localização do chamado você encontra.\nUma espada negra...\nEla exala um ar sombrio, cravada em meio ao concreto, seu corpo se estremece só de se aproximar.");
            Thread.Sleep(1600);
            Console.WriteLine("É possível perceber um nome na base da lâmina.\nEric - o Herói ???");
        }

        Thread.Sleep(1600);
        Console.WriteLine("Você sente uma conexão estranha, como se estivesse esperando por você.");
        Thread.Sleep(1600);
        Console.WriteLine("Antes mesmo de você sequer pensar, seu corpo se move e pega o objeto.");
        Thread.Sleep(1600);

        if (jogador.GetClasse() == "Tank")
        {
            Console.WriteLine("Assim que toca no escudo, algo muda.\nSua mente clareia. Sua pele fica mais resistente.\nVocê sente uma força protetora fluindo por você.");
        }
        else
        {
            Console.WriteLine("Assim que toca na lâmina, algo muda.\nSua mente clareia. Sua pele arrepia.\nVocê sente uma energia cortante fluindo por seus braços.");
        }

        Thread.Sleep(1600);
        Console.WriteLine("\nVocê sente uma presença... te observando.\n");
        Thread.Sleep(1600);
        Console.WriteLine("Você entra em estado de alerta.\n");
        Thread.Sleep(1600);
        Console.WriteLine("O ambiente parece mudar, as paredes tremem levemente.\n");
        Thread.Sleep(1600);
        Console.WriteLine("O silêncio se quebra com um som agudo.");
        Thread.Sleep(1600);
        Console.WriteLine("SLASH.\n");
        Thread.Sleep(1600);
        Console.WriteLine("Algo se move atrás de você.");
        Thread.Sleep(1600);
        
        jogador.AddXp(0.5);
    }

    public void EncontroArakne()
{
    Console.Clear();
    MostrarFichaOpcional();

    // INÍCIO DA BATALHA CONTRA ARAKNA
    int araknaHp = 30;
    Random rnd = new Random();

    Console.WriteLine("\nArakne, Herdeira Esquecida do Caos, surge diante de você!");
    Thread.Sleep(1600);

    while (araknaHp > 0 && jogador.GetHp() > 0)
    {
        Console.WriteLine($"\nSeu HP: {jogador.GetHp()} | HP de Arakna: {araknaHp}");
        Console.WriteLine("Escolha sua ação: 1. Ataque   2. Defesa");
        Console.Write("Opção: ");
        string acao = Console.ReadLine();

        if (acao == "1")
        {
            Console.WriteLine($"\nVocê ataca e causa {jogador.GetAtk()} de dano!");
            araknaHp -= (int)jogador.GetAtk();
        }
        else if (acao == "2")
        {
            int rolagemDef = rnd.Next(1, 6);
            Console.WriteLine($"\nVocê tenta defender... Rolagem: {rolagemDef}");
            if (rolagemDef >= jogador.GetDef() / 2)
            {
                Console.WriteLine("Defesa bem sucedida! Nenhum dano recebido neste turno.");
                Thread.Sleep(1600);
                continue;  // pule o veneno desta rodada
            }
            else
            {
                Console.WriteLine("Defesa falhou!");
            }
        }
        else
        {
            Console.WriteLine("\nAção inválida. Você perde a vez.");
        }

        // Arakna aplica veneno
        Console.WriteLine("\nArakne libera veneno!");
        Console.WriteLine("Você sofre 1 de dano de veneno!");
        jogador.SetHp(jogador.GetHp() - 1);

        Thread.Sleep(1600);
    }

    if (jogador.GetHp() <= 0)
    {
        Console.WriteLine("\nVocê foi derrotado por Arakne...");
    }
    else
    {
        Console.WriteLine("\nVocê derrotou Arakne!");
    }
    Thread.Sleep(1600);

    // RETORNA AO FLUXO ORIGINAL
    Console.WriteLine("\nVocê enfrenta a criatura em um combate épico...");
    Thread.Sleep(1600);
    if (jogador.GetClasse() == "Espadachin")
    {
        Console.WriteLine("Sua espada emite um brilho vermelho enquanto você ataca!");
    }
    else
    {
        Console.WriteLine("Seu escudo brilha enquanto você bloqueia seus ataques!");
    }
    Thread.Sleep(1600);
    Console.WriteLine("Usando tudo o que tem, você consegue derrotá-la!");
    Thread.Sleep(1600);
    Console.WriteLine("Mas isto não é nada que comparado ao futuro.");
    Thread.Sleep(1600);
    Console.WriteLine("O shopping ainda guarda muitos segredos...");
    Thread.Sleep(1600);
    Console.WriteLine("E sua jornada está apenas começando.");
    Thread.Sleep(1600);
    Console.WriteLine("\nObrigado por Jogar Pronum Emptum!");
    Console.WriteLine("(Este é um final temporário - mais conteúdo em breve!)");
    Thread.Sleep(2000);
    EsperarConfirmacao();
}

    public void CriarPersonagem()
    {
        Console.Clear();
        Console.WriteLine("\n===== CRIAÇÃO DE PERSONAGEM =====");

        Console.Write("Digite o nome do seu personagem: ");
        string nome = Console.ReadLine();

        Console.Write("Digite uma descrição: ");
        string desc = Console.ReadLine();

        Random dado = new Random();
        int rolagem = dado.Next(1, 7);
        double hpBase = (rolagem <= 3) ? 40 : 50;

        Console.WriteLine($"\nVocê rolou {rolagem} no dado. HP base: {hpBase}");
        Console.WriteLine("Escolha sua classe:");
        Console.WriteLine("1. Espadachin (ATK +5, HP -5)");
        Console.WriteLine("2. Tank (HP +10, DEF +5, ATK -3)");
        Console.Write("Sua escolha: ");
        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            Espadachin p = new Espadachin();
            p.SetNome(nome);
            p.SetDesc(desc);
            p.SetHp(hpBase);
            p.AplicarClasse();
            jogador = p;
        }
        else if (escolha == "2")
        {
            Tank p = new Tank();
            p.SetNome(nome);
            p.SetDesc(desc);
            p.SetHp(hpBase);
            p.AplicarClasse();
            jogador = p;
        }
        else
        {
            Console.WriteLine("Opção inválida. Criando personagem padrão (Espadachin).");
            Espadachin p = new Espadachin();
            p.SetNome(nome);
            p.SetDesc(desc);
            p.SetHp(hpBase);
            p.AplicarClasse();
            jogador = p;
        }

        Console.WriteLine("\nPersonagem criado com sucesso!");
        jogador.MostrarFicha();
        EsperarConfirmacao();
    }

    public void CasoUm()
    {
        Console.Clear();
        CriarPersonagem();

        Console.WriteLine("Preparando para começar a aventura...");
        Thread.Sleep(1600);
        Console.WriteLine($"\n{jogador.GetNome()}, sua jornada começa em...");
        Thread.Sleep(1600);

        for (int i = 3; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1600);
        }

        CenaUm();
        EsperarConfirmacao();
        CenaDois();
        EsperarConfirmacao();
        CenaTres();
        EsperarConfirmacao();
        CenaQuatro();
        EsperarConfirmacao();
        UltimaCena();
        EsperarConfirmacao();
        EncontroArakne();
        EsperarConfirmacao();
    }

    public void CasoDois()
    {
        Console.Clear();
        Console.WriteLine("Informações do jogo:");
        Console.WriteLine("Pronum Emptum é um jogo de RPG narrativo de mistério, suspense e sobrevivência.");
        Console.WriteLine("Você assume o papel de um protagonista que acorda preso em um shopping — onde segredos o aguardam.");
        Console.WriteLine("Explore o ambiente, descubra pistas, enfrente ameaças, tome decisões e tente desvendar o que causou a Ruptura.");
        Console.WriteLine("\nPrepare-se para uma jornada onde cada escolha pode alterar seu destino.");
        Console.WriteLine("\nPressione ENTER para voltar ao menu.");
        Console.ReadLine();
    }

    public void Inicio()
    {
        string escolha;
        do
        {
            Menu();
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    CasoUm();
                    break;

                case "2":
                    CasoDois();
                    break;

                case "3":
                    Console.WriteLine("\nAté Logo!");
                    Console.WriteLine("Saindo do jogo...");
                    Thread.Sleep(1000);
                    return;

                default:
                    Console.WriteLine("\nOpção inválida. Pressione ENTER para tentar novamente.");
                    Console.ReadLine();
                    break;
            }
        } while (true);
    }

    public static void Main()
    {
        Principal jogo = new Principal();
        jogo.Inicio();
    }
}
