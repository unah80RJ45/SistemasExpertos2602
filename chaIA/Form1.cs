using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace chaIA
{
    public partial class Form1 : Form
    {
        private static readonly string apiKey = "";
        private static readonly string apiUrl = "https://api.groq.com/openai/v1/chat/completions";
        private List<Dictionary<string, string>> historial = new List<Dictionary<string, string>>();

        public Form1()
        {
            InitializeComponent();
        }
        private async Task<string> getRespuesta(string pregunta)
        {
            using (var cliente = new HttpClient())
            {
                Dictionary<string, string > ultimaPregunta =
                    new Dictionary<string, string>
                    {
                        {"role", "user"},
                        {"content", pregunta}
                    };
                historial.Add(ultimaPregunta);
                var requestBody = new { model = "llama-3.1-8b-instant", max_tokens = 500, messages = historial };

                cliente.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json);
                var response = await cliente.PostAsync(apiUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic result = JsonConvert.DeserializeObject(responseString);
                string resultado = result.choices[0].message.content.ToString();

                historial.Add(new Dictionary<string, string>
                    {
                        {"role", "assistant"},
                        {"content", resultado}                    
                    });

                return resultado;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void  cmdEnviar_Click(object sender, EventArgs e)
        {
            if (txtPregunta.Text.Length > 0)
            {
                rtbChat.AppendText("Usuario : " + txtPregunta.Text + "\n");
                string respuesta = await getRespuesta(txtPregunta.Text);
                rtbChat.AppendText("IA : " + respuesta + "\n"); txtPregunta.Clear();
            }
        }
    }
}
