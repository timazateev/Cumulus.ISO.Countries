namespace Cumulus.ISO.Countries
{
	public class DefaultCountryRepository : CountryRepositoryBase
	{
		private readonly List<Country> _countries;
		/// <summary>
		/// using https://www.iso.org/obp/ui/#search/code/ on 9/19/2023
		/// </summary>
		public DefaultCountryRepository()
		{
			_countries = new List<Country>
			{
				new Country { Alpha2Code = "AF", Alpha3Code = "AFG", Name = "Afghanistan", OfficialStateName = "Afghanistan", NumericCode = 4, InternetCcTLD = ".af" },
				new Country { Alpha2Code = "AL", Alpha3Code = "ALB", Name = "Albania", OfficialStateName = "Albania", NumericCode = 8, InternetCcTLD = ".al" },
				new Country { Alpha2Code = "DZ", Alpha3Code = "DZA", Name = "Algeria", OfficialStateName = "Algeria", NumericCode = 12, InternetCcTLD = ".dz" },
				new Country { Alpha2Code = "AS", Alpha3Code = "ASM", Name = "American Samoa", OfficialStateName = "American Samoa", NumericCode = 16, InternetCcTLD = ".as" },
				new Country { Alpha2Code = "AD", Alpha3Code = "AND", Name = "Andorra", OfficialStateName = "Andorra", NumericCode = 20, InternetCcTLD = ".ad" },
				new Country { Alpha2Code = "AO", Alpha3Code = "AGO", Name = "Angola", OfficialStateName = "Angola", NumericCode = 24, InternetCcTLD = ".ao" },
				new Country { Alpha2Code = "AI", Alpha3Code = "AIA", Name = "Anguilla", OfficialStateName = "Anguilla", NumericCode = 660, InternetCcTLD = ".ai" },
				new Country { Alpha2Code = "AQ", Alpha3Code = "ATA", Name = "Antarctica", OfficialStateName = "Antarctica", NumericCode = 10, InternetCcTLD = ".aq" },
				new Country { Alpha2Code = "AG", Alpha3Code = "ATG", Name = "Antigua and Barbuda", OfficialStateName = "Antigua and Barbuda", NumericCode = 28, InternetCcTLD = ".ag" },
				new Country { Alpha2Code = "AR", Alpha3Code = "ARG", Name = "Argentina", OfficialStateName = "Argentina", NumericCode = 32, InternetCcTLD = ".ar" },
				new Country { Alpha2Code = "AM", Alpha3Code = "ARM", Name = "Armenia", OfficialStateName = "Armenia", NumericCode = 51, InternetCcTLD = ".am" },
				new Country { Alpha2Code = "AW", Alpha3Code = "ABW", Name = "Aruba", OfficialStateName = "Aruba", NumericCode = 533, InternetCcTLD = ".aw" },
				new Country { Alpha2Code = "AU", Alpha3Code = "AUS", Name = "Australia", OfficialStateName = "Australia", NumericCode = 36, InternetCcTLD = ".au" },
				new Country { Alpha2Code = "AT", Alpha3Code = "AUT", Name = "Austria", OfficialStateName = "Austria", NumericCode = 40, InternetCcTLD = ".at" },
				new Country { Alpha2Code = "AZ", Alpha3Code = "AZE", Name = "Azerbaijan", OfficialStateName = "Azerbaijan", NumericCode = 31, InternetCcTLD = ".az" },
				new Country { Alpha2Code = "BS", Alpha3Code = "BHS", Name = "Bahamas", OfficialStateName = "Bahamas", NumericCode = 44, InternetCcTLD = ".bs" },
				new Country { Alpha2Code = "BH", Alpha3Code = "BHR", Name = "Bahrain", OfficialStateName = "Bahrain", NumericCode = 48, InternetCcTLD = ".bh" },
				new Country { Alpha2Code = "BD", Alpha3Code = "BGD", Name = "Bangladesh", OfficialStateName = "Bangladesh", NumericCode = 50, InternetCcTLD = ".bd" },
				new Country { Alpha2Code = "BB", Alpha3Code = "BRB", Name = "Barbados", OfficialStateName = "Barbados", NumericCode = 52, InternetCcTLD = ".bb" },
				new Country { Alpha2Code = "BY", Alpha3Code = "BLR", Name = "Belarus", OfficialStateName = "Belarus", NumericCode = 112, InternetCcTLD = ".by" },
				new Country { Alpha2Code = "BE", Alpha3Code = "BEL", Name = "Belgium", OfficialStateName = "Belgium", NumericCode = 56, InternetCcTLD = ".be" },
				new Country { Alpha2Code = "BZ", Alpha3Code = "BLZ", Name = "Belize", OfficialStateName = "Belize", NumericCode = 84, InternetCcTLD = ".bz" },
				new Country { Alpha2Code = "BJ", Alpha3Code = "BEN", Name = "Benin", OfficialStateName = "Benin", NumericCode = 204, InternetCcTLD = ".bj" },
				new Country { Alpha2Code = "BM", Alpha3Code = "BMU", Name = "Bermuda", OfficialStateName = "Bermuda", NumericCode = 60, InternetCcTLD = ".bm" },
				new Country { Alpha2Code = "AX", Alpha3Code = "ALA", Name = "Åland Islands", OfficialStateName = "Åland Islands", NumericCode = 248, InternetCcTLD = ".ax" }
				//TODO: add all countries from ISO https://www.iso.org/obp/ui/#search/code/
    };
		}

		public override Country? GetCountryByAlpha2Code(string alpha2Code)
			=> _countries.Find(c => c.Alpha2Code == alpha2Code);

		public override Country? GetCountryByAlpha3Code(string alpha3Code)
			=> _countries.Find(c => c.Alpha3Code == alpha3Code);

		public override Country? GetCountryByName(string name)
			=> _countries.Find(c => c.Name == name);

		public override Country? GetCountryByOfficialStateName(string officialStateName)
			=> _countries.Find(c => c.OfficialStateName == officialStateName);

		public override Country? GetCountryBySovereignty(string sovereignty)
			=> _countries.Find(c => c.Sovereignty == sovereignty);

		public override Country? GetCountryByNumericCode(int numericCode)
			=> _countries.Find(c => c.NumericCode == numericCode);

		public override Country? GetCountryByInternetCcTLD(string internetCcTLD)
			=> _countries.Find(c => c.InternetCcTLD == internetCcTLD);

		public override string? GetAlpha2CodeByName(string name)
		{
			var country = GetCountryByName(name);
			return country?.Alpha2Code;
		}

		public override string? GetAlpha3CodeByName(string name)
		{
			var country = GetCountryByName(name);
			return country?.Alpha3Code;
		}

		public override Subdivision GetSubdivisionByCode(string code)
		{
			throw new NotImplementedException();
		}
	}
}
