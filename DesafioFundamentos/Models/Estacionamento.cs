namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
    Console.WriteLine("Digite a placa do veículo para estacionar:");
    string placa = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(placa))
        throw new ArgumentException("Placa não pode ser vazia.");

    if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        throw new ArgumentException("Essa placa já está registrada.");

    veiculos.Add(placa);
    Console.WriteLine($"Veículo {placa} adicionado com sucesso!");
}

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*           
            string placa = Console.ReadLine(); // Exemplo de inicialização, deve ser substituído pela entrada do usuário

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
               string entradaHoras = Console.ReadLine();// Exemplo de inicialização, deve ser substituído pela entrada do usuário
                if(!int.TryParse(entradaHoras, out int horas) || horas < 0)
                {
                   throw new ArgumentException("Quantidade de horas inválida. Deve ser um número inteiro não negativo.");
                }
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos.
                // *IMPLEMENTE AQUI*
                veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper());

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
