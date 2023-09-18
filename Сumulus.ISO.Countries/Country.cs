namespace Cumulus.ISO.Countries
{
	public class Country
	{
		/// <summary>
		/// Two-letter country codes as per ISO 3166-1 alpha-2.
		/// </summary>
		public string? Alpha2Code { get; set; }

		/// <summary>
		/// Three-letter country codes as per ISO 3166-1 alpha-3.
		/// </summary>
		public string? Alpha3Code { get; set; }

		/// <summary>
		/// Common or informal name of the country.
		/// </summary>
		public string? Name { get; set; }

		/// <summary>
		/// Official or formal name of the country as recognized internationally.
		/// </summary>
		public string? OfficialStateName { get; set; }

		/// <summary>
		/// Sovereign power or authority governing the country, especially if it's a territory or a dependent region.
		/// </summary>
		public string? Sovereignty { get; set; }

		/// <summary>
		/// Three-digit country codes as per ISO 3166-1 numeric.
		/// </summary>
		public int NumericCode { get; set; }

		/// <summary>
		/// Internet country code top-level domain (ccTLD) associated with the country.
		/// </summary>
		public string? InternetCcTLD { get; set; }

		/// <summary>
		/// Returns the numeric code of the country in a three-digit string format.
		/// </summary>
		/// <returns>A string representation of the numeric country code, always in three digits (e.g., "004").</returns>
		public string GetNumericCodeAsString()
		{
			return NumericCode.ToString("D3");
		}
	}



	public class Subdivision
	{
		/// <summary>
		/// Code representing a specific region or state within a country, such as ISO 3166-2 state code.
		/// </summary>
		public string? Code { get; set; }

		/// <summary>
		/// Common or informal name of the region or state.
		/// </summary>
		public string? Name { get; set; }

		/// <summary>
		/// Reference to the three-digit numeric code of the country to which the region or state belongs.
		/// </summary>
		public string? CountryNumericCode { get; set; }
	}
}