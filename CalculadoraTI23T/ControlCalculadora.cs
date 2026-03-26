using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    class ControlCalculadora
    {
        //Variáveis Globais
        ModelCalculadora model;//Começando a conectar a control e a model

        //Construtor vazio da classe ModelCalculadora
        public ControlCalculadora()
        {
            this.model = new ModelCalculadora();//Efetivando a ligação com a Model
        }//fim do construtor vazio

        public ControlCalculadora(double num1, double num2)
        {
            this.model = new ModelCalculadora(num1, num2);
        }//fim do construtor com parâmetros

        //Método de Menu

        public String mostrarMenu()
        {
            return "----------- Menu -------------\n\n" +
                "Escolha uma das opções abaixo: \n" +
                "0. Sair\n" +
                "1. Somar\n" +
                "2. Subtrair\n" +
                "3. Multiplicar\n" +
                "4. Dividir\n" +
                "5. Potência\n" +
                "6. Raiz Primeiro Número\n" +
                "7. Raiz Segundo Número\n" +
                "8. Tabuada\n" +
                "9. Bissexto\n" +
                "10. Verificar número entre 100 e 200\n" +
                "11. Verificar se pode votar\n" +
                "12. Verificar número em intervalo\n" +
                "13. Top 10 maiores valores\n" +
                "14. Verificar tipo de triângulo\n" +
                "15. Informe o dia da semana\n" +
                "16. Validar senha\n" +
                "17. Comparar dois horários\n" +
                "18. Mostrar o maior número\n" +
                "19. Calcular média de 5 números\n" +
                "20. Somar até ultrapassar 100\n" +
                "21. Solicitar senha até que uma seja válida\n"+
                "22. Ler 10 números e mostrar maior e menor\n" +
                "23. Classificar pessoa por idade\n" +
                "24. Calcular IMC\n" +
                "25. Verificar se número é positivo, negativo ou zero\n" +
                "26. Verificar par ou ímpar\n" +
                "27. Analisar três números\n"+
                "28. Calcule a tarifa do ônibus";


        }//fim do método

        public void realizarOperacao()
        {
            int opcao = 0;//Declarar do lado de fora do do...while()
            do
            {
                Console.WriteLine(this.mostrarMenu());//Chamar o menu
                opcao = Convert.ToInt32(Console.ReadLine());//Leia
                
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        this.coletar();//Pegar o que o usuário está digitando
                        Console.WriteLine(this.model.somar());
                        break;
                    case 2:
                        this.coletar();//Pegar o que o usuário está digitando
                        Console.WriteLine("A subtração é: " + this.model.subtrair());
                        break;
                    case 3:
                        this.coletar();//Pegar o que o usuário está digitando
                        Console.WriteLine("A multiplicação é: " + this.model.multiplicar());
                        break;
                    case 4:
                        this.coletar();//Pegar o que o usuário está digitando
                        if (this.model.dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão é: " + this.model.dividir());
                        }
                        break;
                    case 5:
                        this.coletar();//Pegar o que o usuário está digitando
                        Console.WriteLine("A potência é: " + this.model.potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe um número: ");
                        this.model.setNum1(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("A raiz do primeiro número é: " + this.model.raizPrimeiroNumero());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.model.setNum2(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("A raiz do segundo número é: " + this.model.raizSegundoNumero());
                        break;
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Para chamar a tabuada
                        Console.WriteLine(this.model.tabuada(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Chamar o método do bissexto
                        Console.WriteLine(this.model.bissexto(ano));
                        break;
                    default:
                        Console.WriteLine("Informe um valor correto!");
                        break;
                    case 10:
                        Console.WriteLine("Informe um número: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.verificarIntervalo(numero));
                        break;
                    case 11:
                        Console.WriteLine("Informe a idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.verificarVoto(idade));
                        break;
                    case 12:
                        Console.WriteLine("Informe o número: ");
                        double numeroIntervalo = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o início do intervalo: ");
                        double inicio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o fim do intervalo: ");
                        double fim = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.model.verificarIntervaloPersonalizado(numeroIntervalo, inicio, fim));
                        break;
                    case 13:
                        Console.WriteLine("Informe um número: ");
                        double numeroTop = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.model.verificarTop10(numeroTop));
                        break;
                    case 14:
                        Console.WriteLine("Informe o primeiro lado: ");
                        double l1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o segundo lado: ");
                        double l2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o terceiro lado: ");
                        double l3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.model.verificarTriangulo(l1, l2, l3));
                        break;
                    case 15:
                        Console.WriteLine("Informe um número de 1 a 7: ");
                        int dia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.diaDaSemana(dia));
                        break;
                    case 16:
                        Console.WriteLine("Digite a senha: ");
                        string senha = Console.ReadLine();

                        Console.WriteLine(this.model.validarSenha(senha));
                        break;
                    case 17:
                        Console.WriteLine("Informe o primeiro horário:");
                        Console.Write("Horas (0–23): ");
                        int h1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Minutos (0–59): ");
                        int m1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo horário:");
                        Console.Write("Horas (0–23): ");
                        int h2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Minutos (0–59): ");
                        int m2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.horarioMaisTarde(h1, m1, h2, m2));
                        break;
                    case 18:
                        Console.WriteLine("Digite o primeiro número: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número: ");
                        double n2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"O maior número é: {this.model.maiorNumero(n1, n2)}");
                        break;
                    case 19:
                        double[] numeros = new double[5];

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write($"Digite o {i + 1}º número: ");
                            numeros[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        double media = this.model.calcularMedia(numeros);
                        Console.WriteLine($"A média dos números é: {media}");
                        break;
                    case 20:
                        Console.WriteLine(this.model.somarAteUltrapassar100());
                        break;
                    case 21:
                        this.model.solicitarSenha();
                        break;
                    case 22:
                        Console.WriteLine(this.model.definirMaiorMenor());
                        break;
                    case 23:
                        Console.Write("Digite a idade: ");
                        int idadePessoa = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.classificarIdade(idadePessoa));
                        break;
                    case 24:
                        Console.Write("Digite o peso (kg): ");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite a altura (m): ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.model.calcularIMC(peso, altura));
                        break;
                    case 25:
                        Console.Write("Digite um número: ");
                        double numeros1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.model.verificarNumero(numeros1));
                        break;
                    case 26:
                        Console.Write("Digite um número: ");
                        int numeroPar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.verificarParOuImpar(numeroPar));
                        break;
                    case 27:
                        Console.Write("Digite o primeiro número: ");
                        double numero1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        double numero2 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite o terceiro número: ");
                        double numero3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.model.analisarTresNumeros(numero1, numero2, numero3));
                        break;
                    case 28:
                        Console.Write("Digite a idade: ");
                        int idade2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o valor da tarifa base: ");
                        double tarifa = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.model.calcularTarifa(idade2, tarifa));
                        break;

                }//fim do escolha
            } while (opcao != 0);
        }//fim do método


        public void coletar()
        {
            Console.Write("\n\nInforme o primeiro número: ");
            this.model.setNum1(Convert.ToDouble(Console.ReadLine()));//Peguei o primeiro número

            Console.Write("\n\nInforme o segundo número: ");
            this.model.setNum2(Convert.ToDouble(Console.ReadLine()));//Peguei o segundo número
        }//fim do coletar

    }
}
