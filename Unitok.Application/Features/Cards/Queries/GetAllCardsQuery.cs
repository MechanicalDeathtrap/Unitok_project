/*using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok.Application.DTOs.Cards;
using Unitok.Application.Interfaces.Repositories;

namespace Unitok.Application.Features.Cards.Queries
{
	/// <summary>
	/// Запрос на получение всех игр
	/// </summary>
	public class GetAllCardsQuery : IRequest<List<GetCardsDto>>
	{
	}

	/// <summary>
	/// Обработчик запроса на получение всех игр
	/// </summary>
	internal class GetAllCardsQueryHandler : IRequestHandler<GetAllCardsQuery, List<GetCardsDto>>
	{
		private readonly ICardRepository _gameRepository;
		private readonly IMapper _mapper;

		/// <summary>
		/// Конструткор
		/// </summary>
		/// <param name="gameRepository">Репозиторий игр</param>
		/// <param name="mapper">Маппер объектов</param>
		public GetAllCardsQueryHandler(ICardRepository gameRepository, IMapper mapper)
		{
			_gameRepository = gameRepository;
			_mapper = mapper;
		}

		/// <inheritdoc/>
		public async Task<List<GetCardsDto>> Handle(GetAllCardsQuery request, CancellationToken cancellationToken)
		{
			var allCards = await _gameRepository.GetAllAsync();

			var allCardsMapped = allCards
				.Select(i => _mapper.Map<GetCardsDto>(i))
				.ToList();

			//Console.WriteLine(allCardsMapped[0].Image);

			return allCardsMapped;
		}
	}
}
*/