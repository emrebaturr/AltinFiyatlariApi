using AltinFiyatApi.Models;

namespace AltinFiyatApi.Abstractions
{
    public interface IAltinFiyatServisi
    {
        Task<List<AltinFiyati>> AltinFiyatlariniGetirAsync();
    }
}
