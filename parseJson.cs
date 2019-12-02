{"status":"ok","totalResults":38,"articles":[{"source":{"id":null,"name":"Androidcentral.com"},"author":"Alex Smith","title":"These 20 awesome Cyber Monday deals will finish off your holiday shopping list - Android Central","description":"Looking for some great gift ideas? We've compiled 20 of the best Cyber Monday and lingering Black Friday deals to help you finish your holiday shopping list in record time, and with some great prices too.","url":"https://www.androidcentral.com/20-cyber-monday-gift-ideas","urlToImage":"https://www.androidcentral.com/sites/androidcentral.com/files/styles/large/public/article_images/2019/10/fire-7-kids-edition.jpg?itok=URLhCMpF","publishedAt":"2019-12-02T04:00:03Z","content":"Stuck on what to buy a loved one this holiday season? Black Friday and Cyber Monday are making things much easier this year with some insane discounts on best-selling products that should be on everyone's wish list. Even though Black Friday was a couple of da… [+16028 chars]"},
{"source":{"id":null,"name":"Nydailynews.com"},"author":"David Matthews","title":"Dwyane Wade defends son's appearance in family photo - New York Daily News","description":"Retired NBA star Dwyane Wade defended his son’s appearance after a spate of critics insulted the boy after Wade’s wife Gabrielle Union posted a family photo on Thanksgiving.","url":"https://www.nydailynews.com/news/national/ny-dwyane-wade-son-zion-appearance-family-photo-20191201-5oc7llufwja4xas4iy2oow4g44-story.html","urlToImage":"https://www.nydailynews.com/resizer/W62e0ylcwiXzWGFkLOq_hZk50hI=/1200x0/top/arc-anglerfish-arc2-prod-tronc.s3.amazonaws.com/public/26DWPPITPNB47NUCIKLPMUY4RI.jpg","publishedAt":"2019-12-01T23:42:00Z","content":null}]}
	
	
	
	private List<NewsEntry> parseJson(var json)
	{
		string startPattern = "^\\{\"status\":\"[A-Za-z]+\",\"totalResults\":\"[0-9]+\",\"articles\":\\[";
		string endPattern = "\\]\\}$";
		
		json = Regex.Replace(json, startPattern, "");
		json = Regex.Replace(json, endPattern, "");
		json = Regex.Replace(json, "},{", "},,{");
		
		string[] articles = Regex.Split(jsonStr, "},,{");
		List<NewsEntry> NewsEntries = new List<NewsEntry>();
		for(string s in articles)
		{	NewsEntries.Add(JsonSerializer.Deserialize<NewsEntry>(s));	}
		
		return NewsEntries;
	}




^\{\"status\":\"[A-Za-z]+\",\"totalResults\":[0-9]+,\"articles":\[

