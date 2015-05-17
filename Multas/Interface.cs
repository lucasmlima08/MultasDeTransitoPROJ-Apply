using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Multas
{
    public partial class aplicacao : Form
    {

        MySqlConnection conexao = new MySqlConnection("Server = localhost; Uid = root; Password = root; Database = SistemaDoDetran; Port = 1313");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader reader;

        private int velocidadeMaximaPermitida;
        private int cpfProprietario;
        private int valorDaMulta;

        String[] radares;

        public aplicacao()
        {
            InitializeComponent();

            // Realizar Conexão com o Banco de Dados.
            conexao.Open();
            comando.Connection = conexao;

            // Chama radares para a escolha na multa.
            chamarRadares();
        }

        private String data()
        {
            String data = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
            return data;
        } // Retorna data atual.

        private String hora()
        {
            String hora = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            return hora;
        } // Retorna hora atual.
        
        private void chamarRadares()
        {

            try
            {
                comando.CommandText = "select count(*) from radares";
                int valor = int.Parse(comando.ExecuteScalar().ToString());

                // Entra aqui se encontra algum registro do Radar.
                if (valor >= 1)
                {
                    radares = new String[valor];

                    comando.CommandText = "select * from radares";

                    reader = comando.ExecuteReader();

                    int acm = 0;
                    while (reader.Read())
                    {
                        String id = reader["ID"].ToString();
                        String localizacao = reader["LOCALIZACAO"].ToString();
                        String detalhes = reader["DETALHES"].ToString();

                        String modelo = "Radar " + id + " - " + localizacao + " [" + detalhes + "]";

                        radares[acm] = modelo;

                        listaRadares.Items.Add(modelo);
                        acm++;
                    }

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Não existe proprietário cadastrado!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os proprietarios!");
            }
        } // Chama a lista de radares.

        private int numRadar()
        {
            for (int i = 0; i < radares.Length; i++)
            {
                if (radares[i].Equals(listaRadares.Text))
                {
                    return i + 1;
                }
            }
            return 0;
        } // Encontra o número do radar pela escolha no comboBox.

        private Boolean procurarPlaca(String placa)
        {
            try
            {
                comando.CommandText = "select count(*) from veiculos where PLACA='" + placa + "';";
                int valor = int.Parse(comando.ExecuteScalar().ToString());

                if (valor > 0)
                {
                    lerCpfProprietario(placa);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        } // Procura se veículo existe.

        private void lerCpfProprietario(String placa)
        {
            comando.CommandText = "select proprietario from veiculos where placa='" + placa + "';";

            reader = comando.ExecuteReader();

            String cpf = "";

            while (reader.Read())
            {
                cpf = reader["PROPRIETARIO"].ToString();
            }

            reader.Close();

            cpfProprietario = int.Parse(cpf);
        }
        
        private int ultrapassouVelocidade(String velocidade)
        {
            try
            {
                comando.CommandText = "select velocidade, peso from radares where ID='" + numRadar() + "';";

                reader = comando.ExecuteReader();

                String velocidadeMaxima = "";
                String pesoMulta = "";

                while (reader.Read())
                {
                    velocidadeMaxima = reader["VELOCIDADE"].ToString();
                    pesoMulta = reader["PESO"].ToString();
                }

                velocidadeMaximaPermitida = int.Parse(velocidadeMaxima);

                int diferencaVelocidade = int.Parse(velocidade) - velocidadeMaximaPermitida;
                valorDaMulta = int.Parse(pesoMulta) * diferencaVelocidade;

                reader.Close();

                return (valorDaMulta);
            }
            catch (Exception ex)
            {
                return 0;
            }
        } // Retorna a diferença de velocidade.

        private void pontuarCarteira(int velocidadeAtingida, int velocidadeMaximaPermitida, int cpf)
        {
            int pontosNaCarteira = 0;
            double valorDaMulta = this.valorDaMulta;

            /* Regras de pontuação na carteira */
            if (velocidadeMaximaPermitida * 2 >= velocidadeAtingida)
            {
                pontosNaCarteira = 7;
            }
            else if (velocidadeAtingida - velocidadeMaximaPermitida >= velocidadeMaximaPermitida / 2)
            {
                pontosNaCarteira = 5;
            }
            else
            {
                pontosNaCarteira = 4;
            }

            /* Faz a leitura dos pontos e das multas para realizar a soma */
            comando.CommandText = "select pontos, multas from proprietarios where cpf='" + cpf + "';";

            reader = comando.ExecuteReader();

            String pontos = "";
            String multas = "";

            while (reader.Read())
            {
                pontos = reader["PONTOS"].ToString();
                multas = reader["MULTAS"].ToString();
            }

            reader.Close();

            /* Reescreve somando com os valores atuais */

            pontosNaCarteira += int.Parse(pontos);
            valorDaMulta += double.Parse(multas);

            comando.CommandText = "update proprietarios set pontos='"+pontosNaCarteira+"', multas='"+valorDaMulta+"' where cpf='"+cpf+"';";
            comando.ExecuteNonQuery();
        } // Realiza a pontuação na carteira do proprietário a partir das regras.

        private void multarVeiculo()
        {
            if (placaEnt.Text.Equals("") || velocidadeEnt.Text.Equals("") || listaRadares.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os dados!");
            }
            else if (procurarPlaca(placaEnt.Text) == false)
            {
                MessageBox.Show("Veículo não encontrado!");
            }
            else
            {
                try
                {
                    int velocidadeUltrapassada = ultrapassouVelocidade(velocidadeEnt.Text);
                    if (velocidadeUltrapassada > 0)
                    {
                        pontuarCarteira(int.Parse(velocidadeEnt.Text), velocidadeMaximaPermitida, cpfProprietario);

                        comando.CommandText = "insert into multas(data, hora, placa, radar, velocidade, valor) values " +
                                              "('" + data() + "','" + hora() + "','" + placaEnt.Text + "','" + numRadar() + "','" + velocidadeEnt.Text + "','" + velocidadeUltrapassada + "');";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Veículo multado!");
                    }
                    else
                    {
                        MessageBox.Show("O veículo está dentro do limite de Velocidade!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve algum problema!" + ex.Message);
                }

            }
        } // Evento de multa do veículo.
        
        private void botaoMultar_Click(object sender, EventArgs e)
        {
            multarVeiculo();
        } // Evento do Botão para multar veículos.

    }
}
