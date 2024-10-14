using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;
using MtgCollectionCoreModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MtgCollectionCore.service
{
    public class CardService
    {
        private static readonly HttpClient client = new HttpClient();
        public void buscarPorNombreAsync(string text, DataGridView gridBusqueda)
        {
            try
            {
                LlamadaApiBuscarPorNombre(text, gridBusqueda);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public async void LlamadaApiBuscarPorNombre(string text, DataGridView gridBusqueda)
        {
            try
            {
                List<ICard> cards = new List<ICard>();
                List<Card> cartasBuscadasTranscritas = new List<Card>();
                IMtgServiceProvider mtgServiceProvider = new MtgServiceProvider();
                ICardService cardService = mtgServiceProvider.GetCardService();


                IOperationResult<List<ICard>> result = await cardService.Where(x => x.Name, text).AllAsync();
                if (result.IsSuccess)
                {
                    List<ICard> listaCartasConRepetidos = result.Value;
                    cards = listaCartasConRepetidos.GroupBy(x => x.Name).Select(x => x.First()).ToList();
                    
                    foreach (ICard card in cards)
                    {
                        cartasBuscadasTranscritas.Add(TranscribirCarta(card));
                    }

                    gridBusqueda.DataSource = cartasBuscadasTranscritas;
                    gridBusqueda.Refresh();
                }
                else
                {
                    throw new Exception($"No se han encontrado cartas con el texto {text}");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Card TranscribirCarta(ICard cartaAPI)
        {
            return new Card
            {
                Blue = !cartaAPI.IsColorless && cartaAPI.ColorIdentity.Contains("U") ? true : false,
                Red = !cartaAPI.IsColorless && cartaAPI.ColorIdentity.Contains("R") ? true : false,
                White = !cartaAPI.IsColorless && cartaAPI.ColorIdentity.Contains("W") ? true : false,
                Black = !cartaAPI.IsColorless && cartaAPI.ColorIdentity.Contains("B") ? true : false,
                Green = !cartaAPI.IsColorless && cartaAPI.ColorIdentity.Contains("G") ? true : false,
                Colorless = cartaAPI.IsColorless,
                Cmc = cartaAPI.Cmc,
                IdCard = cartaAPI.Id,
                ImageUrl = cartaAPI.ImageUrl.ToString(),
                ManaCost = cartaAPI.ManaCost,
                Name = cartaAPI.Name,
                OriginalText = cartaAPI.OriginalText,
                OriginalType = cartaAPI.OriginalType,
                Rarity = cartaAPI.Rarity,
                Text = cartaAPI.Text,
                Quantity = 1,
                Foil = false
            };
        }
    }
}
