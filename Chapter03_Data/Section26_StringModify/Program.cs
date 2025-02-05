/* 문자열 변환하기 */
Console.WriteLine("ToLower() : '{0}'", "ABC".ToLower()); // 'ABC' -> 'abc'
Console.WriteLine("ToUpper() : '{0}'", "abc".ToUpper()); // 'abc' -> 'ABC'

Console.WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, "Sunny")); // 'Happy Friday' -> 'HappySunny Friday!'
Console.WriteLine("Remove() : '{0}'", "I Don't Love You.".Remove(2, 6)); // 'I Don't Love You.' -> 'I Love You.'

Console.WriteLine("Trim() : '{0}'", " No Spaces ".Trim()); // ' No Spaces ' -> 'No Spaces'
Console.WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart()); // ' No Spaces ' -> 'No Spaces '
Console.WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd()); // ' No Spaces ' -> ' No Spaces'