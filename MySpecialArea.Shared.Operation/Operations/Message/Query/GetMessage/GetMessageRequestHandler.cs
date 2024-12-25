using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Message.Query.GetMessage
{
	public class GetMessageRequestHandler : IRequestHandler<GetMessageRequest, GetMessageResponse>
	{
		public async Task<GetMessageResponse> Handle(GetMessageRequest request, CancellationToken cancellationToken)
		{
			return new GetMessageResponse
			{
				Title = "Yapay Zeka",
				Description = "Yapay zeka (YZ), makinelerin insan benzeri zekâ ile düşünmesini, öğrenmesini ve problem çözmesini sağlayan bir teknoloji dalıdır. Temel olarak veri analizi, makine öğrenimi ve derin öğrenme algoritmalarına dayanır. Günlük hayatta sesli asistanlar, görüntü tanıma ve öneri sistemleri gibi birçok alanda kullanılır. YZ, sağlık, finans, eğitim ve lojistik gibi sektörlerde devrim yaratmaktadır. Ancak etik sorunlar ve iş gücü üzerindeki etkileri tartışma konusu olmaya devam etmektedir."
			};
		}
	}
}
