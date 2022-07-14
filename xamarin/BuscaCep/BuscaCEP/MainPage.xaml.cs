using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace BuscaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCEP.Text))
                    return;
                //https://viacep.com.br/ws/38057590/json/
                using (var cliente = new HttpClient())
                {
                    using (var response = await cliente.GetAsync($"https://viacep.com.br/ws/{txtCEP.Text}/json/"))
                    {
                        response.EnsureSuccessStatusCode();

                        var content = await response.Content.ReadAsStringAsync();
                        if (string.IsNullOrWhiteSpace(content))
                            throw new InvalidOperationException();

                        var retorno = JsonConvert.DeserializeObject<ViaCepDto>(content);

                        if (retorno.erro)
                            throw new InvalidOperationException();


                        txtLogradouro.Text = retorno.logradouro;
                        txtComplemento.Text = retorno.complemento;
                        txtBairro.Text = retorno.bairro;
                        txtLocalidade.Text = retorno.localidade;
                        txtUF.Text = retorno.uf;
                    }
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Algo de errado não está certo","Teste" + ex,"OK");
            }
            
        }
    }


    public class ViaCepDto
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }
        public bool erro { get; set; } = false;
    }


}
