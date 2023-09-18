namespace Cumulus.ISO.Countries
{
	public abstract class CountryRepositoryBase
	{
		#region Get country

		/// <summary>
		/// Retrieves a country based on its ISO 3166-1 alpha-2 code.
		/// </summary>
		/// <param name="alpha2Code">The ISO 3166-1 alpha-2 code.</param>
		/// <returns>The country associated with the provided alpha-2 code.</returns>
		public abstract Country? GetCountryByAlpha2Code(string alpha2Code);

		/// <summary>
		/// Retrieves a country based on its ISO 3166-1 alpha-3 code.
		/// </summary>
		/// <param name="alpha3Code">The ISO 3166-1 alpha-3 code.</param>
		/// <returns>The country associated with the provided alpha-3 code.</returns>
		public abstract Country? GetCountryByAlpha3Code(string alpha3Code);

		/// <summary>
		/// Retrieves a country based on its common or informal name.
		/// </summary>
		/// <param name="name">The common or informal name of the country.</param>
		/// <returns>The country associated with the provided name.</returns>
		public abstract Country? GetCountryByName(string name);

		/// <summary>
		/// Retrieves a country based on its official or formal name.
		/// </summary>
		/// <param name="officialStateName">The official or formal name of the country.</param>
		/// <returns>The country associated with the provided official name.</returns>
		public abstract Country? GetCountryByOfficialStateName(string officialStateName);

		/// <summary>
		/// Retrieves a country based on its sovereignty.
		/// </summary>
		/// <param name="sovereignty">The sovereignty of the country.</param>
		/// <returns>The country associated with the provided sovereignty.</returns>
		public abstract Country? GetCountryBySovereignty(string sovereignty);

		/// <summary>
		/// Retrieves a country based on its ISO 3166-1 numeric code.
		/// </summary>
		/// <param name="numericCode">The ISO 3166-1 numeric code.</param>
		/// <returns>The country associated with the provided numeric code.</returns>
		public abstract Country? GetCountryByNumericCode(int numericCode);

		/// <summary>
		/// Retrieves a country based on its internet country code top-level domain (ccTLD).
		/// </summary>
		/// <param name="internetCcTLD">The internet ccTLD of the country.</param>
		/// <returns>The country associated with the provided ccTLD.</returns>
		public abstract Country? GetCountryByInternetCcTLD(string internetCcTLD);

		#endregion

		#region Get country name

		/// <summary>
		/// Retrieves the ISO 3166-1 alpha-2 code based on the country's common or informal name.
		/// </summary>
		/// <param name="name">The common or informal name of the country.</param>
		/// <returns>The ISO 3166-1 alpha-2 code associated with the provided name.</returns>
		public abstract string? GetAlpha2CodeByName(string name);

		/// <summary>
		/// Retrieves the ISO 3166-1 alpha-3 code based on the country's common or informal name.
		/// </summary>
		/// <param name="name">The common or informal name of the country.</param>
		/// <returns>The ISO 3166-1 alpha-3 code associated with the provided name.</returns>
		public abstract string? GetAlpha3CodeByName(string name);

		#endregion

		/// <summary>
		/// Retrieves a subdivision (region or state) based on its code.
		/// </summary>
		/// <param name="code">The code representing the subdivision.</param>
		/// <returns>The subdivision associated with the provided code.</returns>
		public abstract Subdivision GetSubdivisionByCode(string code);
	}
}