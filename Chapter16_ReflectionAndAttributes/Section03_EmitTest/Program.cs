/* 형식 내보내기: Emit을 사용하여 중간 언어(IL) 코드로 동적으로 생성하고 실행합니다. */
using System.Reflection;
using System.Reflection.Emit;

AssemblyBuilder newAssembly =
	// "CalculatorAssembly"라는 동적 어셈블리를 생성합니다.
	AssemblyBuilder.DefineDynamicAssembly(
		new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

// 생성한 어셈블리에 "Calculator"라는 이름의 모듈을 동적으로 생성합니다.
ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");
// 생성한 모듈에 "Sum1To100"이라는 타입을 생성합니다.
TypeBuilder newType = newModule.DefineType("Sum1To100");

// 생성한 타입에 "Calculate"라는 메소드를 생성합니다.
MethodBuilder newMethod = newType.DefineMethod(
	"Calculate",    // 메소드 이름
	MethodAttributes.Public, // 메소드의 접근성은 public, 인스턴스(멤버) 메소드
	typeof(int),    // 반환 형식
	new Type[0]);   // 매개 변수

// 메소드를 실행할 코드(IL 명령어)를 채워 넣기 위해 ILGenerater 객체를 가져옵니다
ILGenerator generator = newMethod.GetILGenerator();

// 32비트 정수(1)를 계산 스택에 넣습니다
generator.Emit(OpCodes.Ldc_I4, 1);

for (int i = 2; i <= 100; i++)
{
	// 32비트 정수(i)를 계산 스택에 넣습니다
	generator.Emit(OpCodes.Ldc_I4, i);
	// 두 개의 값을 꺼내 더한 후, 그 결과를 다시 계산 스택에 넣습니다
	generator.Emit(OpCodes.Add);
}

// 'Ret'는 Return의 약자로, 메소드의 끝을 나타내는 메소드입니다.
generator.Emit(OpCodes.Ret);
// 'TypeBuilder' 객체에 대한 모든 변경사항을 적용하고, 실제로 닷넷형식으로 생성하고 'Type'객체를 반환합니다
Type createdType = newType.CreateType(); // 실제 .NET 형식을 사용하기 때문에 반환값을 사용하는 것이 좋습니다

// Activator.CreateInstance 메소드를 사용하여 newType의 인스턴스를 생성합니다.
object sum1To100 = Activator.CreateInstance(createdType);
// sum1To100 객체의 형식에서 "Calculate"라는 이름의 메소드를 가져옵니다.
MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
// "Calculate"라는 이름의 메소드 호출
Console.WriteLine(Calculate.Invoke(sum1To100, null));