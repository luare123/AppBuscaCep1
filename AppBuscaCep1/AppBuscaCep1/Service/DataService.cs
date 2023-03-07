using AppBuscaCep1.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Xamarin.Forms;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Globalization;

namespace AppBuscaCep1.Service
{
    public class DataService
    {
        public static async Task<Endereco> GetEnderecoByCep(string cep)
        {
            Endereco end;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/endereco/by-cep?cep=17210580" + cep);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    end = JsonConvert.DeserializeObject<Endereco>(json);
                }
                else
                {
                    throw new Exception(response.RequestMessage.Content.ToString());
                }
                return end;

            }
        }
        public static async Task<List<Bairro>> GetBairrosByIdCidade(int id_cidade)
        {
            List<Bairro> arr_bairros = new List<Bairro>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/bairro/by-cidade?id=4874" + id_cidade);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_bairros = JsonConvert.DeserializeObject<List<Bairro>>(json);
                }
                else
                {
                    throw new Exception(response.RequestMessage.Content.ToString());
                }
                return arr_bairros;
            }

        }
        public static async Task<List<Logradouro>> GetLogradourosByAndIdCidade(string bairro, int id_cidade)
        {
            List<Logradouro> arr_logradouros = new List<Logradouro>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/logradouro/by-bairro?id_cidade=4874" + id_cidade + "&bairro=" + bairro);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_logradouros = JsonConvert.DeserializeObject<List<Logradouro>>(json);
                }
                else
                {
                    throw new Exception(response.RequestMessage.Content.ToString());
                }
                return arr_logradouros;
            }

        }
        public static async Task<List<Cidade>> GetCidadesByEstado(string uf)
        {
            List<Cidade> arr_cidades = new List<Cidade>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/cidade/by-uf?uf=" + uf);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_cidades = JsonConvert.DeserializeObject<List<Cidade>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }
            return arr_cidades;
        }
        public static async Task<List<Cep>> GetCepsByLogradouro(string logradouro)
        {
            List<Cep> arr_ceps = new List<Cep>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://https://cep.metoda.com.br/cep/by-logradouro?logradouro=Rua%20Raphael%20de%20Almeida%20Leite" + logradouro);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_ceps = JsonConvert.DeserializeObject<List<Cep>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }
            return arr_ceps;
        }
    }
}