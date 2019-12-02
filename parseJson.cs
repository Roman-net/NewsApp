
	
	
	private List<NewsEntry> parseJson(var json)
	{
		string startPattern = "^{\"status\":\"[A-Za-z]+\",\"totalResults\":\"[0-9]+\",\"articles\":[";
		string endPattern = "$]}";
		
		json = Regex.Replace(json, startPattern, "");
		json = Regex.Replace(json, endPattern, "");
		json = Regex.Replace(json, "},{", "},,{");
		
		string[] articles = Regex.Split(jsonStr, "},,{");
		List<NewsEntry> NewsEntries = new List<NewsEntry>();
		for(string s in articles)
		{	NewsEntries.Add(JsonSerializer.Deserialize<NewsEntry>(s));	}
		
		return NewsEntries;
	}




