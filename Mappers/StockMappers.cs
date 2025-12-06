using StockApi.Dtos.Stock;
using StockApi.Models;
using StockApi.Dtos.Comment;

namespace StockApi.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockmodel)
        {
            return new StockDto
            {
                Id = stockmodel.Id,
                Symbol = stockmodel.Symbol,
                CompanyName = stockmodel.CompanyName,
                Purchase = stockmodel.Purchase,
                LastDiv = stockmodel.LastDiv,
                Industry = stockmodel.Industry,
                MarketCap = stockmodel.MarketCap,
                Comments = stockmodel.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto)
        {
            return new Stock
            {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                LastDiv = stockDto.LastDiv,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
            };
        }

        public static Stock ToStockFromUpdateDTO(this UpdateStockRequestDto stockDto, Stock stock)
        {
            stock.Symbol = stockDto.Symbol;
            stock.CompanyName = stockDto.CompanyName;
            stock.Purchase = stockDto.Purchase;
            stock.LastDiv = stockDto.LastDiv;
            stock.Industry = stockDto.Industry;
            stock.MarketCap = stockDto.MarketCap;
            return stock;
        }
    }
}