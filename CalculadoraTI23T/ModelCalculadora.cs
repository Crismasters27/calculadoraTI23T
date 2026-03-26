using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    class ModelCalculadora
    {
        //1º Variáveis = GLOBALMENTE - Código inteiro enxerga elas
        private double num1;//Encapsular a variável
        private double num2;
        private double resultado;
        private List<double> top10 = new List<double>();

        //Método que instancia as variáveis = dá valores iniciais
        //2º Método construtor
        public ModelCalculadora()
        {
            this.num1 = 0;
            this.num2 = 0;
            this.resultado = 0;
        }//fim do consttrutor

        public ModelCalculadora(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        
        }//fim do construtor com parâmetros

        //Método GET e SET
        public double getNum1()
        {
            return this.num1;
        }//fim do método get

        public double getNum2()
        {
            return this.num2;
        }//fim do get

        public double getResultado()
        {
            return this.resultado;
        }//fim do get

        //Métodos set - Modificadores
        public void setNum1(double num1)
        {
            this.num1 = num1;
        }//fim do set

        public void setNum2(double num2)
        {
            this.num2 = num2;
        }//fim do set

        public void setResultado(double resultado)
        {
            this.resultado= resultado;
        }//fim do set

        //Operações aritméticas
        public double somar()
        {
            setResultado(this.getNum1() + this.getNum2());//Alterando a resultado
            return this.getResultado();//Mostrando a resultado
        }//fim do método

        public double subtrair()
        {
            this.setResultado(this.getNum1() - this.getNum2());
            return this.getResultado();
        }//fio do subtrair

        public double multiplicar()
        {
            this.setResultado(this.getNum1() * this.getNum2());
            return this.getResultado();
        }//fim do multiplicar

        public double dividir()
        {
            if (this.getNum2() == 0)
            {
                return -1;//Flag = Porque ele vai indicar que não da para dividir por zero
            }
            else
            {
                this.setResultado(this.getNum1() / this.getNum2());
                return this.getResultado();
            }
        }//fim do dividir

        //Potência
        public double potencia()
        {
            this.setResultado(Math.Pow(this.getNum1(), this.getNum2()));
            return this.getResultado();
        }//fim do método

        public double raizPrimeiroNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum1()));
            return this.getResultado();
        }//fim do primeiro número

        public double raizSegundoNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum2()));
            return this.getResultado();
        }//fim do segundo número

        public string tabuada(int num)
        {
            string msg = "";
            int i = 0;
            for (i = 0; i <= 10; i++)
            {
                msg += "\n" + num + " * " + i + " = " + (num * i);
            }//fim do for
            return msg;
        }//fim do método

        //Exercicio 1
        public string bissexto(int ano)
        {
            if(ano % 4 == 0)
            {
                return $"{ano} é bissexto";//Interpolação
            }
            else
            {
                return $"{ano} NÃO é bissexto";
            }
        }//fim do bissexto

        //Exercicio 2
        public string verificarIntervalo(int num)
        {
            if (num >= 100 && num <= 200)
            {
                return $"{num} está entre 100 e 200";
            }
            else
            {
                return $"{num} NÃO está entre 100 e 200";
            }
        }

        //Exercicio 3
        public string verificarVoto(int idade)
        {
            if (idade < 16)
            {
                return "Não pode votar";
            }
            else if (idade >= 16 && idade < 18 || idade >= 70)
            {
                return "Voto facultativo";
            }
            else
            {
                return "Voto obrigatório";
            }
        }

        //Exercicio 4
        public string verificarIntervaloPersonalizado(double num, double inicio, double fim)
        {
            if (num >= inicio && num <= fim)
            {
                return $"{num} está dentro do intervalo de {inicio} até {fim}";
            }
            else
            {
                return $"{num} NÃO está dentro do intervalo de {inicio} até {fim}";
            }
        }

        //Exercicio 5
        public string verificarTop10(double num)
        {
            bool entrou = false;

            if (top10.Count < 10)
            {
                top10.Add(num);
                entrou = true;
            }
            else
            {
                double menor = top10.Min();

                if (num > menor)
                {
                    top10.Remove(menor);
                    top10.Add(num);
                    entrou = true;
                }
            }

            if (entrou)
            {
                return $"{num} está entre os 10 maiores valores";
            }
            else
            {
                return $"{num} NÃO está entre os 10 maiores valores";
            }
        }

        //Exercicio 6
        public string verificarTriangulo(double lado1, double lado2, double lado3)
        {
            // Primeiro verifica se os lados formam um triângulo
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                return "Lados inválidos";
            }

            if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
            {
                return "Não forma um triângulo";
            }

            // Agora verifica o tipo do triângulo
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Triângulo Equilátero";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Triângulo Isósceles";
            }
            else
            {
                return "Triângulo Escaleno";
            }
        }

        //Exercicio 7
        public string diaDaSemana(int dia)
        {
            switch (dia)
            {
                case 1:
                    return "Domingo";
                case 2:
                    return "Segunda-feira";
                case 3:
                    return "Terça-feira";
                case 4:
                    return "Quarta-feira";
                case 5:
                    return "Quinta-feira";
                case 6:
                    return "Sexta-feira";
                case 7:
                    return "Sábado";
                default:
                    return "Número inválido! Digite um valor entre 1 e 7.";
            }
        }

        //Exercicio 8
        public string validarSenha(string senha)
        {
            // Exemplo de regra de validação:
            // - mínimo 6 caracteres
            // - contém pelo menos 1 letra
            // - contém pelo menos 1 número

            if (senha.Length < 6)
            {
                return "Senha inválida: deve ter no mínimo 6 caracteres.";
            }

            bool temLetra = senha.Any(char.IsLetter);
            bool temNumero = senha.Any(char.IsDigit);

            if (!temLetra || !temNumero)
            {
                return "Senha inválida: deve conter letras e números.";
            }

            return "Senha válida!";
        }

        //Exercicio 9
        public string horarioMaisTarde(int hora1, int minuto1, int hora2, int minuto2)
        {
            // Validação básica
            if (hora1 < 0 || hora1 > 23 || hora2 < 0 || hora2 > 23 ||
                minuto1 < 0 || minuto1 > 59 || minuto2 < 0 || minuto2 > 59)
            {
                return "Horário inválido! Use 0–23 para horas e 0–59 para minutos.";
            }

            // Comparar horários
            if (hora1 > hora2 || (hora1 == hora2 && minuto1 > minuto2))
            {
                return $"O primeiro horário ({hora1:D2}:{minuto1:D2}) é mais tarde.";
            }
            else if (hora2 > hora1 || (hora2 == hora1 && minuto2 > minuto1))
            {
                return $"O segundo horário ({hora2:D2}:{minuto2:D2}) é mais tarde.";
            }
            else
            {
                return "Os dois horários são iguais.";
            }
        }

        //Exercicio 10
        public double maiorNumero(double num1, double num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }

        //Exercicio 11
        public double calcularMedia(double[] numeros)
        {
            double soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma / numeros.Length;
        }

        //Exercicio 12
        public string somarAteUltrapassar100()
        {
            double soma = 0;
            double numero;

            do
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToDouble(Console.ReadLine());

                soma += numero;

                Console.WriteLine($"Soma atual: {soma}");

            } while (soma <= 100);

            return $"A soma ultrapassou 100! Total final: {soma}";
        }

        //Exercicio 13
        public void solicitarSenha()
        {
            string senha;
            string resposta;

            do
            {
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();

                resposta = validarSenha(senha);
                Console.WriteLine(resposta);

            } while (resposta != "Senha válida!");
        }


        //Exercicio 14
        public string definirMaiorMenor()
        {
            int num = 0;
            int maior = 0;
            int menor = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}º Número: ");
                num = Convert.ToInt32(Console.ReadLine());

                //Instanciar
                if (i == 0)
                {
                    maior = num;
                    menor = num;
                }

                //Comparação
                if (num > maior)
                {
                    maior = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
            }//fim do for
        return $" O maior é: {maior} e o menor é: {menor}";

        }//fim do método

        //Exercício 15
        public string classificarIdade(int idade)
        {
            if (idade < 0)
            {
                return "Idade inválida";
            }
            else if (idade <= 12)
            {
                return "Criança";
            }
            else if (idade <= 17)
            {
                return "Jovem";
            }
            else if (idade <= 59)
            {
                return "Adulto";
            }
            else
            {
                return "Idoso";
            }
        }

        //Exercicio 16
        public string calcularIMC(double peso, double altura)
        {
            if (altura <= 0 || peso <= 0)
            {
                return "Valores inválidos";
            }

            double imc = peso / (altura * altura);
            string classificacao;

            if (imc < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                classificacao = "Peso normal";
            }
            else if (imc < 30)
            {
                classificacao = "Sobrepeso";
            }
            else if (imc < 35)
            {
                classificacao = "Obesidade I";
            }
            else if (imc < 40)
            {
                classificacao = "Obesidade II";
            }
            else
            {
                classificacao = "Obesidade III";
            }

            return $"IMC: {imc:F2} - {classificacao}";
        }

        //Exercicio 17
        public string verificarNumero(double num)
        {
            if (num > 0)
            {
                return "Número positivo";
            }
            else if (num < 0)
            {
                return "Número negativo";
            }
            else
            {
                return "Número zero";
            }
        }

        //Exercicio 18
        public string verificarParOuImpar(int num)
        {
            if (num % 2 == 0)
            {
                return "Número par";
            }
            else
            {
                return "Número ímpar";
            }
        }

        //Exercicio 19
        public string analisarTresNumeros(double numero1, double numero2, double numero3)
        {
            // Maior
            double maior = numero1;
            if (numero2 > maior) maior = numero2;
            if (numero3 > maior) maior = numero3;

            // Menor
            double menor = numero1;
            if (numero2 < menor) menor = numero2;
            if (numero3 < menor) menor = numero3;

            // Soma
            double soma = numero1 + numero2 + numero3;

            // Média
            double media = soma / 3;

            // Potência (exemplo: numero1 elevado a numero2)
            double potencia = Math.Pow(numero1, numero2);

            return $"Maior: {maior}\n" +
                   $"Menor: {menor}\n" +
                   $"Soma: {soma}\n" +
                   $"Média: {media:F2}\n" +
                   $"Potência (numero1^numero2): {potencia}";
        }

        //Exercicio 20
        public string calcularTarifa(int idade2, double tarifaBase)
        {
            if (idade2 < 0)
            {
                return "Idade inválida";
            }
            else if (idade2 <= 5)
            {
                return "Tarifa: Gratuita";
            }
            else if (idade2 <= 17)
            {
                double meia = tarifaBase / 2;
                return $"Tarifa: Meia ({meia:F2})";
            }
            else if (idade2 <= 59)
            {
                return $"Tarifa: Normal ({tarifaBase:F2})";
            }
            else
            {
                return "Tarifa: Gratuita";
            }
        }

    }//fim da classe Model
}//fim do projetoCalculadoraTI23T
