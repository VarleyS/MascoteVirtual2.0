using MascoteVirtual.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascoteVirtual.Service
{
    public class GetImage
    {
        public static async Task ArmazenaImagem()
        {
            GetPokemon getPokemon = new GetPokemon();
            List<PokemonResults> results = await getPokemon.GetPokemonRepository();

            foreach (PokemonResults result in results)
            {
                if (result != null)
                {
                    var ulrsprites = await getPokemon.GetSprites(result.Url);

                    string url = ulrsprites.front_default;

                    string imageName = $"{result.Name}.jpg";
                    string folderPath = @"D:\Projetos\MascoteVirtual\MascoteVirtual\MascoteVirtual\Resources\PokemonsImage\";

                    try
                    {
                        await DownloadImageAsync(url, imageName, folderPath);
                        Console.WriteLine("Imagem baixada e salva com sucesso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao baixar a imagem: {ex.Message}");
                    }
                }
            }
        }

        public static async Task DownloadImageAsync(string url, string imageName, string folderPath)
        {
            using (HttpClient client = new HttpClient())
            {
                // cria pasta se ela não existir
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                //Define o caminho completo para salvar a imagem
                string filePath = Path.Combine(folderPath, imageName);

                //baixa a imagem da url
                byte[] imageBytes = await client.GetByteArrayAsync(url);

                //salva a imagem no disco
                File.WriteAllBytes(filePath, imageBytes);
            }
        }

        public static async Task BuscaImagem(string nomeImagem)
        {
            string nome = $"{nomeImagem}.jpg";

            string pasta = "D:\\Projetos\\MascoteVirtual\\MascoteVirtual\\MascoteVirtual\\Resources\\PokemonsImage\\";

            string arquivo = pasta + nome;

            if (File.Exists(arquivo))
            {
                
            }
        }

    }
}
