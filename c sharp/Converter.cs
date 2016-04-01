public class Converter {
	private static char[] geoToLatinBinding = new char[] {
		'a', 'b', 'g', 'd', 'e', 'v', 'z', 'T', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'J', 'r', 's', 't', 'u', 'f', 'q', 'R', 'y', 'S', 'C', 'c', 'Z', 'w', 'W', 'x', 'j', 'h'
	};
	private static char[] latinToGeoBinding = new char[] {
		'A', 'B', 'ჩ', 'D', 'E', 'F', 'G', 'H', 'I', 'ჟ', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'ღ', 'შ', 'თ', 'U', 'V', 'ჭ', 'X', 'Y', 'ძ', '[', '\\', ']', '^', '_', '`', 'ა', 'ბ', 'ც', 'დ', 'ე', 'ფ', 'გ', 'ჰ', 'ი', 'ჯ', 'კ', 'ლ', 'მ', 'ნ', 'ო', 'პ', 'ქ', 'რ', 'ს', 'ტ', 'უ', 'ვ', 'წ', 'ხ', 'ყ', 'ზ'
	};



	public static string ToLatin(string word) {
		return convert(word, geoToLatinBinding, 'ა', 'ჰ', 4304);
	}

	public static string ToGeorgian(string word) {
		return convert(word, latinToGeoBinding, 'A', 'z', 65);
	}

	private static string convert(string word, char[] binding, char min, char max, int charNum) {
		char[] buffer = new char[word.Length];
		int i = 0;
		foreach(char c in word) {
			if (c >= min && c <= max) {
				buffer[i++] = binding[c - charNum];
			} else {
				buffer[i++] = c;
			}
		}
		return new string(buffer);
	}
}
