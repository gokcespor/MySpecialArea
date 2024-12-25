using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Message.Query.GetMessages
{
	public class GetMessagesRequestHandler : IRequestHandler<GetMessagesRequest, List<GetMessagesResponse>>
	{
		public async Task<List<GetMessagesResponse>> Handle(GetMessagesRequest request, CancellationToken cancellationToken)
		{
			var messageList = new List<GetMessagesResponse>
			{
				new GetMessagesResponse
				{
					Title = "Yapay Zeka",
				Description = "Yapay zeka (YZ), makinelerin insan benzeri zekâ ile düşünmesini, öğrenmesini ve problem çözmesini sağlayan bir teknoloji dalıdır. Temel olarak veri analizi, makine öğrenimi ve derin öğrenme algoritmalarına dayanır. Günlük hayatta sesli asistanlar, görüntü tanıma ve öneri sistemleri gibi birçok alanda kullanılır. YZ, sağlık, finans, eğitim ve lojistik gibi sektörlerde devrim yaratmaktadır. Ancak etik sorunlar ve iş gücü üzerindeki etkileri tartışma konusu olmaya devam etmektedir."
				},
				new GetMessagesResponse
				{
					Title = "JavaScript",
				Description = "JavaScript (JS), web geliştirme için kullanılan, dinamik ve zengin özelliklere sahip bir programlama dilidir. Tarayıcı üzerinde çalışarak web sayfalarına etkileşimli özellikler ekler (ör. düğmeler, formlar, animasyonlar). Node.js sayesinde sunucu tarafında da kullanılabilir. Çoğu modern web framework'ü (React, Angular, Vue.js) JavaScript üzerine kuruludur. Popülerliği sayesinde geniş bir topluluğa ve çok sayıda kütüphaneye sahiptir."
				}
			};
			return messageList;
		}
	}
}
