using AltinFiyatApi.Abstractions;
using AltinFiyatApi.Models;
using System.Text.Json;

namespace AltinFiyatApi.Services
{
    public class AltinFiyatServisi : IAltinFiyatServisi
    {
        private readonly HttpClient _httpClient;

        public AltinFiyatServisi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AltinFiyati>> AltinFiyatlariniGetirAsync()
        {
            var response = await _httpClient.GetAsync("https://finans.truncgil.com/v4/today.json");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // JSON key isimleri büyük/küçük harfe duyarlı olmadan eşleşsin
            };

            ExchangeResponse exchangeResponse = JsonSerializer.Deserialize<ExchangeResponse>(json, options);

            var fiyatlar = new List<AltinFiyati>();

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.ONS.Name,
                Fiyat = exchangeResponse.ONS.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.GRA.Name,
                Fiyat = exchangeResponse.GRA.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.CEY.Name,
                Fiyat = exchangeResponse.CEY.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.YAR.Name,
                Fiyat = exchangeResponse.YAR.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.TAM.Name,
                Fiyat = exchangeResponse.TAM.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.CUM.Name,
                Fiyat = exchangeResponse.CUM.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.ATA.Name,
                Fiyat = exchangeResponse.ATA.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.YIA.Name,
                Fiyat = exchangeResponse.YIA.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.RES.Name,
                Fiyat = exchangeResponse.RES.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            fiyatlar.Add(new AltinFiyati
            {
                Ad = exchangeResponse.HAM.Name,
                Fiyat = exchangeResponse.HAM.Buying,
                Birim = "TL",
                Tarih = DateTime.Now
            });

            return fiyatlar;
        }
    }
}