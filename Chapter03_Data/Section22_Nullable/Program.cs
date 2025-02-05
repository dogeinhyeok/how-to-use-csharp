/* Nullable 형식 */
int? a = null; // 비어 있는 상태가 될 수 있음

Console.WriteLine(a.HasValue);
Console.WriteLine(a != null);

a = 3;

Console.WriteLine(a.HasValue);
Console.WriteLine(a != null);
Console.WriteLine(a.Value);