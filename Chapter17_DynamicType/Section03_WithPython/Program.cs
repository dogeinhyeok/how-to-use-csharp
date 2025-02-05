/* 동적 언어와의 상호 운용성을 위한 dynamic 형식 */
// IronPython 설치 필요
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

ScriptEngine engine = Python.CreateEngine();
ScriptScope scope = engine.CreateScope();
scope.SetVariable("n", "박상현");
scope.SetVariable("p", "010-123-4566");

ScriptSource source = engine.CreateScriptSourceFromString(
	@"
class NameCard :
    name = ''
    phone = ''

    def __init__(self, name, phone) : 
        self.name = name 
        self.phone = phone

    def printNameCard(self) : 
        print self.name + ', ' + self.phone

NameCard(n, p)
");
dynamic result = source.Execute(scope);
result.printNameCard();

Console.WriteLine("{0}, {1}", result.name, result.phone);