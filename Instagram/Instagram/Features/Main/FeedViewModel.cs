using Exrin.Abstraction;
using Exrin.Framework;
using System.Collections.Generic;

namespace Instagram.ViewModel
{


	public class Data
	{
		public string Name { get; set; }
		public string Image { get; set; }
		public string Comment { get; set; }
		public int CommentCount { get; set; }
		public string PostedAt { get; set; }
		public int ViewCount { get; set; }
	}


	public class FeedViewModel : Exrin.Framework.ViewModel
	{


		public FeedViewModel()
		{
			// Example Data
			InstagramFeed = new List<Data>()
			{
				new Data()
				{
					ViewCount = 10517,
					Comment = "latenightseth Enjoy your well-deserved vacation, Mr President. #LNSM",
					CommentCount = 45,
					Image = "latenightsethfeedimage.jpg",
					Name = "latenightseth",
					PostedAt = "1 hour ago"
				}


			};

		}

		public List<Data> InstagramFeed { get; set; }

	}
}
