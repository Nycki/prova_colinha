using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace prova_colinha
{
    internal class Program
    {
        public static void Lista7()
        {
            //1.Você  é  um  aluno  do  Instituto  Federal  de  São  Paulo  que  precisa  entregar
            //um  programa desenvolvido em C# para automatizar o processo de soma dos preços das suas
            //compras. No supermercado,  a  cada  vez  que  você  adiciona  um  novo  produto  aocarrinho,
            //o  programa deverá  lera  quantidade  de  itens  adquiridos  e  o  preço  do  produto.
            //Seu  programa  somente deverá mostrar a quantidade total de itens adquiridos e o valor total
            //da compra quando for inserida uma quantidade igual ou menor a zero para um novo produto.  

            //2. Você  foi  contratado  para  desenvolver  um  programa  em  C#  para  auxiliar  o  gerente
            //de almoxarifado da mercearia Bom Preço a controlar o estoque de produtos. Toda vez que uma
            //nova  carga  de  produtos  é  entregue  na  mercearia,  o  gerente  precisa  fazer o
            //lançamento  do nome do produto, número de itens daquele produto e preço de compra.
            //Seu programa deve ler  quantos  produtos o gerente  quiser  lançar  no  sistema  e
            //somente  irá  encerrar  o  cadastro quando  for  fornecido  expressamente  algum
            //dado  que  indique  sua  vontade  de  parar  (você criará  essa  regra).
            //Após  indicar  que  não  quer  mais  cadastrar  produtos,  o  sistema  deverá
            //mostrar:a.Nome do produto e maior quantia total investida em um único produto
            //em estoque;b.Nome do produto e menor quantia total investida em um único produto em estoque.

            //3. Os  professores  do  IFSP  Campos  do  Jordão  estão  tendo  um  sério  problema  ao
            //realizar  o cadastro dos pesos associados à cada avaliação contida emsuas disciplinas.
            //O sistema atual não verificar se a soma individual dos pesos das avaliações cadastradas
            //totaliza100%. Faça um programa  onde  o  professor  forneça  inicialmente  o  número  de
            //avaliações  que  ele  planeja oferecer  em  um  bimestre.  Em  seguida,  seu  programa
            //deve  ser  capaz  de  realizar  a  leitura  e soma dos pesos associados a cada uma das avaliações.
            //Terminada a inserção dos pesos, seu programa  deve  mostrar  se  a  soma  total  dos  pesos  é
            //insuficiente  (inferior  a  100),  se  é excedente (superior a 100) ou se é adequada (igual a 100).

            //4.Escreva um programa que peça ao usuário para informar uma sigla de estado
            //(por exemplo, "SP"   para   São   Paulo).   O   programa   deve   então   exibir
            //o   nome   completo   do   estado correspondente. Se a sigla informada não corresponder
            //a um estado válido, o programa deve exibir uma mensagem de erro.Você deve obrigatoriamente
            //utilizar a estrutura switch.

            //5. Faça  um  programa  que  solicite  ao  usuário  que  digite  um  número  inteiro  entre
            //1  e  12, representando   um   mês   do   ano.   O   programa   deve   então   exibir   a
            //estação   do   ano correspondente   (Primavera,   Verão,   Outono   ou   Inverno),   utilizand
            //switch.Caso   seja escolhido algum mês que contenha duas estações, solicite informação extra
            //que possibilite a você definir qual estação será. Considere que esse programa funcionará para
            //o ano de 2023e que o programa poderá ser executadoum número indefinido de vezes.

            //6.Escreva um programa que peça ao usuário que informe o seu peso (em kg) e a sua altura (em metros).
            //O programa deve então calcular o seu IMC (Índice de Massa Corporal) e exibir uma mensagem indicando
            //em qual faixa de peso ele se encontra, conforme a tabela abaixo:
            //-Abaixo de 18,5: abaixo do peso;
            //-Entre 18,5 e 24,9: peso normal;
            //-Entre 25,0 e 29,9: sobrepeso;
            //-Entre 30,0 e 34,9: obesidade grau 1;
            //-Entre 35,0 e 39,9: obesidade grau 2;
            //-Acima de 40: obesidade grau 3 (mórbida).
            //O  programa  devecontinuar  funcionando  para  uma  nova  entrada  até  que  o usuário  acione
            //algum comando para parar o programa (você escolhe).

            //7.Faça um programa que seja capaz de informar quais são os divisores de um dado número N informado pelo usuário (N > 0). 

            int program = 1;

            while (program != 0)
            {
                Console.WriteLine("\nqual o programa que voce deseja executar? \ndigite 0 para finalizar\n");
                program = int.Parse(Console.ReadLine());

                if (program == 0)
                {
                    break;
                }

                switch (program)
                {
                    case 1:
                        int q, qt;
                        double v, vt;
                        qt = 0;
                        q = 1;
                        vt = 0;

                        while (q != 0)
                        {
                            Console.WriteLine("Digite a quantidade de produtos que deseja comprar");
                            q = int.Parse(Console.ReadLine());
                            qt += q;

                            Console.WriteLine("Digite a valor do produto que deseja comprar (preço da unidade)");
                            v = double.Parse(Console.ReadLine());
                            v = q * v;
                            vt += v;
                        }
                        Console.WriteLine("A quantidade total de produtos é: " + qt + " e o valor total é: " + vt);
                        break;

                    case 2:
                        double vl, qq, vtt, vm, vmm;
                        string nom, nm, nmm;

                        Console.WriteLine("digite o nome do produto (digite 'parar' para parar)");
                        nom = Console.ReadLine();
                        if (nom == "parar")
                        {
                            break;
                        }
                        Console.WriteLine("digite o valor do produto por unidade");
                        vl = double.Parse(Console.ReadLine());
                        Console.WriteLine("digite o a quantidade do produto");
                        qq = double.Parse(Console.ReadLine());
                        vtt = qq * vl;
                        vm = vtt;
                        nm = nom;
                        vmm = vtt;
                        nmm = nom;
                        while (nom != "parar")
                        {
                            Console.WriteLine("digite o nome do produto (digite 'parar' para parar)");
                            nom = Console.ReadLine();
                            if (nom == "parar")
                            {
                                break;
                            }
                            Console.WriteLine("digite o valor do produto por unidade");
                            vl = double.Parse(Console.ReadLine());
                            Console.WriteLine("digite o a quantidade do produto");
                            qq = double.Parse(Console.ReadLine());

                            vtt = qq * vl;

                            if (vtt > vm)
                            {
                                vm = vtt;
                                nm = nom;
                            }
                            if (vtt < vmm)
                            {
                                vmm = vtt;
                                nmm = nom;
                            }
                        }
                        Console.WriteLine("o produto com maior investimento é: " + nm + " com um investimento de R$" + vm + " e o de menor investimento é: " + nmm + " com um investimento de R$" + vmm);

                        break;

                    case 3:
                        double na, pa, pt;

                        Console.WriteLine("quantas avaliações terão neste bimestre?");
                        na = double.Parse(Console.ReadLine());
                        pt = 0;
                        int i = 0;
                        i++;
                        while (i <= na)
                        {
                            Console.WriteLine("qual o peso das avaliações (ex: 3)");
                            pa = double.Parse(Console.ReadLine());
                            pt += pa;
                            i++;
                        }

                        pt *= 10;

                        if (pt > 100)
                        {
                            Console.WriteLine("\nOs pesos ultrapassam 100%");
                            break;
                        }
                        if (pt == 100)
                        {
                            Console.WriteLine("\nOs pesos resultam em 100%");
                            break;
                        }
                        if (pt < 100)
                        {
                            Console.WriteLine("\nOs pesos nao atingem 100%");
                            break;
                        }
                        break;

                    case 4:
                        string estado;

                        Console.WriteLine("digite a sigla do estado");
                        estado = Console.ReadLine();

                        switch (estado)
                        {
                            case "AC":
                                Console.WriteLine("o estado correspondente é: Acre");
                                break;
                            case "AL":
                                Console.WriteLine("o estado correspondente é: Alagoas");
                                break;
                            case "AP":
                                Console.WriteLine("o estado correspondente é: Amapá");
                                break;
                            case "AM":
                                Console.WriteLine("o estado correspondente é: Amazonas");
                                break;
                            case "BA":
                                Console.WriteLine("o estado correspondente é: Bahia");
                                break;
                            case "CE":
                                Console.WriteLine("o estado correspondente é: Ceará");
                                break;
                            case "DF":
                                Console.WriteLine("Distrito Federal não é um estado, mas sim uma uniudade autônoma");
                                break;
                            case "ES":
                                Console.WriteLine("o estado correspondente é: Espírito Santo");
                                break;
                            case "GO":
                                Console.WriteLine("o estado correspondente é: Goiás");
                                break;
                            case "MA":
                                Console.WriteLine("o estado correspondente é: Maranhão");
                                break;
                            case "MT":
                                Console.WriteLine("o estado correspondente é: Mato Grosso");
                                break;
                            case "MS":
                                Console.WriteLine("o estado correspondente é: Mato Grosso do Sul");
                                break;
                            case "MG":
                                Console.WriteLine("o estado correspondente é: Minas Gerais");
                                break;
                            case "PA":
                                Console.WriteLine("o estado correspondente é: Pará");
                                break;
                            case "PB":
                                Console.WriteLine("o estado correspondente é: Paraíba");
                                break;
                            case "PR":
                                Console.WriteLine("o estado correspondente é: Paraná");
                                break;
                            case "PE":
                                Console.WriteLine("o estado correspondente é: Pernambuco");
                                break;
                            case "PI":
                                Console.WriteLine("o estado correspondente é: Piauí");
                                break;
                            case "RJ":
                                Console.WriteLine("o estado correspondente é: Rio de Janeiro");
                                break;
                            case "RN":
                                Console.WriteLine("o estado correspondente é: Rio Grande do Norte");
                                break;
                            case "RS":
                                Console.WriteLine("o estado correspondente é: Rio Grande do Sul");
                                break;
                            case "RO":
                                Console.WriteLine("o estado correspondente é: Rondônia");
                                break;
                            case "RR":
                                Console.WriteLine("o estado correspondente é: Roraima");
                                break;
                            case "SC":
                                Console.WriteLine("o estado correspondente é: Santa Catarina");
                                break;
                            case "SP":
                                Console.WriteLine("o estado correspondente é: São Paulo");
                                break;
                            case "SE":
                                Console.WriteLine("o estado correspondente é: Sergipe");
                                break;
                            case "TO":
                                Console.WriteLine("o estado correspondente é: Tocantins");
                                break;

                            default:
                                Console.WriteLine("nao existe estado com essa sigla");
                                break;
                        }
                        break;

                    case 5:
                        int m, d;

                        Console.WriteLine("digite o numero do mês (ex: 12)");
                        m = int.Parse(Console.ReadLine());

                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("a estação correspondente a este mês é: verão");
                                break;

                            case 2:
                                Console.WriteLine("a estação correspondente a este mês é: verão");
                                break;

                            case 3:
                                Console.WriteLine("qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 20 && d > 1)
                                    Console.WriteLine("a estação correspondente a este mês é: verão");
                                if (d >= 20 && d < 31)
                                    Console.WriteLine("a estação correspondente a este mês é: outono");
                                break;

                            case 4:
                                Console.WriteLine("a estação correspondente a este mês é: verão");
                                break;

                            case 5:
                                Console.WriteLine("a estação correspondente a este mês é: verão");
                                break;

                            case 6:
                                Console.WriteLine("qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 21 && d > 1)
                                    Console.WriteLine("a estação correspondente a este mês é: outono");
                                if (d >= 21 && d < 30)
                                    Console.WriteLine("a estação correspondente a este mês é: inverno");
                                break;

                            case 7:
                                Console.WriteLine("a estação correspondente a este mês é: inverno");
                                break;

                            case 8:
                                Console.WriteLine("a estação correspondente a este mês é: inverno");
                                break;

                            case 9:
                                Console.WriteLine("qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 23 && d > 1)
                                    Console.WriteLine("a estação correspondente a este mês é: inverno");
                                if (d >= 23 && d < 30)
                                    Console.WriteLine("a estação correspondente a este mês é: primavera");
                                break;

                            case 10:
                                Console.WriteLine("a estação correspondente a este mês é: primavera");
                                break;

                            case 11:
                                Console.WriteLine("a estação correspondente a este mês é: primavera");
                                break;

                            case 12:
                                Console.WriteLine("qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 22 && d > 1)
                                    Console.WriteLine("a estação correspondente a este mês é: primavera");
                                if (d >= 22 && d < 30)
                                    Console.WriteLine("a estação correspondente a este mês é: verão");
                                break;

                            default:
                                Console.WriteLine("o valor digitado é invalido");
                                break;
                        }
                        break;

                    case 6:
                        double alt, kg, imc;

                        Console.WriteLine("Digite sua altura em metros: ");
                        alt = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu peso em kg: ");
                        kg = double.Parse(Console.ReadLine());

                        imc = kg / (alt * alt);

                        if (imc < 18.5)
                        {
                            Console.WriteLine("você está abaixo do peso");
                            break;
                        }
                        if (imc >= 18.5 && imc <= 24.9)
                        {
                            Console.WriteLine("você está no peso normal");
                            break;
                        }
                        if (imc >= 25 && imc <= 29.9)
                        {
                            Console.WriteLine("você está com sobrepeso");
                            break;
                        }
                        if (imc >= 30 && imc < 34.9)
                        {
                            Console.WriteLine("você está com obesidade grau 1");
                            break;
                        }
                        if (imc >= 35 && imc < 39.9)
                        {
                            Console.WriteLine("você está com obesidade grau 2");
                            break;
                        }
                        if (imc >= 40)
                        {
                            Console.WriteLine("você está com obesidade grau 3");
                            break;
                        }

                        break;

                    case 7:
                        int num, numtotal;

                        Console.WriteLine("digite um numero");
                        num = int.Parse(Console.ReadLine());
                        i = 1;
                        while (i != num)
                        {
                            if (num % i == 0)
                            {
                                numtotal = i;
                                Console.WriteLine(numtotal);
                                i++;
                            }
                            else
                                i++;
                        }
                        break;

                    default:
                        Console.WriteLine("o numero do programa é invalido");
                        break;

                }
            }
        }

        public static void Lista9_()
        {
            //Exercício 1: Criar um programa que tenha um vetor de tamanho definido pelo usuário,
            //no qual os valores sejam gerados de forma aleatória (você é livre para escolher o intervalo).
            //Apresente ao final o vetor e a média aritmética dos valores contidos nesse vetor. 

            //Exercício 2:  Utilizando a estrutura do exercício anterior, crie um programa que apresente ao
            //final a soma dos valores pares e a soma dos valores ímpares contidos no vetor. 

            //Exercício 3: Crie um programa que gere um vetor de tamanho T (definido pelo usuário) e faça a
            //leitura dos dados de forma aleatória. Mostre esse vetor de dados da posição 0 para a última e
            //da última para a posição 0. 

            //Exercício 4: Crie um programa que faça a definição de um vetor de tamanho T (definido pelo usuário)
            //preenchido de forma aleatória. Ao final, apresente os valores contidos no vetor e a média aritmética
            //apenas dos dados que são ao mesmo tempo divisíveis por 3 e por 5. 

            //public static void Exercicio1()
            //{
            //    int[] vet2;
            //    Random rand = new Random();
            //    Console.WriteLine("entre com o tamanho");
            //    int t = int.Parse(Console.ReadLine());
            //    vet2 = new int[t];

            //    float soma = 0;
            //    for (int i = 0; i < t; i++)
            //    {
            //        vet2[i] = rand.Next(10, 50);
            //        Console.WriteLine(vet2[i]);
            //        soma = soma + vet2[i];

            //    }
            //    Console.WriteLine("a media é= " + soma / (float)t);

            //    for (int i = 0; i < t; i++)
            //    {
            //        Console.WriteLine("digite o valor da posição [{0}]", i);
            //        vet2[i] = int.Parse(Console.ReadLine());
            //    }
            //    for (int i = 0; i < t; i++)
            //    {
            //        Console.WriteLine("posição [{0}]={1}", i, vet2[i]);
            //    }
            //    Console.ReadKey();
            //}
            //public static void Exercicio2()
            //{
            //    int[] vet3;
            //    int t;



            //    int smP = 0, smI = 0;
            //    Random rand = new Random();
            //    Console.WriteLine("entre com  o tamanho");
            //    t = int.Parse(Console.ReadLine());
            //    vet3 = new int[t];



            //    for (int i = 0; i < t; i++)
            //    {
            //        vet3[i] = rand.Next(10, 50);



            //        if (vet3[i] % 2 == 0)
            //        {
            //            smP = vet3[i] + smP;
            //        }
            //        else
            //        {
            //            smI = vet3[i] + smI;
            //        }



            //    }
            //    for (int i = 0; i < t; i++)
            //    {
            //        Console.WriteLine(vet3[i]);



            //    }
            //    Console.WriteLine(" os numeros pares somados sera de:  " + smP);
            //    Console.WriteLine(" os numeros inpares somados sera de:  " + smI);



            //    Console.ReadKey();
            //}
            //public static void Exercicio3()
            //{
            //    int[] vet5;
            //    Console.WriteLine("entre com o tamanho");
            //    int t = int.Parse(Console.ReadLine());

            //    vet5 = new int[t];
            //    Random rand = new Random();

            //    for (int i = 0; i < t; i++)
            //    {
            //        vet5[i] = rand.Next(1, 100);


            //    }
            //    for (int i = 0; i < t; i++)
            //    {
            //        Console.WriteLine("posição [{0}] = {1}", i, vet5[i]);


            //    }
            //    Console.WriteLine();
            //    for (int i = t - 1; i >= 0; i--)
            //    {

            //        Console.WriteLine("posição [{0}] = {1}", i, vet5[i]);


            //    }


            //    Console.ReadKey();

            //}
            //public static void Exercicio4()
            //{
            //    float media = 0;
            //    int[] vet6;
            //    Console.WriteLine("entre com o tamanho");
            //    int t = int.Parse(Console.ReadLine());

            //    vet6 = new int[t];
            //    Random rand = new Random();

            //    for (int i = 0; i < t; i++)
            //    {
            //        vet6[i] = rand.Next(10, 50);


            //    }
            //    for (int i = 0; i < t; i++)
            //    {
            //        Console.WriteLine("posição [{0}] = {1}", i, vet6[i]);
            //        if (vet6[i] % 3 == 0 && vet6[i] % 5 == 0)
            //        {
            //            media = vet6[i] + media;
            //        }


            //    }

            //    media = media / (float)t;
            //    Console.WriteLine("a media aridimentica é " + media);

            //    Console.ReadKey();

            //}

        }
        public static void Lista10_vetor()
        {
            //1. Crie um programa que define um vetor de tamanho N, faz a leitura dos N números floats e apresenta,
            //com base nos números digitados, o menor número, o maior número e a média aritmética dos números.

            //Console.Write("Digite o tamanho : ");
            //int tamanho = int.Parse(Console.ReadLine());

            //float[] numeros = new float[tamanho];

            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.Write("Digite o número {0}: ", i);
            //    numeros[i] = float.Parse(Console.ReadLine());
            //}

            //float menor = numeros[0], maior = numeros[0], soma = 0;


            //for (int i = 0; i < tamanho; i++)
            //{
            //    if (numeros[i] < menor)
            //        menor = numeros[i];

            //    if (numeros[i] > maior)
            //        maior = numeros[i];

            //    soma = soma + numeros[i];
            //}

            //float media = soma / tamanho;

            //Console.WriteLine("Menor número: {0}", menor);
            //Console.WriteLine("Maior número: {0}", maior);
            //Console.WriteLine("Média aritmética: {0}", media);




            //2. Crie um programa que define um vetor de tamanho N, onde N é informado pelo usuário
            //(você precisa garantir que  o valor de N é maior que  zero). Em seguida,  faça  a  leitura
            //dos  N números e  mostre  ao final apenas os números contidos no vetor que são maiores ou iguais
            //à médiade todos os números digitados.

            //Console.Write("Digite o tamanho do vetor N: ");
            //int tamanho = int.Parse(Console.ReadLine());

            //while (tamanho <= 0)
            //{
            //    Console.WriteLine("O valor de N deve ser maior que zero");
            //    Console.Write("Digite o tamanho do vetor N: ");
            //    tamanho = int.Parse(Console.ReadLine());
            //}

            //float[] numeros = new float[tamanho];
            //float soma = 0;

            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.Write("Digite o número {0}: ", i);
            //    numeros[i] = float.Parse(Console.ReadLine());
            //    soma += numeros[i];
            //}

            //float media = soma / tamanho;

            //Console.WriteLine("Números maiores ou iguais à média:");

            //for (int i = 0; i < tamanho; i++)
            //{
            //    if (numeros[i] >= media)
            //        Console.WriteLine(numeros[i]);
            //}

            //3. Utilizando   o   exercício   anterior,   altere   seu   programa   para
            //que   a   inclusão   dos   números   seja   feita automaticamente. Pesquise por
            //geração de números aleatórios em C#.

            //Random rand = new Random();
            //Console.Write("Digite o tamanho do vetor N: ");
            //int tamanho = int.Parse(Console.ReadLine());

            //while (tamanho <= 0)
            //{
            //    Console.WriteLine("O valor de N deve ser maior que zero");
            //    Console.Write("Digite o tamanho do vetor N: ");
            //    tamanho = int.Parse(Console.ReadLine());
            //}

            //float[] numeros = new float[tamanho];
            //float soma = 0;

            //for (int i = 0; i < tamanho; i++)
            //{
            //    numeros[i] = rand.Next(10, 50);
            //    soma += numeros[i];
            //}

            //float media = soma / tamanho;

            //Console.WriteLine("Números maiores ou iguais à média:");

            //for (int i = 0; i < tamanho; i++)
            //{
            //    if (numeros[i] >= media)
            //        Console.WriteLine(numeros[i]);
            //}


            //4. Crie um programa que seja capaz de definir uma lista de assinaturas
            //com N nomes a serem informados pelo usuário. Após a leitura dos N nomes,
            //realize a exibição deles do último para o primeiro.

            //string[] vet5;
            //Console.WriteLine("entre com o tamanho");
            //int t = int.Parse(Console.ReadLine());

            //vet5 = new string[t];

            //for (int i = 0; i < t; i++)
            //{
            //    Console.WriteLine("entre com os nomes");
            //    vet5[i] = Console.ReadLine();
            //}

            //for (int i = t - 1; i >= 0; i--)
            //{
            //    Console.WriteLine("posição [{0}] = {1}", i, vet5[i]);

            //}

            //5. Crie um programa que capaz de definir um vetor de inteiros de tamanho N
            //(maior que zero e definido pelo usuário), preencher cada posição de maneira
            //aleatória e contar quantos números pares e ímpares existem no vetor gerado

            //int[] vet2;
            //int t, somai = 0, somap = 0;


            //Console.WriteLine("entre com o tamanho");
            //t = int.Parse(Console.ReadLine());
            //vet2 = new int[t];
            //Random rand = new Random();

            //for (int i = 0; i < t; i++)
            //{

            //    vet2[i] = rand.Next(1, 1000);

            //}

            //for (int i = 0; i < t; i++)
            //{

            //    if (vet2[i] % 2 == 0)
            //    {
            //        somai++;
            //    }
            //    else
            //    {
            //        somap++;
            //    }

            //}
            //for (int i = 0; i < t; i++)
            //{
            //    Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);


            //}

            //Console.WriteLine("neste vetor existem: " + somai + " numeros pares e: " + somap + " numeros impares");


        }
        public static void Lista11()
        {
            //1 - Crie um programa que seja capaz de armazenar 1000 números inteiros.
            //Em seguida, faça com que o usuário fique tentando adivinhar um número existente nesse vetor.
            //Ao adivinhar, o programa deve ser encerrado.

            //2 - Crie um programa que seja capaz de armazenar 20000 números inteiros.
            //Seu programa deve ser capaz de contar quantas  vezes um determinado número
            //escolhido pelo usuário aparece no vetor preenchido previamente.  

            //3 - Ler um vetor de 10 elementos inteiros e positivos. Criar um segundo vetor da seguinte forma:
            //os elementos de índice par receberão os respectivos elementos divididos por 2; os elementos de índice
            //ímpar receberão os respectivos elementos multiplicados por 3.Imprima os dois vetores.

            //4 - Criar um programa que seja capaz de ler 5000 números, armazená - los em um vetor
            //e posteriormente dizer quais números armazenados são primos.


            //public static void Exercicio1()

            //{

            //    int[] vet2;

            //    int n;


            //    vet2 = new int[1000];

            //    Random rand = new Random();

            //    for (int i = 0; i < 1000; i++)

            //    {
            //        vet2[i] = rand.Next(1, 1000);

            //    }

            //    Console.WriteLine("digite um número: ");

            //    n = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < 1000; i++)

            //    {
            //        if (n == vet2[i])

            //        {
            //            Console.WriteLine("o número digitado esta no vetor.");

            //            break;
            //        }
            //    }
            //}
            //public static void Exercicio2()
            //{
            //    int[] vet2;
            //    int n, cont = 0;


            //    vet2 = new int[20000];
            //    Random rand = new Random();

            //    for (int i = 0; i < 20000; i++)
            //    {
            //        vet2[i] = rand.Next(1, 20000);

            //    }
            //    Console.WriteLine("digite um número: ");
            //    n = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < 20000; i++)
            //    {
            //        if (n == vet2[i])
            //        {
            //            Console.WriteLine("o número digitado esta no vetor.");
            //            cont++;

            //        }
            //    }

            //    Console.WriteLine("o número selecionado aparece no vetor " + cont + " vezes");


            //}
            //public static void Exercicio3()
            //{
            //    int[] vet4;
            //    int[] vet5;
            //    int[] vet6;
            //    vet4 = new int[10];
            //    vet5 = new int[10];
            //    vet6 = new int[10];
            //    Random rand = new Random();


            //    for (int i = 0; i < 10; i++)
            //    {
            //        vet5[i] = rand.Next(1, 1000);
            //    }
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (vet5[i] % 2 == 0)
            //        {
            //            vet4[i] = vet5[i] / 2;
            //        }
            //        else
            //        {
            //            vet6[i] = vet5[i] * 3;
            //        }
            //    }
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("numeros pares {0}", vet4[i]);
            //        Console.WriteLine("numeros impares {0}", vet6[i]);

            //    }
            //}
            //public static void Exercicio4()
            //{
            //    int[] vet2;

            //    vet2 = new int[5000];
            //    Random rand = new Random();

            //    for (int i = 0; i < 5000; i++)
            //    {

            //        vet2[i] = rand.Next(1, 5000);

            //    }
            //    Console.WriteLine("digite um número: ");


            //    for (int i = 0; i < 5000; i++)
            //    {
            //        if (vet2[i] % 2 != 0 && vet2[i] % 3 != 0 && vet2[i] % 5 != 0)
            //        {
            //            Console.WriteLine("o número digitado é um número primo.");
            //            Console.WriteLine("números primos {0}", vet2[i]);

            //        }

            //    }
            }
        static void Main(string[] args)
        {


        }
    }
}
